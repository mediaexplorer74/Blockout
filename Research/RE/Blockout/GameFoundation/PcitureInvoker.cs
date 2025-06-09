// Decompiled with JetBrains decompiler
// Type: GameFoundation.PcitureInvoker
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace GameFoundation
{
  internal static class PcitureInvoker
  {
    private const int parentKeywords = 0;
    private const int currentUri = 1;
    private const int filterID = 2;
    private const int parentCancel = 3;
    private const int namesID = 4;
    private const int currentNode = 5;
    private const int idToken = 6;
    private const int nextOutput = 7;
    private const int timerDisposed = 8;
    private const int messageCount = 9;
    private const int generatorToken = 10;
    private const int currentValues = 11;
    private const int windowPosition = 12;
    private const int handlerHandle = 13;
    private const int windowDisposed = 14;
    private const int categoryCount = 15;
    private const int cancelID = 16;
    private const int pathDisposed = 17;
    private const int userDataInstance = 18;
    private const int pathEnabled = 19;
    private const int nodeHandle = 20;
    private const int firstFilter = 21;
    private const int lastMessage = 22;
    private const int wrapperCache = 23;
    private const int captionEnabled = 24;
    private const int childFilter = 25;
    private const int keywordsCollection = 26;
    private const int logAvailable = 27;
    private const int reasonCount = 28;
    private const int managerCache = 29;
    private const int lockHandle = 30;
    private const int urlMap = 31;
    private const int generator = 32;
    private const int cancelAvailable = 33;
    private const int userDataCollection = 34;
    private const int sessionHandle = 35;
    private const int syncObjectLength = 36;
    private const int nameLength = 37;
    private const int cancelPosition = 38;
    private const int idHeader = 39;
    private const int previousMessage = 40;
    private const int lockPosition = 41;
    private const int urlID = 42;
    private const int idCache = 43;
    private const int lineEnabled = 44;
    private const int urlList = 45;
    private const int captionList = 46;
    private const int variableDisposed = 47;
    private const int lineCache = 48;
    private const int wrapperID = 49;
    private const int cancelHeader = 50;
    private const int lineCollection = 51;
    private const int managerCount = 52;
    private const int activeColor = 53;
    private const int nextVersion = 54;
    private const int optionsPosition = 55;
    private const int windowCache = 56;
    private const int firstCategory = 57;
    private const int previousManager = 59;
    private const int versionCollection = 60;
    private const int keywordsList = 61;
    private const int lockCount = 62;
    private const int previousData = 63;
    private const int parentOutput = 64;
    private const int lockID = 65;
    private const int handlerHeader = 66;
    private const int parentName = 67;
    private const int windowCollection = 68;
    private const int activeManager = 69;
    private const int rootAddress = 70;
    private const int queryInitialized = 71;
    private const int cancelCount = 1;
    private const int syncObjectCache = 2;
    private const int previousAddress = 3;
    private const int syncObjectEnabled = 1;
    private const int currentHandler = 2;
    private const int urlCache = 16;
    private const int childLock = 128;
    private const int captionToken = 256;
    private const int managerList = 512;
    private const int nextManager = 1024;

    [SpecialName]
    internal static PcitureInvoker.ClientTable get_DisconnectProject()
    {
      PcitureInvoker.ClientTable clientTable = (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2561);
      int num = IntPtr.Size * ReferenceInvoker.DisconnectProject(2565);
      PcitureInvoker.ClientTable disconnectProject;
      if (num != ReferenceInvoker.DisconnectProject(2569))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PcitureInvoker.get_DisconnectProject);
            }
            disconnectProject = num != ReferenceInvoker.DisconnectProject(2573) ? (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2585) : (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2577);
            break;
        }
      }
      else
        disconnectProject = (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2581);
      return disconnectProject;
    }

    [SpecialName]
    internal static PcitureInvoker.ClientTable get_DisposeDrive()
    {
      PcitureInvoker.ClientTable clientTable = (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2589);
      int num = IntPtr.Size * ReferenceInvoker.DisconnectProject(2593);
      PcitureInvoker.ClientTable disposeDrive;
      if (num != ReferenceInvoker.DisconnectProject(2597))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PcitureInvoker.get_DisposeDrive);
            }
            if (num == ReferenceInvoker.DisconnectProject(2601))
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  disposeDrive = (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2605);
                  break;
              }
            }
            else
            {
              disposeDrive = (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2613);
              break;
            }
            break;
        }
      }
      else
        disposeDrive = (PcitureInvoker.ClientTable) ReferenceInvoker.DisconnectProject(2609);
      return disposeDrive;
    }

    [SpecialName]
    internal static PcitureInvoker.NodeType get_DisconnectProject()
    {
      PcitureInvoker.NodeType disconnectProject = (PcitureInvoker.NodeType) ReferenceInvoker.DisconnectProject(2617);
      try
      {
        PcitureInvoker.AssistantSite assistantSite = new PcitureInvoker.AssistantSite();
        PcitureInvoker.DisconnectProject(ref assistantSite);
        ushort parentKeywords = assistantSite.parentKeywords.parentKeywords;
        if ((int) parentKeywords != ReferenceInvoker.DisconnectProject(2621))
        {
label_2:
          switch (7)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (PcitureInvoker.get_DisconnectProject);
              }
              switch ((int) parentKeywords - ReferenceInvoker.DisconnectProject(2625))
              {
                case 0:
                  disconnectProject = (PcitureInvoker.NodeType) ReferenceInvoker.DisconnectProject(2641);
                  break;
                case 1:
                  disconnectProject = (PcitureInvoker.NodeType) ReferenceInvoker.DisconnectProject(2633);
                  break;
                case 4:
                  disconnectProject = (PcitureInvoker.NodeType) ReferenceInvoker.DisconnectProject(2629);
                  break;
                default:
                  disconnectProject = (PcitureInvoker.NodeType) ReferenceInvoker.DisconnectProject(2645);
                  break;
              }
              break;
          }
        }
        else
          disconnectProject = (PcitureInvoker.NodeType) ReferenceInvoker.DisconnectProject(2637);
      }
      catch
      {
      }
      return disconnectProject;
    }

    [DllImport("kernel32.dll", EntryPoint = "GetNativeSystemInfo")]
    public static extern void DisconnectProject([MarshalAs(UnmanagedType.Struct)] ref PcitureInvoker.AssistantSite _param0);

    [DllImport("kernel32", EntryPoint = "GetProcAddress", SetLastError = true)]
    public static extern IntPtr DisconnectProject(IntPtr _param0, string _param1);

    [SpecialName]
    internal static string get_DisposeDrive()
    {
      string empty = string.Empty;
      new PcitureInvoker.StubList().parentKeywords = Marshal.SizeOf(typeof (PcitureInvoker.StubList));
      return empty;
    }

    private static PcitureInvoker.DeviceSettings DisconnectProject()
    {
      return (PcitureInvoker.DeviceSettings) null;
    }

    internal enum ClientTable
    {
      Unknown,
      Bit32,
      Bit64,
    }

    internal enum NodeType
    {
      Unknown,
      Bit32,
      Bit64,
      Itanium64,
      Arm,
    }

    private delegate bool DeviceSettings([In] IntPtr handle, out bool isWow64Process);

    private struct StubList
    {
      public int parentKeywords;
      public int currentUri;
      public int filterID;
      public int parentCancel;
      public int namesID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      public string parentKeywords;
      public short parentKeywords;
      public short currentUri;
      public short filterID;
      public byte parentKeywords;
      public byte currentUri;
    }

    public struct AssistantSite
    {
      internal PcitureInvoker.ServerSerializer parentKeywords;
      public uint parentKeywords;
      public IntPtr parentKeywords;
      public IntPtr currentUri;
      public IntPtr filterID;
      public uint currentUri;
      public uint filterID;
      public uint parentCancel;
      public ushort parentKeywords;
      public ushort currentUri;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ServerSerializer
    {
      [FieldOffset(0)]
      internal uint parentKeywords;
      [FieldOffset(0)]
      internal ushort parentKeywords;
      [FieldOffset(2)]
      internal ushort currentUri;
    }
  }
}
