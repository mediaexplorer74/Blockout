// Decompiled with JetBrains decompiler
// Type: Blockout.AchievementsScreen
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class AchievementsScreen : MenuScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    private bool parentKeywords;
    private Rectangle parentKeywords;
    private Vector2 parentKeywords;

    public AchievementsScreen()
      : base(DatabaseLoader.DisconnectProject(11893), ClientTree.DisconnectProject(1983561) != 0)
    {
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void HandleInput(InputState input)
    {
      if (input == null)
        throw new ArgumentNullException(DatabaseLoader.DisconnectProject(11845));
      if (input.IsNewButtonPress((Buttons) ClientTree.DisconnectProject(1983409)))
      {
label_3:
        switch (1)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementsScreen.HandleInput);
            }
            LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ClientTree.DisconnectProject(1983413) != 0, ClientTree.DisconnectProject(1983417));
            break;
        }
      }
      else
      {
        this.HandleInput(input, out bool _);
        this.IgnoreHandleInput();
      }
    }

    public override void LoadContent()
    {
      if (this.parentKeywords)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementsScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ClientTree.DisconnectProject(1983421) != 0;
        base.LoadContent();
        this.parentKeywords = new Rectangle(ClientTree.DisconnectProject(1983425), ClientTree.DisconnectProject(1983429), ClientTree.DisconnectProject(1983433), ClientTree.DisconnectProject(1983437));
        this.parentKeywords = new Vector2(ClientTree.DisconnectProject(1983441), ClientTree.DisconnectProject(1983445));
        MenuEntry menuEntry1 = new MenuEntry(DatabaseLoader.DisconnectProject(11856));
        menuEntry1.AdditionalBottomMargin = ClientTree.DisconnectProject(1983449);
        MenuEntry menuEntry2 = new MenuEntry("");
        menuEntry2.AdditionalBottomMargin = ClientTree.DisconnectProject(1983453);
        MenuEntryButton menuEntryButton = new MenuEntryButton(DatabaseLoader.DisconnectProject(11881));
        menuEntryButton.Selected += new EventHandler<RelativeClickEventArg>(this.ListQueue);
        menuEntryButton.Scale = ClientTree.DisconnectProject(1983457);
        menuEntryButton.AdditionalBottomMargin = ClientTree.DisconnectProject(1983461);
        if (MenuScreen.IsLandscapeMenu)
        {
label_5:
          switch (7)
          {
            case 0:
              goto label_5;
            default:
              menuEntryButton.MenuLocation = (MenuLocation) ClientTree.DisconnectProject(1983465);
              break;
          }
        }
        this.MenuEntries.Add(menuEntry1);
        this.MenuEntries.Add(menuEntry2);
        this.MenuEntries.Add((MenuEntry) menuEntryButton);
      }
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      OnlineCommunications.Instance.OpenHomepage();
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2) => this.ExitScreen();

    public override void Draw(GameTime gameTime)
    {
      base.Draw(gameTime);
      Color color = ActivityInvoker.DisconnectProject(Color.White, this.TransitionAlpha);
      Achievement[] achievement = AchievementManager.Instance.achievement;
      Vector2 vector2 = new Vector2((float) this.parentKeywords.X, (float) this.parentKeywords.Y);
      for (int index1 = ClientTree.DisconnectProject(1983469); index1 < (int) ActivatorManager.DisconnectProject(achievement); index1 += ClientTree.DisconnectProject(1983557))
      {
        for (int index2 = ClientTree.DisconnectProject(1983473); index2 < achievement[index1].AchievementsToGet; index2 += ClientTree.DisconnectProject(1983477))
        {
          int achievementProgress = achievement[index1].CurrentAchievementProgress;
          vector2.X += this.parentKeywords.X;
        }
        float scale = ClientTree.DisconnectProject(1983481);
        float num1 = vector2.Y + (float) this.parentKeywords.Height / ClientTree.DisconnectProject(1983485);
        float num2 = ScreenManager.Instance.MenuFont.MeasureString(DatabaseLoader.DisconnectProject(11890)).Y * scale;
        int index3 = achievement[index1].CurrentAchievementProgress - ClientTree.DisconnectProject(1983489);
        Vector2 position;
        if (index3 >= ClientTree.DisconnectProject(1983493))
        {
label_5:
          switch (6)
          {
            case 0:
              goto label_5;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (AchievementsScreen.Draw);
              }
              if (achievement[index1].achievementTextLine2[index3] != null)
              {
label_9:
                switch (1)
                {
                  case 0:
                    goto label_9;
                  default:
                    GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, achievement[index1].achievementTexLine2Extended[index3], new Vector2(vector2.X + ClientTree.DisconnectProject(1983497), num1 - num2 / ClientTree.DisconnectProject(1983501) + ClientTree.DisconnectProject(1983505)), color, ClientTree.DisconnectProject(1983509), Vector2.Zero, scale, (SpriteEffects) ClientTree.DisconnectProject(1983513), ClientTree.DisconnectProject(1983517));
                    position = new Vector2(vector2.X + ClientTree.DisconnectProject(1983521), num1 - num2 / ClientTree.DisconnectProject(1983525) - ClientTree.DisconnectProject(1983529));
                    goto label_12;
                }
              }
              else
                break;
          }
        }
        position = new Vector2(vector2.X + ClientTree.DisconnectProject(1983533), num1 - num2 / ClientTree.DisconnectProject(1983537));
        index3 += ClientTree.DisconnectProject(1983541);
label_12:
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, achievement[index1].achievementTextLine1[index3], position, color, ClientTree.DisconnectProject(1983545), Vector2.Zero, scale, (SpriteEffects) ClientTree.DisconnectProject(1983549), ClientTree.DisconnectProject(1983553));
        vector2.X = (float) this.parentKeywords.X;
        vector2.Y += this.parentKeywords.Y;
      }
    }
  }
}
