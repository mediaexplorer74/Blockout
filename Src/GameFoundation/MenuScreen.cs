// *************************************************************
// Type: GameFoundation.MenuScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public abstract class MenuScreen : GameScreen
  {
    public const int AdditionalMenuHitVerticalMargin = 9;
    public const int AdditionalMenuHitHorizontalMargin = 9;
    private const int parentKeywords = 140;
    private const int currentUri = 55;
    private const float parentKeywords = 0.95f;
    private const int filterID = 10;
    private bool parentKeywords;
    [DataMember]
    public string menuTitle;
    [DataMember]
    public bool showMenuTitle;
    [DataMember]
    public int TopOffset;
    [DataMember]
    public int TransitionOffsetX;
    protected IList<MenuEntry> MenuEntries;

    public MenuScreen(string menuTitle, bool showMenuTitle)
    {
      this.menuTitle = menuTitle;
      this.showMenuTitle = showMenuTitle;
    }

    public static bool IsLandscapeMenu => ReferenceInvoker.DisconnectProject(3313) != 0;

    public override void LoadContent()
    {
      if (this.parentKeywords)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(3317) != 0;
        base.LoadContent();
        this.EnabledGestures = (GestureType) ReferenceInvoker.DisconnectProject(3321);
        this.TransitionOnTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(3325));
        this.TransitionOffTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(3333));
        if (MenuScreen.IsLandscapeMenu)
        {
label_5:
          switch (3)
          {
            case 0:
              goto label_5;
            default:
              this.TopOffset = ReferenceInvoker.DisconnectProject(3341);
              break;
          }
        }
        else
          this.TopOffset = ReferenceInvoker.DisconnectProject(3345);
        this.MenuEntries = (IList<MenuEntry>) new List<MenuEntry>();
      }
    }

    protected virtual Rectangle GetMenuEntryHitBounds(MenuEntry entry)
    {
      return new Rectangle((int) entry.PositionDrawing.X - ReferenceInvoker.DisconnectProject(3349), (int) entry.PositionDrawing.Y - ReferenceInvoker.DisconnectProject(3353), entry.GetWidth() + ReferenceInvoker.DisconnectProject(3357), entry.GetHeight() + ReferenceInvoker.DisconnectProject(3361));
    }

    public override void HandleInput(InputState input) => this.HandleInput(input, out bool _);

    public void HandleInput(InputState input, out bool menuEntryGotInput)
    {
      base.HandleInput(input);
      menuEntryGotInput = ReferenceInvoker.DisconnectProject(3365) != 0;
      if (input.IsNewButtonPress((Buttons) ReferenceInvoker.DisconnectProject(3369)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuScreen.HandleInput);
            }
            this.OnCancel();
            break;
        }
      }
      if (this.IgnoreHandleInput())
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
        }
      }
      else
      {
        using (List<GestureSample>.Enumerator enumerator = input.Gestures.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            GestureSample current = enumerator.Current;
            if (current.GestureType == (GestureType) ReferenceInvoker.DisconnectProject(3373))
            {
              Point point = new Point((int) current.Position.X, (int) current.Position.Y);
              for (int index = ReferenceInvoker.DisconnectProject(3377); index < this.MenuEntries.Count; index += ReferenceInvoker.DisconnectProject(3385))
              {
                Rectangle menuEntryHitBounds = this.GetMenuEntryHitBounds(this.MenuEntries[index]);
                if (menuEntryHitBounds.Contains(point))
                {
label_13:
                  switch (2)
                  {
                    case 0:
                      goto label_13;
                    default:
                      Point relativeHitPosition = new Point(point.X - menuEntryHitBounds.X, point.Y - menuEntryHitBounds.Y);
                      this.OnSelectEntry(index, relativeHitPosition);
                      menuEntryGotInput = ReferenceInvoker.DisconnectProject(3381) != 0;
                      continue;
                  }
                }
              }
label_17:
              switch (1)
              {
                case 0:
                  goto label_17;
                default:
                  continue;
              }
            }
          }
label_19:
          switch (2)
          {
            case 0:
              goto label_19;
          }
        }
        TouchLocation[] touchStateHandyArea = input.TouchStateHandyArea;
        for (int index1 = ReferenceInvoker.DisconnectProject(3389); index1 < (int) DomainEditor.DisconnectProject(touchStateHandyArea); index1 += ReferenceInvoker.DisconnectProject(3405))
        {
          TouchLocation touchLocation = touchStateHandyArea[index1];
          Point point = new Point((int) touchLocation.Position.X, (int) touchLocation.Position.Y);
          for (int index2 = ReferenceInvoker.DisconnectProject(3393); index2 < this.MenuEntries.Count; index2 += ReferenceInvoker.DisconnectProject(3401))
          {
            Rectangle menuEntryHitBounds = this.GetMenuEntryHitBounds(this.MenuEntries[index2]);
            if (menuEntryHitBounds.Contains(point))
            {
label_25:
              switch (7)
              {
                case 0:
                  goto label_25;
                default:
                  Point relativeHitPosition = new Point(point.X - menuEntryHitBounds.X, point.Y - menuEntryHitBounds.Y);
                  this.OnTouchEntry(index2, relativeHitPosition);
                  menuEntryGotInput = ReferenceInvoker.DisconnectProject(3397) != 0;
                  continue;
              }
            }
          }
label_29:
          switch (2)
          {
            case 0:
              goto label_29;
            default:
              continue;
          }
        }
