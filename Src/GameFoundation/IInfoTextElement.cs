// *************************************************************
// Type: GameFoundation.IInfoTextElement
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public interface IInfoTextElement
  {
    KeyValuePair<StringBuilder, Color>[] GetTextToDraw();

    void Update(GameTime gameTime);

    void LoadContent();
  }
}
