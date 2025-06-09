// Decompiled with JetBrains decompiler
// Type: GameFoundation.EditorService
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Reflection;
using System.Text;

#nullable disable
namespace GameFoundation
{
  internal sealed class EditorService
  {
    internal static byte[] parentKeywords;

    static EditorService()
    {
      if (EditorService.parentKeywords != null)
        return;
      byte[] bytes = Convert.FromBase64String("R2FtZUZvdW5kYXRpb24k");
      string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
      EditorService.parentKeywords = PackageSet.DisconnectProject((sbyte) 0, typeof (EditorService).GetTypeInfo().Assembly.GetManifestResourceStream(name));
    }

    internal static string DisconnectProject(int _param0)
    {
      int count;
      if (((int) EditorService.parentKeywords[_param0] & 128) == 0)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (EditorService.DisconnectProject);
            }
            count = (int) EditorService.parentKeywords[_param0];
            ++_param0;
            break;
        }
      }
      else if (((int) EditorService.parentKeywords[_param0] & 64) == 0)
      {
label_6:
        switch (3)
        {
          case 0:
            goto label_6;
          default:
            count = ((int) EditorService.parentKeywords[_param0] & -129) << 8 | (int) EditorService.parentKeywords[_param0 + 1];
            _param0 += 2;
            break;
        }
      }
      else
      {
        count = ((int) EditorService.parentKeywords[_param0] & -193) << 24 | (int) EditorService.parentKeywords[_param0 + 1] << 16 | (int) EditorService.parentKeywords[_param0 + 2] << 8 | (int) EditorService.parentKeywords[_param0 + 3];
        _param0 += 4;
      }
      return count < 1 ? string.Empty : Encoding.Unicode.GetString(EditorService.parentKeywords, _param0, count);
    }
  }
}
