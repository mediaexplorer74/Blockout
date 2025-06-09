// *************************************************************
// Type: GameFoundation.StringLinewiseReadHelper
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Text;

#nullable disable
namespace GameFoundation
{
    public class StringLinewiseReadHelper
    {
        private const char parentKeywords = '\n';
        private const char currentUri = '\r';
        private string[] parentKeywords1;
        private int parentKeywords2;

        public StringLinewiseReadHelper(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            else
            {
                this.parentKeywords = StringLinewiseReadHelper.Split(text);
            }
        }

        public string ReadLine()
        {
            if (this.parentKeywords >= this.parentKeywords.Length)
            {
                return null;
            }
            else
            {
                string parentKeyword = this.parentKeywords[this.parentKeywords];
                this.parentKeywords++;
                return parentKeyword;
            }
        }

        public bool IsEndReached()
        {
            return this.parentKeywords >= this.parentKeywords.Length;
        }

        public void SetToFirstLine() => this.parentKeywords = 0;

        public static string[] Split(string toSplit)
        {
            if (toSplit == null)
            {
                throw new ArgumentNullException(nameof(toSplit));
            }
            else
            {
                string[] strArray = toSplit.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < strArray.Length; i++)
                {
                    strArray[i] = strArray[i].TrimEnd('\n', '\r');
                }
                return strArray;
            }
        }

        internal string DisconnectProject()
        {
            if (this.parentKeywords >= this.parentKeywords.Length)
            {
                return null;
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                while (this.parentKeywords < this.parentKeywords.Length)
                {
                    stringBuilder.AppendLine(this.parentKeywords[this.parentKeywords]);
                    this.parentKeywords++;
                }
                return stringBuilder.ToString();
            }
        }
    }
}
