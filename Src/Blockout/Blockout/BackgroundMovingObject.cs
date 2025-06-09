// *************************************************************
// Type: Blockout.BackgroundMovingObject
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace Blockout
{
    public class BackgroundMovingObject
    {
        private Texture2D parentKeywords;
        public Rectangle Pos;
        public bool IsActive;

        public BackgroundMovingObject(Texture2D texToUse)
        {
            if (texToUse == null)
            {
                // Removed problematic code causing errors
                throw new ArgumentNullException(nameof(texToUse), "Texture cannot be null.");
            }
            else
            {
                this.parentKeywords = texToUse;
                this.Pos.Width = this.parentKeywords.Width;
                this.Pos.Height = this.parentKeywords.Height;
            }
        }

        public void Start(Vector2 startPosition)
        {
            this.Pos.X = (int)startPosition.X;
            this.Pos.Y = (int)startPosition.Y;
            this.IsActive = ClientTree.DisconnectProject(1476) != 0;
        }

        public void Start()
        {
            this.Pos.X = RandomManager.Rnd.Next(GameplayScreenBase.BoundsGame.X - this.parentKeywords.Width + ClientTree.DisconnectProject(1480), GameplayScreenBase.BoundsGame.X2() - ClientTree.DisconnectProject(1484));
            this.Pos.Y = RandomManager.Rnd.Next(GameplayScreenBase.BoundsGame.Y - this.parentKeywords.Height + ClientTree.DisconnectProject(1488), GameplayScreenBase.BoundsGame.Y2() - ClientTree.DisconnectProject(1492));
            this.IsActive = ClientTree.DisconnectProject(1496) != 0;
        }

        public void Update()
        {
            if (!this.IsActive)
                return;

            //TODO
            //if (this.Pos.X2() >= ScreenManager.BoundsScreen.X && this.Pos.X <= ScreenManager.BoundsScreen.X2())
            //{
            //    if (this.Pos.Y2() >= ScreenManager.BoundsScreen.Y && this.Pos.Y <= ScreenManager.BoundsScreen.Y2())
            //        return;
            //}
            this.IsActive = ClientTree.DisconnectProject(1500) != 0;
        }

        public void Draw()
        {
            if (!this.IsActive)
                return;

            //TODO
            //GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, this.Pos, Color.White);
        }
    }
}
