// Decompiled with JetBrains decompiler
// Type: GameFoundation.PackageSet
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.IO;

#nullable disable
namespace GameFoundation
{
  internal sealed class PackageSet
  {
    internal static byte[] DisconnectProject(sbyte _param0, Stream _param1)
    {
      byte num = ~(byte) _param1.ReadByte();
      for (int index = 1; index < 3; ++index)
        _param1.ReadByte();
label_3:
      switch (3)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PackageSet.DisconnectProject);
          }
          byte[] buffer = PageQueue.DisconnectProject((int) checked ((IntPtr) unchecked (_param1.Length - _param1.Position)));
          _param1.Read(buffer, 0, (int) NetworkStack.DisconnectProject(buffer));
          if (((int) num & 32) != 0)
          {
label_7:
            switch (7)
            {
              case 0:
                goto label_7;
              default:
                for (int index = 0; index < (int) NetworkStack.DisconnectProject(buffer); ++index)
                  buffer[index] = ~buffer[index];
label_11:
                switch (1)
                {
                  case 0:
                    goto label_11;
                }
                break;
            }
          }
          return buffer;
      }
    }
  }
}
