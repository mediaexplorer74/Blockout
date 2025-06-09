// Decompiled with JetBrains decompiler
// Type: GameFoundation.OnlineCommunications
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Threading;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class OnlineCommunications
  {
    public const string GameName = "blockout";
    private const int parentKeywords = 20;
    public const bool useTimelyBasedScores = false;
    public const bool useMultipleScores = false;
    private const double parentKeywords = 10000.0;
    [DataMember]
    public DateTime MultipleCallProtectionGameInstalledLastCall;
    [DataMember]
    public DateTime MultipleCallProtectionGetOnlineRacesLastCall;
    [DataMember]
    public string[][] Scores;
    [DataMember]
    public int[] TopOnlineScores;
    [DataMember]
    public int[] OurScores;
    [DataMember]
    public string[] AdsPreferedReceived = RegistryInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(1657));
    private static EventHandler parentKeywords;
    private static EventHandler currentUri;
    public static OnlineCommunications Instance;

    private OnlineCommunications()
    {
      this.Scores = ActivatorProvider.DisconnectProject(ReferenceInvoker.DisconnectProject(1661));
      this.TopOnlineScores = DatabaseQueue.DisconnectProject(ReferenceInvoker.DisconnectProject(1665));
      this.OurScores = DatabaseQueue.DisconnectProject(ReferenceInvoker.DisconnectProject(1669));
      this.LoadContent();
    }

    public static event EventHandler ScoresUpdated
    {
      add
      {
        EventHandler eventHandler1 = OnlineCommunications.parentKeywords;
        EventHandler eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          EventHandler eventHandler3 = ToolbarInfo.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) value));
          eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref OnlineCommunications.parentKeywords, eventHandler3, eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (7)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.add_ScoresUpdated);
            break;
        }
      }
      remove
      {
        EventHandler eventHandler1 = OnlineCommunications.parentKeywords;
        EventHandler eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          EventHandler eventHandler3 = ToolbarInfo.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) value));
          eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref OnlineCommunications.parentKeywords, eventHandler3, eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
      }
    }

    public static event EventHandler GamesUpdated
    {
      add
      {
        EventHandler eventHandler1 = OnlineCommunications.currentUri;
        EventHandler eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          EventHandler eventHandler3 = ToolbarInfo.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) value));
          eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref OnlineCommunications.currentUri, eventHandler3, eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (1)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.add_GamesUpdated);
            break;
        }
      }
      remove
      {
        EventHandler eventHandler1 = OnlineCommunications.currentUri;
        EventHandler eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          EventHandler eventHandler3 = ToolbarInfo.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) value));
          eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref OnlineCommunications.currentUri, eventHandler3, eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (3)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.remove_GamesUpdated);
            break;
        }
      }
    }

    public static OnlineCommunications Init()
    {
      if (OnlineCommunications.Instance == null)
        return new OnlineCommunications();
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.Init);
          }
          return OnlineCommunications.Instance;
      }
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context)
    {
      this.LoadContent();
      if ((int) AssemblyCollection.DisconnectProject(this.Scores) != 0)
        return;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.SetValuesOnDeserialized);
          }
          OnlineCommunications.Instance.GetTop6Scores();
          break;
      }
    }

    public void LoadContent() => OnlineCommunications.Instance = this;

    private static void DisconnectProject()
    {
      if (OnlineCommunications.parentKeywords == null)
        return;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.DisconnectProject);
          }
          OnlineCommunications.parentKeywords((object) OnlineCommunications.Instance, NetworkCollection.parentKeywords);
          break;
      }
    }

    private static void DisposeDrive()
    {
      if (OnlineCommunications.currentUri == null)
        return;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.DisposeDrive);
          }
          OnlineCommunications.currentUri((object) OnlineCommunications.Instance, NetworkCollection.parentKeywords);
          break;
      }
    }

    public void GetTop6Scores()
    {
    }

    public void PostScore(
      string name,
      KeyValuePair<DateTime, int> scoreEasy,
      KeyValuePair<DateTime, int> scoreNormal,
      KeyValuePair<DateTime, int> scoreHard)
    {
    }

    public void RegisterUsage()
    {
      if (!this.IsInternetAvailable)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.RegisterUsage);
            break;
        }
      }
      else
      {
        uint num1 = (uint) ReferenceInvoker.DisconnectProject(1405);
        int num2 = ReferenceInvoker.DisconnectProject(1409);
        int num3 = ReferenceInvoker.DisconnectProject(1413);
        int num4 = ReferenceInvoker.DisconnectProject(1417);
        int num5 = ReferenceInvoker.DisconnectProject(1421);
        int num6 = ReferenceInvoker.DisconnectProject(1425);
        int num7 = ReferenceInvoker.DisconnectProject(1429);
        int num8 = ReferenceInvoker.DisconnectProject(1433);
        int num9 = ReferenceInvoker.DisconnectProject(1437);
        int num10 = ReferenceInvoker.DisconnectProject(1441);
        int num11 = ReferenceInvoker.DisconnectProject(1445);
        GameData instance = GameData.Instance;
        if (instance != null)
        {
          num1 = (uint) TimeSpan.FromMilliseconds((double) instance.MsPlayed).TotalMinutes;
          num2 = instance.AdsRequestSentCounter;
          num3 = instance.AdsReceivedCounter;
          num4 = instance.AdsClickCounter;
          num5 = instance.AdsRequestErrorCounter;
          num6 = instance.StartupCounter;
          num7 = instance.AdDuplexLoadingError;
          num8 = instance.AdDuplexClickLog;
          num9 = instance.AdDuplexAdLoaded;
          num10 = instance.HouseAdClickCounter;
          num11 = instance.HouseAdDispalyCounter;
        }
        int num12 = MsAdOnline.DisconnectProject();
        string str1 = FunctionCollection.DisconnectProject();
        string stringToEscape = EditorService.DisconnectProject(697);
        string str2 = str1;
        string format = EditorService.DisconnectProject(702);
        object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(1449));
        objArray1[ReferenceInvoker.DisconnectProject(1453)] = (object) num1;
        objArray1[ReferenceInvoker.DisconnectProject(1457)] = (object) num2;
        objArray1[ReferenceInvoker.DisconnectProject(1461)] = (object) num3;
        objArray1[ReferenceInvoker.DisconnectProject(1465)] = (object) num4;
        objArray1[ReferenceInvoker.DisconnectProject(1469)] = (object) num5;
        objArray1[ReferenceInvoker.DisconnectProject(1473)] = (object) num6;
        objArray1[ReferenceInvoker.DisconnectProject(1477)] = (object) num7;
        objArray1[ReferenceInvoker.DisconnectProject(1481)] = (object) num8;
        objArray1[ReferenceInvoker.DisconnectProject(1485)] = (object) num9;
        objArray1[ReferenceInvoker.DisconnectProject(1489)] = (object) Uri.EscapeDataString(stringToEscape);
        objArray1[ReferenceInvoker.DisconnectProject(1493)] = (object) num10;
        objArray1[ReferenceInvoker.DisconnectProject(1497)] = (object) num11;
        objArray1[ReferenceInvoker.DisconnectProject(1501)] = (object) num12;
        object[] objArray2 = objArray1;
        string str3 = string.Format(format, objArray2);
        HttpWebRequest http = WebRequest.CreateHttp(ResourceSerializer.DisconnectProject(str2, str3));
        try
        {
          http.BeginGetResponse(new AsyncCallback(this.DisconnectProject), (object) http);
        }
        catch
        {
        }
      }
    }

    private void DisconnectProject(IAsyncResult _param1)
    {
      string str1 = OnlineCommunications.DisconnectProject(_param1);
      if (string.IsNullOrEmpty(str1))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.DisconnectProject);
            break;
        }
      }
      else
      {
        string str2 = str1;
        char[] chArray1 = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(1505));
        chArray1[ReferenceInvoker.DisconnectProject(1509)] = (char) ReferenceInvoker.DisconnectProject(1513);
        char[] chArray2 = chArray1;
        string[] strArray = str2.Split(chArray2);
        if ((int) IconEventArgs.DisconnectProject(strArray) <= ReferenceInvoker.DisconnectProject(1517))
        {
label_6:
          switch (2)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          for (int index = ReferenceInvoker.DisconnectProject(1521); index < (int) IconEventArgs.DisconnectProject(strArray); index += ReferenceInvoker.DisconnectProject(1525))
          {
            string str3 = strArray[index];
            if (!RegistryScope.DisconnectProject(str3, EditorService.DisconnectProject(888)))
            {
label_10:
              switch (3)
              {
                case 0:
                  goto label_10;
                default:
                  if (!RegistryScope.DisconnectProject(str3, EditorService.DisconnectProject(897)))
                  {
label_12:
                    switch (7)
                    {
                      case 0:
                        goto label_12;
                      default:
                        if (str3.StartsWith(EditorService.DisconnectProject(902)))
                        {
label_14:
                          switch (5)
                          {
                            case 0:
                              goto label_14;
                            default:
                              MsAdOnline.DisconnectProject(str3);
                              continue;
                          }
                        }
                        else
                          continue;
                    }
                  }
                  else
                    continue;
              }
            }
          }
label_18:
          switch (2)
          {
            case 0:
              goto label_18;
            default:
              if (PcitureService.DisconnectProject(strArray[ReferenceInvoker.DisconnectProject(1529)], EditorService.DisconnectProject(888)))
              {
label_20:
                switch (6)
                {
                  case 0:
                    goto label_20;
                  default:
                    return;
                }
              }
              else
              {
                HttpWebRequest http = WebRequest.CreateHttp(FunctionCollection.DisposeDrive());
                try
                {
                  http.BeginGetResponse(new AsyncCallback(this.DisposeDrive), (object) http);
                  break;
                }
                catch
                {
                  break;
                }
              }
          }
        }
      }
    }

    private static bool DisconnectProject(string _param0)
    {
      if (string.IsNullOrEmpty(_param0))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.DisconnectProject);
            }
            return ReferenceInvoker.DisconnectProject(1533) != 0;
        }
      }
      else
      {
        Uri result;
        bool flag1 = Uri.TryCreate(_param0, (UriKind) ReferenceInvoker.DisconnectProject(1537), out result);
        bool flag2 = RegistryScope.DisconnectProject(result.Scheme, EditorService.DisconnectProject(911));
        bool flag3 = (OnlineCommunications.DisposeDrive(_param0) ? 1 : 0) == ReferenceInvoker.DisconnectProject(1541);
        if (flag1)
        {
label_6:
          switch (4)
          {
            case 0:
              goto label_6;
            default:
              if (flag2)
              {
label_8:
                switch (6)
                {
                  case 0:
                    goto label_8;
                  default:
                    return flag3;
                }
              }
              else
                break;
          }
        }
        return ReferenceInvoker.DisconnectProject(1545) != 0;
      }
    }

    private static bool DisposeDrive(string _param0)
    {
      string str = _param0.Substring(_param0.IndexOf((char) ReferenceInvoker.DisconnectProject(1549)) + ReferenceInvoker.DisconnectProject(1553));
      char[] chArray1 = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(1557));
      chArray1[ReferenceInvoker.DisconnectProject(1561)] = (char) ReferenceInvoker.DisconnectProject(1565);
      char[] chArray2 = chArray1;
      string[] strArray = str.Split(chArray2);
      Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
      for (int index = ReferenceInvoker.DisconnectProject(1569); index < (int) IconEventArgs.DisconnectProject(strArray); index += ReferenceInvoker.DisconnectProject(1589))
      {
        string key1 = strArray[index];
        string key2 = key1.Substring(ReferenceInvoker.DisconnectProject(1573), key1.IndexOf((char) ReferenceInvoker.DisconnectProject(1577)));
        if (dictionary.ContainsKey(key2))
        {
label_2:
          switch (7)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.DisposeDrive);
              }
              return ReferenceInvoker.DisconnectProject(1581) != 0;
          }
        }
        else
          dictionary.Add(key1, ReferenceInvoker.DisconnectProject(1585) != 0);
      }
