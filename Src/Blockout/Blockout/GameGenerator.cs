// *************************************************************
// Type: Blockout.GameGenerator
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#nullable disable
namespace Blockout
{
  public static class GameGenerator
  {
    public const int xGameOffset = 0;
    public const int yGameOffset = 200;
    public const int GameSize = 480;
    public const int GameBorderSize = 12;
    private static Rectangle parentKeywords = new Rectangle(ClientTree.DisconnectProject(3300), ClientTree.DisconnectProject(3304), ClientTree.DisconnectProject(3308), ClientTree.DisconnectProject(3312));
    private static Texture2D parentKeywords = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11575));
    private static int parentKeywords;
    public static string[] texLevelNames = new List<string>()
    {
      DatabaseLoader.DisconnectProject(11575)
    }.ToArray();

    public static GameLevel GenerateLevel(ChallangeBlock challangeMode, int levelIndex)
    {
      Block[] blocksForLevel = PredefinedLevels.GetBlocksForLevel(challangeMode, levelIndex);
      return new GameLevel(GameGenerator.parentKeywords, GameGenerator.parentKeywords, blocksForLevel);
    }

    internal static bool DisconnectProject(ChallangeBlock _param0, int _param1)
    {
      return PredefinedLevels.LevelExists(_param0, _param1);
    }
  }
}
