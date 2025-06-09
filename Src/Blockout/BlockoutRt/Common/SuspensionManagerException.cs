// *************************************************************
// Type: BlockoutRt.Common.SuspensionManagerException
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Blockout;
using System;

#nullable disable
namespace BlockoutRt.Common
{
  public class SuspensionManagerException : Exception
  {
    public SuspensionManagerException()
    {
    }

    public SuspensionManagerException(Exception e)
      : base(DatabaseLoader.DisconnectProject(13345), e)
    {
    }
  }
}
