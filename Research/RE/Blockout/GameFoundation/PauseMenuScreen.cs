// Decompiled with JetBrains decompiler
// Type: GameFoundation.PauseMenuScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class PauseMenuScreen : MenuScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    private bool parentKeywords;

    public PauseMenuScreen()
      : base(EditorService.DisconnectProject(5188), ReferenceInvoker.DisconnectProject(4837) != 0)
    {
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void LoadContent()
    {
      if (this.parentKeywords)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PauseMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(4757) != 0;
        base.LoadContent();
        MenuEntry menuEntry = new MenuEntry("");
        if (!MenuScreen.IsLandscapeMenu)
        {
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              menuEntry.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4761);
              break;
          }
        }
        else
          menuEntry.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4765);
        MenuEntryButton menuEntryButton1 = new MenuEntryButton(EditorService.DisconnectProject(5160));
        menuEntryButton1.Scale = ReferenceInvoker.DisconnectProject(4769);
        menuEntryButton1.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4773);
        MenuEntryButton menuEntryButton2 = new MenuEntryButton(EditorService.DisconnectProject(5173));
        menuEntryButton2.Scale = ReferenceInvoker.DisconnectProject(4777);
        menuEntryButton2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4781);
        MenuEntryButton menuEntryButton3 = new MenuEntryButton(EditorService.DisconnectProject(4582));
        menuEntryButton3.Scale = ReferenceInvoker.DisconnectProject(4785);
        menuEntryButton3.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4789);
        menuEntryButton1.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
        menuEntryButton2.Selected += new EventHandler<RelativeClickEventArg>(this.DisposeDrive);
        menuEntryButton3.Selected += new EventHandler<RelativeClickEventArg>(this.ListQueue);
        if (MenuScreen.IsLandscapeMenu)
        {
label_9:
          switch (7)
          {
            case 0:
              goto label_9;
            default:
              menuEntry.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4793);
              menuEntryButton1.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4797);
              menuEntryButton2.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4801);
              menuEntryButton3.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4805);
              break;
          }
        }
        this.MenuEntries.Add(menuEntry);
        this.MenuEntries.Add((MenuEntry) menuEntryButton1);
        this.MenuEntries.Add((MenuEntry) menuEntryButton2);
        this.MenuEntries.Add((MenuEntry) menuEntryButton3);
        AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(4809) != 0);
      }
    }

    public override void HandleInput(InputState input)
    {
      if (input == null)
        throw new ArgumentNullException(EditorService.DisconnectProject(4204));
      if (input.IsNewButtonPress((Buttons) ReferenceInvoker.DisconnectProject(4813)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PauseMenuScreen.HandleInput);
            }
            GameplayScreenBase.Instance.SetDefaultUpdatePause();
            LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, (GameScreen) GameplayScreenBase.Instance);
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
      GameplayScreenBase.Instance.SetDefaultUpdatePause();
      LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ReferenceInvoker.DisconnectProject(4817) != 0, ReferenceInvoker.DisconnectProject(4821));
      GameplayScreenBase.Instance.Resume();
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.DisposeDrive();
      LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ReferenceInvoker.DisconnectProject(4825) != 0, ReferenceInvoker.DisconnectProject(4829));
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2)
    {
      ScreenManager.Instance.RemoveScreen((GameScreen) GameplayScreenBase.Instance);
      ScreenManager.Instance.AddScreen((GameScreen) new MainMenuScreen());
      this.ExitScreen();
    }

    public override void HideScreen(bool setToHidden)
    {
      if (setToHidden)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PauseMenuScreen.HideScreen);
          }
          AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(4833) != 0);
          break;
      }
    }
  }
}
