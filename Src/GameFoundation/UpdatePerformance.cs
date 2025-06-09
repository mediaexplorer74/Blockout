// *************************************************************
// Type: GameFoundation.UpdatePerformance
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
    public class UpdatePerformance : IInfoTextElement
    {
        private const double parentKeywords = 1000.0;
        private const double currentUri = 40.0;
        private double[] parentKeywordsDoubleA;
        private int parentKeywordsInt;
        private double[] currentUriDouble;
        private int currentUriInt;
        private double filterIDDouble;
        private int filterIDInt;
        private int parentCancel;
        private int namesID;
        private int currentNode;
        private DateTime parentKeywordsDateTime;
        private StringBuilder parentKeywords9 = new StringBuilder(EditorService.DisconnectProject(6247));
        private StringBuilder currentUri10 = new StringBuilder(EditorService.DisconnectProject(6279));
        private KeyValuePair<StringBuilder, Color>[] parentKeywords11 = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5741));

        public UpdatePerformance()
        {
            this.parentKeywordsDoubleA = DomainResolver.DisconnectProject(ReferenceInvoker.DisconnectProject(5745));
            for (int index = ReferenceInvoker.DisconnectProject(5749); index < (int)LineSettings.DisconnectProject(this.parentKeywords); index += ReferenceInvoker.DisconnectProject(5761))
                this.parentKeywordsDoubleA[index] = ReferenceInvoker.DisconnectProject(5753);

            this.currentUriDouble = DomainResolver.DisconnectProject(ReferenceInvoker.DisconnectProject(5765));
            for (int index = ReferenceInvoker.DisconnectProject(5769); index < (int)LineSettings.DisconnectProject(this.currentUri); index += ReferenceInvoker.DisconnectProject(5781))
                this.currentUriDouble[index] = ReferenceInvoker.DisconnectProject(5773);

            this.parentKeywordsDateTime = DateTime.Now;
        }

        public void LoadContent()
        {
        }

        public void Update(GameTime gameTime)
        {
            this.filterIDDouble += gameTime.ElapsedGameTime.TotalMilliseconds;
            this.parentKeywords[this.parentKeywords] = gameTime.ElapsedGameTime.TotalMilliseconds;
            this.parentKeywords += ReferenceInvoker.DisconnectProject(5605);
            if (this.filterID < ReferenceInvoker.DisconnectProject(5609))
                return;

            this.filterID -= ReferenceInvoker.DisconnectProject(5617);
            double num1 = ReferenceInvoker.DisconnectProject(5625);
            this.filterID = ReferenceInvoker.DisconnectProject(5633);
            for (int index = ReferenceInvoker.DisconnectProject(5637); index < this.parentKeywords; index += ReferenceInvoker.DisconnectProject(5657))
            {
                if (this.parentKeywords[index] >= ReferenceInvoker.DisconnectProject(5641))
                {
                    num1 += this.parentKeywords[index];
                    this.filterID = (int)Math.Max((double)this.filterID, this.parentKeywords[index]);
                    this.parentKeywords[index] = ReferenceInvoker.DisconnectProject(5649);
                }
            }

            this.parentCancel = (int)Math.Round(num1 / (double)this.parentKeywords);
            this.parentKeywords = ReferenceInvoker.DisconnectProject(5661);
            double num2 = ReferenceInvoker.DisconnectProject(5665);
            this.namesID = ReferenceInvoker.DisconnectProject(5673);
            for (int index = ReferenceInvoker.DisconnectProject(5677); index < this.currentUri; index += ReferenceInvoker.DisconnectProject(5697))
            {
                if (this.currentUri[index] >= ReferenceInvoker.DisconnectProject(5681))
                {
                    num2 += this.currentUri[index];
                    this.namesID = (int)Math.Max((double)this.namesID, this.currentUri[index]);
                    this.currentUri[index] = ReferenceInvoker.DisconnectProject(5689);
                }
            }

            this.currentNode = (int)Math.Round(num2 / (double)this.currentUri);
            this.currentUri = ReferenceInvoker.DisconnectProject(5701);
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
            if ((double)this.namesID >= ReferenceInvoker.DisconnectProject(5709))
                this.parentKeywords[ReferenceInvoker.DisconnectProject(5717)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
            else
                this.parentKeywords[ReferenceInvoker.DisconnectProject(5721)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.White);
            if ((double)this.filterID >= ReferenceInvoker.DisconnectProject(5725))
            {
                this.parentKeywords[ReferenceInvoker.DisconnectProject(5733)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.Red);
            }
            else
                this.parentKeywords[ReferenceInvoker.DisconnectProject(5737)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.White);
            return this.parentKeywords;
        }
    }
}
