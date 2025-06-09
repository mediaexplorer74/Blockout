// Decompiled with JetBrains decompiler
// Type: GameFoundation.GuiBase
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public abstract class GuiBase
  {
    private const int parentKeywords = 0;
    public static Rectangle Bounds = new Rectangle(ReferenceInvoker.DisconnectProject(412), ScreenManager.BoundsScreen.Height, ScreenManager.BoundsScreen.Width, ReferenceInvoker.DisconnectProject(416));
  }
}
