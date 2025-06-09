using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=402347&clcid=0x409

namespace Blockout
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        static string deviceFamily;
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            //API check to ensure the "RequiresPointerMode" property exists, ensuring project is running on build 14393 or later
            if (Windows.Foundation.Metadata.ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Application", "RequiresPointerMode"))
            {
                //If running on the Xbox, disable the default on screen pointer
               // if (IsXbox())
               // {
               //     Application.Current.RequiresPointerMode = ApplicationRequiresPointerMode.WhenRequested;
               // }
            }
        }

        /// <summary>
        /// Detection code in Windows 10 to identify the platform it is being run on
        /// This function returns true if the project is running on an XboxOne
        /// </summary>
        public static bool IsXbox()
        {
            if (deviceFamily == null)
                deviceFamily = Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily;

            return deviceFamily == "Windows.Xbox";
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load TouchState from previously suspended application
                }

                if (!e.PrelaunchActivated)
                {

                } 

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(typeof(GamePage), e.Arguments);
            }
            // Ensure the current window is active
            Window.Current.Activate();
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application TouchState is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application TouchState and stop any background activity
            deferral.Complete();
        }
    }
}

/*
 // *************************************************************
// Type: BlockoutRt.App
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

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

 
 */

/*
 Program.cs
// *************************************************************
// Type: BlockoutRt.Program
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System.CodeDom.Compiler;
using System.Diagnostics;
using Windows.UI.Xaml;

#nullable disable
namespace BlockoutRt
{
  public static class Program
  {
    [DebuggerNonUserCode]
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private static void DisconnectProject(string[] _param0_1)
    {
      App app;
      Application.Start((ApplicationInitializationCallback) (_param0_2 => app = new App()));
    }
  }
}

 */
