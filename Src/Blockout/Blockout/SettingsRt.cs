// *************************************************************
// Type: Blockout.SettingsRt
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace Blockout
{
  public sealed class SettingsRt : UserControl, IComponentConnector
  {
    private bool parentKeywords;
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private StackPanel parentKeywords;
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private ToggleSwitch parentKeywords;
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private bool currentUri;

    internal SettingsRt()
    {
      this.InitializeComponent();
      this.parentKeywords.put_IsOn(GameBase.Instance.GameSettings.SoundFxIsOn);
      this.parentKeywords = ClientTree.DisconnectProject(1984821) != 0;
    }

    internal static void DisconnectProject() => SettingsPane.Show();

    private void DisconnectProject(object _param1, RoutedEventArgs _param2)
    {
      if ((object) ((FrameworkElement) this).Parent.GetType() == (object) Type.GetTypeFromHandle(IconSet.DisconnectProject()))
        QueueSettings.DisconnectProject((object) ((FrameworkElement) this).Parent).put_IsOpen(ClientTree.DisconnectProject(1984801) != 0);
      SettingsPane.Show();
    }

    private void DisposeDrive(object _param1, RoutedEventArgs _param2)
    {
      if (!this.parentKeywords)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (SettingsRt.DisposeDrive);
            break;
        }
      }
      else
        GameBase.Instance.GameSettings.InvertOptionMusicIsOn();
    }

    private void ListQueue(object _param1, RoutedEventArgs _param2)
    {
      if (!this.parentKeywords)
        return;
      GameBase.Instance.GameSettings.InvertOptionSoundIsOn();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    public void InitializeComponent()
    {
      if (this.currentUri)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (SettingsRt.InitializeComponent);
            break;
        }
      }
      else
      {
        this.currentUri = ClientTree.DisconnectProject(1984805) != 0;
        Application.LoadComponent((object) this, new Uri(DatabaseLoader.DisconnectProject(13460)), (ComponentResourceLocation) ClientTree.DisconnectProject(1984809));
        this.parentKeywords = ToolboxCollection.DisconnectProject(((FrameworkElement) this).FindName(DatabaseLoader.DisconnectProject(13531)));
        this.parentKeywords = SymbolEditor.DisconnectProject(((FrameworkElement) this).FindName(DatabaseLoader.DisconnectProject(13558)));
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    public void Connect(int connectionId, object target)
    {
      switch (connectionId - ClientTree.DisconnectProject(1984813))
      {
        case 0:
          ToggleSwitch toggleSwitch = SymbolEditor.DisconnectProject(target);
          WindowsRuntimeMarshal.AddEventHandler<RoutedEventHandler>(new Func<RoutedEventHandler, EventRegistrationToken>(toggleSwitch.add_Toggled), new Action<EventRegistrationToken>(toggleSwitch.remove_Toggled), new RoutedEventHandler(this.ListQueue));
          break;
        case 1:
          ButtonBase buttonBase = DialogStream.DisconnectProject(target);
          WindowsRuntimeMarshal.AddEventHandler<RoutedEventHandler>(new Func<RoutedEventHandler, EventRegistrationToken>(buttonBase.add_Click), new Action<EventRegistrationToken>(buttonBase.remove_Click), new RoutedEventHandler(this.DisconnectProject));
          break;
      }
      this.currentUri = ClientTree.DisconnectProject(1984817) != 0;
    }
  }
}
