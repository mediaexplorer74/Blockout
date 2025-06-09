using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Blockout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class GamePage : Page
    {
		readonly Game1 _game;

		public GamePage()
        {
            this.InitializeComponent();

			// Create the game.
			var launchArguments = string.Empty;
            _game = MonoGame.Framework.XamlGame<Game1>.Create(launchArguments, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}

/*
 // *************************************************************
// Type: BlockoutRt.GamePage
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Blockout;
using GameFoundation;
using Microsoft.Advertising.WinRT.UI;
using Microsoft.Xna.Framework;
using MonoGame.Framework;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace BlockoutRt
{
  public sealed class GamePage : SwapChainBackgroundPanel, IComponentConnector
  {
    internal static GamePage parentKeywords;
    private readonly Game1 parentKeywords;
    private BookmarkManager parentKeywords;
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private Grid parentKeywords;
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private bool parentKeywords;

    public GamePage(string launchArguments)
    {
      GamePage.parentKeywords = this;
      this.InitializeComponent();
      this.parentKeywords = XamlGame<Game1>.Create(launchArguments, Window.Current.CoreWindow, (SwapChainBackgroundPanel) this);
      this.parentKeywords = new BookmarkManager();
      Window current = Window.Current;
      WindowsRuntimeMarshal.AddEventHandler<WindowSizeChangedEventHandler>(new Func<WindowSizeChangedEventHandler, EventRegistrationToken>(current.add_SizeChanged), new Action<EventRegistrationToken>(current.remove_SizeChanged), new WindowSizeChangedEventHandler(this.DisconnectProject));
    }

    private void DisconnectProject(object _param1, WindowSizeChangedEventArgs _param2)
    {
      this.DisconnectProject();
    }

    private void DisconnectProject()
    {
      UIElement random = ((IList<UIElement>) ((Panel) this.parentKeywords).Children).GetRandom<UIElement>();
      if (random == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GamePage.DisconnectProject);
            break;
        }
      }
      else
      {
        // ISSUE: variable of a compiler-generated type
        AdControl adControl = MenuItemDesigner.DisconnectProject((object) random);
        ((FrameworkElement) adControl)?.put_Margin(this.DisconnectProject(((FrameworkElement) adControl).Width));
      }
    }

    internal AdControl DisconnectProject()
    {
      IEnumerator<UIElement> enumerator = ((IEnumerable<UIElement>) ((Panel) this.parentKeywords).Children).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          UIElement current = enumerator.Current;
          if (MenuItemDesigner.DisconnectProject((object) current) != null)
          {
            // ISSUE: variable of a compiler-generated type
            AdControl adControl = MenuItemDesigner.DisconnectProject((object) current);
            return adControl;
          }
        }
label_5:
        switch (3)
        {
          case 0:
            goto label_5;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GamePage.DisconnectProject);
              break;
            }
            break;
        }
      }
      finally
      {
        if (enumerator != null)
        {
label_9:
          switch (7)
          {
            case 0:
              goto label_9;
            default:
              enumerator.Dispose();
              break;
          }
        }
      }
      return (AdControl) null;
    }

    private Thickness DisconnectProject(double _param1)
    {
      Rectangle handyCenteredDrawPos = GameBase.Instance.GetHandyCenteredDrawPos();
      double width = Window.Current.Bounds.Width;
      double height = Window.Current.Bounds.Height;
      int num1 = GameBase.Instance.Graphics.PreferredBackBufferWidth;
      if (num1 <= ClientTree.DisconnectProject(1984725))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GamePage.DisconnectProject);
            }
            num1 = ClientTree.DisconnectProject(1984729);
            break;
        }
      }
      int num2 = (int) ((double) handyCenteredDrawPos.Left / (double) num1 * width);
      int num3 = (int) ((double) num2 * ClientTree.DisconnectProject(1984733));
      int left = Math.Max(ClientTree.DisconnectProject(1984741), (int) ((double) (num2 - num3) - _param1));
      if (width <= ClientTree.DisconnectProject(1984745))
        left = ClientTree.DisconnectProject(1984753);
      int bottom = (int) (ClientTree.DisconnectProject(1984757) * height);
      return new Thickness((double) left, ClientTree.DisconnectProject(1984765), ClientTree.DisconnectProject(1984773), (double) bottom);
    }

    internal void DisconnectProject(AdControl _param1)
    {
      ((ICollection<UIElement>) ((Panel) this.parentKeywords).Children).Clear();
      ((FrameworkElement) _param1).put_HorizontalAlignment((HorizontalAlignment) ClientTree.DisconnectProject(1984781));
      ((FrameworkElement) _param1).put_VerticalAlignment((VerticalAlignment) ClientTree.DisconnectProject(1984785));
      ((FrameworkElement) _param1).put_Margin(this.DisconnectProject(((FrameworkElement) _param1).Width));
      ((ICollection<UIElement>) ((Panel) this.parentKeywords).Children).Add((UIElement) _param1);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    public void InitializeComponent()
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GamePage.InitializeComponent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ClientTree.DisconnectProject(1984789) != 0;
        Application.LoadComponent((object) this, new Uri(DatabaseLoader.DisconnectProject(13394)), (ComponentResourceLocation) ClientTree.DisconnectProject(1984793));
        this.parentKeywords = DiskEventArgs.DisconnectProject(((FrameworkElement) this).FindName(DatabaseLoader.DisconnectProject(13443)));
      }
    }

    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    [DebuggerNonUserCode]
    public void Connect(int connectionId, object target)
    {
      this.parentKeywords = ClientTree.DisconnectProject(1984797) != 0;
    }
  }
}

 */
