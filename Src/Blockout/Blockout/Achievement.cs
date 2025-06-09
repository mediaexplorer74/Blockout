// *************************************************************
// Type: Blockout.Achievement
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class Achievement
  {
    protected const bool DefaultShowLeftSide = true;
    protected const float FontScale = 0.6f;
    public const int MaxAchievementsToGet = 4;
    public Vector2[] parentKeywords;// = 700;
    private const int currentUri = 0;
    private const int filterID = 10;
    private const int parentCancel = 12;
    private const int namesID = 3;
    private const int currentNode = 9;
    private const int idToken = -10;
    private const float parentKeywords5 = 0.0333333351f;
    protected static readonly int MaxTextLength = DatabaseLoader.DisconnectProject(1).Length;
    public int AchievementsToGet;
    private int nextOutput;
    [DataMember]
    public int OpenToShow;
    [DataMember]
    public int CurrentAchievementProgress;
    [DataMember]
    public bool IsShowingCurrentAchievement;
    public StringBuilder[] achievementTextLine1;
    public StringBuilder[] achievementTextLine2;
    public string[] achievementTexLine2Extended;
    private Vector2[] parentKeywords6;
    private Vector2[] currentUri7;
    private static Rectangle parentKeywords8;
    private static Rectangle currentUri9;
    private static Rectangle filterID10;
    private static Rectangle parentCancel11;
    private Func<bool>[] parentKeywords12;
    protected Color colorFadingWhite;
    private Color parentKeywords13;
    [DataMember]
    public float colorFadingFactor;
    [DataMember]
    public FadeState CurrentFadeState;

    public Achievement(AchievementProperties achievements)
    {
      this.LoadContent(achievements);
      this.ResetAchievedAchievements();
    }

    public bool HasAchievementToShow => this.OpenToShow > ClientTree.DisconnectProject(0);

    protected virtual bool ShowLeftSide => ClientTree.DisconnectProject(4) != 0;

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context)
    {
    }

    public void LoadContent(AchievementProperties achievements)
    {
      this.AchievementsToGet = (int) MenuToken.DisconnectProject(achievements.AchievedTest);
      this.parentKeywords = default;//achievements.AchievedTest;
      this.achievementTextLine1 = ToolboxDictionary.DisconnectProject(this.AchievementsToGet);
      for (int index = ClientTree.DisconnectProject(8); index < (int) ActivatorAttribute.DisconnectProject(this.achievementTextLine1); index += ClientTree.DisconnectProject(12))
        this.achievementTextLine1[index] = new StringBuilder();
      this.achievementTextLine2 = ToolboxDictionary.DisconnectProject(this.AchievementsToGet);
      this.achievementTexLine2Extended = WindowLayout.DisconnectProject(this.AchievementsToGet);
      
      //todo
      this.parentKeywords = ViewInvoker.DisconnectProject(ClientTree.DisconnectProject(16));
      for (int index = ClientTree.DisconnectProject(20); index < (int) SolutionAttribute.DisconnectProject(this.parentKeywords); index += ClientTree.DisconnectProject(24))
        this.parentKeywords[index] = Vector2.Zero;
label_6:
      switch (6)
      {
        case 0:
          goto label_6;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.LoadContent);
          }
          this.currentUri = ViewInvoker.DisconnectProject(ClientTree.DisconnectProject(28));
          for (int index = ClientTree.DisconnectProject(32); index < (int) SolutionAttribute.DisconnectProject(this.currentUri); index += ClientTree.DisconnectProject(36))
            this.currentUri[index] = Vector2.Zero;
label_12:
          switch (4)
          {
            case 0:
              goto label_12;
            default:
              this.DisconnectProject(achievements.Line1, achievements.Line2, achievements.Line2Extended);
              this.DisposeDrive();
              this.nextOutput = ClientTree.DisconnectProject(40) - this.AchievementsToGet;
              return;
          }
      }
    }

    public void ResetAchievedAchievements()
    {
      this.CurrentAchievementProgress = ClientTree.DisconnectProject(44) - this.AchievementsToGet;
    }

    private void DisconnectProject(string[] _param1, string[] _param2, string[] _param3)
    {
      for (int index = ClientTree.DisconnectProject(48); index < (int) ActivatorAttribute.DisconnectProject(this.achievementTextLine1); index += ClientTree.DisconnectProject(56))
      {
        this.achievementTextLine1[index].Remove(ClientTree.DisconnectProject(52), this.achievementTextLine1[index].Length);
        this.achievementTextLine1[index].Append(_param1[index]);
      }
      if (_param2 == null)
      {
        for (int index = ClientTree.DisconnectProject(60); index < (int) ActivatorAttribute.DisconnectProject(this.achievementTextLine2); index += ClientTree.DisconnectProject(64))
          this.achievementTextLine2[index] = (StringBuilder) null;
label_7:
        switch (3)
        {
          case 0:
            goto label_7;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.DisconnectProject);
              break;
            }
            break;
        }
      }
      else
      {
        for (int index = ClientTree.DisconnectProject(68); index < (int) ActivatorAttribute.DisconnectProject(this.achievementTextLine2); index += ClientTree.DisconnectProject(72))
          this.achievementTextLine2[index] = new StringBuilder(_param2[index]);
label_13:
        switch (2)
        {
          case 0:
            goto label_13;
        }
      }
      for (int index = ClientTree.DisconnectProject(76); index < (int) DeviceQueue.DisconnectProject(this.achievementTexLine2Extended); index += ClientTree.DisconnectProject(80))
        this.achievementTexLine2Extended[index] = _param3[index];
