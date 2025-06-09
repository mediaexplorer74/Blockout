// Decompiled with JetBrains decompiler
// Type: BlockoutRt.Common.BooleanNegationConverter
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using Blockout;
using System;
using Windows.UI.Xaml.Data;

#nullable disable
namespace BlockoutRt.Common
{
  public sealed class BooleanNegationConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, string language)
    {
      return (object) (bool) (DockingPaneService.DisconnectProject(value) == null ? ClientTree.DisconnectProject(1984481) : (((bool) value ? 1 : 0) == ClientTree.DisconnectProject(1984477) ? 1 : 0));
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      int num;
      if (DockingPaneService.DisconnectProject(value) != null)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (BooleanNegationConverter.ConvertBack);
            }
            num = ((bool) value ? 1 : 0) == ClientTree.DisconnectProject(1984485) ? 1 : 0;
            break;
        }
      }
      else
        num = ClientTree.DisconnectProject(1984489);
      return (object) (bool) num;
    }
  }
}
