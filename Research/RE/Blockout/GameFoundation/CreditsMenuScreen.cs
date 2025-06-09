// Decompiled with JetBrains decompiler
// Type: GameFoundation.CreditsMenuScreen
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
  public class CreditsMenuScreen : MenuScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    private Texture2D parentKeywords;
    private bool parentKeywords;

    public CreditsMenuScreen()
      : base(EditorService.DisconnectProject(4282), ReferenceInvoker.DisconnectProject(3641) != 0)
    {
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void HandleInput(InputState input)
    {
      if (input == null)
        throw new ArgumentNullException(EditorService.DisconnectProject(4204));
      if (input.IsNewButtonPress((Buttons) ReferenceInvoker.DisconnectProject(3593)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (CreditsMenuScreen.HandleInput);
            }
            LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ReferenceInvoker.DisconnectProject(3597) != 0, ReferenceInvoker.DisconnectProject(3601));
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
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (CreditsMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(3605) != 0;
        base.LoadContent();
        this.parentKeywords = ScreenManager.Instance.Game.Content.Load<Texture2D>(EditorService.DisconnectProject(4215));
        MenuEntryButton menuEntryButton1 = new MenuEntryButton(EditorService.DisconnectProject(4246));
        menuEntryButton1.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
        menuEntryButton1.Scale = ReferenceInvoker.DisconnectProject(3609);
        menuEntryButton1.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(3613);
        MenuEntryButton menuEntryButton2 = new MenuEntryButton(EditorService.DisconnectProject(4273));
        menuEntryButton2.Selected += new EventHandler<RelativeClickEventArg>(this.DisposeDrive);
        menuEntryButton2.Scale = ReferenceInvoker.DisconnectProject(3617);
        menuEntryButton2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(3621);
        if (MenuScreen.IsLandscapeMenu)
        {
          menuEntryButton1.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(3625);
          menuEntryButton2.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(3629);
        }
        else
          this.MenuEntries.Add(new MenuEntry("")
          {
            AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(3633)
          });
        this.MenuEntries.Add((MenuEntry) menuEntryButton1);
        this.MenuEntries.Add((MenuEntry) menuEntryButton2);
      }
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
      OnlineCommunications.Instance.OpenHomepage();
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2) => this.ExitScreen();

    public override void Draw(GameTime gameTime)
    {
      base.Draw(gameTime);
      Color color = WindowOptions.DisconnectProject(Color.White, this.TransitionAlpha);
      GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, new Rectangle(this.TransitionOffsetX, ReferenceInvoker.DisconnectProject(3637), this.parentKeywords.Width, this.parentKeywords.Height), color);
    }
  }
}
