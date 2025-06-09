// Decompiled with JetBrains decompiler
// Type: BlockoutRt.App
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using Blockout;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace BlockoutRt
{
  public sealed class App : Application, IComponentConnector, IXamlMetadataProvider
  {
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private bool parentKeywords;
    private SymbolContext parentKeywords;

    public App()
    {
      this.InitializeComponent();
      App app = this;
      WindowsRuntimeMarshal.AddEventHandler<SuspendingEventHandler>(new Func<SuspendingEventHandler, EventRegistrationToken>(((Application) app).add_Suspending), new Action<EventRegistrationToken>(((Application) app).remove_Suspending), new SuspendingEventHandler(this.DisconnectProject));
    }

    protected virtual void OnLaunched(LaunchActivatedEventArgs args)
    {
      if (FileSet.DisconnectProject((object) Window.Current.Content) == null)
      {
        GamePage gamePage = new GamePage(args.Arguments);
        ApplicationExecutionState previousExecutionState = args.PreviousExecutionState;
        ClientTree.DisconnectProject(1984453);
        Window.Current.put_Content((UIElement) gamePage);
      }
      Window.Current.Activate();
    }

    private void DisconnectProject(object _param1, SuspendingEventArgs _param2)
    {
      _param2.SuspendingOperation.GetDeferral().Complete();
    }

    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this.parentKeywords)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (App.InitializeComponent);
            break;
        }
      }
      else
        this.parentKeywords = ClientTree.DisconnectProject(1984457) != 0;
    }

    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    [DebuggerNonUserCode]
    public void Connect(int connectionId, object target)
    {
      this.parentKeywords = ClientTree.DisconnectProject(1984461) != 0;
    }

    public IXamlType GetXamlType(Type type)
    {
      if (this.parentKeywords == null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (App.GetXamlType);
            }
            this.parentKeywords = new SymbolContext();
            break;
        }
      }
      return this.parentKeywords.DisconnectProject(type);
    }

    public IXamlType GetXamlType(string fullName)
    {
      if (this.parentKeywords == null)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (App.GetXamlType);
            }
            this.parentKeywords = new SymbolContext();
            break;
        }
      }
      return this.parentKeywords.DisconnectProject(fullName);
    }

    public XmlnsDefinition[] GetXmlnsDefinitions()
    {
      return ConfigService.DisconnectProject(ClientTree.DisconnectProject(1984465));
    }
  }
}
