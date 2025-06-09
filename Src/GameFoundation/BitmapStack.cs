// *************************************************************
// Type: GameFoundation.BitmapStack
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

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
