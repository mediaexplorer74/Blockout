// *************************************************************
// Type: GameFoundation.FunctionResolver
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using GameFoundation.GameFoundation;
using System;
using System.Globalization;
using Windows.ApplicationModel;
using Windows.Storage.Streams;
using Windows.System.Profile;

#nullable disable
namespace GameFoundation
{
  internal sealed class FunctionResolver
  {
    internal static FunctionResolver parentKeywords = new FunctionResolver();
    private static bool parentKeywordsBool;
    internal static string parentKeywordsString;
    internal static string currentUri;
    internal static string filterID;
    internal static string parentCancel;
    internal static string namesID;
    internal static string currentNode;
    internal static string idToken;

    static FunctionResolver() => FunctionResolver.DisconnectProject();

    private static void DisconnectProject()
    {
      if (FunctionResolver.parentKeywordsBool)
        return;
      FunctionResolver.parentKeywordsString = PcitureInvoker.get_DisposeDrive().ToString();
      FunctionResolver.currentUri = PcitureInvoker.get_DisconnectProject().ToString();
      FunctionResolver.filterID = Package.Current.Id.Architecture.ToString();
      FunctionResolver.parentCancel = FunctionResolver.ListQueue();
      FunctionResolver.namesID = FunctionResolver.DisconnectProject(true);
      CultureInfo cultureInfo1;
      CultureInfo cultureInfo2;
      PlatformHelper.ListQueue(out cultureInfo1, out cultureInfo2);
      FunctionResolver.idToken = cultureInfo1.ToString();
      FunctionResolver.currentNode = cultureInfo2.ToString();
      FunctionResolver.parentKeywordsBool = ReferenceInvoker.DisconnectProject(2133) != 0;
    }

    private static string DisconnectProject(bool flag)
    {
      string contentForFile = PlatformLocalStorage.LoadTextFromFile(EditorService.DisconnectProject(1853));
      if (string.IsNullOrEmpty(contentForFile))
      {
        
        // this.DisconnectProject();
        
        Guid guid;
        do
        {
            guid = Guid.NewGuid();
        }
        while (RegistryType.DisconnectProject(guid, Guid.Empty));
        {
            contentForFile = guid.ToString();
            PlatformLocalStorage.SaveTextToFile(EditorService.DisconnectProject(1853),
                contentForFile);
        }
      }
      return contentForFile;
    }

    [Obsolete("Not recommended as the full hardware id will change even with attaching a docking station.", true)]
    private static string DisposeDrive()
    {
      IBuffer id = HardwareIdentification.GetPackageSpecificToken(DeploymentSet.parentKeywords).Id;
      DataReader dataReader = DataReader.FromBuffer(id);
      byte[] numArray = PageQueue.DisconnectProject((int) (IntPtr) id.Length);
      dataReader.ReadBytes(numArray);
      return BitConverter.ToString(numArray);
    }

    private static string ListQueue()
    {
      string str1 = string.Empty;
      HardwareToken packageSpecificToken = HardwareIdentification.GetPackageSpecificToken(DeploymentSet.parentKeywords);
      DataReader dataReader = DataReader.FromBuffer(packageSpecificToken.Id);
      try
      {
        for (int index = ReferenceInvoker.DisconnectProject(2137); (long) index < (long) packageSpecificToken.Id.Length; index += ReferenceInvoker.DisconnectProject(2201))
        {
          byte[] numArray = PageQueue.DisconnectProject(ReferenceInvoker.DisconnectProject(2141));
          dataReader.ReadBytes(numArray);
          if ((int) numArray[ReferenceInvoker.DisconnectProject(2145)] != ReferenceInvoker.DisconnectProject(2149))
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
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (FunctionResolver.ListQueue);
                }
                if ((int) numArray[ReferenceInvoker.DisconnectProject(2153)] != ReferenceInvoker.DisconnectProject(2157))
                {
label_7:
                  switch (5)
                  {
                    case 0:
                      goto label_7;
                    default:
                      if ((int) numArray[ReferenceInvoker.DisconnectProject(2161)] != ReferenceInvoker.DisconnectProject(2165))
                      {
label_9:
                        switch (3)
                        {
                          case 0:
                            goto label_9;
                          default:
                            if ((int) numArray[ReferenceInvoker.DisconnectProject(2169)] == ReferenceInvoker.DisconnectProject(2173))
                            {
label_11:
                              switch (6)
                              {
                                case 0:
                                  goto label_11;
                              }
                            }
                            else
                              continue;
                            break;
                        }
                      }
                      else
                        break;
                  }
                }
                else
                  break;
                break;
            }
          }
          if (numArray[ReferenceInvoker.DisconnectProject(2177)] == (byte) 0)
          {
label_13:
            switch (1)
            {
              case 0:
                goto label_13;
              default:
                if (!string.IsNullOrEmpty(str1))
                  str1 = ResourceSerializer.DisconnectProject(str1, EditorService.DisconnectProject(1890));
                string str2 = str1;
                string format = EditorService.DisconnectProject(1893);
                object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2181));
                objArray1[ReferenceInvoker.DisconnectProject(2185)] = (object) numArray[ReferenceInvoker.DisconnectProject(2189)];
                objArray1[ReferenceInvoker.DisconnectProject(2193)] = (object) numArray[ReferenceInvoker.DisconnectProject(2197)];
                object[] objArray2 = objArray1;
                string str3 = string.Format(format, objArray2);
                str1 = ResourceSerializer.DisconnectProject(str2, str3);
                continue;
            }
          }
        }
label_19:
        switch (1)
        {
          case 0:
            goto label_19;
        }
      }
      finally
      {
        if (dataReader != null)
        {
label_21:
          switch (5)
          {
            case 0:
              goto label_21;
            default:
              ((IDisposable) dataReader).Dispose();
              break;
          }
        }
      }
      return str1;
    }
  }
}
