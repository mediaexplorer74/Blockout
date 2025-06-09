// *************************************************************
// Type: GameFoundation.ConfigStream
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;

#nullable disable
namespace GameFoundation
{
  internal sealed class ConfigStream
  {
    public string parentKeywords;
    public int parentKeywords;
    public int currentUri;

    internal ConfigStream()
    {
    }

    internal ConfigStream(string _param1, int _param2, int _param3)
    {
      this.parentKeywords = _param1;
      this.parentKeywords = _param2;
      this.currentUri = _param3;
    }

    internal string DisconnectProject()
    {
      object[] objArray = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(1133));
      objArray[ReferenceInvoker.DisconnectProject(1137)] = (object) this.parentKeywords;
      objArray[ReferenceInvoker.DisconnectProject(1141)] = (object) EditorService.DisconnectProject(610);
      objArray[ReferenceInvoker.DisconnectProject(1145)] = (object) this.parentKeywords;
      objArray[ReferenceInvoker.DisconnectProject(1149)] = (object) EditorService.DisconnectProject(610);
      objArray[ReferenceInvoker.DisconnectProject(1153)] = (object) this.currentUri;
      return string.Concat(objArray);
    }

    internal bool DisconnectProject(string _param1)
    {
      if (string.IsNullOrEmpty(_param1))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ConfigStream.DisconnectProject);
            }
            return ReferenceInvoker.DisconnectProject(1157) != 0;
        }
      }
      else
      {
        string str = _param1;
        char[] chArray1 = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(1161));
        chArray1[ReferenceInvoker.DisconnectProject(1165)] = (char) ReferenceInvoker.DisconnectProject(1169);
        char[] chArray2 = chArray1;
        string[] strArray = str.Split(chArray2);
        if (strArray != null)
        {
          if ((int) IconEventArgs.DisconnectProject(strArray) != ReferenceInvoker.DisconnectProject(1173))
          {
label_7:
            switch (2)
            {
              case 0:
                goto label_7;
            }
          }
          else
          {
            this.parentKeywords = strArray[ReferenceInvoker.DisconnectProject(1181)];
            bool flag1 = int.TryParse(strArray[ReferenceInvoker.DisconnectProject(1185)], out this.parentKeywords);
            bool flag2 = int.TryParse(strArray[ReferenceInvoker.DisconnectProject(1189)], out this.currentUri);
            return !flag1 || !flag2 ? ReferenceInvoker.DisconnectProject(1193) != 0 : ReferenceInvoker.DisconnectProject(1197) != 0;
          }
        }
        return ReferenceInvoker.DisconnectProject(1177) != 0;
      }
    }
  }
}
