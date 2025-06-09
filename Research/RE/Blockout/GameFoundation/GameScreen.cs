// Decompiled with JetBrains decompiler
// Type: GameFoundation.GameScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public abstract class GameScreen
  {
    private bool parentKeywords;
    [DataMember]
    public bool IsPopup;
    public TimeSpan TransitionOnTime;
    public TimeSpan TransitionOffTime;
    [DataMember]
    public float TransitionPosition;
    [DataMember]
    public ScreenState ScreenState;
    [DataMember]
    public bool IsExiting;
    [DataMember]
    public bool otherScreenHasFocus;
    [DataMember]
    public GestureType enabledGestures;

    public GameScreen()
    {
      this.TransitionPosition = ReferenceInvoker.DisconnectProject(2949);
      this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2953);
      this.IsExiting = ReferenceInvoker.DisconnectProject(2957) != 0;
    }

    public float TransitionAlpha
    {
      get => ReferenceInvoker.DisconnectProject(2837) - this.TransitionPosition;
    }

    public bool IsActive
    {
      get
      {
        if (this.otherScreenHasFocus)
          return ReferenceInvoker.DisconnectProject(2849) != 0;
        if (this.ScreenState == ScreenState.TransitionOn)
          return ReferenceInvoker.DisconnectProject(2845) != 0;
label_2:
        switch (6)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameScreen.get_IsActive);
            }
            return this.ScreenState == (ScreenState) ReferenceInvoker.DisconnectProject(2841);
        }
      }
    }

    public GestureType EnabledGestures
    {
      get => this.enabledGestures;
      protected set
      {
        this.enabledGestures = value;
        if (this.ScreenState != (ScreenState) ReferenceInvoker.DisconnectProject(2853))
          return;
        TouchPanel.EnabledGestures = value;
      }
    }

    public virtual void LoadContent()
    {
      if (this.parentKeywords)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameScreen.LoadContent);
            break;
        }
      }
      else
        this.parentKeywords = ReferenceInvoker.DisconnectProject(2857) != 0;
    }

    public virtual void UnloadContent()
    {
    }

    public virtual void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      this.otherScreenHasFocus = otherScreenHasFocus;
      if (this.IsExiting)
      {
        this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2861);
        if (this.DisconnectProject(gameTime, this.TransitionOffTime, ReferenceInvoker.DisconnectProject(2865)))
          return;
label_2:
        switch (2)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameScreen.Update);
            }
            ScreenManager.Instance.RemoveScreen(this);
            break;
        }
      }
      else if (coveredByOtherScreen)
      {
        if (this.DisconnectProject(gameTime, this.TransitionOffTime, ReferenceInvoker.DisconnectProject(2869)))
        {
label_8:
          switch (2)
          {
            case 0:
              goto label_8;
            default:
              this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2873);
              break;
          }
        }
        else
          this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2877);
      }
      else if (this.DisconnectProject(gameTime, this.TransitionOnTime, ReferenceInvoker.DisconnectProject(2881)))
      {
label_12:
        switch (5)
        {
          case 0:
            goto label_12;
          default:
            this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2885);
            break;
        }
      }
      else
        this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2889);
    }

    private bool DisconnectProject(GameTime _param1, TimeSpan _param2, int _param3)
    {
      this.TransitionPosition += (!DeviceOptions.DisconnectProject(_param2, TimeSpan.Zero) ? (float) (_param1.ElapsedGameTime.TotalMilliseconds / _param2.TotalMilliseconds) : ReferenceInvoker.DisconnectProject(2893)) * (float) _param3;
      if (_param3 < ReferenceInvoker.DisconnectProject(2897))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameScreen.DisconnectProject);
            }
            if ((double) this.TransitionPosition > (double) ReferenceInvoker.DisconnectProject(2901))
            {
label_5:
              switch (4)
              {
                case 0:
                  goto label_5;
              }
            }
            else
              goto label_7;
            break;
        }
      }
      if (_param3 <= ReferenceInvoker.DisconnectProject(2905) || (double) this.TransitionPosition < (double) ReferenceInvoker.DisconnectProject(2909))
        return ReferenceInvoker.DisconnectProject(2925) != 0;
label_7:
      this.TransitionPosition = MathHelper.Clamp(this.TransitionPosition, ReferenceInvoker.DisconnectProject(2913), ReferenceInvoker.DisconnectProject(2917));
      return ReferenceInvoker.DisconnectProject(2921) != 0;
    }

    public virtual void HandleInput(InputState input)
    {
    }

    public virtual void Draw(GameTime gameTime)
    {
    }

    public void ExitScreen()
    {
      if (DeviceOptions.DisconnectProject(this.TransitionOffTime, TimeSpan.Zero))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameScreen.ExitScreen);
            }
            ScreenManager.Instance.RemoveScreen(this);
            break;
        }
      }
      else
        this.IsExiting = ReferenceInvoker.DisconnectProject(2929) != 0;
    }

    public virtual void HideScreen(bool setToHidden)
    {
      if (this.ScreenState != (ScreenState) ReferenceInvoker.DisconnectProject(2933) && this.ScreenState != (ScreenState) ReferenceInvoker.DisconnectProject(2937))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameScreen.HideScreen);
            break;
        }
      }
      else if (setToHidden)
      {
label_5:
        switch (1)
        {
          case 0:
            goto label_5;
          default:
            this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2941);
            break;
        }
      }
      else
        this.ScreenState = (ScreenState) ReferenceInvoker.DisconnectProject(2945);
    }
  }
}