label_17:
      switch (6)
      {
        case 0:
          goto label_17;
        default:
          this.DisconnectProject();
          break;
      }
    }

    [SpecialName]
    private Rectangle get_DisconnectProject()
    {
      if (this.ShowLeftSide)
        return Achievement.parentKeywords;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.get_DisconnectProject);
          }
          return Achievement.currentUri;
      }
    }

    protected Rectangle CurrentPosIcon
    {
      get
      {
        if (this.ShowLeftSide)
          return Achievement.filterID;
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.get_CurrentPosIcon);
            }
            return Achievement.parentCancel;
        }
      }
    }

    private void DisconnectProject()
    {
      float num1 = (float) this.get_DisconnectProject().X2() - ((float) this.get_DisconnectProject().Width - (float) this.CurrentPosIcon.Width) / ClientTree.DisconnectProject(84);
      float num2 = (float) this.get_DisconnectProject().Y + (float) this.get_DisconnectProject().Height / ClientTree.DisconnectProject(88);
      for (int index = ClientTree.DisconnectProject(92); index < this.AchievementsToGet; index += ClientTree.DisconnectProject(164))
      {
        Vector2 vector2_1 = ScreenManager.Instance.MenuFont.MeasureString(this.achievementTextLine1[index]);
        Vector2 vector2_2 = new Vector2(vector2_1.X * ClientTree.DisconnectProject(96), vector2_1.Y * ClientTree.DisconnectProject(100));
        if (this.achievementTextLine2[index] == null)
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.DisconnectProject);
              }
              this.parentKeywords[index] = new Vector2(num1 - vector2_2.X / ClientTree.DisconnectProject(104) + ClientTree.DisconnectProject(108), num2 - vector2_2.Y / ClientTree.DisconnectProject(112));
              this.currentUri[index] = Vector2.Zero;
              continue;
          }
        }
        else
        {
          Vector2 vector2_3 = ScreenManager.Instance.MenuFont.MeasureString(this.achievementTextLine2[index]);
          Vector2 vector2_4 = new Vector2(vector2_3.X * ClientTree.DisconnectProject(116), vector2_3.Y * ClientTree.DisconnectProject(120));
          this.parentKeywords[index] = new Vector2(num1 - vector2_2.X / ClientTree.DisconnectProject(124) + ClientTree.DisconnectProject(128), (float) ((double) num2 - (double) this.get_DisconnectProject().Height / (double) ClientTree.DisconnectProject(132) - (double) vector2_2.Y / (double) ClientTree.DisconnectProject(136)) + ClientTree.DisconnectProject(140));
          this.currentUri[index] = new Vector2(num1 - vector2_4.X / ClientTree.DisconnectProject(144) + ClientTree.DisconnectProject(148), (float) ((double) num2 + (double) this.get_DisconnectProject().Height / (double) ClientTree.DisconnectProject(152) - (double) vector2_4.Y / (double) ClientTree.DisconnectProject(156)) + ClientTree.DisconnectProject(160));
        }
      }
