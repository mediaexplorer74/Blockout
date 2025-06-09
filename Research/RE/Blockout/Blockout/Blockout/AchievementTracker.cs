// Decompiled with JetBrains decompiler
// Type: Blockout.AchievementTracker
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class AchievementTracker
  {
    public static AchievementTracker Instance;
    [DataMember]
    public int DifferentDaysPlayed;
    [DataMember]
    public DateTime LastDayPlayed;
    [DataMember]
    public int DailyHighscoresEarned;
    public TimeSpan TimePlayedComplete;
    public TimeSpan TimePlayedCurrentGame;

    private AchievementTracker() => this.LoadContent();

    public static AchievementTracker Init()
    {
      if (AchievementTracker.Instance == null)
        return new AchievementTracker();
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementTracker.Init);
          }
          return AchievementTracker.Instance;
      }
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void LoadContent()
    {
      if (AchievementTracker.Instance != null)
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementTracker.LoadContent);
            break;
        }
      }
      else
      {
        AchievementTracker.Instance = this;
        this.TimePlayedComplete = TimeSpan.FromMilliseconds((double) GameData.Instance.MsPlayed);
        PartitionHelper.DisconnectProject(ref this.TimePlayedCurrentGame);
        if (this.LastDayPlayed.Year >= ClientTree.DisconnectProject(392) && this.LastDayPlayed.DayOfYear != DateTime.Now.DayOfYear)
          this.DifferentDaysPlayed += ClientTree.DisconnectProject(396);
        this.LastDayPlayed = DateTime.Now;
      }
    }

    private void DisconnectProject(object _param1, EventArgs _param2) => this.NewHighscoreAchived();

    public void Update(double elapsedGameMs)
    {
      TimeSpan ts = TimeSpan.FromMilliseconds(elapsedGameMs);
      this.TimePlayedComplete = this.TimePlayedComplete.Add(ts);
      this.TimePlayedCurrentGame = this.TimePlayedCurrentGame.Add(ts);
    }

    public void NewHighscoreAchived()
    {
    }

    public void Reset()
    {
    }
  }
}
