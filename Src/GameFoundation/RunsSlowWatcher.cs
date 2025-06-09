// *************************************************************
// Type: GameFoundation.RunsSlowWatcher
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
  public class RunsSlowWatcher : IInfoTextElement
  {
    private const int parentKeywords = 2000;
    private bool parentKeywords;
    private double parentKeywords;
    private StringBuilder parentKeywords = new StringBuilder(EditorService.DisconnectProject(6163));
    private StringBuilder currentUri = new StringBuilder(EditorService.DisconnectProject(6190));
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5517));

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      if (gameTime.IsRunningSlowly)
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(5485) != 0;
        this.parentKeywords = ReferenceInvoker.DisconnectProject(5489);
      }
      else if (this.parentKeywords > ReferenceInvoker.DisconnectProject(5497))
      {
label_3:
        switch (5)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (RunsSlowWatcher.Update);
            }
            this.parentKeywords -= gameTime.ElapsedGameTime.TotalMilliseconds;
            break;
        }
      }
      else
        this.parentKeywords = ReferenceInvoker.DisconnectProject(5505) != 0;
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      if (this.parentKeywords)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (RunsSlowWatcher.GetTextToDraw);
            }
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5509)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5513)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.White);
      return this.parentKeywords;
    }
  }
}
