// *************************************************************
// Type: GameFoundation.ListExtension
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Collections.Generic;

#nullable disable
namespace GameFoundation
{
  public static class ListExtension
  {
    public static T GetRandom<T>(this IList<T> listToGetRandom)
    {
      if (listToGetRandom.Count != 0)
        return listToGetRandom[RandomManager.Rnd.Next(ReferenceInvoker.DisconnectProject(464), listToGetRandom.Count)];
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ListExtension.GetRandom);
          }
          return default (T);
      }
    }
  }
}
