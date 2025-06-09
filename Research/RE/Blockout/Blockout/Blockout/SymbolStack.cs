// Decompiled with JetBrains decompiler
// Type: Blockout.SymbolStack
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Blockout
{
  internal static class SymbolStack
  {
    private const string parentKeywords = "secure.dat";
    private const string currentUri = "secure.bak";
    private const string filterID = "ver0";
    private const char parentKeywords = ';';

    internal static bool DisconnectProject(GameSettings _param0)
    {
      if (Player.Instance != null)
      {
        if (_param0 == null)
        {
label_2:
          switch (1)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolStack.DisconnectProject);
                break;
              }
              break;
          }
        }
        else
        {
          bool flag = ClientTree.DisconnectProject(1508) != 0;
          if (PlatformLocalStorage.FileExists(DatabaseLoader.DisconnectProject(9895)))
          {
            PlatformLocalStorage.DeleteFile(DatabaseLoader.DisconnectProject(9916));
            PlatformLocalStorage.MoveFile(DatabaseLoader.DisconnectProject(9895), DatabaseLoader.DisconnectProject(9916));
          }
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.AppendLine(DatabaseLoader.DisconnectProject(9937));
          stringBuilder.AppendLine(_param0.SoundFxIsOn.ToString());
          stringBuilder.AppendLine(_param0.LocalHighScoreHard.Scores.ToString());
          if (_param0.BestPlayResults == null)
          {
label_9:
            switch (1)
            {
              case 0:
                goto label_9;
              default:
                stringBuilder.AppendLine(DatabaseLoader.DisconnectProject(9861));
                break;
            }
          }
          else
          {
            stringBuilder.AppendLine(((int) FileScope.DisconnectProject(_param0.BestPlayResults)).ToString());
            for (int index1 = ClientTree.DisconnectProject(1512); index1 < (int) FileScope.DisconnectProject(_param0.BestPlayResults); index1 += ClientTree.DisconnectProject(1524))
            {
              int[] bestPlayResult = _param0.BestPlayResults[index1];
              if (bestPlayResult == null)
              {
                stringBuilder.AppendLine(DatabaseLoader.DisconnectProject(9861));
              }
              else
              {
                stringBuilder.AppendLine(((int) AssistantAttribute.DisconnectProject(bestPlayResult)).ToString());
                for (int index2 = ClientTree.DisconnectProject(1516); index2 < (int) AssistantAttribute.DisconnectProject(bestPlayResult); index2 += ClientTree.DisconnectProject(1520))
                  stringBuilder.AppendLine(bestPlayResult[index2].ToString());
label_17:
                switch (4)
                {
                  case 0:
                    goto label_17;
                  default:
                    continue;
                }
              }
            }
label_20:
            switch (3)
            {
              case 0:
                goto label_20;
            }
          }
          stringBuilder.Insert(ClientTree.DisconnectProject(1528), NetworkDesigner.DisconnectProject(PlatformEncryption.GetHardwareIdComplete(), DatabaseLoader.DisconnectProject(9946)));
          string contentForFile = NetworkDesigner.DisconnectProject(DatabaseLoader.DisconnectProject(9946), PlatformEncryption.Encrypt(stringBuilder.ToString()));
          if (!string.IsNullOrEmpty(contentForFile))
            return PlatformLocalStorage.SaveTextToFile(DatabaseLoader.DisconnectProject(9895), contentForFile);
label_22:
          switch (3)
          {
            case 0:
              goto label_22;
            default:
              throw new Exception(DatabaseLoader.DisconnectProject(9949));
          }
        }
      }
      return ClientTree.DisconnectProject(1504) != 0;
    }

    private static string DisconnectProject(Dictionary<string, int> _param0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(_param0.Count.ToString());
      ((char) ClientTree.DisconnectProject(1532)).ToString();
      using (Dictionary<string, int>.Enumerator enumerator = _param0.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          KeyValuePair<string, int> current = enumerator.Current;
          string str = AddinList.DisconnectProject((object) current.Key, (object) (char) ClientTree.DisconnectProject(1536), (object) current.Value);
          stringBuilder.AppendLine(str);
        }
label_4:
        switch (4)
        {
          case 0:
            goto label_4;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolStack.DisconnectProject);
              break;
            }
            break;
        }
      }
      return stringBuilder.ToString();
    }

    private static Dictionary<string, int> DisconnectProject(StringLinewiseReadHelper _param0)
    {
      Dictionary<string, int> dictionary = new Dictionary<string, int>();
      int num1 = int.Parse(_param0.ReadLine());
      for (int index = ClientTree.DisconnectProject(1540); index < num1; index += ClientTree.DisconnectProject(1568))
      {
        string str = _param0.ReadLine();
        char[] chArray1 = XmlFileContext.DisconnectProject(ClientTree.DisconnectProject(1544));
        chArray1[ClientTree.DisconnectProject(1548)] = (char) ClientTree.DisconnectProject(1552);
        char[] chArray2 = chArray1;
        string[] strArray = str.Split(chArray2);
        if ((int) DeviceQueue.DisconnectProject(strArray) == ClientTree.DisconnectProject(1556))
        {
label_2:
          switch (4)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolStack.DisconnectProject);
              }
              string key = strArray[ClientTree.DisconnectProject(1560)];
              int num2 = int.Parse(strArray[ClientTree.DisconnectProject(1564)]);
              dictionary.Add(key, num2);
              continue;
          }
        }
      }
      return dictionary;
    }

    internal static bool DisconnectProject()
    {
      bool flag = SymbolStack.DisconnectProject(DatabaseLoader.DisconnectProject(9895));
      if (!flag)
        flag = SymbolStack.DisconnectProject(DatabaseLoader.DisconnectProject(9916));
      return flag;
    }

    private static bool DisconnectProject(string _param0)
    {
      GameSettings gameSettings = GameBase.Instance.GameSettings;
      if (gameSettings == null)
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolStack.DisconnectProject);
            }
            gameSettings = new GameSettings();
            GameBase.Instance.GameSettings = gameSettings;
            break;
        }
      }
      if (!PlatformLocalStorage.FileExists(_param0))
      {
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            return ClientTree.DisconnectProject(1572) != 0;
        }
      }
      else
      {
        try
        {
          string text = PlatformLocalStorage.LoadTextFromFile(_param0);
          if (text.StartsWith(DatabaseLoader.DisconnectProject(9946)))
          {
label_9:
            switch (2)
            {
              case 0:
                goto label_9;
              default:
                string str = PlatformEncryption.Decrypt(text.Substring(ClientTree.DisconnectProject(1576)));
                char[] chArray = XmlFileContext.DisconnectProject(ClientTree.DisconnectProject(1580));
                chArray[ClientTree.DisconnectProject(1584)] = (char) ClientTree.DisconnectProject(1588);
                char[] separator = chArray;
                int count = ClientTree.DisconnectProject(1592);
                string[] strArray = str.Split(separator, count);
                if ((int) DeviceQueue.DisconnectProject(strArray) != ClientTree.DisconnectProject(1596))
                {
label_11:
                  switch (7)
                  {
                    case 0:
                      goto label_11;
                    default:
                      return ClientTree.DisconnectProject(1600) != 0;
                  }
                }
                else
                {
                  PlatformEncryption.IsSameHardwareIdAsHardware(strArray[ClientTree.DisconnectProject(1604)]);
                  if (ClientTree.DisconnectProject(1608) == 0)
                    return ClientTree.DisconnectProject(1612) != 0;
                  text = strArray[ClientTree.DisconnectProject(1616)];
                  break;
                }
            }
          }
          StringLinewiseReadHelper linewiseReadHelper = new StringLinewiseReadHelper(text);
          linewiseReadHelper.ReadLine();
          bool flag = bool.Parse(linewiseReadHelper.ReadLine());
          gameSettings.SoundFxIsOn = flag;
          int num1 = int.Parse(linewiseReadHelper.ReadLine());
          gameSettings.CurrentModeHighScore = num1;
          int num2 = int.Parse(linewiseReadHelper.ReadLine());
          if (num2 > ClientTree.DisconnectProject(1620))
          {
label_17:
            switch (7)
            {
              case 0:
                goto label_17;
              default:
                int[][] numArray = SolutionDictionary.DisconnectProject(num2);
                for (int index1 = ClientTree.DisconnectProject(1624); index1 < num2; index1 += ClientTree.DisconnectProject(1640))
                {
                  int num3 = int.Parse(linewiseReadHelper.ReadLine());
                  if (num3 > ClientTree.DisconnectProject(1628))
                  {
label_20:
                    switch (5)
                    {
                      case 0:
                        goto label_20;
                      default:
                        numArray[index1] = FormConverter.DisconnectProject(num3);
                        for (int index2 = ClientTree.DisconnectProject(1632); index2 < num3; index2 += ClientTree.DisconnectProject(1636))
                        {
                          int num4 = int.Parse(linewiseReadHelper.ReadLine());
                          numArray[index1][index2] = num4;
                        }
                        continue;
                    }
                  }
                }
label_26:
                switch (6)
                {
                  case 0:
                    goto label_26;
                  default:
                    gameSettings.BestPlayResults = numArray;
                    break;
                }
                break;
            }
          }
          return ClientTree.DisconnectProject(1644) != 0;
        }
        catch
        {
          return ClientTree.DisconnectProject(1648) != 0;
        }
      }
    }
  }
}
