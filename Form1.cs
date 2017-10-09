using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace torrentsearch {
  public partial class Form1 : Form {
    private List<Thread> threadList;
    private List<QueryEngine> queryList;

    public Form1() {
      InitializeComponent();

      threadList = new List<Thread>();
      queryList = new List<QueryEngine>();
    }

    protected override void OnShown(EventArgs e) {
      base.OnShown(e);
      tbURL.Focus();
    }

    public string Status {
      get { return toolStripStatusLabel1.Text; }
      set { toolStripStatusLabel1.Text = value;
      statusStrip1.Refresh();
    }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void tbURL_TextChanged(object sender, EventArgs e) {
      if (tbURL.Text.Length > 0 && tbURL.Text.StartsWith("http://")) {
        llblTest.Enabled = true;
      }
    }

    private void llblTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      try {
        Status = "Launching " + tbURL.Text + "...";
        System.Diagnostics.Process.Start(tbURL.Text);
        Status = "";
      } catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnAddNewSite_Click(object sender, EventArgs e) {
      clbSites.Items.Add(tbURL.Text);
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      try {
        btnSearch.Enabled = false;
        btnStopSearch.Enabled = true;
        foreach (string site in clbSites.Items) {
          ListViewGroup group = new ListViewGroup(site + tbQuery.Text);
          lvResults.Groups.Add(group);

          Uri uri = new Uri(site);

          Status = "Setting up connection...";

          //ListViewGroup group = new ListViewGroup(site);

          QueryEngine qe = new QueryEngine(site);
          qe.Query = tbQuery.Text;

          qe.DownloadComplete += new System.Net.DownloadStringCompletedEventHandler(qe_DownloadComplete);
          qe.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(qe_DownloadProgressChanged);

          Status = "Connecting to " + uri.Host;

          //Thread thread = new Thread(new ThreadStart(qe.GetLinksAsync));
          qe.GetLinksAsync();

          queryList.Add(qe);

          //thread.Start();

          Status = "Connected. Searching " + uri.Host + " for \"" + tbQuery.Text + "\"...";

          toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
          
        }

        btnSearch.Enabled = true;
      } catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }
    }

    void qe_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e) {
      Status = e.BytesReceived + " bytes received. " + (e.ProgressPercentage > 0 ? e.ProgressPercentage + "% left. " : "") + (queryList.Count > 1 ? queryList.Count-1 + " queries queued." : "");
    }

    void qe_DownloadComplete(object sender, System.Net.DownloadStringCompletedEventArgs e) {
      QueryEngine qe = (QueryEngine)sender;
      if (e.Error != null) {
        Status = "Download failed. " + e.Error.Message;
        //queryList.Remove(qe);
        toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        return;
      }
      if (e.Cancelled) {
        Status = "Download cancelled.";
        //queryList.Remove(qe);
        toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        return;
      }
      ListViewGroup group = new ListViewGroup(qe.Site + qe.Query);
      lvResults.Groups.Add(group);


      Status = "Download complete. Parsing results from " + new Uri(qe.Site).Host + "... " + (queryList.Count > 1 ? queryList.Count - 1 + " queries queued." : "");
      
      toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

      foreach (string link in QueryEngine.GetLinks(e.Result)) {
        ListViewItem item = new ListViewItem(link.Trim().Replace("href=\"/", "href=\"" + qe.Site.Substring(0, qe.Site.ToString().LastIndexOf('/')) + "/"), group);
        lvResults.Items.Add(item);
      }

      queryList.Remove(qe);
      toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

      Status = "Done. " + (lvResults.Items.Count > 0 ? lvResults.Items.Count + " links found." : "");

    }

    private void btnFindLCS_Click(object sender, EventArgs e) {

      toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

      Status = "Finding common substring in " + lvResults.CheckedItems.Count + " links...";

      List<string> strings = new List<string>();
      foreach (ListViewItem item in lvResults.CheckedItems) {
        strings.Add(item.Text.Trim());
      }

      LCS lcs = new LCS(strings);
      lcs.Complete += new LCS.CompleteEventHandler(lcs_Complete);
      
      System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(lcs.GetLCSAsync));
      threadList.Add(thread);
      thread.Start();

      btnStopFilter.Enabled = true;


      //tbCommonString.Text = lcs.GetLCS();

      //Status = "";

      //toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

    }

    void lcs_Complete(object sender, string result) {
      tbCommonString.Text = result;
      Status = "";
      toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
    }

    private void tbCommonString_TextChanged(object sender, EventArgs e) {
      btnFilter.Enabled = tbCommonString.Text.Length > 0;
    }

    private void llblTest2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      try {
        Status = "Launching " + clbSites.SelectedItem.ToString() + tbQuery.Text + "...";
        System.Diagnostics.Process.Start(clbSites.SelectedItem.ToString() + tbQuery.Text);
        Status = "";
      } catch (Exception ex) {
        MessageBox.Show(ex.Message + ex.StackTrace);
      }

    }

    private void tbQuery_TextChanged(object sender, EventArgs e) {
      llblTest2.Enabled = tbQuery.Text.Length > 0;
      this.AcceptButton = btnSearch;
    }

    private void btnFilter_Click(object sender, EventArgs e) {
      Status = "Filtering " + lvResults.Items.Count + " links for matches...";

      tabPage2.Show();
      
      lvFilteredResults.BeginUpdate();
      foreach (ListViewGroup group in lvResults.Groups) {
        lvFilteredResults.Groups.Add(group.Name, group.Header);
      }

      MessageBox.Show(lvResults.Items.Count.ToString());

      foreach (ListViewItem item in lvResults.Items) {
        if (item.Text.IndexOf(tbCommonString.Text) > -1) {
          ListViewItem clone = (ListViewItem)item.Clone();

          clone.Group = lvFilteredResults.Groups[clone.Group.Name];
          lvFilteredResults.Items.Add(clone);
        }
      }

      lvFilteredResults.EndUpdate();

      tabControl1.SelectedIndex = 1;

      //lvFilteredResults.Refresh();
      //lvFilteredResults.RedrawItems(0, lvFilteredResults.Items.Count-1, false);

      Status = "Found " + lvFilteredResults.Items.Count + " matching links.";
    }

    private void btnStopFilter_Click(object sender, EventArgs e) {
      foreach (Thread thread in threadList) {
        thread.Abort();
      }
      Status = "Stopped";
      toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
      btnStopFilter.Enabled = false;
    }

    private void btnStopSearch_Click(object sender, EventArgs e) {
      int count = queryList.Count;
      Status = "Stopping " + count + " queries...";
      toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

      foreach (QueryEngine qe in queryList) {
        if( qe.IsBusy )
          qe.CancelAsync();
      }

      queryList.Clear();

      Status = "Stopped " + count + " queries.";

      toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

      btnStopSearch.Enabled = false;
      btnSearch.Enabled = true;
    }

    private void tbURL_Enter(object sender, EventArgs e) {
      this.AcceptButton = btnAddNewSite;
    }

    private void tbCommonString_Enter(object sender, EventArgs e) {
      this.AcceptButton = btnFilter;
    }

    private void tabPage1_Enter(object sender, EventArgs e) {
      this.AcceptButton = btnFilter;
    }

    private void tbQuery_Enter(object sender, EventArgs e) {
      this.AcceptButton = btnSearch;
    }

   
  }
}