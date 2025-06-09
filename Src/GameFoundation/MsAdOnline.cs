// *************************************************************
// Type: GameFoundation.MsAdOnline
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public static class MsAdOnline
  {
    private const string parentKeywords = "adsuseable.txt";
    private const string currentUri = "adstoplist.txt";
    internal const string filterID = "msad";
    private const string parentCancel = "usablead";
    private const int parentKeywordsInt = 0;
    private const int currentUriInt = 10;
    private const string namesIDString = "ver1";
    private static int filterIDInt;
    private static int parentCancelInt;
    private static ConfigStream[] parentKeywordsConfigStream;
    private static ConfigStream[] currentUriConfigStream;
    private static bool parentKeywordsBool;
    private static bool currentUriBool;
    private static int namesIDInt;
    private static int currentNodeInt;
    private static string currentNodeString;

    internal static int DisconnectProject()
    {
      MsAdOnline.DisconnectProject();
      return Math.Max((byte)ReferenceInvoker.DisconnectProject(1201), MsAdOnline.filterIDInt);
    }

    internal static int DisposeDrive()
    {
      MsAdOnline.DisconnectProject();
      int num = DiskType.DisconnectProject((int)0) ? MsAdOnline.currentNodeInt : MsAdOnline.namesIDInt;
      if (num <= ReferenceInvoker.DisconnectProject(1205))
        num = (int) TimeSpan.FromMilliseconds((double) DiskType.DisconnectProject(true)).TotalSeconds;
      return num;
    }

    /*internal static string DisconnectProject()
    {
      MsAdOnline.DisconnectProject();
      string str = MsAdOnline.currentNode;
      bool flag = ReferenceInvoker.DisconnectProject(1209) != 0;
      if (!string.IsNullOrEmpty(str))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            }
            if (!flag)
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  if (str.Length < ReferenceInvoker.DisconnectProject(1213))
                  {
label_7:
                    switch (1)
                    {
                      case 0:
                        goto label_7;
                    }
                  }
                  else
                    goto label_9;
                  break;
              }
            }
            else
              break;
        }
      }
      str = DiskType.DisconnectProject(flag);
label_9:
      return str;
    }

    private static bool DisconnectProject()
    {
      MsAdOnline.DisconnectProject();
      double num = RandomManager.Rnd.NextDouble() * ReferenceInvoker.DisconnectProject(1217);
      if (MsAdOnline.parentCancel <= ReferenceInvoker.DisconnectProject(1225))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            }
            MsAdOnline.currentUri = (num < ReferenceInvoker.DisconnectProject(1229) ? 1 : 0) == ReferenceInvoker.DisconnectProject(1237);
            break;
        }
      }
      else
        MsAdOnline.currentUri = (num < (double) (ReferenceInvoker.DisconnectProject(1241) - MsAdOnline.parentCancel) ? 1 : 0) == ReferenceInvoker.DisconnectProject(1245);
      return MsAdOnline.currentUri;
    }

    internal static ConfigStream[] DisconnectProject(bool _param0, bool _param1)
    {
      if (_param0)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            }
            return DiskType.DisconnectProject(ReferenceInvoker.DisconnectProject(1249));
        }
      }
      else
      {
        MsAdOnline.DisconnectProject();
        bool flag = MsAdOnline.currentUri;
        if (_param1)
        {
label_6:
          switch (3)
          {
            case 0:
              goto label_6;
            default:
              flag = MsAdOnline.DisconnectProject();
              break;
          }
        }
        int num = ReferenceInvoker.DisconnectProject(1253);
        ConfigStream[] configStreamArray;
        if (flag)
        {
label_9:
          switch (1)
          {
            case 0:
              goto label_9;
            default:
              ConfigStream[] parentKeywords = MsAdOnline.parentKeywords;
              if (parentKeywords == null)
              {
label_11:
                switch (3)
                {
                  case 0:
                    goto label_11;
                  default:
                    configStreamArray = DiskType.DisposeDrive(num);
                    break;
                }
              }
              else
              {
                configStreamArray = DiskType.DisposeDrive(parentKeywords, num);
                break;
              }
              break;
          }
        }
        else
        {
          ConfigStream[] currentUri = MsAdOnline.currentUri;
          if (currentUri == null)
          {
label_15:
            switch (4)
            {
              case 0:
                goto label_15;
              default:
                configStreamArray = DiskType.ListQueue(num);
                break;
            }
          }
          else
            configStreamArray = DiskType.ListQueue(currentUri, num);
        }
        return configStreamArray;
      }
    }

    private static void DisconnectProject()
    {
      if (MsAdOnline.parentKeywords)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            break;
        }
      }
      else
      {
        MsAdOnline.DisconnectProject(out MsAdOnline.currentUri);
        MsAdOnline.DisconnectProject(out MsAdOnline.filterID, out MsAdOnline.parentCancel, out MsAdOnline.namesID, out MsAdOnline.currentNode, out MsAdOnline.currentNode, out MsAdOnline.parentKeywords);
        MsAdOnline.parentKeywords = ReferenceInvoker.DisconnectProject(1257) != 0;
      }
    }

    private static void DisconnectProject(
      int _param0,
      int _param1,
      int _param2,
      int _param3,
      string _param4,
      List<ConfigStream> _param5)
    {
      if (_param5 == null)
        return;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(EditorService.DisconnectProject(613));
      stringBuilder.AppendLine(_param0.ToString());
      stringBuilder.AppendLine(_param1.ToString());
      stringBuilder.AppendLine(_param2.ToString());
      stringBuilder.AppendLine(_param3.ToString());
      stringBuilder.AppendLine(_param4);
      stringBuilder.AppendLine(_param5.Count.ToString());
      for (int index = ReferenceInvoker.DisconnectProject(1261); index < _param5.Count; index += ReferenceInvoker.DisconnectProject(1265))
        stringBuilder.AppendLine(_param5[index].DisconnectProject());
label_4:
      switch (2)
      {
        case 0:
          goto label_4;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
          }
          PlatformLocalStorage.SaveTextToFile(EditorService.DisconnectProject(622), stringBuilder.ToString());
          break;
      }
    }

    private static void DisconnectProject(
      out int _param0,
      out int _param1,
      out int _param2,
      out int _param3,
      out string _param4,
      out ConfigStream[] _param5)
    {
      _param0 = ReferenceInvoker.DisconnectProject(1269);
      _param1 = ReferenceInvoker.DisconnectProject(1273);
      _param2 = ReferenceInvoker.DisconnectProject(1277);
      _param3 = ReferenceInvoker.DisconnectProject(1281);
      _param4 = nameof ();
      _param5 = (ConfigStream[]) null;
      if (!PlatformLocalStorage.FileExists(EditorService.DisconnectProject(622)))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            break;
        }
      }
      else
      {
        string text = PlatformLocalStorage.LoadTextFromFile(EditorService.DisconnectProject(622));
        if (string.IsNullOrEmpty(text))
          return;
        StringLinewiseReadHelper linewiseReadHelper = new StringLinewiseReadHelper(text);
        if (linewiseReadHelper.IsEndReached())
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
          }
        }
        else if (PcitureService.DisconnectProject(linewiseReadHelper.ReadLine(), EditorService.DisconnectProject(613)))
        {
label_11:
          switch (7)
          {
            case 0:
              goto label_11;
          }
        }
        else if (linewiseReadHelper.IsEndReached())
        {
label_14:
          switch (4)
          {
            case 0:
              goto label_14;
          }
        }
        else
        {
          if (!int.TryParse(linewiseReadHelper.ReadLine(), out _param0))
            return;
          if (linewiseReadHelper.IsEndReached())
          {
label_18:
            switch (6)
            {
              case 0:
                goto label_18;
            }
          }
          else
          {
            if (!int.TryParse(linewiseReadHelper.ReadLine(), out _param1))
              return;
label_21:
            switch (5)
            {
              case 0:
                goto label_21;
              default:
                if (linewiseReadHelper.IsEndReached())
                {
label_23:
                  switch (1)
                  {
                    case 0:
                      goto label_23;
                    default:
                      return;
                  }
                }
                else
                {
                  if (!int.TryParse(linewiseReadHelper.ReadLine(), out _param2))
                    break;
label_26:
                  switch (2)
                  {
                    case 0:
                      goto label_26;
                    default:
                      if (linewiseReadHelper.IsEndReached())
                      {
label_28:
                        switch (1)
                        {
                          case 0:
                            goto label_28;
                          default:
                            return;
                        }
                      }
                      else
                      {
                        if (!int.TryParse(linewiseReadHelper.ReadLine(), out _param3))
                          return;
                        if (linewiseReadHelper.IsEndReached())
                        {
label_32:
                          switch (6)
                          {
                            case 0:
                              goto label_32;
                            default:
                              return;
                          }
                        }
                        else
                        {
                          _param4 = linewiseReadHelper.ReadLine();
                          if (string.IsNullOrEmpty(_param4))
                          {
label_35:
                            switch (5)
                            {
                              case 0:
                                goto label_35;
                              default:
                                return;
                            }
                          }
                          else
                          {
                            MsAdOnline.DisconnectProject(linewiseReadHelper, out _param5);
                            return;
                          }
                        }
                      }
                  }
                }
            }
          }
        }
      }
    }

    private static void DisconnectProject(List<ConfigStream> _param0)
    {
      if (_param0 == null)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            break;
        }
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(_param0.Count.ToString());
        for (int index = ReferenceInvoker.DisconnectProject(1285); index < _param0.Count; index += ReferenceInvoker.DisconnectProject(1289))
          stringBuilder.AppendLine(_param0[index].DisconnectProject());
label_7:
        switch (4)
        {
          case 0:
            goto label_7;
          default:
            PlatformLocalStorage.SaveTextToFile(EditorService.DisconnectProject(651), stringBuilder.ToString());
            break;
        }
      }
    }

    private static void DisconnectProject(out ConfigStream[] _param0)
    {
      _param0 = (ConfigStream[]) null;
      if (!PlatformLocalStorage.FileExists(EditorService.DisconnectProject(651)))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            break;
        }
      }
      else
      {
        string text = PlatformLocalStorage.LoadTextFromFile(EditorService.DisconnectProject(651));
        if (string.IsNullOrEmpty(text))
          return;
        MsAdOnline.DisconnectProject(new StringLinewiseReadHelper(text), out _param0);
      }
    }

    private static void DisconnectProject(
      StringLinewiseReadHelper _param0,
      out ConfigStream[] _param1)
    {
      _param1 = (ConfigStream[]) null;
      int result;
      if (!int.TryParse(_param0.ReadLine(), out result) || result <= ReferenceInvoker.DisconnectProject(1293))
        return;
      ConfigStream[] configStreamArray = NetworkToken.DisconnectProject(result);
      for (int index = ReferenceInvoker.DisconnectProject(1297); index < (int) OptionsSet.DisconnectProject(configStreamArray); index += ReferenceInvoker.DisconnectProject(1301))
      {
        if (_param0.IsEndReached())
          return;
        ConfigStream configStream = new ConfigStream();
        if (!configStream.DisconnectProject(_param0.ReadLine()))
        {
label_6:
          switch (4)
          {
            case 0:
              goto label_6;
            default:
              if (true)
                return;
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
              return;
          }
        }
        else
          configStreamArray[index] = configStream;
      }
label_11:
      switch (6)
      {
        case 0:
          goto label_11;
        default:
          _param1 = configStreamArray;
          break;
      }
    }

    internal static void DisconnectProject(string _param0)
    {
      if (string.IsNullOrEmpty(_param0))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisconnectProject);
            break;
        }
      }
      else
      {
        string str1 = _param0;
        char[] chArray1 = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(1305));
        chArray1[ReferenceInvoker.DisconnectProject(1309)] = (char) ReferenceInvoker.DisconnectProject(1313);
        char[] chArray2 = chArray1;
        string[] strArray = str1.Split(chArray2);
        if (strArray == null)
          return;
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
          default:
            if ((int) IconEventArgs.DisconnectProject(strArray) <= ReferenceInvoker.DisconnectProject(1317))
            {
label_8:
              switch (7)
              {
                case 0:
                  goto label_8;
                default:
                  return;
              }
            }
            else
            {
              List<ConfigStream> configStreamList1 = new List<ConfigStream>();
              List<ConfigStream> configStreamList2 = new List<ConfigStream>();
              bool flag = ReferenceInvoker.DisconnectProject(1321) != 0;
              int num1 = ReferenceInvoker.DisconnectProject(1325);
              int num2 = ReferenceInvoker.DisconnectProject(1329);
              int num3 = ReferenceInvoker.DisconnectProject(1333);
              int num4 = ReferenceInvoker.DisconnectProject(1337);
              string str2 = nameof ();
              for (int index = ReferenceInvoker.DisconnectProject(1341); index < (int) IconEventArgs.DisconnectProject(strArray); index += ReferenceInvoker.DisconnectProject(1393))
              {
                if (index + ReferenceInvoker.DisconnectProject(1345) < (int) IconEventArgs.DisconnectProject(strArray))
                {
label_11:
                  switch (2)
                  {
                    case 0:
                      goto label_11;
                    default:
                      string str3 = strArray[index];
                      string s1 = strArray[index + ReferenceInvoker.DisconnectProject(1349)];
                      string s2 = strArray[index + ReferenceInvoker.DisconnectProject(1353)];
                      if (flag)
                      {
label_13:
                        switch (4)
                        {
                          case 0:
                            goto label_13;
                          default:
                            if (RegistryScope.DisconnectProject(str3, EditorService.DisconnectProject(680)))
                            {
                              int result1;
                              if (int.TryParse(s1, out result1))
                              {
label_16:
                                switch (3)
                                {
                                  case 0:
                                    goto label_16;
                                  default:
                                    num1 = result1;
                                    break;
                                }
                              }
                              int result2;
                              if (int.TryParse(s2, out result2))
                              {
label_19:
                                switch (7)
                                {
                                  case 0:
                                    goto label_19;
                                  default:
                                    num2 = result2;
                                    break;
                                }
                              }
                              if (index + ReferenceInvoker.DisconnectProject(1357) - ReferenceInvoker.DisconnectProject(1361) < (int) IconEventArgs.DisconnectProject(strArray))
                              {
label_22:
                                switch (1)
                                {
                                  case 0:
                                    goto label_22;
                                  default:
                                    string s3 = strArray[index + ReferenceInvoker.DisconnectProject(1365)];
                                    string s4 = strArray[index + ReferenceInvoker.DisconnectProject(1369)];
                                    string str4 = strArray[index + ReferenceInvoker.DisconnectProject(1373)];
                                    int result3;
                                    if (int.TryParse(s3, out result3))
                                    {
label_24:
                                      switch (6)
                                      {
                                        case 0:
                                          goto label_24;
                                        default:
                                          if (result3 > ReferenceInvoker.DisconnectProject(1377))
                                          {
label_26:
                                            switch (1)
                                            {
                                              case 0:
                                                goto label_26;
                                              default:
                                                num3 = result3;
                                                break;
                                            }
                                          }
                                          else
                                            break;
                                          break;
                                      }
                                    }
                                    int result4;
                                    if (int.TryParse(s4, out result4))
                                    {
label_29:
                                      switch (4)
                                      {
                                        case 0:
                                          goto label_29;
                                        default:
                                          if (result4 > ReferenceInvoker.DisconnectProject(1381))
                                          {
label_31:
                                            switch (1)
                                            {
                                              case 0:
                                                goto label_31;
                                              default:
                                                num4 = result4;
                                                break;
                                            }
                                          }
                                          else
                                            break;
                                          break;
                                      }
                                    }
                                    string str5 = str4;
                                    if (!string.IsNullOrEmpty(str5))
                                      str2 = str5;
                                    index += ReferenceInvoker.DisconnectProject(1385);
                                    flag = ReferenceInvoker.DisconnectProject(1389) != 0;
                                    continue;
                                }
                              }
                              else
                                continue;
                            }
                            else
                              break;
                        }
                      }
                      int result5;
                      int result6;
                      if (!string.IsNullOrEmpty(str3) && int.TryParse(s1, out result5) && int.TryParse(s2, out result6))
                      {
label_37:
                        switch (4)
                        {
                          case 0:
                            goto label_37;
                          default:
                            ConfigStream configStream = new ConfigStream(str3, result5, result6);
                            if (flag)
                            {
                              configStreamList1.Add(configStream);
                              continue;
                            }
                            configStreamList2.Add(configStream);
                            continue;
                        }
                      }
                      else
                        continue;
                  }
                }
              }
label_43:
              switch (1)
              {
                case 0:
                  goto label_43;
                default:
                  MsAdOnline.DisconnectProject(configStreamList1);
                  if (num1 > ReferenceInvoker.DisconnectProject(1397))
                  {
label_45:
                    switch (7)
                    {
                      case 0:
                        goto label_45;
                      default:
                        if (configStreamList2.Count > ReferenceInvoker.DisconnectProject(1401))
                        {
label_47:
                          switch (7)
                          {
                            case 0:
                              goto label_47;
                            default:
                              MsAdOnline.DisconnectProject(num1, num2, num3, num4, str2, configStreamList2);
                              MsAdOnline.parentKeywords = configStreamList2.ToArray();
                              MsAdOnline.filterID = num1;
                              MsAdOnline.parentCancel = num2;
                              MsAdOnline.namesID = num3;
                              MsAdOnline.currentNode = num4;
                              MsAdOnline.currentNode = str2;
                              break;
                          }
                        }
                        else
                          break;
                        break;
                    }
                  }
                  MsAdOnline.currentUri = configStreamList1.ToArray();
                  MsAdOnline.DisposeDrive();
                  return;
              }
            }
        }
      }
    }

    /*private static void DisposeDrive()
    {
      AdController instance = AdController.Instance;
      if (instance == null)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MsAdOnline.DisposeDrive);
            break;
        }
      }
      else
      {
        instance.SelectResource();
        instance.DisconnectProject();
      }
    }*/
  }
}