label_9:
      switch (5)
      {
        case 0:
          goto label_9;
      }
    }

    public void ShowAchievement()
    {
      if (this.OpenToShow <= ClientTree.DisconnectProject(168))
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.ShowAchievement);
            break;
        }
      }
      else
      {
        this.IsShowingCurrentAchievement = ClientTree.DisconnectProject(172) != 0;
        this.colorFadingFactor = ClientTree.DisconnectProject(176);
        this.CurrentFadeState = (FadeState) ClientTree.DisconnectProject(180);
        this.DisposeDrive();
      }
    }

    public void StartEndShowingAchievement()
    {
      this.CurrentFadeState = (FadeState) ClientTree.DisconnectProject(184);
    }

    public void EndShowingAchievement()
    {
      if (!this.IsShowingCurrentAchievement)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.EndShowingAchievement);
            break;
        }
      }
      else
      {
        this.IsShowingCurrentAchievement = ClientTree.DisconnectProject(188) != 0;
        if (this.CurrentAchievementProgress > this.OpenToShow)
        {
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              this.OpenToShow += ClientTree.DisconnectProject(192);
              break;
          }
        }
        else
          this.OpenToShow = ClientTree.DisconnectProject(196);
        this.colorFadingFactor = ClientTree.DisconnectProject(200);
        this.DisposeDrive();
      }
    }

    public void Update()
    {
      int index = this.CurrentAchievementProgress - this.nextOutput;
      if (index >= ClientTree.DisconnectProject(204))
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Achievement.Update);
            }
            if (index < (int) MenuToken.DisconnectProject(this.parentKeywords))
            {
label_5:
              switch (4)
              {
                case 0:
                  goto label_5;
                default:
                  if (this.CurrentAchievementProgress < ClientTree.DisconnectProject(208))
                  {
label_7:
                    switch (7)
                    {
                      case 0:
                        goto label_7;
                      default:
                        if (this.parentKeywords[index]())
                        {
label_9:
                          switch (1)
                          {
                            case 0:
                              goto label_9;
                            default:
                              this.CurrentAchievementProgress += ClientTree.DisconnectProject(212);
                              if (this.OpenToShow <= ClientTree.DisconnectProject(216))
                              {
label_11:
                                switch (7)
                                {
                                  case 0:
                                    goto label_11;
                                  default:
                                    this.OpenToShow = this.CurrentAchievementProgress;
                                    break;
                                }
                              }
                              else
                                break;
                              break;
                          }
                        }
                        else
                          break;
                        break;
                    }
                  }
                  else
                    break;
                  break;
              }
            }
            else
              break;
            break;
        }
      }
      if (!this.IsShowingCurrentAchievement)
      {
label_14:
        switch (2)
        {
          case 0:
            goto label_14;
        }
      }
      else
      {
        this.colorFadingFactor = this.CurrentFadeState != (FadeState) ClientTree.DisconnectProject(220) ? Math.Min(ClientTree.DisconnectProject(232), this.colorFadingFactor + ClientTree.DisconnectProject(236)) : Math.Max(ClientTree.DisconnectProject(224), this.colorFadingFactor - ClientTree.DisconnectProject(228));
        this.DisposeDrive();
      }
    }

    private void DisposeDrive()
    {
      this.colorFadingWhite = ActivityInvoker.DisconnectProject(Color.White, this.colorFadingFactor);
      this.parentKeywords = ActivityInvoker.DisconnectProject(Color.DarkGray, this.colorFadingFactor);
    }

    public bool FadingOutFinished
    {
      get
      {
        return this.CurrentFadeState == (FadeState) ClientTree.DisconnectProject(240) ? ((double) this.colorFadingFactor > (double) ClientTree.DisconnectProject(244) ? 1 : 0) == ClientTree.DisconnectProject(248) : ClientTree.DisconnectProject(252) != 0;
      }
    }

    public void Draw()
    {
      if (!this.IsShowingCurrentAchievement)
        return;
      int index1 = this.OpenToShow - ClientTree.DisconnectProject(256);
      int index2 = index1 - this.nextOutput;
      this.DrawIcon(index1);
      if (this.achievementTextLine2[index2] != null)
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.achievementTextLine2[index2], this.currentUri[index2], this.parentKeywords, ClientTree.DisconnectProject(260), Vector2.Zero, ClientTree.DisconnectProject(264), (SpriteEffects) ClientTree.DisconnectProject(268), ClientTree.DisconnectProject(272));
      GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.achievementTextLine1[index2], this.parentKeywords[index2], this.parentKeywords, ClientTree.DisconnectProject(276), Vector2.Zero, ClientTree.DisconnectProject(280), (SpriteEffects) ClientTree.DisconnectProject(284), ClientTree.DisconnectProject(288));
    }

    protected virtual void DrawIcon(int index)
    {
    }

    internal void ListQueue()
    {
      this.OpenToShow = ClientTree.DisconnectProject(292);
      this.IsShowingCurrentAchievement = ClientTree.DisconnectProject(296) != 0;
      this.colorFadingFactor = ClientTree.DisconnectProject(300);
      this.CurrentFadeState = (FadeState) ClientTree.DisconnectProject(304);
    }
  }
}
