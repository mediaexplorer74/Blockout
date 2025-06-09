// *************************************************************
// Type: Blockout.Stream
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System;

#nullable disable
namespace Blockout
{
  internal sealed class Stream
  {
    internal static byte[] DisconnectProject(sbyte _param0, System.IO.Stream _param1)
    {
      byte num = ~(byte) _param1.ReadByte();
      for (int index = 1; index < 3; ++index)
        _param1.ReadByte();
label_3:
      switch (5)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Stream.DisconnectProject);
          }
          byte[] buffer = StoreTable.DisconnectProject((int) checked ((IntPtr) unchecked (_param1.Length - _param1.Position)));
          _param1.Read(buffer, 0, (int) BuilderDictionary.DisconnectProject(buffer));
          if (((int) num & 32) != 0)
          {
            for (int index = 0; index < (int) BuilderDictionary.DisconnectProject(buffer); ++index)
              buffer[index] = ~buffer[index];
label_10:
            switch (4)
            {
              case 0:
                goto label_10;
            }
          }
          return buffer;
      }
    }
  }
}
