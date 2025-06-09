// *************************************************************
// Type: GameFoundation.GameplayScreenBase
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public abstract class GameplayScreenBase : GameScreen
  {
    private const double parentKeywords = 800.0;
    public static GameplayScreenBase Instance;
    [DataMember]
    public bool IsPaused;
    [DataMember]
    public bool IsGameToContinue;
    [DataMember]
    public List<ManagedOneTimeAnimator> OneTimeElementsToDraw;
    [DataMember]
    public List<ManagedTimeLimitedBase> TimeLimitedManagedToUpdate;
    [DataMember]
    public List<IUpdateableElement> UpdateableElements;
    public static Rectangle BoundsGame = new Rectangle(ReferenceInvoker.DisconnectProject(3745), ReferenceInvoker.DisconnectProject(3749), ScreenManager.BoundsScreen.Width, ScreenManager.BoundsScreen.Height - ReferenceInvoker.DisconnectProject(3753) - GuiBase.Bounds.Height);
    public Rectangle BoundsUi;
    private Song parentKeywords;
    public double TempUpdatePause;

    public GameplayScreenBase()
    {
      this.OneTimeElementsToDraw = new List<ManagedOneTimeAnimator>(ReferenceInvoker.DisconnectProject(3757));
      this.TimeLimitedManagedToUpdate = new List<ManagedTimeLimitedBase>(ReferenceInvoker.DisconnectProject(3761));
      this.UpdateableElements = new List<IUpdateableElement>(ReferenceInvoker.DisconnectProject(3765));
      this.IsPaused = ReferenceInvoker.DisconnectProject(3769) != 0;
      this.LoadContent();
      this.IsGameToContinue = ReferenceInvoker.DisconnectProject(3773) != 0;
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void SetDefaultUpdatePause()
    {
      this.TempUpdatePause = ReferenceInvoker.DisconnectProject(3645);
    }

    public override void LoadContent()
    {
      if (GameplayScreenBase.Instance != null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreenBase.LoadContent);
            break;
        }
      }
      else
      {
        GameplayScreenBase.Instance = this;
        this.parentKeywords = this.GetSoundBackground();
        GameBase.Instance.ResetElapsedTime();
      }
    }

    public override void UnloadContent()
    {
    }

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
      double totalMilliseconds = gameTime.ElapsedGameTime.TotalMilliseconds;
      if (this.IsPaused)
        return;
      if (!this.IsActive)
      {
label_2:
        switch (6)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreenBase.Update);
            break;
        }
      }
      else if (this.TempUpdatePause > ReferenceInvoker.DisconnectProject(3653))
      {
label_7:
        switch (1)
        {
          case 0:
            goto label_7;
          default:
            this.TempUpdatePause -= gameTime.ElapsedGameTime.TotalMilliseconds;
            break;
        }
      }
      else
      {
        for (int index = this.OneTimeElementsToDraw.Count - ReferenceInvoker.DisconnectProject(3661); index >= ReferenceInvoker.DisconnectProject(3669); index -= ReferenceInvoker.DisconnectProject(3665))
          this.OneTimeElementsToDraw[index].Update(totalMilliseconds);
label_12:
        switch (7)
        {
          case 0:
            goto label_12;
          default:
            for (int index = this.TimeLimitedManagedToUpdate.Count - ReferenceInvoker.DisconnectProject(3673); index >= ReferenceInvoker.DisconnectProject(3681); index -= ReferenceInvoker.DisconnectProject(3677))
              this.TimeLimitedManagedToUpdate[index].Update(totalMilliseconds);
            for (int index = this.UpdateableElements.Count - ReferenceInvoker.DisconnectProject(3685); index >= ReferenceInvoker.DisconnectProject(3693); index -= ReferenceInvoker.DisconnectProject(3689))
              this.UpdateableElements[index].Update(gameTime.ElapsedGameTime.TotalMilliseconds);
label_19:
            switch (7)
            {
              case 0:
                goto label_19;
              default:
                return;
            }
        }
      }
    }

    public override void HandleInput(InputState input)
    {
      if (input != null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreenBase.HandleInput);
          }
          throw new ArgumentNullException(EditorService.DisconnectProject(4204));
      }
    }

    public abstract void SwitchToPauseScreen(bool useLoadingScreen);

    public override void Draw(GameTime gameTime)
    {
      for (int index = this.OneTimeElementsToDraw.Count - ReferenceInvoker.DisconnectProject(3697); index >= ReferenceInvoker.DisconnectProject(3705); index -= ReferenceInvoker.DisconnectProject(3701))
        this.OneTimeElementsToDraw[index].Draw();
label_3:
      switch (6)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreenBase.Draw);
          }
          for (int index = this.TimeLimitedManagedToUpdate.Count - ReferenceInvoker.DisconnectProject(3709); index >= ReferenceInvoker.DisconnectProject(3717); index -= ReferenceInvoker.DisconnectProject(3713))
            this.TimeLimitedManagedToUpdate[index].Draw();
label_9:
          switch (4)
          {
            case 0:
              goto label_9;
            default:
              double transitionPosition = (double) this.TransitionPosition;
              double num = (double) ReferenceInvoker.DisconnectProject(3721);
              return;
          }
      }
    }

    protected abstract GuiBase InitGameGui();

    public virtual void ResetGame()
    {
      this.OneTimeElementsToDraw.Clear();
      this.TimeLimitedManagedToUpdate.Clear();
      this.UpdateableElements.Clear();
      this.IsGameToContinue = ReferenceInvoker.DisconnectProject(3725) != 0;
    }

    public virtual void RestartGame()
    {
      this.ResetGame();
      this.IsPaused = ReferenceInvoker.DisconnectProject(3729) != 0;
      AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(3733) != 0);
    }

    public virtual void Resume() => this.IsPaused = ReferenceInvoker.DisconnectProject(3737) != 0;

    public override void HideScreen(bool setToHidden)
    {
      base.HideScreen(setToHidden);
      this.IsPaused = setToHidden;
      if (setToHidden)
        return;
      AdController.Instance.HideAd(ReferenceInvoker.DisconnectProject(3741) != 0);
    }

    public void PlaySound()
    {
    }

    public abstract Song GetSoundBackground();
  }
}
