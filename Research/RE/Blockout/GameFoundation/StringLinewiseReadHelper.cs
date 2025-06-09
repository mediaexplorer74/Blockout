// Decompiled with JetBrains decompiler
// Type: GameFoundation.StringLinewiseReadHelper
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public class StringLinewiseReadHelper
  {
    private const char parentKeywords = '\n';
    private const char currentUri = '\r';
    private string[] parentKeywords;
    private int parentKeywords;

    public StringLinewiseReadHelper(string text)
    {
      if (text == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (StringLinewiseReadHelper.\u002Ector);
            }
            throw new ArgumentNullException();
        }
      }
      else
        this.parentKeywords = StringLinewiseReadHelper.Split(text);
    }

    public string ReadLine()
    {
      if (this.parentKeywords >= (int) IconEventArgs.DisconnectProject(this.parentKeywords))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (StringLinewiseReadHelper.ReadLine);
            }
            return (string) null;
        }
      }
      else
      {
        string parentKeyword = this.parentKeywords[this.parentKeywords];
        this.parentKeywords += ReferenceInvoker.DisconnectProject(741);
        return parentKeyword;
      }
    }

    public bool IsEndReached()
    {
      return (this.parentKeywords < (int) IconEventArgs.DisconnectProject(this.parentKeywords) ? 1 : 0) == ReferenceInvoker.DisconnectProject(745);
    }

    public void SetToFirstLine() => this.parentKeywords = ReferenceInvoker.DisconnectProject(749);

    public static string[] Split(string toSplit)
    {
      if (toSplit == null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (StringLinewiseReadHelper.Split);
            }
            return (string[]) null;
        }
      }
      else
      {
        string str1 = toSplit;
        char[] chArray1 = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(753));
        chArray1[ReferenceInvoker.DisconnectProject(757)] = (char) ReferenceInvoker.DisconnectProject(761);
        char[] chArray2 = chArray1;
        string[] strArray1 = str1.Split(chArray2);
        for (int index1 = ReferenceInvoker.DisconnectProject(765); index1 < (int) IconEventArgs.DisconnectProject(strArray1); index1 += ReferenceInvoker.DisconnectProject(789))
        {
          string[] strArray2 = strArray1;
          int index2 = index1;
          string str2 = strArray1[index1];
          char[] chArray3 = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(769));
          chArray3[ReferenceInvoker.DisconnectProject(773)] = (char) ReferenceInvoker.DisconnectProject(777);
          chArray3[ReferenceInvoker.DisconnectProject(781)] = (char) ReferenceInvoker.DisconnectProject(785);
          char[] chArray4 = chArray3;
          string str3 = str2.TrimEnd(chArray4);
          strArray2[index2] = str3;
        }
label_8:
        switch (2)
        {
          case 0:
            goto label_8;
          default:
            return strArray1;
        }
      }
    }

    internal string DisconnectProject()
    {
      if (this.parentKeywords >= (int) IconEventArgs.DisconnectProject(this.parentKeywords))
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (StringLinewiseReadHelper.DisconnectProject);
            }
            return (string) null;
        }
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        for (; this.parentKeywords < (int) IconEventArgs.DisconnectProject(this.parentKeywords); this.parentKeywords += ReferenceInvoker.DisconnectProject(793))
          stringBuilder.AppendLine(this.parentKeywords[this.parentKeywords]);
        return stringBuilder.ToString();
      }
    }
  }
}
