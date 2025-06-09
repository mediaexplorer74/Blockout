// Decompiled with JetBrains decompiler
// Type: GameFoundation.FrameRateCounter
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
  public class FrameRateCounter : IInfoTextElement
  {
    private const int parentKeywords = 28;
    private int currentUri;
    private int filterID;
    private TimeSpan parentKeywords = TimeSpan.Zero;
    private StringBuilder parentKeywords = new StringBuilder(EditorService.DisconnectProject(5616));
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5373));

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      FrameRateCounter frameRateCounter1 = this;
      frameRateCounter1.parentKeywords = DeviceSite.DisconnectProject(frameRateCounter1.parentKeywords, gameTime.ElapsedGameTime);
      if (!XmlFileLoader.DisconnectProject(this.parentKeywords, TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(5337))))
        return;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (FrameRateCounter.Update);
          }
          FrameRateCounter frameRateCounter2 = this;
          frameRateCounter2.parentKeywords = PartitionSite.DisconnectProject(frameRateCounter2.parentKeywords, TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(5345)));
          this.currentUri = this.filterID;
          this.filterID = ReferenceInvoker.DisconnectProject(5353);
          break;
      }
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      this.filterID += ReferenceInvoker.DisconnectProject(5357);
      this.parentKeywords.Remove(EditorService.DisconnectProject(5605).Length, this.parentKeywords.Length - EditorService.DisconnectProject(5605).Length);
      this.parentKeywords.Concat(this.currentUri);
      if (this.currentUri <= ReferenceInvoker.DisconnectProject(5361))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (FrameRateCounter.GetTextToDraw);
            }
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5365)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5369)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.White);
      return this.parentKeywords;
    }
  }
}
