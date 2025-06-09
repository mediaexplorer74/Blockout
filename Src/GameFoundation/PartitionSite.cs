// *************************************************************
// Type: GameFoundation.PartitionSite
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;

#nullable disable
namespace GameFoundation
{
  internal sealed class PartitionSite
  {
    internal static TimeSpan DisconnectProject(TimeSpan _param0, TimeSpan _param1)
    {
      return _param0 - _param1;
    }
  }
}
