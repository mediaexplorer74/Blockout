// *************************************************************
// Type: GameFoundation.PlatformHelper
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Windows.ApplicationModel;

#nullable disable
namespace GameFoundation
{
    // *************************************************************
    // Type: GameFoundation.PlatformHelper
    // Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
    // *************************************************************

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Windows.ApplicationModel;

#nullable disable
    namespace GameFoundation
    {
        public static class PlatformHelper
        {
            private static CultureInfo parentKeywordsCulture;
            private static CultureInfo currentUriCulture;
            private static Texture2D parentKeywordsTexture;

            internal static bool DisconnectProject()
            {
                return ReferenceInvoker.DisconnectProject(2037) != 0;
            }

            internal static bool DisconnectProject(string _param0)
            {
                if (string.IsNullOrEmpty(_param0))
                    return ReferenceInvoker.DisconnectProject(2033) != 0;
                PlatformHelper.DisconnectProject(ResourceSerializer.DisconnectProject(EditorService.DisconnectProject(1683), _param0));
                return ReferenceInvoker.DisconnectProject(2037) != 0;
            }

            private static void DisconnectProject2(int _param0)
            {
                PlatformHelper.DatabaseList stateMachine = new PlatformHelper.DatabaseList();
                stateMachine.parentKeywordsInt = _param0;
                stateMachine.parentKeywords = AsyncVoidMethodBuilder.Create();
                stateMachine.parentKeywordsInt = ReferenceInvoker.DisconnectProject(2041);
                //TODO
                //stateMachine.parentKeywords.Start<PlatformHelper.DatabaseList>(ref stateMachine);
            }

            //private static string DisconnectProject() => Package.Current.Id.FamilyName;

            internal static void DisconnectProject(Uri _param0)
            {
                PlatformHelper.DisconnectProject(_param0.AbsoluteUri);
            }

            //internal static long DisconnectProject() => (long)ReferenceInvoker.DisconnectProject(2045);

            internal static long DisposeDrive() => (long)ReferenceInvoker.DisconnectProject(2049);

            public static void Sleep(int ms)
            {
                new ManualResetEvent(ReferenceInvoker.DisconnectProject(2053) != 0).WaitOne(ms);
            }

            [DllImport("ole32.dll", PreserveSig = false)]
            public static extern Guid CoCreateGuid();

            internal static void ListQueue(out CultureInfo _param0, out CultureInfo _param1)
            {
                if (PlatformHelper.parentKeywordsCulture != null)
                {
                label_1:
                    switch (1)
                    {
                        case 0:
                            goto label_1;
                        default:
                            if (false)
                            {
                                //TODO
                                //PlatformHelper.ListQueue(default,default);
                            }
                            if (PlatformHelper.currentUriCulture != null)
                            {
                            label_5:
                                switch (5)
                                {
                                    case 0:
                                        goto label_5;
                                    default:
                                        _param0 = PlatformHelper.parentKeywordsCulture;
                                        _param1 = PlatformHelper.currentUriCulture;
                                        return;
                                }
                            }
                            else
                                break;
                    }
                }
                PlatformHelper.EnableNetwork(out _param0, out _param1);
            }

            internal static void EnableNetwork(out CultureInfo _param0, out CultureInfo _param1)
            {
                _param0 = CultureInfo.CurrentCulture;
                _param1 = CultureInfo.CurrentUICulture;
            }

            internal static void TestConnection()
            {
            }

            public static string GetVersionNumber()
            {
                PackageVersion version = Package.Current.Id.Version;
                object[] objArray = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2061));
                objArray[ReferenceInvoker.DisconnectProject(2065)] = (object)version.Major;
                objArray[ReferenceInvoker.DisconnectProject(2069)] = (object)EditorService.DisconnectProject(528);
                objArray[ReferenceInvoker.DisconnectProject(2073)] = (object)version.Minor;
                objArray[ReferenceInvoker.DisconnectProject(2077)] = (object)EditorService.DisconnectProject(528);
                objArray[ReferenceInvoker.DisconnectProject(2081)] = (object)version.Build;
                objArray[ReferenceInvoker.DisconnectProject(2085)] = (object)EditorService.DisconnectProject(528);
                objArray[ReferenceInvoker.DisconnectProject(2089)] = (object)version.Revision;
                return string.Concat(objArray);
            }

            public static bool HasDeviceBackButton() => ReferenceInvoker.DisconnectProject(2097) != 0;

            internal static void ExtractDockingPane(int _param0, int _param1)
            {
                if (PlatformHelper.parentKeywordsTexture == null)
                {
                label_1:
                    switch (2)
                    {
                        case 0:
                            goto label_1;
                        default:
                            if (false)
                            {
                                PlatformHelper.ExtractDockingPane(_param0, _param1);
                            }
                            PlatformHelper.parentKeywordsTexture = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(1802));
                            break;
                    }
                }
                GameBase.Instance.SpriteBatch.Draw(PlatformHelper.parentKeywordsTexture, 
                    new Rectangle(ReferenceInvoker.DisconnectProject(2101), 
                    ReferenceInvoker.DisconnectProject(2105), _param0, _param1), Color.White);
            }

            internal static void LoadDirectory()
            {
                PlatformInheritBase.DisconnectProject().ShowSettingsFlyout();
            }

            /*internal static PlatformHelper.ScreenModeTypes DisconnectProject()
            {
                int preferredBackBufferWidth = GameBase.Instance.Graphics.PreferredBackBufferWidth;
                int backBufferHeight = GameBase.Instance.Graphics.PreferredBackBufferHeight;
                if (preferredBackBufferWidth <= backBufferHeight)
                {
                label_1:
                    switch (2)
                    {
                        case 0:
                            goto label_1;
                        default:
                            if (false)
                            {
                                RuntimeMethodHandle runtimeMethodHandle = __methodref(PlatformHelper.DisconnectProject);
                            }
                            return (PlatformHelper.ScreenModeTypes)ReferenceInvoker.DisconnectProject(2109);
                    }
                }
                else
                {
                    if ((double)preferredBackBufferWidth > (double)backBufferHeight * ReferenceInvoker.DisconnectProject(2113))
                        return (PlatformHelper.ScreenModeTypes)ReferenceInvoker.DisconnectProject(2125);
                    label_6:
                    switch (1)
                    {
                        case 0:
                            goto label_6;
                        default:
                            return (PlatformHelper.ScreenModeTypes)ReferenceInvoker.DisconnectProject(2121);
                    }
                }
            }*/

            /*internal static Vector2 DisconnectProject()
            {
                PlatformHelper.ScreenModeTypes screenModeTypes = PlatformHelper.DisconnectProject();
                return screenModeTypes == (PlatformHelper.ScreenModeTypes)ReferenceInvoker.DisconnectProject(2129) || screenModeTypes == PlatformHelper.ScreenModeTypes.fullScreen ? new Vector2((float)GameBase.ScreenWidth / (float)GameBase.Instance.Graphics.PreferredBackBufferWidth, (float)GameBase.ScreenHeight / (float)GameBase.Instance.Graphics.PreferredBackBufferHeight) : Vector2.One;
            }*/

            internal static void SelectResource()
            {
            }

            public enum ScreenModeTypes
            {
                fullScreen,
                filled,
                snapped,
            }

            public class DatabaseList
            {
                public int parentKeywordsInt;
                internal AsyncVoidMethodBuilder parentKeywords;
            }
        }
    }
}
