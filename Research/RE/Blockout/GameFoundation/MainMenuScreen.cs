// Decompiled with JetBrains decompiler
// Type: GameFoundation.MainMenuScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class MainMenuScreen : MenuScreen
  {
    private const bool parentKeywords = false;
    [DataMember]
    public double DeserializeWorkaround;
    private bool currentUri;

    public MainMenuScreen()
      : base(EditorService.DisconnectProject(4582), ReferenceInvoker.DisconnectProject(4309) != 0)
    {
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void LoadContent()
    {
      if (this.currentUri)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MainMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.currentUri = ReferenceInvoker.DisconnectProject(4109) != 0;
        base.LoadContent();
        this.DisconnectProject();
        if (!MenuScreen.IsLandscapeMenu)
          return;
label_6:
        switch (3)
        {
          case 0:
            goto label_6;
          default:
            AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(4113) != 0);
            break;
        }
      }
    }

    private void DisconnectProject()
    {
      MenuEntry menuEntry1 = new MenuEntry(EditorService.DisconnectProject(4408));
      MenuEntry menuEntry2 = new MenuEntry(GameBase.Instance.GameSettings.CurrentModeHighScore.ToString());
      menuEntry2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4117);
      Vector2 vector2;
      BitmapService.DisconnectProject(ref vector2);
      vector2.Y = (float) (ReferenceInvoker.DisconnectProject(4121) + this.TopOffset);
      menuEntry2.ColorText = Color.Red;
      MenuEntryButton menuEntryButton1 = new MenuEntryButton(EditorService.DisconnectProject(4441));
      menuEntryButton1.Scale = ReferenceInvoker.DisconnectProject(4125);
      menuEntryButton1.IsPlayButton = ReferenceInvoker.DisconnectProject(4129) != 0;
      menuEntryButton1.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4133);
      MenuEntryButton menuEntryButton2 = new MenuEntryButton(EditorService.DisconnectProject(4450));
      menuEntryButton2.Scale = ReferenceInvoker.DisconnectProject(4137);
      menuEntryButton2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4141);
      MenuEntryButton menuEntryButton3 = new MenuEntryButton(EditorService.DisconnectProject(4349));
      menuEntryButton3.Scale = ReferenceInvoker.DisconnectProject(4145);
      menuEntryButton3.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4149);
      MenuEntryButton menuEntryButton4 = new MenuEntryButton(EditorService.DisconnectProject(4475));
      menuEntryButton4.Scale = ReferenceInvoker.DisconnectProject(4153);
      menuEntryButton4.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4157);
      MenuEntryButton menuEntryButton5 = new MenuEntryButton(EditorService.DisconnectProject(4500));
      menuEntryButton5.Scale = ReferenceInvoker.DisconnectProject(4161);
      menuEntryButton5.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4165);
      MenuEntryButton menuEntryButton6 = new MenuEntryButton(EditorService.DisconnectProject(4282));
      menuEntryButton6.Scale = ReferenceInvoker.DisconnectProject(4169);
      menuEntryButton6.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4173);
      MenuEntryButton menuEntryButton7 = new MenuEntryButton(EditorService.DisconnectProject(4517));
      menuEntryButton7.Scale = ReferenceInvoker.DisconnectProject(4177);
      menuEntryButton7.TexCustomBackground = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4520));
      MenuEntryButton menuEntryButton8 = new MenuEntryButton(EditorService.DisconnectProject(4567));
      menuEntryButton8.Scale = ReferenceInvoker.DisconnectProject(4181);
      menuEntryButton8.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4185);
      menuEntryButton1.Selected += new EventHandler<RelativeClickEventArg>(this.EnableDockingPane);
      menuEntryButton2.Selected += new EventHandler<RelativeClickEventArg>(this.SelectResource);
      menuEntryButton3.Selected += new EventHandler<RelativeClickEventArg>(this.DisposeDrive);
      menuEntryButton4.Selected += new EventHandler<RelativeClickEventArg>(this.ListQueue);
      menuEntryButton5.Selected += new EventHandler<RelativeClickEventArg>(this.LoadDirectory);
      menuEntryButton6.Selected += new EventHandler<RelativeClickEventArg>(this.ExtractDockingPane);
      menuEntryButton7.Selected += new EventHandler<RelativeClickEventArg>(this.EnableNetwork);
      menuEntryButton8.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
      if (MenuScreen.IsLandscapeMenu)
      {
        this.MenuEntries.Add(new MenuEntry("")
        {
          MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4189)
        });
        menuEntry1.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4193);
        menuEntry2.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4197);
        menuEntryButton1.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4201);
        menuEntryButton2.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4205);
        menuEntryButton5.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4209);
        menuEntryButton6.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4213);
        menuEntryButton7.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4217);
        menuEntryButton7.IsManualPosition = ReferenceInvoker.DisconnectProject(4221) != 0;
        menuEntryButton7.Position = new Vector2(ReferenceInvoker.DisconnectProject(4225), (float) (ScreenManager.BoundsScreen.Height - menuEntryButton7.GetHeight() - ReferenceInvoker.DisconnectProject(4229)));
      }
      this.MenuEntries.Add(menuEntry1);
      this.MenuEntries.Add(menuEntry2);
      this.MenuEntries.Add((MenuEntry) menuEntryButton1);
      this.MenuEntries.Add((MenuEntry) menuEntryButton3);
      this.MenuEntries.Add((MenuEntry) menuEntryButton5);
      AssemblyStack assemblyStack;
      if (MenuScreen.IsLandscapeMenu)
      {
label_3:
        switch (2)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MainMenuScreen.DisconnectProject);
            }
            assemblyStack = new AssemblyStack(new Vector2(ReferenceInvoker.DisconnectProject(4233), ReferenceInvoker.DisconnectProject(4237)));
            assemblyStack.Position = new Vector2(ReferenceInvoker.DisconnectProject(4241), ReferenceInvoker.DisconnectProject(4245));
            break;
        }
      }
      else
      {
        assemblyStack = new AssemblyStack(new Vector2(ReferenceInvoker.DisconnectProject(4249), ReferenceInvoker.DisconnectProject(4253)));
        assemblyStack.Position = new Vector2(ReferenceInvoker.DisconnectProject(4257), ReferenceInvoker.DisconnectProject(4261));
      }
      assemblyStack.IsManualPosition = ReferenceInvoker.DisconnectProject(4265) != 0;
      assemblyStack.Selected += new EventHandler<RelativeClickEventArg>(this.TestConnection);
      this.MenuEntries.Add((MenuEntry) assemblyStack);
      this.MenuEntries.Add((MenuEntry) menuEntryButton8);
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
      PlatformHelper.DisconnectProject();
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.AddScreen((GameScreen) GameBase.Instance.GetPuzzleScreen());
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.AddScreen((GameScreen) GameBase.Instance.GetAchievementScreen());
    }

    private void EnableNetwork(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.AddScreen((GameScreen) new CreditsMenuScreen());
    }

    private void TestConnection(object _param1, RelativeClickEventArg _param2)
    {
    }

    private void ExtractDockingPane(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.AddScreen((GameScreen) new CreditsMenuScreen());
    }

    private void LoadDirectory(object _param1, RelativeClickEventArg _param2)
    {
      PlatformHelper.LoadDirectory();
    }

    private void SelectResource(object _param1, RelativeClickEventArg _param2)
    {
    }

    private void EnableDockingPane(object _param1, RelativeClickEventArg _param2)
    {
      if (!MenuScreen.IsLandscapeMenu)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MainMenuScreen.EnableDockingPane);
            }
            ScreenManager instance = ScreenManager.Instance;
            int num1 = ReferenceInvoker.DisconnectProject(4269);
            int num2 = ReferenceInvoker.DisconnectProject(4273);
            GameScreen[] gameScreenArray1 = ImageEditor.DisconnectProject(ReferenceInvoker.DisconnectProject(4277));
            gameScreenArray1[ReferenceInvoker.DisconnectProject(4281)] = (GameScreen) new HowToPlayMenuScreen();
            GameScreen[] gameScreenArray2 = gameScreenArray1;
            LoadingScreen.SwitchToTempScreen(instance, num1 != 0, num2 != 0, gameScreenArray2);
            break;
        }
      }
      else
      {
        ScreenManager instance = ScreenManager.Instance;
        int num = ReferenceInvoker.DisconnectProject(4285);
        GameScreen[] gameScreenArray3 = ImageEditor.DisconnectProject(ReferenceInvoker.DisconnectProject(4289));
        gameScreenArray3[ReferenceInvoker.DisconnectProject(4293)] = (GameScreen) new BackgroundScreen(ReferenceInvoker.DisconnectProject(4297) != 0);
        gameScreenArray3[ReferenceInvoker.DisconnectProject(4301)] = (GameScreen) new HowToPlayMenuScreen();
        GameScreen[] gameScreenArray4 = gameScreenArray3;
        LoadingScreen.Load(instance, num != 0, gameScreenArray4);
      }
    }

    protected override void OnCancel() => GameBase.Instance.Exit();

    public override void HideScreen(bool setToHidden)
    {
      if (setToHidden)
        return;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MainMenuScreen.HideScreen);
          }
          if (!MenuScreen.IsLandscapeMenu)
            break;
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(4305) != 0);
              return;
          }
      }
    }
  }
}
