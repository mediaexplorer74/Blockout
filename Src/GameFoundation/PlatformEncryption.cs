// *************************************************************
// Type: GameFoundation.PlatformEncryption
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Collections.Generic;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Windows.System.Profile;

#nullable disable
namespace GameFoundation
{
  public static class PlatformEncryption
  {
    private const string parentKeywords = "idfile.dat";
    private static CryptographicKey parentKeywords;

    static PlatformEncryption() => PlatformEncryption.DisconnectProject();

    internal static string DisconnectProject()
    {
      return CryptographicBuffer.EncodeToBase64String(CryptographicBuffer.GenerateRandom((uint) ReferenceInvoker.DisconnectProject(1909)));
    }

    internal static void DisconnectProject()
    {
      string contentForFile = ViewSet.parentKeywords;
      if (PlatformLocalStorage.FileExists(EditorService.DisconnectProject(1662)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformEncryption.DisconnectProject);
            }
            string text = PlatformLocalStorage.LoadTextFromFile(EditorService.DisconnectProject(1662));
            if (!string.IsNullOrEmpty(text))
            {
              contentForFile = new StringLinewiseReadHelper(text).ReadLine();
              break;
            }
            break;
        }
      }
      if (string.IsNullOrEmpty(contentForFile))
      {
label_7:
        switch (7)
        {
          case 0:
            goto label_7;
          default:
            contentForFile = PlatformEncryption.DisconnectProject();
            PlatformLocalStorage.SaveTextToFile(EditorService.DisconnectProject(1662), contentForFile);
            break;
        }
      }
      PlatformEncryption.DisconnectProject(contentForFile);
    }

    private static void DisconnectProject(string _param0)
    {
      if (string.IsNullOrEmpty(_param0))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformEncryption.DisconnectProject);
            break;
        }
      }
      else
        PlatformEncryption.parentKeywords = SymmetricKeyAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithmNames.AesCbcPkcs7).CreateSymmetricKey(CryptographicBuffer.DecodeFromBase64String(_param0));
    }

    public static string Encrypt(string toEncrypt)
    {
      if (string.IsNullOrEmpty(toEncrypt))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformEncryption.Encrypt);
            }
            return (string) null;
        }
      }
      else
      {
        IBuffer binary = CryptographicBuffer.ConvertStringToBinary(toEncrypt, (BinaryStringEncoding) ReferenceInvoker.DisconnectProject(1913));
        return CryptographicBuffer.EncodeToBase64String(CryptographicEngine.Encrypt(PlatformEncryption.parentKeywords, binary, DeploymentSet.parentKeywords));
      }
    }

    public static string Decrypt(string toDecrypt)
    {
      if (string.IsNullOrEmpty(toDecrypt))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformEncryption.Decrypt);
            }
            return (string) null;
        }
      }
      else
      {
        IBuffer ibuffer1 = CryptographicBuffer.DecodeFromBase64String(toDecrypt);
        IBuffer ibuffer2 = CryptographicEngine.Decrypt(PlatformEncryption.parentKeywords, ibuffer1, DeploymentSet.parentKeywords);
        return CryptographicBuffer.ConvertBinaryToString((BinaryStringEncoding) ReferenceInvoker.DisconnectProject(1917), ibuffer2);
      }
    }

    public static string GetHardwareIdComplete()
    {
      return CryptographicBuffer.EncodeToBase64String(HardwareIdentification.GetPackageSpecificToken(DeploymentSet.parentKeywords).Id);
    }

    public static bool IsSameHardwareIdAsHardware(string hardwareId)
    {
      Dictionary<int, byte[]> dictionary1 = PlatformEncryption.DisconnectProject(CryptographicBuffer.DecodeFromBase64String(hardwareId));
      Dictionary<int, byte[]> dictionary2 = PlatformEncryption.DisconnectProject(CryptographicBuffer.DecodeFromBase64String(PlatformEncryption.GetHardwareIdComplete()));
      int num = ReferenceInvoker.DisconnectProject(1921);
      for (int key = ReferenceInvoker.DisconnectProject(1925); key <= ReferenceInvoker.DisconnectProject(1973); key += ReferenceInvoker.DisconnectProject(1969))
      {
        if (dictionary1.ContainsKey(key))
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformEncryption.IsSameHardwareIdAsHardware);
              }
              if (dictionary2.ContainsKey(key))
              {
label_6:
                switch (4)
                {
                  case 0:
                    goto label_6;
                  default:
                    if ((int) dictionary1[key][ReferenceInvoker.DisconnectProject(1929)] == (int) dictionary2[key][ReferenceInvoker.DisconnectProject(1933)] && (int) dictionary1[key][ReferenceInvoker.DisconnectProject(1937)] == (int) dictionary2[key][ReferenceInvoker.DisconnectProject(1941)])
                    {
label_8:
                      switch (5)
                      {
                        case 0:
                          goto label_8;
                        default:
                          switch (key - ReferenceInvoker.DisconnectProject(1945))
                          {
                            case 0:
                              num += ReferenceInvoker.DisconnectProject(1949);
                              continue;
                            case 1:
                              num += ReferenceInvoker.DisconnectProject(1953);
                              continue;
                            case 2:
                              num += ReferenceInvoker.DisconnectProject(1957);
                              continue;
                            case 3:
                              num += ReferenceInvoker.DisconnectProject(1961);
                              continue;
                            case 8:
                              num += ReferenceInvoker.DisconnectProject(1965);
                              continue;
                            default:
                              continue;
                          }
                      }
                    }
                    else
                      continue;
                }
              }
              else
                continue;
          }
        }
      }
