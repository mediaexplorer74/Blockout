// *************************************************************
// Type: GameFoundation.ScoreMenuScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class ScoreMenuScreen : MenuScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    [DataMember]
    public int scores;
    private bool parentKeywords;

    public ScoreMenuScreen(int scores)
      : base(EditorService.DisconnectProject(5235), ReferenceInvoker.DisconnectProject(4985) != 0)
    {
      this.scores = scores;
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void LoadContent()
    {
      if (this.parentKeywords)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScoreMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(4841) != 0;
        base.LoadContent();
        this.DisconnectProject(this.scores);
      }
    }

    private void DisconnectProject(int _param1)
    {
      this.scores = _param1;
      GameBase.Instance.GameSettings.CurrentModeHighScore = this.scores;
      MenuEntry menuEntry1 = new MenuEntry(EditorService.DisconnectProject(5199));
      MenuEntry menuEntry2 = new MenuEntry(this.scores.ToString());
      menuEntry2.ColorText = Color.Red;
      menuEntry2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4845);
      MenuEntryButton menuEntryButton1 = new MenuEntryButton(EditorService.DisconnectProject(5173));
      menuEntryButton1.Scale = ReferenceInvoker.DisconnectProject(4849);
      menuEntryButton1.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4853);
      MenuEntryButton menuEntryButton2 = new MenuEntryButton(EditorService.DisconnectProject(4450));
      menuEntryButton2.Scale = ReferenceInvoker.DisconnectProject(4857);
      menuEntryButton2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4861);
      MenuEntryButton menuEntryButton3 = new MenuEntryButton(EditorService.DisconnectProject(4582));
      menuEntryButton3.Scale = ReferenceInvoker.DisconnectProject(4865);
      menuEntryButton3.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4869);
      menuEntryButton1.Selected += new EventHandler<RelativeClickEventArg>(this.DisposeDrive);
      menuEntryButton2.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
      menuEntryButton3.Selected += new EventHandler<RelativeClickEventArg>(this.ListQueue);
      if (MenuScreen.IsLandscapeMenu)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScoreMenuScreen.DisconnectProject);
            }
            menuEntry1.IsManualPosition = ReferenceInvoker.DisconnectProject(4873) != 0;
            menuEntry1.Position = new Vector2((float) ((double) ReferenceInvoker.DisconnectProject(4877) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(4881) - (double) ReferenceInvoker.DisconnectProject(4885) * (double) menuEntry1.GetWidth() / (double) ReferenceInvoker.DisconnectProject(4889)), ReferenceInvoker.DisconnectProject(4893));
            menuEntry2.IsManualPosition = ReferenceInvoker.DisconnectProject(4897) != 0;
            menuEntry2.Position = new Vector2((float) ((double) ReferenceInvoker.DisconnectProject(4901) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(4905) - (double) ReferenceInvoker.DisconnectProject(4909) * (double) menuEntry2.GetWidth() / (double) ReferenceInvoker.DisconnectProject(4913)), ReferenceInvoker.DisconnectProject(4917));
            MenuEntry menuEntry3 = new MenuEntry(nameof ())
            {
              MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4921)
            };
            menuEntry3.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4925);
            this.MenuEntries.Add(menuEntry3);
            menuEntryButton1.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4929);
            menuEntryButton2.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4933);
            menuEntryButton3.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4937);
            break;
        }
      }
      this.MenuEntries.Add(menuEntry1);
      this.MenuEntries.Add(menuEntry2);
      MenuEntry menuEntry4 = new MenuEntry(EditorService.DisconnectProject(5220))
      {
        Scale = ReferenceInvoker.DisconnectProject(4941),
        IsManualPosition = ReferenceInvoker.DisconnectProject(4945) != 0
      };
      menuEntry4.Position = new Vector2((float) ((double) ReferenceInvoker.DisconnectProject(4949) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(4953) - (double) ReferenceInvoker.DisconnectProject(4957) * (double) menuEntry4.GetWidth() / (double) ReferenceInvoker.DisconnectProject(4961)), ReferenceInvoker.DisconnectProject(4965));
      this.MenuEntries.Add(menuEntry4);
      this.MenuEntries.Add((MenuEntry) menuEntryButton2);
      this.MenuEntries.Add((MenuEntry) menuEntryButton1);
      this.MenuEntries.Add((MenuEntry) menuEntryButton3);
    }

    public override void HandleInput(InputState input)
    {
      if (input == null)
        throw new ArgumentNullException(EditorService.DisconnectProject(4204));
      if (input.IsNewButtonPress((Buttons) ReferenceInvoker.DisconnectProject(4969)))
      {
label_3:
        switch (5)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScoreMenuScreen.HandleInput);
            }
            ScreenManager.Instance.RemoveScreen((GameScreen) GameplayScreenBase.Instance);
            ScreenManager.Instance.AddScreen((GameScreen) new MainMenuScreen());
            ScreenManager.Instance.PlaySound();
            this.ExitScreen();
            break;
        }
      }
      else
      {
        base.HandleInput(input);
        this.IgnoreHandleInput();
      }
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.DisposeDrive();
      LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ReferenceInvoker.DisconnectProject(4973) != 0, ReferenceInvoker.DisconnectProject(4977));
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.RemoveScreen((GameScreen) GameplayScreenBase.Instance);
      ScreenManager.Instance.AddScreen((GameScreen) new MainMenuScreen());
      this.ExitScreen();
    }

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
      if (otherScreenHasFocus)
        return;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScoreMenuScreen.Update);
          }
          if (coveredByOtherScreen)
            break;
label_5:
          switch (4)
          {
            case 0:
              goto label_5;
            default:
              AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(4981) != 0);
              return;
          }
      }
    }
  }
}