label_8:
      switch (2)
      {
        case 0:
          goto label_8;
        default:
          return ReferenceInvoker.DisconnectProject(1593) != 0;
      }
    }

    internal static string DisconnectProject(IAsyncResult _param0)
    {
      string str = ViewSet.parentKeywords;
      try
      {
        using (StreamReader streamReader = new StreamReader(MenuLoader.DisconnectProject(_param0.AsyncState).EndGetResponse(_param0).GetResponseStream()))
          str = streamReader.ReadToEnd();
      }
      catch
      {
      }
      return str;
    }

    private void DisposeDrive(IAsyncResult _param1)
    {
      string.IsNullOrEmpty(OnlineCommunications.DisconnectProject(_param1));
    }

    public void ShowSubmitScoreUI(bool showNoInternetConnection)
    {
      if (Guide.IsVisible)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.ShowSubmitScoreUI);
          }
          if (this.IsInternetAvailable)
          {
            Guide.BeginShowKeyboardInput((PlayerIndex) ReferenceInvoker.DisconnectProject(1597), EditorService.DisconnectProject(920), MemoryManager.DisconnectProject((object) EditorService.DisconnectProject(989), (object) GameBase.Instance.GameSettings.CurrentModeHighScore), GameBase.Instance.GameSettings.PlayerName, new AsyncCallback(this.ListQueue), TextFileSet.parentKeywords);
            break;
          }
          if (!showNoInternetConnection)
            break;
