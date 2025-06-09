// *************************************************************
// Type: GameFoundation.ConnectionType
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace GameFoundation
{
  internal sealed class ConnectionType(string _param1) : MenuEntry(_param1)
  {
    public const int parentKeywords = 0;
    public const int currentUri = 100;
    private const int filterID = 3;
    private const int parentCancel = 3;
    private const int namesID = 4;
    public int currentNode;
    private static Texture2D parentKeywords = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4770));
    private static Texture2D currentUri = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4817));

    public override void Draw(MenuScreen screen)
    {
      if (!this.IsVisible)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ConnectionType.Draw);
            break;
        }
      }
      else
      {
        Color color1 = WindowOptions.DisconnectProject(Color.White, screen.TransitionAlpha);
        SpriteBatch spriteBatch1 = GameBase.Instance.SpriteBatch;
        Texture2D parentKeywords = ConnectionType.parentKeywords;
        Vector2 positionDrawing = this.PositionDrawing;
        Rectangle? nullable1;
        BookmarkFactory.DisconnectProject(ref nullable1);
        Rectangle? sourceRectangle1 = nullable1;
        Color color2 = color1;
        double rotation1 = (double) ReferenceInvoker.DisconnectProject(4453);
        Vector2 origin1 = new Vector2(ReferenceInvoker.DisconnectProject(4457), ReferenceInvoker.DisconnectProject(4461));
        double scale1 = (double) this.Scale;
        int effect1 = ReferenceInvoker.DisconnectProject(4465);
        double depth1 = (double) ReferenceInvoker.DisconnectProject(4469);
        spriteBatch1.Draw(parentKeywords, positionDrawing, sourceRectangle1, color2, (float) rotation1, origin1, (float) scale1, (SpriteEffects) effect1, (float) depth1);
        Color color3 = WindowOptions.DisconnectProject(this.ColorText, screen.TransitionAlpha);
        Vector2 origin2 = new Vector2(ReferenceInvoker.DisconnectProject(4473), (float) ScreenManager.Instance.MenuFont.LineSpacing * this.Scale / ReferenceInvoker.DisconnectProject(4477));
        Vector2 position1 = new Vector2((float) ((double) this.PositionDrawing.X + (double) ConnectionType.parentKeywords.Width * (double) this.Scale / (double) ReferenceInvoker.DisconnectProject(4481) - (double) ScreenManager.Instance.MenuFont.MeasureString(this.Text).X * (double) this.Scale / (double) ReferenceInvoker.DisconnectProject(4485)), (float) ((double) this.PositionDrawing.Y + (double) ConnectionType.parentKeywords.Height * (double) this.Scale / (double) ReferenceInvoker.DisconnectProject(4489) - (double) ScreenManager.Instance.MenuFont.Spacing * (double) this.Scale / (double) ReferenceInvoker.DisconnectProject(4493)));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.Text, position1, color3, ReferenceInvoker.DisconnectProject(4497), origin2, this.Scale, (SpriteEffects) ReferenceInvoker.DisconnectProject(4501), ReferenceInvoker.DisconnectProject(4505));
        Vector2 vector2 = new Vector2(this.PositionDrawing.X + ReferenceInvoker.DisconnectProject(4509) + this.DisconnectProject(), this.PositionDrawing.Y + ReferenceInvoker.DisconnectProject(4513));
        SpriteBatch spriteBatch2 = GameBase.Instance.SpriteBatch;
        Texture2D currentUri = ConnectionType.currentUri;
        Vector2 position2 = vector2;
        Rectangle? nullable2;
        BookmarkFactory.DisconnectProject(ref nullable2);
        Rectangle? sourceRectangle2 = nullable2;
        Color color4 = color1;
        double rotation2 = (double) ReferenceInvoker.DisconnectProject(4517);
        Vector2 origin3 = new Vector2(ReferenceInvoker.DisconnectProject(4521), ReferenceInvoker.DisconnectProject(4525));
        double scale2 = (double) this.Scale;
        int effect2 = ReferenceInvoker.DisconnectProject(4529);
        double depth2 = (double) ReferenceInvoker.DisconnectProject(4533);
        spriteBatch2.Draw(currentUri, position2, sourceRectangle2, color4, (float) rotation2, origin3, (float) scale2, (SpriteEffects) effect2, (float) depth2);
      }
    }

    private float DisconnectProject()
    {
      return (float) (int) ((double) this.GetWidth() - (double) (ReferenceInvoker.DisconnectProject(4537) + ConnectionType.currentUri.Width) * (double) this.Scale) / ReferenceInvoker.DisconnectProject(4541) * (float) this.currentNode;
    }

    public void DisconnectProject(int _param1)
    {
      double num1 = (double) ConnectionType.currentUri.Width * (double) this.Scale / ReferenceInvoker.DisconnectProject(4545);
      double num2 = (double) _param1 - ((double) ReferenceInvoker.DisconnectProject(4553) * (double) this.Scale + num1 * (double) this.Scale);
      double num3 = (double) this.GetWidth() - ((double) ReferenceInvoker.DisconnectProject(4557) * (double) this.Scale + (double) ReferenceInvoker.DisconnectProject(4561) * (double) this.Scale + (double) ConnectionType.currentUri.Width * (double) this.Scale);
      if (num2 <= ReferenceInvoker.DisconnectProject(4565))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ConnectionType.DisconnectProject);
            }
            this.currentNode = ReferenceInvoker.DisconnectProject(4573);
            break;
        }
      }
      else if (num2 >= num3)
      {
label_6:
        switch (3)
        {
          case 0:
            goto label_6;
          default:
            this.currentNode = ReferenceInvoker.DisconnectProject(4577);
            break;
        }
      }
      else
      {
        double num4 = num2 / num3;
        this.currentNode = (int) (ReferenceInvoker.DisconnectProject(4581) * num4);
      }
    }

    public override int GetHeight()
    {
      return (int) ((double) ConnectionType.parentKeywords.Height * (double) this.Scale);
    }

    public override int GetWidth()
    {
      return (int) ((double) ConnectionType.parentKeywords.Width * (double) this.Scale);
    }
  }
}
