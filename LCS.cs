using System;
using System.Collections.Generic;
using System.Text;

namespace torrentsearch {
  public class LCS {

    public delegate void CompleteEventHandler(object sender, string result);

    public event CompleteEventHandler Complete;

    private List<string> strings;

    public LCS(List<string> strings) {
      this.strings = strings;
    }

    public void GetLCSAsync() {
      if (Complete != null) {
        Complete(this, GetLCS());
      }
    }

    public string GetLCS() {
      List<string> results = new List<string>();
      foreach (string item in strings) {
        int lastResultLength = 0;
        for (int i = 0; i < item.Length; i++) {
          // foreach character in this string
          // check if all strings have this substring
          string result = Step(item, i, 1);
          if (result.Length > lastResultLength) {
            lastResultLength = result.Length;
            results.Add(result);
            System.Diagnostics.Trace.WriteLine(result);
          }
        }
      }

      string response = "";
      
      for (int i = 0; i < results.Count; i++) {
        if (results[i].Length > response.Length) {
          response = results[i];
        }
      }

      return response;

    }

    private string Step(string source, int startIndex, int length) {
      if (startIndex + length < source.Length && AllStringsContain(source.Substring(startIndex, length)))
        return Step(source, startIndex, length + 1);
      else
        return source.Substring(startIndex, length-1);
    }

    public bool AllStringsContain(string query) {
      foreach (string item in strings) {
        if (item.IndexOf(query) < 0)
          return false;
      }
      return true;
    }
  }
}
