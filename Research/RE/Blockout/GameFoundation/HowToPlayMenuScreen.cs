// Decompiled with JetBrains decompiler
// Type: GameFoundation.HowToPlayMenuScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class HowToPlayMenuScreen : MenuScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    private Texture2D parentKeywords;
    private MenuEntryButton parentKeywords;
    private MenuEntryButton currentUri;
    private bool parentKeywords;

    public HowToPlayMenuScreen()
      : base(EditorService.DisconnectProject(4364), ReferenceInvoker.DisconnectProject(3933) != 0)
    {
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void HandleInput(InputState input)
    {
      if (input == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (HowToPlayMenuScreen.HandleInput);
            }
            throw new ArgumentNullException(EditorService.DisconnectProject(4204));
        }
      }
      else if (input.IsNewButtonPress((Buttons) ReferenceInvoker.DisconnectProject(3777)))
      {
label_6:
        switch (6)
        {
          case 0:
            goto label_6;
          default:
            if (!MenuScreen.IsLandscapeMenu)
            {
              LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ReferenceInvoker.DisconnectProject(3781) != 0, ReferenceInvoker.DisconnectProject(3785));
              break;
            }
            ScreenManager instance = ScreenManager.Instance;
            int num = ReferenceInvoker.DisconnectProject(3789);
            GameScreen[] gameScreenArray1 = ImageEditor.DisconnectProject(ReferenceInvoker.DisconnectProject(3793));
            gameScreenArray1[ReferenceInvoker.DisconnectProject(3797)] = (GameScreen) new BackgroundScreen(ReferenceInvoker.DisconnectProject(3801) != 0);
            gameScreenArray1[ReferenceInvoker.DisconnectProject(3805)] = (GameScreen) new MainMenuScreen();
            GameScreen[] gameScreenArray2 = gameScreenArray1;
            LoadingScreen.Load(instance, num != 0, gameScreenArray2);
            break;
        }
      }
      else
      {
        base.HandleInput(input);
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (HowToPlayMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(3809) != 0;
        base.LoadContent();
        AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(3813) != 0);
        this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4297));
        this.parentKeywords = new MenuEntryButton(EditorService.DisconnectProject(4332));
        this.parentKeywords.IsManualPosition = ReferenceInvoker.DisconnectProject(3817) != 0;
        this.parentKeywords.Scale = ReferenceInvoker.DisconnectProject(3821);
        this.parentKeywords.Selected += new EventHandler<RelativeClickEventArg>(this.EnableNetwork);
        this.currentUri = new MenuEntryButton(EditorService.DisconnectProject(4349));
        this.currentUri.IsManualPosition = ReferenceInvoker.DisconnectProject(3825) != 0;
        this.currentUri.Scale = ReferenceInvoker.DisconnectProject(3829);
        this.currentUri.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
        if (MenuScreen.IsLandscapeMenu)
        {
label_5:
          switch (6)
          {
            case 0:
              goto label_5;
            default:
              float x = (float) ((double) ReferenceInvoker.DisconnectProject(3833) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(3837) * (double) ReferenceInvoker.DisconnectProject(3841) - (double) ReferenceInvoker.DisconnectProject(3845) * (double) this.currentUri.GetWidth() / (double) ReferenceInvoker.DisconnectProject(3849)) + ReferenceInvoker.DisconnectProject(3853);
              this.parentKeywords.Position = new Vector2(x, ReferenceInvoker.DisconnectProject(3857));
              this.parentKeywords.Scale = ReferenceInvoker.DisconnectProject(3861);
              this.currentUri.Position = new Vector2(x, ReferenceInvoker.DisconnectProject(3865));
              this.currentUri.Scale = ReferenceInvoker.DisconnectProject(3869);
              break;
          }
        }
        else
        {
          float x = (float) ((double) ReferenceInvoker.DisconnectProject(3873) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(3877) - (double) ReferenceInvoker.DisconnectProject(3881) * (double) this.currentUri.GetWidth() / (double) ReferenceInvoker.DisconnectProject(3885));
          this.parentKeywords.Position = new Vector2(x, ReferenceInvoker.DisconnectProject(3889));
          this.currentUri.Position = new Vector2(x, ReferenceInvoker.DisconnectProject(3893));
        }
        if (GameplayScreenBase.Instance.IsGameToContinue)
          this.MenuEntries.Add((MenuEntry) this.parentKeywords);
        this.MenuEntries.Add((MenuEntry) this.currentUri);
      }
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager instance = ScreenManager.Instance;
      int num1 = ReferenceInvoker.DisconnectProject(3897);
      int num2 = ReferenceInvoker.DisconnectProject(3901);
      GameScreen[] gameScreenArray1 = ImageEditor.DisconnectProject(ReferenceInvoker.DisconnectProject(3905));
      gameScreenArray1[ReferenceInvoker.DisconnectProject(3909)] = (GameScreen) GameBase.Instance.GetPuzzleScreen();
      GameScreen[] gameScreenArray2 = gameScreenArray1;
      LoadingScreen.SwitchToTempScreen(instance, num1 != 0, num2 != 0, gameScreenArray2);
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.StartGame();
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.StartGame();
    }

    private void EnableNetwork(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager instance = ScreenManager.Instance;
      int num = ReferenceInvoker.DisconnectProject(3913);
      GameScreen[] gameScreenArray1 = ImageEditor.DisconnectProject(ReferenceInvoker.DisconnectProject(3917));
      gameScreenArray1[ReferenceInvoker.DisconnectProject(3921)] = (GameScreen) GameplayScreenBase.Instance;
      GameScreen[] gameScreenArray2 = gameScreenArray1;
      LoadingScreen.Load(instance, num != 0, gameScreenArray2);
      GameplayScreenBase.Instance.Resume();
    }

    public override void Draw(GameTime gameTime)
    {
      base.Draw(gameTime);
      Color color = WindowOptions.DisconnectProject(Color.White, this.TransitionAlpha);
      GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, new Rectangle(this.TransitionOffsetX, ReferenceInvoker.DisconnectProject(3925), this.parentKeywords.Width, this.parentKeywords.Height), color);
    }

    public override void HideScreen(bool setToHidden)
    {
      if (setToHidden)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (HowToPlayMenuScreen.HideScreen);
          }
          AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(3929) != 0);
          break;
      }
    }
  }
}
