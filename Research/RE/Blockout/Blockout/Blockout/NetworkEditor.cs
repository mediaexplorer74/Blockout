// Decompiled with JetBrains decompiler
// Type: Blockout.NetworkEditor
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using System.Runtime.CompilerServices;
using Windows.Storage.Streams;

#nullable disable
namespace Blockout
{
  internal sealed class NetworkEditor
  {
    internal static void DisconnectProject(ref TaskAwaiter<IInputStream> _param0)
    {
      _param0 = new TaskAwaiter<IInputStream>();
    }
  }
}
