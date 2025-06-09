// Decompiled with JetBrains decompiler
// Type: Blockout.Block
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Shared;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class Block : IElement
  {
    [DataMember]
    public Rectangle pos;
    [DataMember]
    public int typeIndex;
    [DataMember]
    public int subTextureIndex;
    [DataMember]
    public bool isActive;
    [DataMember]
    public bool isBlueBlock;

    public Block(int typeIndex, int subTextureIndex)
    {
      this.pos = new Rectangle(ClientTree.DisconnectProject(2940), ClientTree.DisconnectProject(2944), (int) ElementGenerator.BlockSize[typeIndex].X, (int) ElementGenerator.BlockSize[typeIndex].Y);
      this.typeIndex = typeIndex;
      this.subTextureIndex = subTextureIndex;
      if (typeIndex == 0)
        this.isBlueBlock = ClientTree.DisconnectProject(2948) != 0;
      this.isActive = ClientTree.DisconnectProject(2952) != 0;
    }

    public int ClosestRasterPosX
    {
      get
      {
        return (int) Math.Round(((double) this.pos.X - ClientTree.DisconnectProject(2808) - ClientTree.DisconnectProject(2816)) / ClientTree.DisconnectProject(2824), ClientTree.DisconnectProject(2832));
      }
    }

    public int EqualOrSmallerRasterPosX
    {
      get
      {
        return (int) Math.Floor(((double) this.pos.X - ClientTree.DisconnectProject(2836) - ClientTree.DisconnectProject(2844)) / ClientTree.DisconnectProject(2852));
      }
    }

    public int ClosestRasterPosY
    {
      get
      {
        return (int) Math.Round(((double) this.pos.Y - ClientTree.DisconnectProject(2860) - ClientTree.DisconnectProject(2868)) / ClientTree.DisconnectProject(2876), ClientTree.DisconnectProject(2884));
      }
    }

    public BlockMovementDirection MovementDirection
    {
      get => ElementGenerator.AllowedMovement[this.typeIndex];
    }

    public void Place(int xRasterIndex, int yRasterIndex)
    {
      int num1 = xRasterIndex * ClientTree.DisconnectProject(2888) + ClientTree.DisconnectProject(2892);
      int num2 = yRasterIndex * ClientTree.DisconnectProject(2896) + ClientTree.DisconnectProject(2900) + ClientTree.DisconnectProject(2904);
      this.pos.X = num1;
      this.pos.Y = num2;
      this.isActive = ClientTree.DisconnectProject(2908) != 0;
    }

    public void Draw(float transitionAlpha)
    {
      GameBase.Instance.SpriteBatch.Draw(ElementGenerator.BlockTextures[this.typeIndex][this.subTextureIndex], this.pos, ActivityInvoker.DisconnectProject(Color.White, transitionAlpha));
      if (!this.isBlueBlock)
        return;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Block.Draw);
          }
          Game1 game1 = QueueLayout.DisconnectProject((object) GameBase.Instance);
          if (game1 == null)
            break;
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              game1.DrawingBlueBlock(this, transitionAlpha);
              return;
          }
      }
    }

    public void Draw(float transitionAlpha, float scaleX, float scaleY, int xOffset, int yOffset)
    {
      Rectangle rectangle = new Rectangle((int) ((double) this.pos.X * (double) scaleX + (double) xOffset), (int) ((double) this.pos.Y * (double) scaleY + (double) yOffset), (int) ((double) this.pos.Width * (double) scaleX), (int) ((double) this.pos.Height * (double) scaleY));
      GameBase.Instance.SpriteBatch.Draw(ElementGenerator.BlockTextures[this.typeIndex][this.subTextureIndex], rectangle, ActivityInvoker.DisconnectProject(Color.White, transitionAlpha));
    }

    public void DrawInSpecificArea(Rectangle areaToDrawIn, Color color)
    {
      double num1 = (double) areaToDrawIn.Width / ClientTree.DisconnectProject(2912);
      double num2 = (double) areaToDrawIn.Height / ClientTree.DisconnectProject(2920);
      int x = (int) ((double) (this.pos.X - ClientTree.DisconnectProject(2928)) * num1) + areaToDrawIn.X;
      int y = (int) ((double) (this.pos.Y - ClientTree.DisconnectProject(2932) - ClientTree.DisconnectProject(2936)) * num2) + areaToDrawIn.Y;
      int width = (int) ((double) this.pos.Width * num1);
      int height = (int) ((double) this.pos.Height * num2);
      GameBase.Instance.SpriteBatch.Draw(ElementGenerator.BlockTextures[this.typeIndex][this.subTextureIndex], new Rectangle(x, y, width, height), color);
    }

    public Rectangle PosLevelEditor
    {
      get => this.pos;
      set => this.pos = value;
    }

    public int ElementIndexLevelEditor => this.typeIndex;
  }
}
