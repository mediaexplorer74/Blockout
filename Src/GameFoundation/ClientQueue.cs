// *************************************************************
// Type: GameFoundation.ClientQueue
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace GameFoundation
{
  internal sealed class ClientQueue
  {
    internal static void DisconnectProject(ref TaskAwaiter<Stream> _param0)
    {
      _param0 = new TaskAwaiter<Stream>();
    }
  }
}
