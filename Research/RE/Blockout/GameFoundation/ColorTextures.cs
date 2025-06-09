// Decompiled with JetBrains decompiler
// Type: GameFoundation.ColorTextures
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace GameFoundation
{
  public static class ColorTextures
  {
    public static Texture2D texBlack = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(1));
    public static Texture2D texWhite = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(50));
  }
}