label_32:
        switch (7)
        {
          case 0:
            goto label_32;
        }
      }
    }

    protected bool IgnoreHandleInput()
    {
      if (this.ScreenState == ScreenState.TransitionOn)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuScreen.IgnoreHandleInput);
            }
            if ((double) this.TransitionPosition < (double) ReferenceInvoker.DisconnectProject(3409))
              return ReferenceInvoker.DisconnectProject(3417) != 0;
            break;
        }
      }
      return this.ScreenState == (ScreenState) ReferenceInvoker.DisconnectProject(3413);
    }

    protected virtual void OnSelectEntry(int entryIndex, Point relativeHitPosition)
    {
      this.MenuEntries[entryIndex].OnSelectEntry(relativeHitPosition);
    }

    protected virtual void OnTouchEntry(int entryIndex, Point relativeHitPosition)
    {
      this.MenuEntries[entryIndex].OnTouchEntry(relativeHitPosition);
    }

    protected virtual void OnCancel() => this.ExitScreen();

    protected void OnCancel(object sender, EventArgs e) => this.OnCancel();

    protected virtual void UpdateMenuEntryLocations()
    {
      float num1 = (float) Math.Pow((double) this.TransitionPosition, ReferenceInvoker.DisconnectProject(3421));
      float topOffset1 = (float) this.TopOffset;
      float topOffset2 = (float) this.TopOffset;
      float topOffset3 = (float) this.TopOffset;
      for (int index = ReferenceInvoker.DisconnectProject(3429); index < this.MenuEntries.Count; index += ReferenceInvoker.DisconnectProject(3513))
      {
        MenuEntry menuEntry = this.MenuEntries[index];
        if (!menuEntry.IsManualPosition)
        {
label_2:
          switch (4)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuScreen.UpdateMenuEntryLocations);
              }
              float num2;
              float y;
              switch (this.MenuEntries[index].MenuLocation)
              {
                case MenuLocation.Left:
                  num2 = (float) ((double) ReferenceInvoker.DisconnectProject(3433) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(3437) - (double) ReferenceInvoker.DisconnectProject(3441) * (double) menuEntry.GetWidth() / (double) ReferenceInvoker.DisconnectProject(3445));
                  y = topOffset1;
                  topOffset1 += (float) (menuEntry.GetHeight() + ReferenceInvoker.DisconnectProject(3449) + menuEntry.AdditionalBottomMargin);
                  break;
                case MenuLocation.Center:
                  num2 = (float) ((double) ReferenceInvoker.DisconnectProject(3453) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(3457) - (double) ReferenceInvoker.DisconnectProject(3461) * (double) menuEntry.GetWidth() / (double) ReferenceInvoker.DisconnectProject(3465));
                  y = topOffset2;
                  topOffset2 += (float) (menuEntry.GetHeight() + ReferenceInvoker.DisconnectProject(3469) + menuEntry.AdditionalBottomMargin);
                  break;
                case MenuLocation.Right:
                  num2 = (float) ((double) ReferenceInvoker.DisconnectProject(3473) * (double) ScreenManager.BoundsScreen.Width / (double) ReferenceInvoker.DisconnectProject(3477) * (double) ReferenceInvoker.DisconnectProject(3481) - (double) ReferenceInvoker.DisconnectProject(3485) * (double) menuEntry.GetWidth() / (double) ReferenceInvoker.DisconnectProject(3489));
                  y = topOffset3;
                  topOffset3 += (float) (menuEntry.GetHeight() + ReferenceInvoker.DisconnectProject(3493) + menuEntry.AdditionalBottomMargin);
                  break;
                default:
                  throw new NotImplementedException(EditorService.DisconnectProject(4121));
              }
              float x;
              if (this.ScreenState == ScreenState.TransitionOn)
              {
label_11:
                switch (4)
                {
                  case 0:
                    goto label_11;
                  default:
                    x = num2 - num1 * ReferenceInvoker.DisconnectProject(3497);
                    break;
                }
              }
              else
                x = num2 + num1 * ReferenceInvoker.DisconnectProject(3501);
              menuEntry.PositionDrawing = new Vector2(x, y);
              continue;
          }
        }
        else
        {
          Vector2 position = menuEntry.Position;
          if (this.ScreenState == ScreenState.TransitionOn)
            position.X -= num1 * ReferenceInvoker.DisconnectProject(3505);
          else
            position.X += num1 * ReferenceInvoker.DisconnectProject(3509);
          menuEntry.PositionDrawing = position;
        }
      }
