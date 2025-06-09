// Decompiled with JetBrains decompiler
// Type: BlockoutRt.Common.SuspensionManagerException
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

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
