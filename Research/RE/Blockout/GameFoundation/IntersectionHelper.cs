// Decompiled with JetBrains decompiler
// Type: GameFoundation.IntersectionHelper
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace GameFoundation
{
  public static class IntersectionHelper
  {
    public static bool IntersectPixels(
      Rectangle rectangleA,
      Color[] dataA,
      Rectangle rectangleB,
      Color[] dataB)
    {
      int num1 = Math.Max(rectangleA.Top, rectangleB.Top);
      int num2 = Math.Min(rectangleA.Bottom, rectangleB.Bottom);
      int num3 = Math.Max(rectangleA.Left, rectangleB.Left);
      int num4 = Math.Min(rectangleA.Right, rectangleB.Right);
      for (int index1 = num1; index1 < num2; index1 += ReferenceInvoker.DisconnectProject(428))
      {
        for (int index2 = num3; index2 < num4; index2 += ReferenceInvoker.DisconnectProject(424))
        {
          Color color1 = dataA[index2 - rectangleA.Left + (index1 - rectangleA.Top) * rectangleA.Width];
          Color color2 = dataB[index2 - rectangleB.Left + (index1 - rectangleB.Top) * rectangleB.Width];
          if (color1.A != (byte) 0 && color2.A != (byte) 0)
          {
label_3:
            switch (4)
            {
              case 0:
                goto label_3;
              default:
                if (false)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (IntersectionHelper.IntersectPixels);
                }
                return ReferenceInvoker.DisconnectProject(420) != 0;
            }
          }
        }
      }
      return ReferenceInvoker.DisconnectProject(432) != 0;
    }

    public static bool IntersectPixels(Rectangle rectangleA, Color[] dataA, Rectangle rectangleB)
    {
      int num1 = Math.Max(rectangleA.Top, rectangleB.Top);
      int num2 = Math.Min(rectangleA.Bottom, rectangleB.Bottom);
      int num3 = Math.Max(rectangleA.Left, rectangleB.Left);
      int num4 = Math.Min(rectangleA.Right, rectangleB.Right);
      for (int index1 = num1; index1 < num2; index1 += ReferenceInvoker.DisconnectProject(444))
      {
        for (int index2 = num3; index2 < num4; index2 += ReferenceInvoker.DisconnectProject(440))
        {
          if (dataA[index2 - rectangleA.Left + (index1 - rectangleA.Top) * rectangleA.Width].A != (byte) 0)
          {
label_3:
            switch (4)
            {
              case 0:
                goto label_3;
              default:
                if (false)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (IntersectionHelper.IntersectPixels);
                }
                return ReferenceInvoker.DisconnectProject(436) != 0;
            }
          }
        }
label_9:
        switch (7)
        {
          case 0:
            goto label_9;
          default:
            continue;
        }
      }
label_12:
      switch (6)
      {
        case 0:
          goto label_12;
        default:
          return ReferenceInvoker.DisconnectProject(448) != 0;
      }
    }

    public static bool InsideArea(Rectangle area, Vector2 toBeInside)
    {
      if ((double) toBeInside.X >= (double) area.X)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (IntersectionHelper.InsideArea);
            }
            if ((double) toBeInside.X > (double) area.X2())
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              if ((double) toBeInside.Y >= (double) area.Y)
              {
                if ((double) toBeInside.Y <= (double) area.Y2())
                  return ReferenceInvoker.DisconnectProject(460) != 0;
label_9:
                switch (6)
                {
                  case 0:
                    goto label_9;
                }
              }
              return ReferenceInvoker.DisconnectProject(456) != 0;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(452) != 0;
    }
  }
}
