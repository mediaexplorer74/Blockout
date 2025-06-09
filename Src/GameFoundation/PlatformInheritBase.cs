// *************************************************************
// Type: GameFoundation.PlatformInheritBase
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Advertising.WinRT.UI;

#nullable disable
namespace GameFoundation
{
  public abstract class PlatformInheritBase
  {
    private static PlatformInheritBase parentKeywords;

    internal static PlatformInheritBase DisconnectProject()
    {
      if (PlatformInheritBase.parentKeywords == null)
        PlatformInheritBase.parentKeywords = GameBase.Instance.CreatePlatformInheritClass();
      return PlatformInheritBase.parentKeywords;
    }

    public abstract AdControl GetVisibleAdControl();

    public abstract void SetVisibileAdControl(AdControl controlToSet);

    public abstract void ShowSettingsFlyout();
  }
}
