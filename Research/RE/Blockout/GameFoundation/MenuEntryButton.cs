// Decompiled with JetBrains decompiler
// Type: GameFoundation.MenuEntryButton
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace GameFoundation
{
  public class MenuEntryButton : MenuEntry
  {
    public bool IsPlayButton;
    public Texture2D TexCustomBackground;
    private static Texture2D parentKeywords = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4601));
    private static Texture2D currentUri = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4648));

    public MenuEntryButton(string text)
      : base(text)
    {
      this.IsPlayButton = ReferenceInvoker.DisconnectProject(4449) != 0;
    }

    public MenuEntryButton(string text, Texture2D customBackgroundTexture)
      : this(text)
    {
      if (customBackgroundTexture == null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntryButton.\u002Ector);
            }
            throw new ArgumentNullException(EditorService.DisconnectProject(4699));
        }
      }
      else
        this.TexCustomBackground = customBackgroundTexture;
    }

    public static void PlayClickSound()
    {
      if (!GameBase.Instance.GameSettings.SoundFxIsOn)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntryButton.PlayClickSound);
          }
          ScreenManager.Instance.SoundClickButtonInstance.Play();
          break;
      }
    }

    public override void Draw(MenuScreen screen)
    {
      if (!this.IsVisible)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntryButton.Draw);
            break;
        }
      }
      else
      {
        Color color1 = WindowOptions.DisconnectProject(Color.White, screen.TransitionAlpha);
        if (this.TexCustomBackground != null)
        {
label_5:
          switch (1)
          {
            case 0:
              goto label_5;
            default:
              SpriteBatch spriteBatch = GameBase.Instance.SpriteBatch;
              Texture2D customBackground = this.TexCustomBackground;
              Vector2 positionDrawing = this.PositionDrawing;
              Rectangle? nullable;
              BookmarkFactory.DisconnectProject(ref nullable);
              Rectangle? sourceRectangle = nullable;
              Color color2 = color1;
              double rotation = (double) ReferenceInvoker.DisconnectProject(4353);
              Vector2 origin = new Vector2(ReferenceInvoker.DisconnectProject(4357), ReferenceInvoker.DisconnectProject(4361));
              double scale = (double) this.Scale;
              int effect = ReferenceInvoker.DisconnectProject(4365);
              double depth = (double) ReferenceInvoker.DisconnectProject(4369);
              spriteBatch.Draw(customBackground, positionDrawing, sourceRectangle, color2, (float) rotation, origin, (float) scale, (SpriteEffects) effect, (float) depth);
              break;
          }
        }
        else if (this.IsPlayButton)
        {
label_8:
          switch (1)
          {
            case 0:
              goto label_8;
            default:
              SpriteBatch spriteBatch = GameBase.Instance.SpriteBatch;
              Texture2D parentKeywords = MenuEntryButton.parentKeywords;
              Vector2 positionDrawing = this.PositionDrawing;
              Rectangle? nullable;
              BookmarkFactory.DisconnectProject(ref nullable);
              Rectangle? sourceRectangle = nullable;
              Color color3 = color1;
              double rotation = (double) ReferenceInvoker.DisconnectProject(4373);
              Vector2 origin = new Vector2(ReferenceInvoker.DisconnectProject(4377), ReferenceInvoker.DisconnectProject(4381));
              double scale = (double) this.Scale;
              int effect = ReferenceInvoker.DisconnectProject(4385);
              double depth = (double) ReferenceInvoker.DisconnectProject(4389);
              spriteBatch.Draw(parentKeywords, positionDrawing, sourceRectangle, color3, (float) rotation, origin, (float) scale, (SpriteEffects) effect, (float) depth);
              break;
          }
        }
        else
        {
          SpriteBatch spriteBatch = GameBase.Instance.SpriteBatch;
          Texture2D currentUri = MenuEntryButton.currentUri;
          Vector2 positionDrawing = this.PositionDrawing;
          Rectangle? nullable;
          BookmarkFactory.DisconnectProject(ref nullable);
          Rectangle? sourceRectangle = nullable;
          Color color4 = color1;
          double rotation = (double) ReferenceInvoker.DisconnectProject(4393);
          Vector2 origin = new Vector2(ReferenceInvoker.DisconnectProject(4397), ReferenceInvoker.DisconnectProject(4401));
          double scale = (double) this.Scale;
          int effect = ReferenceInvoker.DisconnectProject(4405);
          double depth = (double) ReferenceInvoker.DisconnectProject(4409);
          spriteBatch.Draw(currentUri, positionDrawing, sourceRectangle, color4, (float) rotation, origin, (float) scale, (SpriteEffects) effect, (float) depth);
        }
        Vector2 origin1 = new Vector2(ReferenceInvoker.DisconnectProject(4413), (float) (ScreenManager.Instance.MenuFont.LineSpacing / ReferenceInvoker.DisconnectProject(4417)));
        Color color5 = WindowOptions.DisconnectProject(this.ColorText, screen.TransitionAlpha);
        Vector2 position = new Vector2((float) ((double) this.PositionDrawing.X + (double) (this.GetWidth() / ReferenceInvoker.DisconnectProject(4421)) - (double) ScreenManager.Instance.MenuFont.MeasureString(this.Text).X * (double) this.Scale / (double) ReferenceInvoker.DisconnectProject(4425)), (float) ((double) this.PositionDrawing.Y + (double) (this.GetHeight() / ReferenceInvoker.DisconnectProject(4429)) - (double) ScreenManager.Instance.MenuFont.Spacing * (double) this.Scale / (double) ReferenceInvoker.DisconnectProject(4433)));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.Text, position, color5, ReferenceInvoker.DisconnectProject(4437), origin1, this.Scale, (SpriteEffects) ReferenceInvoker.DisconnectProject(4441), ReferenceInvoker.DisconnectProject(4445));
      }
    }

    protected internal override void OnSelectEntry(Point relativeHitPosition)
    {
      if (!this.IsVisible)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntryButton.OnSelectEntry);
          }
          base.OnSelectEntry(relativeHitPosition);
          if (!GameBase.Instance.GameSettings.SoundFxIsOn)
            break;
label_5:
          switch (3)
          {
            case 0:
              goto label_5;
            default:
              ScreenManager.Instance.SoundClickButtonInstance.Play();
              return;
          }
      }
    }

    public override int GetHeight()
    {
      if (this.TexCustomBackground != null)
        return (int) ((double) this.TexCustomBackground.Height * (double) this.Scale);
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntryButton.GetHeight);
          }
          return (int) ((double) MenuEntryButton.currentUri.Height * (double) this.Scale);
      }
    }

    public override int GetWidth()
    {
      if (this.TexCustomBackground != null)
        return (int) ((double) this.TexCustomBackground.Width * (double) this.Scale);
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntryButton.GetWidth);
          }
          return (int) ((double) MenuEntryButton.currentUri.Width * (double) this.Scale);
      }
    }
  }
}
