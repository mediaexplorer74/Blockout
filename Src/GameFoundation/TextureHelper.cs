// *************************************************************
// Type: GameFoundation.TextureHelper
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace GameFoundation
{
  public static class TextureHelper
  {
    private static SpriteBatch parentKeywords = new SpriteBatch(GameBase.Instance.GraphicsDevice);

    public static Texture2D ResizeTexture(Texture2D toResize, Vector2 targetSize)
    {
      RenderTarget2D renderTarget = new RenderTarget2D(GameBase.Instance.GraphicsDevice, (int) targetSize.X, (int) targetSize.Y);
      Rectangle rectangle = new Rectangle(ReferenceInvoker.DisconnectProject(797), ReferenceInvoker.DisconnectProject(801), (int) targetSize.X, (int) targetSize.Y);
      GameBase.Instance.GraphicsDevice.SetRenderTarget(renderTarget);
      GameBase.Instance.GraphicsDevice.Clear(Color.Transparent);
      TextureHelper.parentKeywords.Begin();
      TextureHelper.parentKeywords.Draw(toResize, rectangle, Color.White);
      TextureHelper.parentKeywords.End();
      GameBase.Instance.GraphicsDevice.SetRenderTarget(AssemblyAttribute.parentKeywords);
      return (Texture2D) renderTarget;
    }
  }
}
