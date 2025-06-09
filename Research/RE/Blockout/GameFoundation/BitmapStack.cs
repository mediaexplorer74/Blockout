// Decompiled with JetBrains decompiler
// Type: GameFoundation.BitmapStack
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework.Input;

#nullable disable
namespace GameFoundation
{
  internal sealed class BitmapStack
  {
    internal static void DisconnectProject(ref GamePadState _param0)
    {
      _param0 = new GamePadState();
    }
  }
}
