// Decompiled with JetBrains decompiler
// Type: Blockout.PuzzlePacksScreen
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class PuzzlePacksScreen : MenuScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    private bool parentKeywords;

    public PuzzlePacksScreen()
      : base(DatabaseLoader.DisconnectProject(12021), ClientTree.DisconnectProject(1983797) != 0)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzlePacksScreen.HandleInput);
            }
            throw new ArgumentNullException(DatabaseLoader.DisconnectProject(11845));
        }
      }
      else if (input.IsNewButtonPress((Buttons) ClientTree.DisconnectProject(1983741)))
      {
        this.DisconnectProject();
      }
      else
      {
        this.HandleInput(input, out bool _);
        this.IgnoreHandleInput();
      }
    }

    private void DisconnectProject()
    {
      GameScreen[] screens = ScreenManager.Instance.GetScreens();
      for (int index = ClientTree.DisconnectProject(1983745); index < (int) ToolboxEventArgs.DisconnectProject(screens); index += ClientTree.DisconnectProject(1983749))
      {
        if (ActivityQueue.DisconnectProject((object) screens[index]) != null)
        {
label_2:
          switch (1)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzlePacksScreen.DisconnectProject);
              }
              LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, (GameScreen) GameplayScreen.Instance);
              return;
          }
        }
      }
label_8:
      switch (5)
      {
        case 0:
          goto label_8;
        default:
          LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ClientTree.DisconnectProject(1983753) != 0, ClientTree.DisconnectProject(1983757));
          break;
      }
    }

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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzlePacksScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ClientTree.DisconnectProject(1983761) != 0;
        base.LoadContent();
        MenuEntry menuEntry1 = new MenuEntry(DatabaseLoader.DisconnectProject(11996));
        menuEntry1.AdditionalBottomMargin = ClientTree.DisconnectProject(1983765);
        MenuEntry menuEntry2 = new MenuEntry("");
        int num = MenuScreen.IsLandscapeMenu ? 1 : 0;
        this.MenuEntries.Add(menuEntry1);
        ChallangeBlock[] types = ChallangeBlockTypes.GetTypes();
        for (int index = ClientTree.DisconnectProject(1983769); index < (int) StreamManager.DisconnectProject(types); index += ClientTree.DisconnectProject(1983781))
        {
          MenuEntryButton menuEntryButton = new MenuEntryButton(types[index].ToString());
          menuEntryButton.Scale = ClientTree.DisconnectProject(1983773);
          menuEntryButton.AdditionalBottomMargin = ClientTree.DisconnectProject(1983777);
          menuEntryButton.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
          this.MenuEntries.Add((MenuEntry) menuEntryButton);
        }
label_7:
        switch (6)
        {
          case 0:
            goto label_7;
          default:
            this.MenuEntries[this.MenuEntries.Count - ClientTree.DisconnectProject(1983785)].AdditionalBottomMargin += ClientTree.DisconnectProject(1983789);
            break;
        }
      }
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
      MenuEntryButton menuEntryButton = PageOptions.DisconnectProject(_param1);
      if (menuEntryButton == null)
        return;
      ChallangeBlock challangeBlock = (ChallangeBlock) Enum.Parse(Type.GetTypeFromHandle(ProcessFactory.DisconnectProject()), menuEntryButton.Text, ClientTree.DisconnectProject(1983793) != 0);
      ScreenManager.Instance.AddScreen((GameScreen) new PuzzleScreen()
      {
        ChallangeMode = challangeBlock
      });
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2)
    {
      OnlineCommunications.Instance.OpenHomepage();
    }

    private void EnableNetwork(object _param1, RelativeClickEventArg _param2)
    {
      this.DisconnectProject();
    }

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
    }

    public override void Draw(GameTime gameTime)
    {
      base.Draw(gameTime);
      ActivityInvoker.DisconnectProject(Color.White, this.TransitionAlpha);
    }
  }
}
