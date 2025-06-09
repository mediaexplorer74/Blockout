// *************************************************************
// Type: GameFoundation.ReferenceInvoker
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Reflection;
using System.Text;

#nullable disable
namespace GameFoundation
{
    internal sealed class ReferenceInvoker
    {
        internal static byte[] parentKeywords;

        static ReferenceInvoker()
        {
            if (ReferenceInvoker.parentKeywords != null)
                return;
            byte[] bytes = Convert.FromBase64String("R2FtZUZvdW5kYXRpb24l");
            string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            ReferenceInvoker.parentKeywords = PackageSet.DisconnectProject((sbyte)0, typeof(ReferenceInvoker).GetTypeInfo().Assembly.GetManifestResourceStream(name));
        }

        internal static int DisconnectProject(int _param0)
        {
            return BitConverter.ToInt32(ReferenceInvoker.parentKeywords, _param0);
        }

        internal static long DisconnectProject(long _param0)
        {
            return BitConverter.ToInt64(ReferenceInvoker.parentKeywords, (int)_param0);
        }

        internal static float DisconnectProject(float _param0)
        {
            return BitConverter.ToSingle(ReferenceInvoker.parentKeywords, (int)_param0);
        }

        internal static double DisconnectProject(double _param0)
        {
            return BitConverter.ToDouble(ReferenceInvoker.parentKeywords, (int)_param0);
        }

        internal static void DisconnectProject(Array _param0, int _param1)
        {
            int count;
            if (((int)ReferenceInvoker.parentKeywords[_param1] & 128) == 0)
            {
                count = (int)ReferenceInvoker.parentKeywords[_param1];
                ++_param1;
            }
            else if (((int)ReferenceInvoker.parentKeywords[_param1] & 64) == 0)
            {
                count = ((int)ReferenceInvoker.parentKeywords[_param1] & -129) << 8 | (int)ReferenceInvoker.parentKeywords[_param1 + 1];
                _param1 += 2;
            }
            else
            {
                count = ((int)ReferenceInvoker.parentKeywords[_param1] & -193) << 24 | (int)ReferenceInvoker.parentKeywords[_param1 + 1] << 16 | (int)ReferenceInvoker.parentKeywords[_param1 + 2] << 8 | (int)ReferenceInvoker.parentKeywords[_param1 + 3];
                _param1 += 4;
            }
            if (count < 1)
            {
                return;
            }
            else
                Buffer.BlockCopy((Array)ReferenceInvoker.parentKeywords, _param1, _param0, 0, count);
        }
    }
}
