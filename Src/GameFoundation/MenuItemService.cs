// *************************************************************
// Type: GameFoundation.MenuItemService
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace GameFoundation
{
  internal sealed class MenuItemService : IInfoTextElement
  {
    private TimeSpan parentKeywords;
    private StringBuilder parentKeywordsStringBuilder;
    private KeyValuePair<StringBuilder, Color>[] parentKeywordsKeyValuePair 
            = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5433));

    public MenuItemService(TimeSpan _param1)
    {
      this.parentKeywords = _param1;
      this.parentKeywordsStringBuilder = new StringBuilder(RegistryService.DisconnectProject((object) EditorService.DisconnectProject(5847), (object) _param1.TotalSeconds, (object) EditorService.DisconnectProject(5874)));
      this.parentKeywordsKeyValuePair[ReferenceInvoker.DisconnectProject(5437)] 
                = new KeyValuePair<StringBuilder, Color>(this.parentKeywordsStringBuilder, Color.White);
    }

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw() => this.parentKeywordsKeyValuePair;
  }
}
