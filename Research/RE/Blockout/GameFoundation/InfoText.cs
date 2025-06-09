// Decompiled with JetBrains decompiler
// Type: GameFoundation.InfoText
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#nullable disable
namespace GameFoundation
{
  public class InfoText : DrawableGameComponent
  {
    private const int parentKeywords = 20;
    private List<IInfoTextElement> parentKeywords;
    private SpriteFont parentKeywords;
    private Point parentKeywords = new Point(ReferenceInvoker.DisconnectProject(5421), ReferenceInvoker.DisconnectProject(5425));

    public InfoText(GameBase game)
      : base((Game) game)
    {
      this.parentKeywords = new List<IInfoTextElement>();
      this.parentKeywords.Y += ReferenceInvoker.DisconnectProject(5429);
    }

    protected override void LoadContent() => base.LoadContent();

    public override void Update(GameTime gameTime) => base.Update(gameTime);

    public override void Draw(GameTime gameTime) => base.Draw(gameTime);

    public void AddElement(IInfoTextElement element) => this.parentKeywords.Add(element);
  }
}