label_7:
          switch (2)
          {
            case 0:
              goto label_7;
            default:
              string title = EditorService.DisconnectProject(1014);
              string text = EditorService.DisconnectProject(1077);
              string[] strArray = RegistryInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(1601));
              strArray[ReferenceInvoker.DisconnectProject(1605)] = EditorService.DisconnectProject(1164);
              string[] buttons = strArray;
              int focusButton = ReferenceInvoker.DisconnectProject(1609);
              int icon = ReferenceInvoker.DisconnectProject(1613);
              object parentKeywords = TextFileSet.parentKeywords;
              Guide.BeginShowMessageBox(title, text, (IEnumerable<string>) buttons, focusButton, (MessageBoxIcon) icon, (AsyncCallback) null, parentKeywords);
              return;
          }
      }
    }

    private void ListQueue(IAsyncResult _param1)
    {
      string str1 = Guide.EndShowKeyboardInput(_param1);
      if (string.IsNullOrEmpty(str1))
        return;
      if (str1.Length > ReferenceInvoker.DisconnectProject(1617))
        str1 = str1.Substring(ReferenceInvoker.DisconnectProject(1621), ReferenceInvoker.DisconnectProject(1625));
      string str2 = str1.Replace((char) ReferenceInvoker.DisconnectProject(1629), (char) ReferenceInvoker.DisconnectProject(1633)).Replace((char) ReferenceInvoker.DisconnectProject(1637), (char) ReferenceInvoker.DisconnectProject(1641));
      GameBase.Instance.GameSettings.PlayerName = str2;
      GameBase.Instance.GameSettings.LocalHighScoreHard.DisconnectProject();
      this.GetTop6Scores();
    }

    public bool IsInternetAvailable
    {
      get
      {
        if (NetworkInterface.GetIsNetworkAvailable())
          return ReferenceInvoker.DisconnectProject(1649) != 0;
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              RuntimeMethodHandle runtimeMethodHandle = __methodref (OnlineCommunications.get_IsInternetAvailable);
            }
            return ReferenceInvoker.DisconnectProject(1645) != 0;
        }
      }
    }

    public void OpenHomepage()
    {
      PlatformHelper.DisconnectProject(new Uri(EditorService.DisconnectProject(1169), (UriKind) ReferenceInvoker.DisconnectProject(1653)));
    }

    public void ShowRateGame() => PlatformHelper.DisconnectProject();
  }
}
