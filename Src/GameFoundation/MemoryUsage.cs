// *************************************************************
// Type: GameFoundation.MemoryUsage
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using GameFoundation.GameFoundation;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public class MemoryUsage : IInfoTextElement
  {
    private const int parentKeywordsInt = 100;
    private const int currentUriInt = 80;
    private long parentKeywordsLong;
    private long currentUriLong;
    private double parentKeywordsDouble;
    private StringBuilder parentKeywordsStringBuilder = new StringBuilder(EditorService.DisconnectProject(6119));
    private StringBuilder currentUriStringBuilder = new StringBuilder(EditorService.DisconnectProject(6136));
    private KeyValuePair<StringBuilder, Color>[] parentKeywordsKeyValuePair = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5481));

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      this.parentKeywordsDouble += gameTime.ElapsedGameTime.TotalMilliseconds;
      if (this.parentKeywordsDouble >= ReferenceInvoker.DisconnectProject(5441))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {              
              this.Update(gameTime);
            }
            this.parentKeywordsDouble -= ReferenceInvoker.DisconnectProject(5449);
            try
            {
              this.parentKeywordsDouble = PlatformHelper.DisconnectProject((long)0);
              this.currentUriLong = PlatformHelper.DisposeDrive();
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
      this.parentKeywordsStringBuilder.Remove(EditorService.DisconnectProject(6087).Length, 
          this.parentKeywordsStringBuilder.Length - EditorService.DisconnectProject(6087).Length);
      this.parentKeywordsStringBuilder.Concat((float) this.parentKeywordsDouble);
      this.currentUriStringBuilder.Remove(EditorService.DisconnectProject(6098).Length, 
          this.currentUriStringBuilder.Length - EditorService.DisconnectProject(6098).Length);
      this.currentUriStringBuilder.Concat((float) this.currentUriLong);
      if (this.parentKeywordsLong >= (long) ReferenceInvoker.DisconnectProject(5457))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              this.GetTextToDraw();
            }
            this.parentKeywordsKeyValuePair[ReferenceInvoker.DisconnectProject(5461)] 
                            = new KeyValuePair<StringBuilder, Color>(this.parentKeywordsStringBuilder, Color.Red);
            break;
        }
      }
      else
        this.parentKeywordsKeyValuePair[ReferenceInvoker.DisconnectProject(5465)] = 
                    new KeyValuePair<StringBuilder, Color>(this.parentKeywordsStringBuilder, Color.White);
      if (this.currentUriLong >= (long) ReferenceInvoker.DisconnectProject(5469))
        this.parentKeywordsKeyValuePair[ReferenceInvoker.DisconnectProject(5473)] = 
                    new KeyValuePair<StringBuilder, Color>(this.currentUriStringBuilder, Color.Red);
      else
        this.parentKeywordsKeyValuePair[ReferenceInvoker.DisconnectProject(5477)] = 
                    new KeyValuePair<StringBuilder, Color>(this.currentUriStringBuilder, Color.White);
      return parentKeywordsKeyValuePair;
    }
  }
}
