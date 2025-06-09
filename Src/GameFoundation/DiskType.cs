// *************************************************************
// Type: GameFoundation.DiskType
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Collections.Generic;
using Windows.Networking.Connectivity;

#nullable disable
namespace GameFoundation
{
  internal sealed class DiskType
  {
    internal static void DisconnectProject()
    {
      DiskType.DisconnectProject((int)0);
    }

    internal static bool DisconnectProject(int v)
    {
      return true; 
    }

    
    internal static int DisconnectProject(bool _param0)
    {
      int totalMilliseconds;
      if (_param0)
      {
        //base.DisconnectProject();            
        totalMilliseconds = (int) TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(1673)).TotalMilliseconds;

      }
      else
        totalMilliseconds = (int) TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(1681)).TotalMilliseconds;
      return totalMilliseconds;
    }//

    /*internal static bool DisconnectProject()
    {
      bool flag = ReferenceInvoker.DisconnectProject(1689) != 0;
      try
      {
        if (NetworkInformation.GetInternetConnectionProfile()
                    .GetConnectionCost().NetworkCostType == ReferenceInvoker.DisconnectProject(1693))
        {
//label_2:
//          switch (6)
          {
//            case 0:
//              goto label_2;
//            default:
              if (false)
              {
                DiskType.DisconnectProject();
              }
              flag = ReferenceInvoker.DisconnectProject(1697) != 0;
//              break;
          }
        }
      }
      catch
      {
      }
      return flag;
    }*/

    /*internal static string DisconnectProject(bool _param0)
    {
      if (!_param0)
        return EditorService.DisconnectProject(1297);
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (DiskType.DisconnectProject);
          }
          return EditorService.DisconnectProject(1224);
      }
    }*/

    public static ConfigStream[] DisposeDrive(ConfigStream[] _param0, int _param1)
    {
      ConfigStream[] configStreamArray = 
                NetworkToken.DisconnectProject(Math.Min((int) OptionsSet.DisconnectProject(_param0), 
                _param1));
      List<int> intList = new List<int>();
      for (int index = ReferenceInvoker.DisconnectProject(1701); 
                index < (int) OptionsSet.DisconnectProject(_param0); 
                index += ReferenceInvoker.DisconnectProject(1705))
        intList.Add(index);
      int v = 1;
label_3:
      switch (v)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            DisposeDrive(_param0,_param1);
          }
          for (int index1 = ReferenceInvoker.DisconnectProject(1709); index1 < (int) OptionsSet.DisconnectProject(configStreamArray); index1 += ReferenceInvoker.DisconnectProject(1713))
          {
            int index2 = RandomManager.Rnd.Next(intList.Count);
            configStreamArray[index1] = _param0[index2];
            intList.RemoveAt(index2);
          }
//label_9:
//          switch (3)
          {
//            case 0:
//              goto label_9;
//            default:
              return configStreamArray;
          }
      }
    }

    internal static ConfigStream[] DisconnectProject(long _param0)
    {
      throw new Exception(EditorService.DisconnectProject(1370));
    }

    internal static ConfigStream[] ListQueue(ConfigStream[] _param0, int _param1)
    {
      ConfigStream[] configStreamArray = NetworkToken.DisconnectProject(Math.Min((int) OptionsSet.DisconnectProject(_param0), _param1));
      for (int index = ReferenceInvoker.DisconnectProject(1717); index < (int) OptionsSet.DisconnectProject(configStreamArray); index += ReferenceInvoker.DisconnectProject(1721))
        configStreamArray[index] = _param0[index];
      return configStreamArray;
    }

    internal static ConfigStream[] DisposeDrive(int _param0)
    {
      return DiskType.DisposeDrive(new List<ConfigStream>()
      {
        new ConfigStream(EditorService.DisconnectProject(1443), ReferenceInvoker.DisconnectProject(1725), ReferenceInvoker.DisconnectProject(1729)),
        new ConfigStream(EditorService.DisconnectProject(1456), ReferenceInvoker.DisconnectProject(1733), ReferenceInvoker.DisconnectProject(1737)),
        new ConfigStream(EditorService.DisconnectProject(1469), ReferenceInvoker.DisconnectProject(1741), ReferenceInvoker.DisconnectProject(1745)),
        new ConfigStream(EditorService.DisconnectProject(1482), ReferenceInvoker.DisconnectProject(1749), ReferenceInvoker.DisconnectProject(1753)),
        new ConfigStream(EditorService.DisconnectProject(1495), ReferenceInvoker.DisconnectProject(1757), ReferenceInvoker.DisconnectProject(1761))
      }.ToArray(), _param0);
    }

    internal static ConfigStream[] ListQueue(int _param0)
    {
      return DiskType.ListQueue(new List<ConfigStream>()
      {
        new ConfigStream(EditorService.DisconnectProject(1443), ReferenceInvoker.DisconnectProject(1765), ReferenceInvoker.DisconnectProject(1769)),
        new ConfigStream(EditorService.DisconnectProject(1456), ReferenceInvoker.DisconnectProject(1773), ReferenceInvoker.DisconnectProject(1777)),
        new ConfigStream(EditorService.DisconnectProject(1469), ReferenceInvoker.DisconnectProject(1781), ReferenceInvoker.DisconnectProject(1785)),
        new ConfigStream(EditorService.DisconnectProject(1482), ReferenceInvoker.DisconnectProject(1789), ReferenceInvoker.DisconnectProject(1793)),
        new ConfigStream(EditorService.DisconnectProject(1495), ReferenceInvoker.DisconnectProject(1797), ReferenceInvoker.DisconnectProject(1801))
      }.ToArray(), _param0);
    }
  }
}
