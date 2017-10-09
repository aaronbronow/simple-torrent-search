using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;
using System.Net;

namespace torrentsearch {
  //public delegate DownloadStringCompletedEventHandler DownloadComplete(object sender, DownloadDataCompletedEventArgs e);

  public class QueryEngine {
    #region Private properties
    private WebClient client;
    #endregion

    #region Constructors

    public QueryEngine(string site) {
      client = new WebClient();
      this.site = site;
    }

    public QueryEngine(string site, string query) {
      client = new WebClient();
      this.site = site;
      this.query = query;
    }

    #endregion

    #region Public properties
    public event DownloadStringCompletedEventHandler DownloadComplete;
    public event DownloadProgressChangedEventHandler DownloadProgressChanged;

    public bool IsBusy {
      get { return client.IsBusy; }
    }

    private string site;

    public string Site {
      get { return site; }
      set { site = value; }
    }

    private string query;

    public string Query {
      get { return query; }
      set { query = value; }
    }

    #endregion

    #region Public methods

    public string[] GetLinks() {
      byte[] buffer = client.DownloadData(site + query);
      
      string source = Encoding.ASCII.GetString(buffer);

      return GetLinks(source);
    }

    public void GetLinksAsync() {
      client.DownloadStringAsync(new Uri(site + query));
      client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
      client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
    }

    public static string[] GetLinks(string source) {
      Regex linkSearch = new Regex(@"<(a)[^>]*>.*?</\1>", RegexOptions.Singleline);

      ArrayList results = new ArrayList();

      foreach (Match match in linkSearch.Matches(source)) {
        results.Add(match.Value);
      }

      return (string[])results.ToArray(typeof(string));

    }

    public void CancelAsync() {
      client.DownloadStringCompleted -= new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
      client.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

      client.CancelAsync();
    }

    void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
      if (DownloadProgressChanged != null) {
        DownloadProgressChanged(this, e);
      }
    }

    void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e) {
      if (DownloadComplete != null) {
        DownloadComplete(this, e);
      }
    }

    #endregion
  }
}
