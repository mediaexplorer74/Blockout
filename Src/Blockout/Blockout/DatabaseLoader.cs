// *************************************************************
// Type: Blockout.DatabaseLoader
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System;
using System.Reflection;
using System.Text;

#nullable disable
namespace Blockout
{
    internal sealed class DatabaseLoader
    {
        internal static byte[] parentKeywords;

        static DatabaseLoader()
        {
            if (DatabaseLoader.parentKeywords != null)
                return;
            label_1:
            switch (3)
            {
                case 0:
                    goto label_1;
                default:
                    byte[] bytes = Convert.FromBase64String("QmxvY2tvdXQk");
                    string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    DatabaseLoader.parentKeywords = Stream.DisconnectProject((sbyte)0, typeof(DatabaseLoader).GetTypeInfo().Assembly.GetManifestResourceStream(name));
                    break;
            }
        }

        internal static string DisconnectProject(int _param0)
        {
            int count;
            if (((int)DatabaseLoader.parentKeywords[_param0] & 128) == 0)
            {
                count = (int)DatabaseLoader.parentKeywords[_param0];
                ++_param0;
            }
            else if (((int)DatabaseLoader.parentKeywords[_param0] & 64) == 0)
            {
            label_3:
                switch (5)
                {
                    case 0:
                        goto label_3;
                    default:
                        count = ((int)DatabaseLoader.parentKeywords[_param0] & -129) << 8 | (int)DatabaseLoader.parentKeywords[_param0 + 1];
                        _param0 += 2;
                        break;
                }
            }
            else
            {
                count = ((int)DatabaseLoader.parentKeywords[_param0] & -193) << 24 | (int)DatabaseLoader.parentKeywords[_param0 + 1] << 16 | (int)DatabaseLoader.parentKeywords[_param0 + 2] << 8 | (int)DatabaseLoader.parentKeywords[_param0 + 3];
                _param0 += 4;
            }
            if (count >= 1)
                return Encoding.Unicode.GetString(DatabaseLoader.parentKeywords, _param0, count);
            label_9:
            switch (3)
            {
                case 0:
                    goto label_9;
                default:
                    return string.Empty;
            }
        }
    }
}
