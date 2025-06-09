// *************************************************************
// Type: Blockout.ElementGenerator
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Shared;
using System;
using System.Collections.Generic;

#nullable disable
namespace Blockout
{
  public class ElementGenerator : IElementGenerator
  {
    public const int BaseFieldSize = 76;
    public const int BlocksPerDirection = 6;
    public static Texture2D[][] BlockTextures;
    public static Vector2[] BlockSize;
    private static Color[][] parentKeywords;
    private static Vector2[][] parentKeywords;
    public static BlockMovementDirection[] AllowedMovement;

    private ElementGenerator()
    {
    }

    static ElementGenerator()
    {
      List<List<Texture2D>> texture2DListList = new List<List<Texture2D>>();
      List<Vector2> vector2List = new List<Vector2>();
      List<Color[]> colorArrayList = new List<Color[]>();
      List<BlockMovementDirection> movementDirectionList = new List<BlockMovementDirection>();
      texture2DListList.Add(new List<Texture2D>());
      vector2List.Add(new Vector2(ClientTree.DisconnectProject(2960), ClientTree.DisconnectProject(2964)));
      texture2DListList[ClientTree.DisconnectProject(2968)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10726)), vector2List[ClientTree.DisconnectProject(2972)]));
      texture2DListList[ClientTree.DisconnectProject(2976)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10769)), vector2List[ClientTree.DisconnectProject(2980)]));
      texture2DListList[ClientTree.DisconnectProject(2984)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10812)), vector2List[ClientTree.DisconnectProject(2988)]));
      Color[] data1 = ConfigProvider.DisconnectProject(texture2DListList[ClientTree.DisconnectProject(2992)][ClientTree.DisconnectProject(2996)].Width * texture2DListList[ClientTree.DisconnectProject(3000)][ClientTree.DisconnectProject(3004)].Height);
      texture2DListList[ClientTree.DisconnectProject(3008)][ClientTree.DisconnectProject(3012)].GetData<Color>(data1);
      colorArrayList.Add(data1);
      movementDirectionList.Add((BlockMovementDirection) ClientTree.DisconnectProject(3016));
      texture2DListList.Add(new List<Texture2D>());
      vector2List.Add(new Vector2(ClientTree.DisconnectProject(3020), ClientTree.DisconnectProject(3024)));
      texture2DListList[ClientTree.DisconnectProject(3028)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10855)), vector2List[ClientTree.DisconnectProject(3032)]));
      texture2DListList[ClientTree.DisconnectProject(3036)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10900)), vector2List[ClientTree.DisconnectProject(3040)]));
      texture2DListList[ClientTree.DisconnectProject(3044)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10945)), vector2List[ClientTree.DisconnectProject(3048)]));
      texture2DListList[ClientTree.DisconnectProject(3052)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10990)), vector2List[ClientTree.DisconnectProject(3056)]));
      Color[] data2 = ConfigProvider.DisconnectProject(texture2DListList[ClientTree.DisconnectProject(3060)][ClientTree.DisconnectProject(3064)].Width * texture2DListList[ClientTree.DisconnectProject(3068)][ClientTree.DisconnectProject(3072)].Height);
      texture2DListList[ClientTree.DisconnectProject(3076)][ClientTree.DisconnectProject(3080)].GetData<Color>(data2);
      colorArrayList.Add(data2);
      movementDirectionList.Add((BlockMovementDirection) ClientTree.DisconnectProject(3084));
      texture2DListList.Add(new List<Texture2D>());
      vector2List.Add(new Vector2(ClientTree.DisconnectProject(3088), ClientTree.DisconnectProject(3092)));
      texture2DListList[ClientTree.DisconnectProject(3096)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11035)), vector2List[ClientTree.DisconnectProject(3100)]));
      texture2DListList[ClientTree.DisconnectProject(3104)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11080)), vector2List[ClientTree.DisconnectProject(3108)]));
      texture2DListList[ClientTree.DisconnectProject(3112)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11125)), vector2List[ClientTree.DisconnectProject(3116)]));
      texture2DListList[ClientTree.DisconnectProject(3120)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11170)), vector2List[ClientTree.DisconnectProject(3124)]));
      Color[] data3 = ConfigProvider.DisconnectProject(texture2DListList[ClientTree.DisconnectProject(3128)][ClientTree.DisconnectProject(3132)].Width * texture2DListList[ClientTree.DisconnectProject(3136)][ClientTree.DisconnectProject(3140)].Height);
      texture2DListList[ClientTree.DisconnectProject(3144)][ClientTree.DisconnectProject(3148)].GetData<Color>(data3);
      colorArrayList.Add(data3);
      movementDirectionList.Add((BlockMovementDirection) ClientTree.DisconnectProject(3152));
      texture2DListList.Add(new List<Texture2D>());
      vector2List.Add(new Vector2(ClientTree.DisconnectProject(3156), ClientTree.DisconnectProject(3160)));
      texture2DListList[ClientTree.DisconnectProject(3164)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11215)), vector2List[ClientTree.DisconnectProject(3168)]));
      texture2DListList[ClientTree.DisconnectProject(3172)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11260)), vector2List[ClientTree.DisconnectProject(3176)]));
      texture2DListList[ClientTree.DisconnectProject(3180)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11305)), vector2List[ClientTree.DisconnectProject(3184)]));
      texture2DListList[ClientTree.DisconnectProject(3188)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11350)), vector2List[ClientTree.DisconnectProject(3192)]));
      Color[] data4 = ConfigProvider.DisconnectProject(texture2DListList[ClientTree.DisconnectProject(3196)][ClientTree.DisconnectProject(3200)].Width * texture2DListList[ClientTree.DisconnectProject(3204)][ClientTree.DisconnectProject(3208)].Height);
      texture2DListList[ClientTree.DisconnectProject(3212)][ClientTree.DisconnectProject(3216)].GetData<Color>(data4);
      colorArrayList.Add(data4);
      movementDirectionList.Add((BlockMovementDirection) ClientTree.DisconnectProject(3220));
      texture2DListList.Add(new List<Texture2D>());
      vector2List.Add(new Vector2(ClientTree.DisconnectProject(3224), ClientTree.DisconnectProject(3228)));
      texture2DListList[ClientTree.DisconnectProject(3232)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11395)), vector2List[ClientTree.DisconnectProject(3236)]));
      texture2DListList[ClientTree.DisconnectProject(3240)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11440)), vector2List[ClientTree.DisconnectProject(3244)]));
      texture2DListList[ClientTree.DisconnectProject(3248)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11485)), vector2List[ClientTree.DisconnectProject(3252)]));
      texture2DListList[ClientTree.DisconnectProject(3256)].Add(TextureHelper.ResizeTexture(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11530)), vector2List[ClientTree.DisconnectProject(3260)]));
      Color[] data5 = ConfigProvider.DisconnectProject(texture2DListList[ClientTree.DisconnectProject(3264)][ClientTree.DisconnectProject(3268)].Width * texture2DListList[ClientTree.DisconnectProject(3272)][ClientTree.DisconnectProject(3276)].Height);
      texture2DListList[ClientTree.DisconnectProject(3280)][ClientTree.DisconnectProject(3284)].GetData<Color>(data5);
      colorArrayList.Add(data5);
      movementDirectionList.Add((BlockMovementDirection) ClientTree.DisconnectProject(3288));
      ElementGenerator.BlockTextures = AssemblyContext.DisconnectProject(texture2DListList.Count);
      for (int index = ClientTree.DisconnectProject(3292); index < texture2DListList.Count; index += ClientTree.DisconnectProject(3296))
        ElementGenerator.BlockTextures[index] = texture2DListList[index].ToArray();
      ElementGenerator.BlockSize = vector2List.ToArray();
      ElementGenerator.parentKeywords = colorArrayList.ToArray();
      ElementGenerator.AllowedMovement = movementDirectionList.ToArray();
    }

    public static Block GenerateBlockType(BlockTypes toGenerate)
    {
      int typeIndex = (int) toGenerate;
      int subTextureIndex = RandomManager.Rnd.Next(ElementGenerator.BlockTextures[typeIndex].Length);
      return new Block(typeIndex, subTextureIndex);
    }

    public static ElementGenerator GetGeneratorForLevelEditor() => new ElementGenerator();

    public int NumberOfElements
    {
      get => (int) ImageScope.DisconnectProject(ElementGenerator.BlockTextures);
    }

    public IElement GetNewElement(int elementIndex)
    {
      if (elementIndex >= ClientTree.DisconnectProject(2956))
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ElementGenerator.GetNewElement);
            }
            if (elementIndex < (int) ImageScope.DisconnectProject(ElementGenerator.BlockTextures))
              return (IElement) ElementGenerator.GenerateBlockType((BlockTypes) elementIndex);
            break;
        }
      }
      throw new ArgumentOutOfRangeException();
    }
  }
}
