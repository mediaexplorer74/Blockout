// *************************************************************
// Type: Blockout.BookmarkManager
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.UI.ApplicationSettings;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

#nullable disable
namespace Blockout
{
  internal sealed class BookmarkManager
  {
    private const double parentKeywords = 300.0;
    private Popup parentKeywords;
    private Rect parentKeywords;

    internal BookmarkManager()
    {
      this.parentKeywords = Window.Current.Bounds;
      Window current = Window.Current;
      WindowsRuntimeMarshal.AddEventHandler<WindowSizeChangedEventHandler>(new Func<WindowSizeChangedEventHandler, EventRegistrationToken>(current.add_SizeChanged), new Action<EventRegistrationToken>(current.remove_SizeChanged), new WindowSizeChangedEventHandler(this.DisconnectProject));
      SettingsPane forCurrentView1 = SettingsPane.GetForCurrentView();
      // ISSUE: method pointer
      WindowsRuntimeMarshal.AddEventHandler<TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs>>(new Func<TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs>, EventRegistrationToken>(forCurrentView1.add_CommandsRequested), new Action<EventRegistrationToken>(forCurrentView1.remove_CommandsRequested), new TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs>((object) this, __methodptr(DisposeDrive)));
      SettingsPane forCurrentView2 = SettingsPane.GetForCurrentView();
      // ISSUE: method pointer
      WindowsRuntimeMarshal.AddEventHandler<TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs>>(new Func<TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs>, EventRegistrationToken>(forCurrentView2.add_CommandsRequested), new Action<EventRegistrationToken>(forCurrentView2.remove_CommandsRequested), new TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs>((object) this, __methodptr(DisconnectProject)));
    }

    private void DisconnectProject(string _param1)
    {
      // ISSUE: variable of a compiler-generated type
      BookmarkManager.MethodEditor stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = this;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncVoidMethodBuilder.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ClientTree.DisconnectProject(1983137);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<BookmarkManager.MethodEditor>(ref stateMachine);
    }

    private void DisconnectProject(
      SettingsPane _param1,
      SettingsPaneCommandsRequestedEventArgs _param2)
    {
      // ISSUE: method pointer
      _param2.Request.ApplicationCommands.Add(new SettingsCommand((object) DatabaseLoader.DisconnectProject(11682), DatabaseLoader.DisconnectProject(11709), new UICommandInvokedHandler((object) this, __methodptr(DisconnectProject))));
    }

    private void DisposeDrive(SettingsPane _param1, SettingsPaneCommandsRequestedEventArgs _param2)
    {
      // ISSUE: method pointer
      SettingsCommand settingsCommand = new SettingsCommand((object) DatabaseLoader.DisconnectProject(11738), DatabaseLoader.DisconnectProject(11761), new UICommandInvokedHandler((object) this, __methodptr(DisposeDrive)));
      _param2.Request.ApplicationCommands.Add(settingsCommand);
    }

    private void DisconnectProject(object _param1, WindowSizeChangedEventArgs _param2)
    {
      this.parentKeywords = Window.Current.Bounds;
    }

    private void DisconnectProject(object _param1, WindowActivatedEventArgs _param2)
    {
      if (_param2.WindowActivationState != ClientTree.DisconnectProject(1983141))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (BookmarkManager.DisconnectProject);
          }
          this.parentKeywords.put_IsOpen(ClientTree.DisconnectProject(1983145) != 0);
          break;
      }
    }

    private void DisconnectProject(object _param1, object _param2)
    {
      WindowsRuntimeMarshal.RemoveEventHandler<WindowActivatedEventHandler>(new Action<EventRegistrationToken>(Window.Current.remove_Activated), new WindowActivatedEventHandler(this.DisconnectProject));
    }
  }
}
