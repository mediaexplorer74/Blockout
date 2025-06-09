// *************************************************************
// Type: GameFoundation.MenuEntry
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Threading;

#nullable disable
namespace GameFoundation
{
  public class MenuEntry
  {
    public MenuLocation MenuLocation;
    public bool IsVisible;
    public bool IsManualPosition;
    public float Scale;
    public int AdditionalBottomMargin;
    public Color ColorText;
    public string Text;
    public Vector2 Position;
    public Vector2 PositionDrawing;
    private EventHandler<RelativeClickEventArg> parentKeywords;
    private EventHandler<RelativeClickEventArg> currentUri;

    public MenuEntry(string text)
    {
      this.MenuLocation = (MenuLocation) ReferenceInvoker.DisconnectProject(4337);
      this.IsVisible = ReferenceInvoker.DisconnectProject(4341) != 0;
      this.Text = text;
      this.ColorText = Color.White;
      this.IsManualPosition = ReferenceInvoker.DisconnectProject(4345) != 0;
      this.Scale = ReferenceInvoker.DisconnectProject(4349);
    }

    public event EventHandler<RelativeClickEventArg> Selected
    {
      add
      {
        EventHandler<RelativeClickEventArg> eventHandler1 = this.parentKeywords;
        EventHandler<RelativeClickEventArg> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<RelativeClickEventArg>>(ref this.parentKeywords, RegistrySerializer.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (7)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntry.add_Selected);
            break;
        }
      }
      remove
      {
        EventHandler<RelativeClickEventArg> eventHandler1 = this.parentKeywords;
        EventHandler<RelativeClickEventArg> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<RelativeClickEventArg>>(ref this.parentKeywords, RegistrySerializer.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (4)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntry.remove_Selected);
            break;
        }
      }
    }

    public event EventHandler<RelativeClickEventArg> Touched
    {
      add
      {
        EventHandler<RelativeClickEventArg> eventHandler1 = this.currentUri;
        EventHandler<RelativeClickEventArg> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<RelativeClickEventArg>>(ref this.currentUri, RegistrySerializer.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (3)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntry.add_Touched);
            break;
        }
      }
      remove
      {
        EventHandler<RelativeClickEventArg> eventHandler1 = this.currentUri;
        EventHandler<RelativeClickEventArg> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<RelativeClickEventArg>>(ref this.currentUri, RegistrySerializer.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
      }
    }

    protected internal virtual void OnSelectEntry(Point relativeHitPosition)
    {
      if (this.parentKeywords == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntry.OnSelectEntry);
          }
          this.parentKeywords((object) this, new RelativeClickEventArg(relativeHitPosition));
          break;
      }
    }

    protected internal virtual void OnTouchEntry(Point relativeHitPosition)
    {
      if (this.currentUri == null)
        return;
      this.currentUri((object) this, new RelativeClickEventArg(relativeHitPosition));
    }

    public virtual void Update(double elapsedGameTimeMs)
    {
    }

    public virtual void Draw(MenuScreen screen)
    {
      if (!this.IsVisible)
        return;
      if (this.Text == null)
      {
label_3:
        switch (2)
        {
          case 0:
            goto label_3;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntry.Draw);
            break;
        }
      }
      else
      {
        Color color = WindowOptions.DisconnectProject(this.ColorText, screen.TransitionAlpha);
        Vector2 origin = new Vector2(ReferenceInvoker.DisconnectProject(4313), (float) (ScreenManager.Instance.MenuFont.LineSpacing / ReferenceInvoker.DisconnectProject(4317)));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.Text, this.PositionDrawing, color, ReferenceInvoker.DisconnectProject(4321), origin, this.Scale, (SpriteEffects) ReferenceInvoker.DisconnectProject(4325), ReferenceInvoker.DisconnectProject(4329));
      }
    }

    public virtual int GetHeight()
    {
      return (int) ((double) ScreenManager.Instance.MenuFont.LineSpacing * (double) this.Scale);
    }

    public virtual int GetWidth()
    {
      if (this.Text != null)
        return (int) ((double) ScreenManager.Instance.MenuFont.MeasureString(this.Text).X * (double) this.Scale);
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuEntry.GetWidth);
          }
          return ReferenceInvoker.DisconnectProject(4333);
      }
    }
  }
}
