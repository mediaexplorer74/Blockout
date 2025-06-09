// Decompiled with JetBrains decompiler
// Type: GameFoundation.MenuItemService
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

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
    private StringBuilder parentKeywords;
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5433));

    public MenuItemService(TimeSpan _param1)
    {
      this.parentKeywords = _param1;
      this.parentKeywords = new StringBuilder(RegistryService.DisconnectProject((object) EditorService.DisconnectProject(5847), (object) _param1.TotalSeconds, (object) EditorService.DisconnectProject(5874)));
      this.parentKeywords[ReferenceInvoker.DisconnectProject(5437)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.White);
    }

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw() => this.parentKeywords;
  }
}
