// Decompiled with JetBrains decompiler
// Type: Blockout.AchievementManager
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class AchievementManager
  {
    private const double parentKeywords = 3000.0;
    public static AchievementManager Instance;
    [DataMember]
    public Achievement[] achievement;
    [DataMember]
    public AchievementHighscore achievementHighscore;
    private double currentUri;
    private double filterID;
    [DataMember]
    public int visualActiveAchievementIndex = ClientTree.DisconnectProject(388);
    [DataMember]
    public bool visualActiveAchievmentHighscore;

    private AchievementManager() => this.LoadContent();

    public static AchievementManager Init()
    {
      if (AchievementManager.Instance == null)
        return new AchievementManager();
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementManager.Init);
          }
          return AchievementManager.Instance;
      }
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void LoadContent()
    {
      if (AchievementManager.Instance != null)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementManager.LoadContent);
            break;
        }
      }
      else
        AchievementManager.Instance = this;
    }

    public void Update(double elapsedGameTime)
    {
      if (this.visualActiveAchievementIndex >= ClientTree.DisconnectProject(312))
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementManager.Update);
            }
            this.currentUri -= elapsedGameTime;
            if (this.currentUri <= ClientTree.DisconnectProject(316))
            {
label_5:
              switch (4)
              {
                case 0:
                  goto label_5;
                default:
                  if (this.achievement[this.visualActiveAchievementIndex].CurrentFadeState != (FadeState) ClientTree.DisconnectProject(324))
                  {
label_7:
                    switch (3)
                    {
                      case 0:
                        goto label_7;
                      default:
                        this.achievement[this.visualActiveAchievementIndex].StartEndShowingAchievement();
                        break;
                    }
                  }
                  else
                  {
                    if (this.achievement[this.visualActiveAchievementIndex].FadingOutFinished)
                    {
                      this.achievement[this.visualActiveAchievementIndex].EndShowingAchievement();
                      this.visualActiveAchievementIndex = ClientTree.DisconnectProject(328);
                      break;
                    }
                    break;
                  }
                  break;
              }
            }
            else
              break;
            break;
        }
      }
      if (this.visualActiveAchievmentHighscore)
      {
        this.filterID -= elapsedGameTime;
        if (this.filterID <= ClientTree.DisconnectProject(332))
        {
label_13:
          switch (1)
          {
            case 0:
              goto label_13;
            default:
              if (this.achievementHighscore.CurrentFadeState != (FadeState) ClientTree.DisconnectProject(340))
              {
label_15:
                switch (5)
                {
                  case 0:
                    goto label_15;
                  default:
                    this.achievementHighscore.StartEndShowingAchievement();
                    break;
                }
              }
              else
              {
                if (this.achievementHighscore.FadingOutFinished)
                {
                  this.achievementHighscore.EndShowingAchievement();
                  this.visualActiveAchievmentHighscore = ClientTree.DisconnectProject(344) != 0;
                  break;
                }
                break;
              }
              break;
          }
        }
      }
      for (int index = ClientTree.DisconnectProject(348); index < (int) ActivatorManager.DisconnectProject(this.achievement); index += ClientTree.DisconnectProject(364))
      {
        this.achievement[index].Update();
        if (this.visualActiveAchievementIndex < ClientTree.DisconnectProject(352) && this.achievement[index].HasAchievementToShow)
        {
label_21:
          switch (3)
          {
            case 0:
              goto label_21;
            default:
              this.visualActiveAchievementIndex = index;
              this.currentUri = ClientTree.DisconnectProject(356);
              this.achievement[index].ShowAchievement();
              continue;
          }
        }
      }
label_25:
      switch (4)
      {
        case 0:
          goto label_25;
        default:
          this.achievementHighscore.Update();
          if (this.visualActiveAchievmentHighscore)
            break;
label_27:
          switch (2)
          {
            case 0:
              goto label_27;
            default:
              if (!this.achievementHighscore.HasAchievementToShow)
                return;
              this.visualActiveAchievmentHighscore = ClientTree.DisconnectProject(368) != 0;
              this.filterID = ClientTree.DisconnectProject(372);
              this.achievementHighscore.ShowAchievement();
              return;
          }
      }
    }

    public void Draw()
    {
      for (int index = ClientTree.DisconnectProject(380); index < (int) ActivatorManager.DisconnectProject(this.achievement); index += ClientTree.DisconnectProject(384))
        this.achievement[index].Draw();
label_3:
      switch (4)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementManager.Draw);
          }
          this.achievementHighscore.Draw();
          break;
      }
    }

    public void Reset()
    {
    }
  }
}
