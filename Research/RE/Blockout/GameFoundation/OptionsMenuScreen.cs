// Decompiled with JetBrains decompiler
// Type: GameFoundation.OptionsMenuScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class OptionsMenuScreen : MenuScreen
  {
    private const bool parentKeywords = false;
    [DataMember]
    public double DeserializeWorkaround;
    private bool currentUri;
    private MenuEntryButton parentKeywords;
    private MenuEntryButton currentUri;
    private ConnectionType parentKeywords;
    private MenuEntryButton filterID;

    public OptionsMenuScreen()
      : base(EditorService.DisconnectProject(5145), ReferenceInvoker.DisconnectProject(4753) != 0)
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
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (OptionsMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.currentUri = ReferenceInvoker.DisconnectProject(4645) != 0;
        base.LoadContent();
        MenuEntry menuEntry1 = new MenuEntry("");
        MenuEntry menuEntry2 = new MenuEntry(EditorService.DisconnectProject(4500));
        menuEntry2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4649);
        this.parentKeywords = new MenuEntryButton(EditorService.DisconnectProject(4992));
        this.parentKeywords.Scale = ReferenceInvoker.DisconnectProject(4653);
        this.parentKeywords.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4657);
        this.currentUri = new MenuEntryButton(EditorService.DisconnectProject(5007));
        this.currentUri.Scale = ReferenceInvoker.DisconnectProject(4661);
        this.currentUri.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4665);
        this.parentKeywords = new ConnectionType(EditorService.DisconnectProject(5028));
        this.parentKeywords.Scale = ReferenceInvoker.DisconnectProject(4669);
        this.parentKeywords.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4673);
        this.parentKeywords.currentNode = GameBase.Instance.GameSettings.MusicVolume;
        this.filterID = new MenuEntryButton(EditorService.DisconnectProject(5053));
        this.filterID.Scale = ReferenceInvoker.DisconnectProject(4677);
        this.filterID.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4681);
        MenuEntryButton menuEntryButton = new MenuEntryButton(EditorService.DisconnectProject(4273));
        menuEntryButton.Scale = ReferenceInvoker.DisconnectProject(4685);
        this.parentKeywords.Selected += new EventHandler<RelativeClickEventArg>(this.ListQueue);
        this.currentUri.Selected += new EventHandler<RelativeClickEventArg>(this.EnableNetwork);
        this.parentKeywords.Selected += new EventHandler<RelativeClickEventArg>(this.DisposeDrive);
        this.filterID.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
        menuEntryButton.Selected += new EventHandler<RelativeClickEventArg>(this.TestConnection);
        if (MenuScreen.IsLandscapeMenu)
        {
label_5:
          switch (7)
          {
            case 0:
              goto label_5;
            default:
              menuEntry1.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4689);
              menuEntry2.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4693);
              this.parentKeywords.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4697);
              this.currentUri.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4701);
              this.parentKeywords.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4705);
              this.filterID.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4709);
              menuEntryButton.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4713);
              this.MenuEntries.Add(menuEntry1);
              break;
          }
        }
        else
        {
          menuEntry1.Scale = ReferenceInvoker.DisconnectProject(4717);
          menuEntry2.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4721);
        }
        this.MenuEntries.Add(menuEntry2);
        this.parentKeywords.IsVisible = ReferenceInvoker.DisconnectProject(4725) != 0;
        this.parentKeywords.IsVisible = ReferenceInvoker.DisconnectProject(4729) != 0;
        this.MenuEntries.Add((MenuEntry) this.parentKeywords);
        this.MenuEntries.Add((MenuEntry) this.currentUri);
        this.MenuEntries.Add((MenuEntry) this.parentKeywords);
        if (!MenuScreen.IsLandscapeMenu)
        {
label_9:
          switch (5)
          {
            case 0:
              goto label_9;
            default:
              this.filterID.AdditionalBottomMargin = ReferenceInvoker.DisconnectProject(4733);
              this.MenuEntries.Add((MenuEntry) this.filterID);
              break;
          }
        }
        this.filterID.IsVisible = ReferenceInvoker.DisconnectProject(4737) != 0;
        this.MenuEntries.Add((MenuEntry) menuEntryButton);
        this.DisconnectProject();
      }
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
      this.DisconnectProject();
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      this.parentKeywords.DisconnectProject(_param2.RelativeHitPoint.X);
      GameBase.Instance.GameSettings.MusicVolume = this.parentKeywords.currentNode;
      GameBase.Instance.UpdateVolume();
    }

    private void DisconnectProject()
    {
      int num = GameBase.Instance.GameSettings.MusicIsOn ? 1 : 0;
      this.parentKeywords.Text = EditorService.DisconnectProject(5072);
      this.parentKeywords.IsVisible = ReferenceInvoker.DisconnectProject(4741) != 0;
      if (GameBase.Instance.GameSettings.SoundFxIsOn)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (OptionsMenuScreen.DisconnectProject);
            }
            this.currentUri.Text = EditorService.DisconnectProject(5093);
            break;
        }
      }
      else
        this.currentUri.Text = EditorService.DisconnectProject(5118);
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2)
    {
      GameBase.Instance.GameSettings.MusicIsOn = (GameBase.Instance.GameSettings.MusicIsOn ? 1 : 0) == ReferenceInvoker.DisconnectProject(4745);
      this.DisconnectProject();
      GameBase.Instance.UpdateMusicIsOn();
    }

    private void EnableNetwork(object _param1, RelativeClickEventArg _param2)
    {
      GameBase.Instance.GameSettings.SoundFxIsOn = (GameBase.Instance.GameSettings.SoundFxIsOn ? 1 : 0) == ReferenceInvoker.DisconnectProject(4749);
      this.DisconnectProject();
    }

    private void TestConnection(object _param1, RelativeClickEventArg _param2) => this.ExitScreen();
  }
}
