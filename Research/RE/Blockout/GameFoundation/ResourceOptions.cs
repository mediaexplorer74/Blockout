// Decompiled with JetBrains decompiler
// Type: GameFoundation.ResourceOptions
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System.Runtime.CompilerServices;
using Windows.Storage;

#nullable disable
namespace GameFoundation
{
  internal sealed class ResourceOptions
  {
    internal static void DisconnectProject(ref TaskAwaiter<StorageFile> _param0)
    {
      _param0 = new TaskAwaiter<StorageFile>();
    }
  }
}
