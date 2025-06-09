// Decompiled with JetBrains decompiler
// Type: GameFoundation.GameData
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class GameData
  {
    public static GameData Instance;
    private bool parentKeywords;
    [DataMember]
    public ulong MsPlayed;
    [DataMember]
    public int AdsRequestSentCounter;
    [DataMember]
    public int AdsReceivedCounter;
    [DataMember]
    public int AdsClickCounter;
    [DataMember]
    public int AdsRequestErrorCounter;
    [DataMember]
    public int StartupCounter;
    [DataMember]
    public int AdDuplexClickLog;
    [DataMember]
    public int AdDuplexLoadingError;
    [DataMember]
    public int AdDuplexAdLoaded;
    [DataMember]
    public int HouseAdClickCounter;
    [DataMember]
    public int HouseAdDispalyCounter;

    public GameData()
    {
      this.AdsRequestSentCounter = ReferenceInvoker.DisconnectProject(40);
      this.AdsReceivedCounter = ReferenceInvoker.DisconnectProject(44);
      this.AdsClickCounter = ReferenceInvoker.DisconnectProject(48);
      this.AdDuplexClickLog = ReferenceInvoker.DisconnectProject(52);
      this.AdDuplexLoadingError = ReferenceInvoker.DisconnectProject(56);
      this.AdDuplexAdLoaded = ReferenceInvoker.DisconnectProject(60);
      this.StartupCounter = ReferenceInvoker.DisconnectProject(64);
      this.HouseAdClickCounter = ReferenceInvoker.DisconnectProject(68);
      this.HouseAdDispalyCounter = ReferenceInvoker.DisconnectProject(72);
      this.parentKeywords = ReferenceInvoker.DisconnectProject(76) != 0;
      this.DisconnectProject();
    }

    private void DisconnectProject()
    {
      if (GameData.Instance != null)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameData.DisconnectProject);
            break;
        }
      }
      else
      {
        GameData.Instance = this;
        if (!PlatformHelper.DisconnectProject())
          return;
label_6:
        switch (6)
        {
          case 0:
            goto label_6;
          default:
            this.StartupCounter += ReferenceInvoker.DisconnectProject(16);
            break;
        }
      }
    }

    internal void DisposeDrive()
    {
      EventHandler<EventArgs> eventHandler1 = AssemblyScope.parentKeywords;
      EventHandler<BookmarkSite> eventHandler2 = SolutionTable.parentKeywords;
      EventHandler<MenuOptions> eventHandler3 = MemoryInvoker.parentKeywords;
      EventHandler<EventArgs> eventHandler4 = AssemblyScope.parentKeywords;
      if (!this.parentKeywords)
      {
        AdController instance = AdController.Instance;
        if (eventHandler1 == null)
        {
label_2:
          switch (5)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (GameData.DisposeDrive);
              }
              eventHandler1 = (EventHandler<EventArgs>) ((_param1, _param2) => this.AdsClickCounter += ReferenceInvoker.DisconnectProject(24));
              break;
          }
        }
        EventHandler<EventArgs> eventHandler5 = eventHandler1;
        instance.AdClickedEvent += eventHandler5;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler<BookmarkSite>) ((_param1, _param2) => this.AdDuplexAdLoaded += ReferenceInvoker.DisconnectProject(28));
        QueueManager.add_DisconnectProject(eventHandler2);
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler<MenuOptions>) ((_param1, _param2) => this.AdDuplexLoadingError += ReferenceInvoker.DisconnectProject(32));
        QueueManager.add_DisconnectProject(eventHandler3);
        if (eventHandler4 == null)
        {
label_11:
          switch (4)
          {
            case 0:
              goto label_11;
            default:
              eventHandler4 = (EventHandler<EventArgs>) ((_param1, _param2) => this.AdDuplexClickLog += ReferenceInvoker.DisconnectProject(36));
              break;
          }
        }
        QueueManager.add_DisconnectProject(eventHandler4);
      }
      this.parentKeywords = ReferenceInvoker.DisconnectProject(20) != 0;
    }

    [OnSerializing]
    public void SetValuesOnSerializing(StreamingContext context)
    {
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.DisconnectProject();

    internal void DisconnectProject(double _param1) => _param1 += _param1;
  }
}
