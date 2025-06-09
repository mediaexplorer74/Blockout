// *************************************************************
// Type: Blockout.SymbolStack
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

//using GameFoundation;
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
        private const char parentKeywordsC = ';';

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
                                // FIX: Removed invalid '__methodref' usage as it is not supported in C#.  
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
                        stringBuilder.AppendLine(((int)FileScope.DisconnectProject(_param0.BestPlayResults)).ToString());
                        for (int index1 = ClientTree.DisconnectProject(1512); index1 < (int)FileScope.DisconnectProject(_param0.BestPlayResults); index1 += ClientTree.DisconnectProject(1524))
                        {
                            int[] bestPlayResult = _param0.BestPlayResults[index1];
                            if (bestPlayResult == null)
                            {
                                stringBuilder.AppendLine(DatabaseLoader.DisconnectProject(9861));
                            }
                            else
                            {
                                stringBuilder.AppendLine(((int)AssistantAttribute.DisconnectProject(bestPlayResult)).ToString());
                                for (int index2 = ClientTree.DisconnectProject(1516); index2 < (int)AssistantAttribute.DisconnectProject(bestPlayResult); index2 += ClientTree.DisconnectProject(1520))
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

        internal static bool DisconnectProject()
        {
            throw new NotImplementedException();
        }

        internal static void DisconnectProject(object gameSettings)
        {
            throw new NotImplementedException();
        }

        private static string DisconnectProject(Dictionary<string, int> _param0)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(_param0.Count.ToString());
            ((char)ClientTree.DisconnectProject(1532)).ToString();
            using (Dictionary<string, int>.Enumerator enumerator = _param0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    KeyValuePair<string, int> current = enumerator.Current;
                    string str = AddinList.DisconnectProject((object)current.Key, (object)(char)ClientTree.DisconnectProject(1536), (object)current.Value);
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
                            // FIX: Removed invalid '__methodref' usage as it is not supported in C#.  
                            break;
                        }
                        break;
                }
            }
            return stringBuilder.ToString();
        }
    }
}
