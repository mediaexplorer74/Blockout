// *************************************************************
// Type: GameFoundation.MenuEntryButton
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

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
                throw new ArgumentNullException(EditorService.DisconnectProject(4699));
            }
            else
            {
                this.TexCustomBackground = customBackgroundTexture;
            }
        }

        public static void PlayClickSound()
        {
            if (!GameBase.Instance.GameSettings.SoundFxIsOn)
                return;

            ScreenManager.Instance.SoundClickButtonInstance.Play();
        }

        public override void Draw(MenuScreen screen)
        {
            if (!this.IsVisible)
                return;

            Color color1 = WindowOptions.DisconnectProject(Color.White, screen.TransitionAlpha);
            SpriteBatch spriteBatch = GameBase.Instance.SpriteBatch;

            if (this.TexCustomBackground != null)
            {
                spriteBatch.Draw(
                  this.TexCustomBackground,
                  this.PositionDrawing,
                  null,
                  color1,
                  0f,
                  new Vector2(0, 0),
                  this.Scale,
                  SpriteEffects.None,
                  0f
                );
            }
            else if (this.IsPlayButton)
            {
                spriteBatch.Draw(
                  MenuEntryButton.parentKeywords,
                  this.PositionDrawing,
                  null,
                  color1,
                  0f,
                  new Vector2(0, 0),
                  this.Scale,
                  SpriteEffects.None,
                  0f
                );
            }
            else
            {
                spriteBatch.Draw(
                  MenuEntryButton.currentUri,
                  this.PositionDrawing,
                  null,
                  color1,
                  0f,
                  new Vector2(0, 0),
                  this.Scale,
                  SpriteEffects.None,
                  0f
                );
            }

            Vector2 origin1 = new Vector2(0, ScreenManager.Instance.MenuFont.LineSpacing / 2);
            Color color5 = WindowOptions.DisconnectProject(this.ColorText, screen.TransitionAlpha);
            Vector2 position = new Vector2(
              this.PositionDrawing.X + (this.GetWidth() / 2) - ScreenManager.Instance.MenuFont.MeasureString(this.Text).X * this.Scale / 2,
              this.PositionDrawing.Y + (this.GetHeight() / 2) - ScreenManager.Instance.MenuFont.Spacing * this.Scale / 2
            );

            spriteBatch.DrawString(
              ScreenManager.Instance.MenuFont,
              this.Text,
              position,
              color5,
              0f,
              origin1,
              this.Scale,
              SpriteEffects.None,
              0f
            );
        }

        protected internal override void OnSelectEntry(Point relativeHitPosition)
        {
            if (!this.IsVisible)
                return;

            base.OnSelectEntry(relativeHitPosition);

            if (GameBase.Instance.GameSettings.SoundFxIsOn)
            {
                ScreenManager.Instance.SoundClickButtonInstance.Play();
            }
        }

        public override int GetHeight()
        {
            return this.TexCustomBackground != null
              ? (int)(this.TexCustomBackground.Height * this.Scale)
              : (int)(MenuEntryButton.currentUri.Height * this.Scale);
        }

        public override int GetWidth()
        {
            return this.TexCustomBackground != null
              ? (int)(this.TexCustomBackground.Width * this.Scale)
              : (int)(MenuEntryButton.currentUri.Width * this.Scale);
        }
    }
}
