// *************************************************************
// Type: Blockout.StoreManager
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using BlockoutRt;
using GameFoundation;
using Microsoft.Advertising.WinRT.UI;
using System;

#nullable disable
namespace Blockout
{
  internal sealed class StoreManager : PlatformInheritBase
  {
    public override AdControl GetVisibleAdControl()
    {
      GamePage parentKeywords = GamePage.parentKeywords;
      if (parentKeywords != null)
        return parentKeywords.DisconnectProject();
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (StoreManager.GetVisibleAdControl);
          }
          return (AdControl) null;
      }
    }

    public override void SetVisibileAdControl(AdControl controlToSet)
    {
      GamePage parentKeywords = GamePage.parentKeywords;
      if (parentKeywords == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (StoreManager.SetVisibileAdControl);
            break;
        }
      }
      else
        parentKeywords.DisconnectProject(controlToSet);
    }

    public override void ShowSettingsFlyout() => SettingsRt.DisconnectProject();

    internal new static PlatformInheritBase DisconnectProject()
    {
      return (PlatformInheritBase) new StoreManager();
    }
  }
}