label_17:
      switch (6)
      {
        case 0:
          goto label_17;
        default:
          return (num < ReferenceInvoker.DisconnectProject(1977) ? 1 : 0) == ReferenceInvoker.DisconnectProject(1981);
      }
    }

    private static Dictionary<int, byte[]> DisconnectProject(IBuffer _param0)
    {
      Dictionary<int, byte[]> dictionary1 = new Dictionary<int, byte[]>();
      DataReader dataReader = DataReader.FromBuffer(_param0);
      try
      {
        for (int index = ReferenceInvoker.DisconnectProject(1985); (long) index < (long) _param0.Length; index += ReferenceInvoker.DisconnectProject(2029))
        {
          byte[] numArray1 = PageQueue.DisconnectProject(ReferenceInvoker.DisconnectProject(1989));
          dataReader.ReadBytes(numArray1);
          int key1 = (int) numArray1[ReferenceInvoker.DisconnectProject(1993)];
          int num = (int) numArray1[ReferenceInvoker.DisconnectProject(1997)];
          if (key1 >= ReferenceInvoker.DisconnectProject(2001))
          {
label_3:
            switch (4)
            {
              case 0:
                goto label_3;
              default:
                if (false)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformEncryption.DisconnectProject);
                }
                if (key1 <= ReferenceInvoker.DisconnectProject(2005) && num == 0)
                {
label_7:
                  switch (2)
                  {
                    case 0:
                      goto label_7;
                    default:
                      if (!dictionary1.ContainsKey(key1))
                      {
label_9:
                        switch (5)
                        {
                          case 0:
                            goto label_9;
                          default:
                            Dictionary<int, byte[]> dictionary2 = dictionary1;
                            int key2 = key1;
                            byte[] numArray2 = PageQueue.DisconnectProject(ReferenceInvoker.DisconnectProject(2009));
                            numArray2[ReferenceInvoker.DisconnectProject(2013)] = numArray1[ReferenceInvoker.DisconnectProject(2017)];
                            numArray2[ReferenceInvoker.DisconnectProject(2021)] = numArray1[ReferenceInvoker.DisconnectProject(2025)];
                            byte[] numArray3 = numArray2;
                            dictionary2.Add(key2, numArray3);
                            continue;
                        }
                      }
                      else
                        continue;
                  }
                }
                else
                  continue;
            }
          }
        }
label_13:
        switch (2)
        {
          case 0:
            goto label_13;
        }
      }
      finally
      {
        if (dataReader != null)
        {
label_15:
          switch (7)
          {
            case 0:
              goto label_15;
            default:
              ((IDisposable) dataReader).Dispose();
              break;
          }
        }
      }
      return dictionary1;
    }
  }
}
