// *************************************************************
// Type: GameFoundation.MemoryUsage
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
  public class MemoryUsage : IInfoTextElement
  {
    private const int parentKeywords = 100;
    private const int currentUri = 80;
    private long parentKeywords;
    private long currentUri;
    private double parentKeywords;
    private StringBuilder parentKeywords = new StringBuilder(EditorService.DisconnectProject(6119));
    private StringBuilder currentUri = new StringBuilder(EditorService.DisconnectProject(6136));
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5481));

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      this.parentKeywords += gameTime.ElapsedGameTime.TotalMilliseconds;
      if (this.parentKeywords >= ReferenceInvoker.DisconnectProject(5441))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MemoryUsage.Update);
            }
            this.parentKeywords -= ReferenceInvoker.DisconnectProject(5449);
            try
            {
              this.parentKeywords = PlatformHelper.DisconnectProject();
              this.currentUri = PlatformHelper.DisposeDrive();
              break;
            }
            catch (Exception ex)
            {
              break;
            }
        }
      }
      throw new Exception(EditorService.DisconnectProject(5877));
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      this.parentKeywords.Remove(EditorService.DisconnectProject(6087).Length, this.parentKeywords.Length - EditorService.DisconnectProject(6087).Length);
      this.parentKeywords.Concat((float) this.parentKeywords);
      this.currentUri.Remove(EditorService.DisconnectProject(6098).Length, this.currentUri.Length - EditorService.DisconnectProject(6098).Length);
      this.currentUri.Concat((float) this.currentUri);
      if (this.parentKeywords >= (long) ReferenceInvoker.DisconnectProject(5457))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MemoryUsage.GetTextToDraw);
            }
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5461)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5465)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.White);
      if (this.currentUri >= (long) ReferenceInvoker.DisconnectProject(5469))
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5473)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.Red);
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5477)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.White);
      return this.parentKeywords;
    }
  }
}