label_21:
      switch (6)
      {
        case 0:
          goto label_21;
        default:
          if (this.ScreenState == ScreenState.TransitionOn)
          {
            this.TransitionOffsetX = (int) (-(double) num1 * (double) ReferenceInvoker.DisconnectProject(3517));
            break;
          }
          this.TransitionOffsetX = (int) ((double) num1 * (double) ReferenceInvoker.DisconnectProject(3521));
          break;
      }
    }

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
      double totalMilliseconds = gameTime.ElapsedGameTime.TotalMilliseconds;
      for (int index = ReferenceInvoker.DisconnectProject(3525); index < this.MenuEntries.Count; index += ReferenceInvoker.DisconnectProject(3529))
        this.MenuEntries[index].Update(totalMilliseconds);
label_3:
      switch (5)
      {
        case 0:
          goto label_3;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuScreen.Update);
          break;
      }
    }

    public override void Draw(GameTime gameTime)
    {
      this.UpdateMenuEntryLocations();
      GraphicsDevice graphicsDevice = ScreenManager.Instance.GraphicsDevice;
      SpriteFont menuFont = ScreenManager.Instance.MenuFont;
      for (int index = ReferenceInvoker.DisconnectProject(3533); index < this.MenuEntries.Count; index += ReferenceInvoker.DisconnectProject(3537))
        this.MenuEntries[index].Draw(this);
label_3:
      switch (2)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (MenuScreen.Draw);
          }
          float num = (float) Math.Pow((double) this.TransitionPosition, ReferenceInvoker.DisconnectProject(3541));
          if (!this.showMenuTitle)
            break;
          Vector2 position = new Vector2((float) (graphicsDevice.Viewport.Width / ReferenceInvoker.DisconnectProject(3549)), ReferenceInvoker.DisconnectProject(3553));
          Vector2 origin = WindowSite.DisconnectProject(menuFont.MeasureString(this.menuTitle), ReferenceInvoker.DisconnectProject(3557));
          Color color = WindowOptions.DisconnectProject(new Color(ReferenceInvoker.DisconnectProject(3561), ReferenceInvoker.DisconnectProject(3565), ReferenceInvoker.DisconnectProject(3569)), this.TransitionAlpha);
          float scale = ReferenceInvoker.DisconnectProject(3573);
          position.Y -= num * ReferenceInvoker.DisconnectProject(3577);
          GameBase.Instance.SpriteBatch.DrawString(menuFont, this.menuTitle, position, color, ReferenceInvoker.DisconnectProject(3581), origin, scale, (SpriteEffects) ReferenceInvoker.DisconnectProject(3585), ReferenceInvoker.DisconnectProject(3589));
          break;
      }
    }
  }
}
