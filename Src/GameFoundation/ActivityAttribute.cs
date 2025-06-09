// *************************************************************
// Type: GameFoundation.ActivityAttribute
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System.Runtime.CompilerServices;
using Windows.Storage;

#nullable disable
namespace GameFoundation
{
  internal sealed class ActivityAttribute
  {
    internal static void DisconnectProject(ref TaskAwaiter<StorageFolder> _param0)
    {
      _param0 = new TaskAwaiter<StorageFolder>();
    }
  }
}
