// *************************************************************
// Type: GameFoundation.QueueSet
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
  internal sealed class QueueSet : IInfoTextElement
  {
    private const int parentKeywords = 500;
    private bool parentKeywords;
    private double parentKeywords;
    private WeakReference parentKeywords = new WeakReference(new object());
    private int currentUri;
    private StringBuilder parentKeywords = new StringBuilder(ReferenceInvoker.DisconnectProject(5413));
    private StringBuilder currentUri = new StringBuilder(EditorService.DisconnectProject(5719));
    private StringBuilder filterID = new StringBuilder(EditorService.DisconnectProject(5784));
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5417));

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      if (!this.parentKeywords.IsAlive)
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (QueueSet.Update);
            }
            this.parentKeywords = ReferenceInvoker.DisconnectProject(5377) != 0;
            this.parentKeywords = ReferenceInvoker.DisconnectProject(5381);
            this.parentKeywords = new WeakReference(new object());
            this.currentUri += ReferenceInvoker.DisconnectProject(5389);
            break;
        }
      }
      else if (this.parentKeywords > ReferenceInvoker.DisconnectProject(5393))
      {
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            this.parentKeywords -= gameTime.ElapsedGameTime.TotalMilliseconds;
            break;
        }
      }
      else
        this.parentKeywords = ReferenceInvoker.DisconnectProject(5401) != 0;
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      if (this.parentKeywords)
      {
        this.currentUri.Remove(EditorService.DisconnectProject(5631).Length, this.currentUri.Length - EditorService.DisconnectProject(5631).Length);
        this.currentUri.Concat(this.currentUri);
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5405)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.Red);
      }
      else
      {
        this.filterID.Remove(EditorService.DisconnectProject(5676).Length, this.filterID.Length - EditorService.DisconnectProject(5676).Length);
        this.filterID.Concat(this.currentUri);
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5409)] = new KeyValuePair<StringBuilder, Color>(this.filterID, Color.White);
      }
      return this.parentKeywords;
    }
  }
}
