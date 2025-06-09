// Decompiled with JetBrains decompiler
// Type: Blockout.OptionsFactory
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using Microsoft.Xna.Framework.Input.Touch;
using System;

#nullable disable
namespace Blockout
{
  internal sealed class OptionsFactory
  {
    internal static UIntPtr DisconnectProject(TouchLocation[] _param0) => (UIntPtr) _param0.Length;
  }
}
