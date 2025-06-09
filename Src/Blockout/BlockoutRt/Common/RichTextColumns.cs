// *************************************************************
// Type: BlockoutRt.Common.RichTextColumns
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Blockout;
using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace BlockoutRt.Common
{
  [ContentProperty(Name = "RichTextContent")]
  public sealed class RichTextColumns : Panel
  {
    public static readonly DependencyProperty RichTextContentProperty = DependencyProperty.Register(DatabaseLoader.DisconnectProject(12877), Type.GetTypeFromHandle(DatabaseTree.DisconnectProject()), Type.GetTypeFromHandle(StoreList.DisconnectProject()), new PropertyMetadata((object) null, new PropertyChangedCallback(RichTextColumns.DisconnectProject)));
    public static readonly DependencyProperty ColumnTemplateProperty = DependencyProperty.Register(DatabaseLoader.DisconnectProject(12908), Type.GetTypeFromHandle(BuilderFactory.DisconnectProject()), Type.GetTypeFromHandle(StoreList.DisconnectProject()), new PropertyMetadata((object) null, new PropertyChangedCallback(RichTextColumns.DisconnectProject)));
    private List<RichTextBlockOverflow> parentKeywords;

    public RichTextColumns()
    {
      ((FrameworkElement) this).put_HorizontalAlignment((HorizontalAlignment) ClientTree.DisconnectProject(1984713));
    }

    public RichTextBlock RichTextContent
    {
      get
      {
        return ReferenceOptions.DisconnectProject(((DependencyObject) this).GetValue(RichTextColumns.RichTextContentProperty));
      }
      set
      {
        ((DependencyObject) this).SetValue(RichTextColumns.RichTextContentProperty, (object) value);
      }
    }

    public DataTemplate ColumnTemplate
    {
      get
      {
        return PathDesigner.DisconnectProject(((DependencyObject) this).GetValue(RichTextColumns.ColumnTemplateProperty));
      }
      set
      {
        ((DependencyObject) this).SetValue(RichTextColumns.ColumnTemplateProperty, (object) value);
      }
    }

    private static void DisconnectProject(
      DependencyObject _param0,
      DependencyPropertyChangedEventArgs _param1)
    {
      RichTextColumns richTextColumns = ClientSerializer.DisconnectProject((object) _param0);
      if (richTextColumns == null)
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (RichTextColumns.DisconnectProject);
          }
          richTextColumns.parentKeywords = ActionContext.parentKeywords;
          ((ICollection<UIElement>) richTextColumns.Children).Clear();
          ((UIElement) richTextColumns).InvalidateMeasure();
          break;
      }
    }

    protected virtual Size MeasureOverride(Size availableSize)
    {
      if (this.RichTextContent == null)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (RichTextColumns.MeasureOverride);
            }
            return new Size(ClientTree.DisconnectProject(1984653), ClientTree.DisconnectProject(1984661));
        }
      }
      else
      {
        if (this.parentKeywords == null)
        {
          ((ICollection<UIElement>) this.Children).Add((UIElement) this.RichTextContent);
          this.parentKeywords = new List<RichTextBlockOverflow>();
        }
        ((UIElement) this.RichTextContent).Measure(availableSize);
        double width = ((UIElement) this.RichTextContent).DesiredSize.Width;
        double num = ((UIElement) this.RichTextContent).DesiredSize.Height;
        bool hasOverflowContent = this.RichTextContent.HasOverflowContent;
        int index = ClientTree.DisconnectProject(1984669);
        while (hasOverflowContent && width < availableSize.Width)
        {
label_17:
          switch (5)
          {
            case 0:
              goto label_17;
            default:
              if (this.ColumnTemplate != null)
              {
                RichTextBlockOverflow textBlockOverflow;
                if (this.parentKeywords.Count > index)
                {
label_9:
                  switch (1)
                  {
                    case 0:
                      goto label_9;
                    default:
                      textBlockOverflow = this.parentKeywords[index];
                      break;
                  }
                }
                else
                {
                  textBlockOverflow = QueueStack.DisconnectProject((object) this.ColumnTemplate.LoadContent());
                  this.parentKeywords.Add(textBlockOverflow);
                  ((ICollection<UIElement>) this.Children).Add((UIElement) textBlockOverflow);
                  if (index == 0)
                  {
label_12:
                    switch (6)
                    {
                      case 0:
                        goto label_12;
                      default:
                        this.RichTextContent.put_OverflowContentTarget(textBlockOverflow);
                        break;
                    }
                  }
                  else
                    this.parentKeywords[index - ClientTree.DisconnectProject(1984673)].put_OverflowContentTarget(textBlockOverflow);
                }
                ((UIElement) textBlockOverflow).Measure(new Size(availableSize.Width - width, availableSize.Height));
                width += ((UIElement) textBlockOverflow).DesiredSize.Width;
                num = Math.Max(num, ((UIElement) textBlockOverflow).DesiredSize.Height);
                hasOverflowContent = textBlockOverflow.HasOverflowContent;
                index += ClientTree.DisconnectProject(1984677);
                continue;
              }
label_19:
              switch (2)
              {
                case 0:
                  goto label_19;
                default:
                  goto label_20;
              }
          }
        }
label_20:
        if (this.parentKeywords.Count > index)
        {
label_21:
          switch (1)
          {
            case 0:
              goto label_21;
            default:
              if (index == 0)
              {
label_23:
                switch (2)
                {
                  case 0:
                    goto label_23;
                  default:
                    this.RichTextContent.put_OverflowContentTarget(DockingPaneEditor.parentKeywords);
                    break;
                }
              }
              else
                this.parentKeywords[index - ClientTree.DisconnectProject(1984681)].put_OverflowContentTarget(DockingPaneEditor.parentKeywords);
              while (this.parentKeywords.Count > index)
              {
                this.parentKeywords.RemoveAt(index);
                ((IList<UIElement>) this.Children).RemoveAt(index + ClientTree.DisconnectProject(1984685));
              }
              break;
          }
        }
        return new Size(width, num);
      }
    }

    protected virtual Size ArrangeOverride(Size finalSize)
    {
      double num1 = ClientTree.DisconnectProject(1984689);
      double num2 = ClientTree.DisconnectProject(1984697);
      using (IEnumerator<UIElement> enumerator = ((IEnumerable<UIElement>) this.Children).GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          UIElement current = enumerator.Current;
          current.Arrange(new Rect(num1, ClientTree.DisconnectProject(1984705), current.DesiredSize.Width, finalSize.Height));
          num1 += current.DesiredSize.Width;
          num2 = Math.Max(num2, current.DesiredSize.Height);
        }
label_4:
        switch (4)
        {
          case 0:
            goto label_4;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (RichTextColumns.ArrangeOverride);
              break;
            }
            break;
        }
      }
      return new Size(num1, num2);
    }
  }
}
