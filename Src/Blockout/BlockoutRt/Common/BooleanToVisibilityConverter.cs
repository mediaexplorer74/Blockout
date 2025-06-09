// *************************************************************
// Type: BlockoutRt.Common.BooleanToVisibilityConverter
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Blockout;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

#nullable disable
namespace BlockoutRt.Common
{
  public sealed class BooleanToVisibilityConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, string language)
    {
      int num;
      if (DockingPaneService.DisconnectProject(value) != null)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (BooleanToVisibilityConverter.Convert);
            }
            if (!(bool) value)
            {
label_5:
              switch (3)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              num = ClientTree.DisconnectProject(1984497);
              goto label_8;
            }
            break;
        }
      }
      num = ClientTree.DisconnectProject(1984493);
label_8:
      return (object) (Visibility) num;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      int num;
      if (TreeNodeSerializer.DisconnectProject(value) != null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (BooleanToVisibilityConverter.ConvertBack);
            }
            num = (Visibility) value == ClientTree.DisconnectProject(1984501) ? 1 : 0;
            break;
        }
      }
      else
        num = ClientTree.DisconnectProject(1984505);
      return (object) (bool) num;
    }
  }
}
