// Decompiled with JetBrains decompiler
// Type: GameFoundation.SlowdownCounter
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public class SlowdownCounter : IInfoTextElement
  {
    private const int parentKeywords = 100;
    private const double parentKeywords = 5000.0;
    private const int currentUri = 2000;
    private bool parentKeywords;
    private int filterID;
    private DateTime parentKeywords;
    private List<double> parentKeywords;
    private double currentUri;
    private double filterID;
    private StringBuilder parentKeywords = new StringBuilder(EditorService.DisconnectProject(6215));
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5593));

    public SlowdownCounter()
    {
      this.currentUri = ReferenceInvoker.DisconnectProject(5597);
      this.parentKeywords = new List<double>();
      this.DisconnectProject();
    }

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      if (this.filterID > ReferenceInvoker.DisconnectProject(5521))
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SlowdownCounter.Update);
            }
            this.filterID -= gameTime.ElapsedGameTime.TotalMilliseconds;
            break;
        }
      }
      if (this.currentUri > ReferenceInvoker.DisconnectProject(5529))
      {
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
          default:
            this.currentUri -= gameTime.ElapsedGameTime.TotalMilliseconds;
            this.parentKeywords = DateTime.Now;
            break;
        }
      }
      else
      {
        TimeSpan timeSpan = MethodTree.DisconnectProject(DateTime.Now, this.parentKeywords);
        this.parentKeywords = DateTime.Now;
        if (timeSpan.TotalMilliseconds >= ReferenceInvoker.DisconnectProject(5537))
        {
          if (this.parentKeywords)
            return;
          this.parentKeywords = ReferenceInvoker.DisconnectProject(5545) != 0;
          this.filterID += ReferenceInvoker.DisconnectProject(5549);
          this.parentKeywords.Add(timeSpan.TotalMilliseconds);
          this.filterID = ReferenceInvoker.DisconnectProject(5553);
          this.DisconnectProject();
        }
        else
          this.parentKeywords = ReferenceInvoker.DisconnectProject(5561) != 0;
      }
    }

    private void DisconnectProject()
    {
      this.parentKeywords.Remove(EditorService.DisconnectProject(6215).Length, this.parentKeywords.Length - EditorService.DisconnectProject(6215).Length);
      this.parentKeywords.Concat(this.filterID);
      this.parentKeywords.Append(EditorService.DisconnectProject(6236));
      float float_val = ReferenceInvoker.DisconnectProject(5565);
      if (this.parentKeywords.Count > ReferenceInvoker.DisconnectProject(5569))
        float_val = (float) Math.Round(this.parentKeywords.Average(), ReferenceInvoker.DisconnectProject(5573));
      this.parentKeywords.Concat(float_val);
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      if (this.filterID > ReferenceInvoker.DisconnectProject(5577))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SlowdownCounter.GetTextToDraw);
            }
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5585)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5589)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.White);
      return this.parentKeywords;
    }
  }
}
