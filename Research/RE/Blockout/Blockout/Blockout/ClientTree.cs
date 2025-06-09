// Decompiled with JetBrains decompiler
// Type: Blockout.ClientTree
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using System;
using System.Reflection;
using System.Text;

#nullable disable
namespace Blockout
{
  internal sealed class ClientTree
  {
    internal static byte[] parentKeywords;

    static ClientTree()
    {
      if (ClientTree.parentKeywords != null)
        return;
      byte[] bytes = Convert.FromBase64String("QmxvY2tvdXQl");
      string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
      ClientTree.parentKeywords = Stream.DisconnectProject((sbyte) 0, typeof (ClientTree).GetTypeInfo().Assembly.GetManifestResourceStream(name));
    }

    internal static int DisconnectProject(int _param0)
    {
      return BitConverter.ToInt32(ClientTree.parentKeywords, _param0);
    }

    internal static long DisconnectProject(int _param0)
    {
      return BitConverter.ToInt64(ClientTree.parentKeywords, _param0);
    }

    internal static float DisconnectProject(int _param0)
    {
      return BitConverter.ToSingle(ClientTree.parentKeywords, _param0);
    }

    internal static double DisconnectProject(int _param0)
    {
      return BitConverter.ToDouble(ClientTree.parentKeywords, _param0);
    }

    internal static void DisconnectProject(Array _param0, int _param1)
    {
      int count;
      if (((int) ClientTree.parentKeywords[_param1] & 128) == 0)
      {
        count = (int) ClientTree.parentKeywords[_param1];
        ++_param1;
      }
      else if (((int) ClientTree.parentKeywords[_param1] & 64) == 0)
      {
label_3:
        switch (2)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ClientTree.DisconnectProject);
            }
            count = ((int) ClientTree.parentKeywords[_param1] & -129) << 8 | (int) ClientTree.parentKeywords[_param1 + 1];
            _param1 += 2;
            break;
        }
      }
      else
      {
        count = ((int) ClientTree.parentKeywords[_param1] & -193) << 24 | (int) ClientTree.parentKeywords[_param1 + 1] << 16 | (int) ClientTree.parentKeywords[_param1 + 2] << 8 | (int) ClientTree.parentKeywords[_param1 + 3];
        _param1 += 4;
      }
      if (count < 1)
      {
label_9:
        switch (7)
        {
          case 0:
            goto label_9;
        }
      }
      else
        Buffer.BlockCopy((Array) ClientTree.parentKeywords, _param1, _param0, 0, count);
    }
  }
}
