// *************************************************************
// Type: GameFoundation.InputState
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameFoundation
{
  public class InputState
  {
    public GamePadState CurrentGamePadState;
    public GamePadState LastGamePadState;
    public KeyboardState CurrentKeyboardState;
    public KeyboardState LastKeyboardState;
    public TouchLocation[] TouchStateHandyArea;
    public TouchLocation[] TouchStateOriginal;
    public readonly List<GestureSample> Gestures = new List<GestureSample>(ReferenceInvoker.DisconnectProject(3029));
    private ScreenManager parentKeywords;

    public InputState(ScreenManager screenManager)
    {
      this.parentKeywords = screenManager;
      TouchPanel.EnableMouseTouchPoint = ReferenceInvoker.DisconnectProject(3033) != 0;
      TouchPanel.EnableMouseGestures = ReferenceInvoker.DisconnectProject(3037) != 0;
    }

    private Vector2 DisconnectProject()
    {
      float height = (float) GameBase.Instance.Window.ClientBounds.Height;
      return new Vector2((float) GameBase.ScreenWidth / (float) GameBase.Instance.Window.ClientBounds.Width, (float) GameBase.ScreenHeight / height);
    }

    /*internal void DisconnectProject()
    {
      Rectangle handyCenteredDrawPos = GameBase.Instance.GetHandyCenteredDrawPos();
      this.LastGamePadState = this.CurrentGamePadState;
      this.LastKeyboardState = this.CurrentKeyboardState;
      this.CurrentKeyboardState = Keyboard.GetState((PlayerIndex) ReferenceInvoker.DisconnectProject(2961));
      this.CurrentGamePadState = GamePad.GetState((PlayerIndex) ReferenceInvoker.DisconnectProject(2965));
      Mouse.GetState();
      this.DisconnectProject();
      this.Gestures.Clear();
      TouchCollection state = TouchPanel.GetState();
      Vector2 vector2 = PlatformHelper.DisconnectProject();
      TouchLocation[] touchLocationArray1 = ActionEventArgs.DisconnectProject(state.Count);
      TouchLocation[] touchLocationArray2 = ActionEventArgs.DisconnectProject(state.Count);
      for (int index = ReferenceInvoker.DisconnectProject(2969); index < state.Count; index += ReferenceInvoker.DisconnectProject(2985))
      {
        TouchLocation touchLocation = state[index];
        touchLocationArray1[index] = new TouchLocation(touchLocation.Id, touchLocation.State, new Vector2(touchLocation.Position.X, touchLocation.Position.Y));
        touchLocation = new TouchLocation(touchLocation.Id, touchLocation.State, new Vector2(touchLocation.Position.X - (float) handyCenteredDrawPos.Left, touchLocation.Position.Y - (float) handyCenteredDrawPos.Top));
        touchLocationArray2[index] = touchLocation;
        if ((double) touchLocation.Position.Y <= (double) ReferenceInvoker.DisconnectProject(2973))
        {
label_2:
          switch (1)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (InputState.DisconnectProject);
              }
              if (touchLocation.State == (TouchLocationState) ReferenceInvoker.DisconnectProject(2977))
              {
label_6:
                switch (6)
                {
                  case 0:
                    goto label_6;
                  default:
                    AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(2981) != 0);
                    goto label_11;
                }
              }
              else
                continue;
          }
        }
      }
label_10:
      switch (6)
      {
        case 0:
          goto label_10;
      }
label_11:
      if (!AdController.Instance.InputConsumed)
      {
label_12:
        switch (1)
        {
          case 0:
            goto label_12;
          default:
            this.TouchStateHandyArea = touchLocationArray2;
            this.TouchStateOriginal = touchLocationArray1;
            this.CurrentGamePadState = GamePad.GetState((PlayerIndex) ReferenceInvoker.DisconnectProject(2989));
            while (TouchPanel.IsGestureAvailable)
            {
              GestureSample gestureSample = TouchPanel.ReadGesture();
              this.Gestures.Add(new GestureSample(gestureSample.GestureType, gestureSample.Timestamp, ContextToken.DisconnectProject(gestureSample.Position, vector2), ContextToken.DisconnectProject(gestureSample.Position2, vector2), ContextToken.DisconnectProject(gestureSample.Delta, vector2), ContextToken.DisconnectProject(gestureSample.Delta2, vector2)));
            }
label_16:
            switch (1)
            {
              case 0:
                goto label_16;
              default:
                return;
            }
        }
      }
      else
      {
        BitmapStack.DisconnectProject(ref this.CurrentGamePadState);
        this.TouchStateHandyArea = ActionEventArgs.DisconnectProject(ReferenceInvoker.DisconnectProject(2993));
        this.TouchStateOriginal = ActionEventArgs.DisconnectProject(ReferenceInvoker.DisconnectProject(2997));
        while (TouchPanel.IsGestureAvailable)
          TouchPanel.ReadGesture();
      }
    }*/

    public bool IsNewButtonPress(Buttons button)
    {
      if (button == (Buttons) ReferenceInvoker.DisconnectProject(3001))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (InputState.IsNewButtonPress);
            }
            if (this.CurrentGamePadState.IsButtonDown(button))
            {
              if (this.LastGamePadState.IsButtonUp(button))
                return ReferenceInvoker.DisconnectProject(3017) != 0;
label_6:
              switch (3)
              {
                case 0:
                  goto label_6;
              }
            }
            return this.CurrentKeyboardState.IsKeyDown((Keys) ReferenceInvoker.DisconnectProject(3005)) ? this.LastKeyboardState.IsKeyUp((Keys) ReferenceInvoker.DisconnectProject(3009)) : ReferenceInvoker.DisconnectProject(3013) != 0;
        }
      }
      else
        return this.CurrentGamePadState.IsButtonDown(button) ? this.LastGamePadState.IsButtonUp(button) : ReferenceInvoker.DisconnectProject(3021) != 0;
    }

    public bool IsKeyPressed(Keys key) => this.CurrentKeyboardState.IsKeyDown(key);

    public bool IsNewKeyPress(Keys key)
    {
      return this.CurrentKeyboardState.IsKeyDown(key) ? this.LastKeyboardState.IsKeyUp(key) : ReferenceInvoker.DisconnectProject(3025) != 0;
    }
  }
}
