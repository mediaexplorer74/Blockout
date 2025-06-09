// *************************************************************
// Type: GameFoundation.MessageBoxScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
    public class MessageBoxScreen : GameScreen
    {
        [DataMember]
        public double DeserializeWorkaround;
        private bool parentKeywords1;
        [DataMember]
        public string message;
        private Texture2D parentKeywords;

        public MessageBoxScreen(string message)
          : this(message, ReferenceInvoker.DisconnectProject(4641) != 0)
        {
        }

        public MessageBoxScreen(string message, bool includeUsageText)
        {
            this.LoadContent();
            if (includeUsageText)
            {
                this.message = ResourceSerializer.DisconnectProject(message, EditorService.DisconnectProject(4889));
            }
            else
            {
                this.message = message;
            }
        }

        [OnDeserialized]
        public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

        public override void LoadContent()
        {
            if (this.parentKeywords)
            {
                // No-op block removed as it was unreachable code
            }
            else
            {
                this.parentKeywords = ReferenceInvoker.DisconnectProject(4589) != 0;
                this.IsPopup = ReferenceInvoker.DisconnectProject(4593) != 0;
                this.TransitionOnTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(4597));
                this.TransitionOffTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(4605));
                this.parentKeywords = ScreenManager.Instance.Game.Content.Load<Texture2D>(EditorService.DisconnectProject(4856));
            }
        }

        public override void HandleInput(InputState input)
        {
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteFont menuFont = ScreenManager.Instance.MenuFont;
            ScreenManager.Instance.FadeBackBufferToBlack(this.TransitionAlpha * ReferenceInvoker.DisconnectProject(4613) / ReferenceInvoker.DisconnectProject(4617));
            Viewport viewport = ScreenManager.Instance.GraphicsDevice.Viewport;
            Vector2 vector2_1 = new Vector2((float)viewport.Width, (float)viewport.Height);
            Vector2 vector2_2 = menuFont.MeasureString(this.message);
            Vector2 position = WindowSite.DisconnectProject(SelectionFactory.DisconnectProject(vector2_1, vector2_2), ReferenceInvoker.DisconnectProject(4621));
            Rectangle rectangle = new Rectangle((int)position.X - ReferenceInvoker.DisconnectProject(4625), (int)position.Y - ReferenceInvoker.DisconnectProject(4629), (int)vector2_2.X + ReferenceInvoker.DisconnectProject(4633), (int)vector2_2.Y + ReferenceInvoker.DisconnectProject(4637));
            Color color = WindowOptions.DisconnectProject(Color.White, this.TransitionAlpha);
            GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, rectangle, color);
            GameBase.Instance.SpriteBatch.DrawString(menuFont, this.message, position, color);
        }
    }
}
