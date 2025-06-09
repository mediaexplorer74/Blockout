// Decompiled with JetBrains decompiler
// Type: GameFoundation.UpdatePerformance
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
  public class UpdatePerformance : IInfoTextElement
  {
    private const double parentKeywords = 1000.0;
    private const double currentUri = 40.0;
    private double[] parentKeywords;
    private int parentKeywords;
    private double[] currentUri;
    private int currentUri;
    private double filterID;
    private int filterID;
    private int parentCancel;
    private int namesID;
    private int currentNode;
    private DateTime parentKeywords;
    private StringBuilder parentKeywords = new StringBuilder(EditorService.DisconnectProject(6247));
    private StringBuilder currentUri = new StringBuilder(EditorService.DisconnectProject(6279));
    private KeyValuePair<StringBuilder, Color>[] parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5741));

    public UpdatePerformance()
    {
      this.parentKeywords = DomainResolver.DisconnectProject(ReferenceInvoker.DisconnectProject(5745));
      for (int index = ReferenceInvoker.DisconnectProject(5749); index < (int) LineSettings.DisconnectProject(this.parentKeywords); index += ReferenceInvoker.DisconnectProject(5761))
        this.parentKeywords[index] = ReferenceInvoker.DisconnectProject(5753);
label_3:
      switch (1)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (UpdatePerformance.\u002Ector);
          }
          this.currentUri = DomainResolver.DisconnectProject(ReferenceInvoker.DisconnectProject(5765));
          for (int index = ReferenceInvoker.DisconnectProject(5769); index < (int) LineSettings.DisconnectProject(this.currentUri); index += ReferenceInvoker.DisconnectProject(5781))
            this.currentUri[index] = ReferenceInvoker.DisconnectProject(5773);
label_9:
          switch (4)
          {
            case 0:
              goto label_9;
            default:
              this.parentKeywords = DateTime.Now;
              return;
          }
      }
    }

    public void LoadContent()
    {
    }

    public void Update(GameTime gameTime)
    {
      this.filterID += gameTime.ElapsedGameTime.TotalMilliseconds;
      this.parentKeywords[this.parentKeywords] = gameTime.ElapsedGameTime.TotalMilliseconds;
      this.parentKeywords += ReferenceInvoker.DisconnectProject(5605);
      if (this.filterID < ReferenceInvoker.DisconnectProject(5609))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (UpdatePerformance.Update);
          }
          this.filterID -= ReferenceInvoker.DisconnectProject(5617);
          double num1 = ReferenceInvoker.DisconnectProject(5625);
          this.filterID = ReferenceInvoker.DisconnectProject(5633);
          for (int index = ReferenceInvoker.DisconnectProject(5637); index < this.parentKeywords; index += ReferenceInvoker.DisconnectProject(5657))
          {
            if (this.parentKeywords[index] >= ReferenceInvoker.DisconnectProject(5641))
            {
label_6:
              switch (5)
              {
                case 0:
                  goto label_6;
                default:
                  num1 += this.parentKeywords[index];
                  this.filterID = (int) Math.Max((double) this.filterID, this.parentKeywords[index]);
                  this.parentKeywords[index] = ReferenceInvoker.DisconnectProject(5649);
                  continue;
              }
            }
          }
label_10:
          switch (4)
          {
            case 0:
              goto label_10;
            default:
              this.parentCancel = (int) Math.Round(num1 / (double) this.parentKeywords);
              this.parentKeywords = ReferenceInvoker.DisconnectProject(5661);
              double num2 = ReferenceInvoker.DisconnectProject(5665);
              this.namesID = ReferenceInvoker.DisconnectProject(5673);
              for (int index = ReferenceInvoker.DisconnectProject(5677); index < this.currentUri; index += ReferenceInvoker.DisconnectProject(5697))
              {
                if (this.currentUri[index] >= ReferenceInvoker.DisconnectProject(5681))
                {
label_13:
                  switch (4)
                  {
                    case 0:
                      goto label_13;
                    default:
                      num2 += this.currentUri[index];
                      this.namesID = (int) Math.Max((double) this.namesID, this.currentUri[index]);
                      this.currentUri[index] = ReferenceInvoker.DisconnectProject(5689);
                      continue;
                  }
                }
              }
label_17:
              switch (2)
              {
                case 0:
                  goto label_17;
                default:
                  this.currentNode = (int) Math.Round(num2 / (double) this.currentUri);
                  this.currentUri = ReferenceInvoker.DisconnectProject(5701);
                  return;
              }
          }
      }
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      DateTime now = DateTime.Now;
      this.currentUri[this.currentUri] = MethodTree.DisconnectProject(now, this.parentKeywords).TotalMilliseconds;
      this.currentUri += ReferenceInvoker.DisconnectProject(5705);
      this.parentKeywords = now;
      this.parentKeywords.Remove(EditorService.DisconnectProject(6247).Length, this.parentKeywords.Length - EditorService.DisconnectProject(6247).Length);
      this.parentKeywords.Concat(this.currentNode);
      this.parentKeywords.Append(EditorService.DisconnectProject(6276));
      this.parentKeywords.Concat(this.namesID);
      this.currentUri.Remove(EditorService.DisconnectProject(6279).Length, this.currentUri.Length - EditorService.DisconnectProject(6279).Length);
      this.currentUri.Concat(this.parentCancel);
      this.currentUri.Append(EditorService.DisconnectProject(6276));
      this.currentUri.Concat(this.filterID);
      if ((double) this.namesID >= ReferenceInvoker.DisconnectProject(5709))
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5717)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5721)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.White);
      if ((double) this.filterID >= ReferenceInvoker.DisconnectProject(5725))
      {
label_4:
        switch (5)
        {
          case 0:
            goto label_4;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (UpdatePerformance.GetTextToDraw);
            }
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5733)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5737)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.White);
      return this.parentKeywords;
    }
  }
}
