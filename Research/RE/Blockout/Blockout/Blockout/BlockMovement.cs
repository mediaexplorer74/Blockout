// Decompiled with JetBrains decompiler
// Type: Blockout.BlockMovement
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using Microsoft.Xna.Framework;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class BlockMovement
  {
    [DataMember]
    public int BlockIndex;
    [DataMember]
    public Vector2 OldRasterPosition;
    [DataMember]
    public Vector2 NewRasterPosition;

    public BlockMovement(int blockIndex, Vector2 oldRasterPosition, Vector2 newRasterPosition)
    {
      this.BlockIndex = blockIndex;
      this.OldRasterPosition = oldRasterPosition;
      this.NewRasterPosition = newRasterPosition;
    }
  }
}
