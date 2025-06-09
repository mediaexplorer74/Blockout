// Decompiled with JetBrains decompiler
// Type: GameFoundation.RectangleExtension
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace GameFoundation
{
  public static class RectangleExtension
  {
    public static int X2(this Rectangle rect) => rect.X + rect.Width;

    public static int Y2(this Rectangle rect) => rect.Y + rect.Height;

    public static int XCenterRelative(this Rectangle rect)
    {
      return rect.Width / ReferenceInvoker.DisconnectProject(468);
    }

    public static int YCenterRelative(this Rectangle rect)
    {
      return rect.Height / ReferenceInvoker.DisconnectProject(472);
    }

    public static int XCenterAbsolute(this Rectangle rect)
    {
      return rect.X + rect.Width / ReferenceInvoker.DisconnectProject(476);
    }

    public static int YCenterAbsolute(this Rectangle rect)
    {
      return rect.Y + rect.Height / ReferenceInvoker.DisconnectProject(480);
    }

    public static Vector2 FitSubPoint(this Rectangle rect, Vector2 toFit)
    {
      Math.Max((float) rect.X, toFit.X);
      float x = Math.Min((float) rect.X2(), toFit.X);
      Math.Max((float) rect.Y, toFit.Y);
      float y = Math.Min((float) rect.Y2(), toFit.Y);
      return new Vector2(x, y);
    }

    public static Rectangle FitSubRecangle(this Rectangle rect, int margin)
    {
      return new Rectangle(rect.X + margin, rect.Y + margin, rect.Width - margin, rect.Height - margin);
    }

    public static Rectangle FitSubRecangle(
      this Rectangle rect,
      int margin,
      int toFitWidth,
      int toFitHeight)
    {
      int num1 = rect.Width - ReferenceInvoker.DisconnectProject(484) * margin;
      int num2 = rect.Height - ReferenceInvoker.DisconnectProject(488) * margin;
      if (toFitWidth > ReferenceInvoker.DisconnectProject(492))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (RectangleExtension.FitSubRecangle);
            }
            if (toFitHeight > ReferenceInvoker.DisconnectProject(496))
            {
label_5:
              switch (2)
              {
                case 0:
                  goto label_5;
                default:
                  if (num1 > ReferenceInvoker.DisconnectProject(500) && num2 > ReferenceInvoker.DisconnectProject(504))
                  {
                    int num3 = rect.Width - toFitWidth;
                    int num4 = rect.Height - toFitHeight;
                    int x = rect.X + margin;
                    int y = rect.Y + margin;
                    double num5;
                    if (num3 >= num4)
                    {
label_9:
                      switch (6)
                      {
                        case 0:
                          goto label_9;
                        default:
                          num5 = ReferenceInvoker.DisconnectProject(524) / ((double) num1 / (double) toFitWidth);
                          y += (int) ((double) num2 / ReferenceInvoker.DisconnectProject(532) - (double) toFitHeight * num5 / ReferenceInvoker.DisconnectProject(540));
                          break;
                      }
                    }
                    else
                    {
                      num5 = ReferenceInvoker.DisconnectProject(548) / ((double) num2 / (double) toFitHeight);
                      x += (int) ((double) num1 / ReferenceInvoker.DisconnectProject(556) - (double) toFitWidth * num5 / ReferenceInvoker.DisconnectProject(564));
                    }
                    return new Rectangle(x, y, (int) ((double) toFitWidth * num5), (int) ((double) toFitHeight * num5));
                  }
                  break;
              }
            }
            else
              break;
            break;
        }
      }
      return new Rectangle(ReferenceInvoker.DisconnectProject(508), ReferenceInvoker.DisconnectProject(512), ReferenceInvoker.DisconnectProject(516), ReferenceInvoker.DisconnectProject(520));
    }
  }
}
