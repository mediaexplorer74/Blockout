﻿// *************************************************************
// Type: GameFoundation.InfoText
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#nullable disable
namespace GameFoundation
{
  public class InfoText : DrawableGameComponent
  {
    private const int parentKeywords = 20;
    private List<IInfoTextElement> parentKeywordsList;
    private SpriteFont parentKeywordsSpriteFont;
    private Point parentKeywordsPoint = new Point(ReferenceInvoker.DisconnectProject(5421), 
        ReferenceInvoker.DisconnectProject(5425));

    public InfoText(GameBase game)
      : base((Game) game)
    {
      this.parentKeywordsList = new List<IInfoTextElement>();
      this.parentKeywordsPoint.Y += ReferenceInvoker.DisconnectProject(5429);
    }

    protected override void LoadContent() => base.LoadContent();

    public override void Update(GameTime gameTime) => base.Update(gameTime);

    public override void Draw(GameTime gameTime) => base.Draw(gameTime);

    public void AddElement(IInfoTextElement element) => this.parentKeywordsList.Add(element);
  }
}
