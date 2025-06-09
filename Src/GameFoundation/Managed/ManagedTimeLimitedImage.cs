// *************************************************************
// Type: GameFoundation.Managed.ManagedTimeLimitedImage
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace GameFoundation.Managed
{
  public class ManagedTimeLimitedImage : ManagedTimeLimitedBase
  {
    private double parentKeywordsDouble;
    private double currentUri;
    private double filterID;
    private Texture2D parentKeywordsTexture2D;
    public Rectangle Position;
    private Color parentKeywordsColor;

    public ManagedTimeLimitedImage(string textureName, double millisecondsToBeActive)
      : this(GameBase.Instance.Content.Load<Texture2D>(textureName), millisecondsToBeActive)
    {
    }

    public ManagedTimeLimitedImage(Texture2D texture, double millisecondsToBeActive)
      : base(millisecondsToBeActive)
    {
      this.parentKeywordsDouble = ReferenceInvoker.DisconnectProject(1117);
      this.parentKeywordsTexture2D = texture;
      this.Position.Width = texture.Width;
      this.Position.Height = texture.Height;
    }

    public ManagedTimeLimitedImage(
      string textureName,
      double millisecondsToBeActive,
      double fadeOutPartOfActive)
      : this(GameBase.Instance.Content.Load<Texture2D>(textureName), 
            millisecondsToBeActive, fadeOutPartOfActive)
    {
    }

    public ManagedTimeLimitedImage(
      Texture2D texture,
      double millisecondsToBeActive,
      double fadeOutPartOfActive)
      : base(millisecondsToBeActive)
    {
      this.parentKeywordsDouble = millisecondsToBeActive - fadeOutPartOfActive;
      this.filterID = ReferenceInvoker.DisconnectProject(1125) / fadeOutPartOfActive;
      this.parentKeywordsTexture2D = texture;
      this.Position.Width = texture.Width;
      this.Position.Height = texture.Height;
    }

    public virtual void Start(int startX, int startY, bool centerPosition)
    {
      this.Start();
      this.currentUri = ReferenceInvoker.DisconnectProject(1069);
      this.parentKeywordsColor = 
             WindowOptions.DisconnectProject(
                 new Color(ReferenceInvoker.DisconnectProject(1077), 
                 ReferenceInvoker.DisconnectProject(1081), 
                 ReferenceInvoker.DisconnectProject(1085)), (float) this.currentUri);
      if (!centerPosition)
      {
//label_1:
        //switch (1)
        {
          //case 0:
          //  goto label_1;
          //default:
            if (false)
            {
              base.Start();
            }
            this.Position.X = startX;
            this.Position.Y = startY;
            //break;
        }
      }
      else
      {
        this.Position.X = startX - this.Position.Center.X;
        this.Position.Y = startY - this.Position.Center.Y;
      }
    }

    public override void Update(double elapsedGameTimeMs)
    {
      base.Update(elapsedGameTimeMs);
      if (this.timeActiveElapsed <= this.parentKeywordsDouble)
        return;
      this.currentUri -= this.filterID * Math.Min(elapsedGameTimeMs, 
          this.timeActiveElapsed - this.parentKeywordsDouble);
      if (this.currentUri < ReferenceInvoker.DisconnectProject(1089))
      {
        {
            
              base.Update(elapsedGameTimeMs);
          
            this.currentUri = ReferenceInvoker.DisconnectProject(1097);
        }
      }
      this.parentKeywordsColor = 
                WindowOptions.DisconnectProject(new Color(ReferenceInvoker.DisconnectProject(1105), ReferenceInvoker.DisconnectProject(1109), ReferenceInvoker.DisconnectProject(1113)), (float) this.currentUri);
    }

    public override void Draw()
    {
      GameBase.Instance.SpriteBatch.Draw(
          this.parentKeywordsTexture2D, 
          this.Position, 
          this.parentKeywordsColor);
    }
  }
}
