// *************************************************************
// Type: GameFoundation.LoadingScreen
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace GameFoundation
{
  public class LoadingScreen : GameScreen
  {
    private bool parentKeywords;
    private bool currentUri;
    public GameScreen[] screensToLoad;
    private GameScreen[] parentKeywords;
    private bool filterID;
    private bool parentCancel;

    private LoadingScreen(ScreenManager _param1, bool _param2, GameScreen[] _param3)
    {
      this.parentKeywords = _param2;
      this.screensToLoad = _param3;
      this.TransitionOnTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(4101));
    }

    public static void Load(
      ScreenManager screenManager,
      bool loadingIsSlow,
      params GameScreen[] screensToLoad)
    {
      GameScreen[] screens = screenManager.GetScreens();
      for (int index = ReferenceInvoker.DisconnectProject(3937); index < (int) ImageTable.DisconnectProject(screens); index += ReferenceInvoker.DisconnectProject(3941))
        screens[index].ExitScreen();
label_3:
      switch (2)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.Load);
          }
          LoadingScreen screen = new LoadingScreen(screenManager, loadingIsSlow, screensToLoad);
          screenManager.AddScreen((GameScreen) screen);
          break;
      }
    }

    public static void SwitchToTempScreen(
      ScreenManager screenManager,
      bool loadingIsSlow,
      bool useLoadingScreen,
      params GameScreen[] screensToLoad)
    {
      if (useLoadingScreen)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.SwitchToTempScreen);
            }
            screenManager.AddScreen((GameScreen) new LoadingScreen(screenManager, loadingIsSlow, FunctionFactory.parentKeywords)
            {
              parentKeywords = screenManager.GetScreens()
            });
            break;
        }
      }
      else
      {
        GameScreen[] screens = ScreenManager.Instance.GetScreens();
        for (int index = (int) ImageTable.DisconnectProject(screens) - ReferenceInvoker.DisconnectProject(3945); index >= ReferenceInvoker.DisconnectProject(3957); index -= ReferenceInvoker.DisconnectProject(3953))
          screens[index].HideScreen(ReferenceInvoker.DisconnectProject(3949) != 0);
label_8:
        switch (1)
        {
          case 0:
            goto label_8;
        }
      }
      for (int index = ReferenceInvoker.DisconnectProject(3961); index < (int) ImageTable.DisconnectProject(screensToLoad); index += ReferenceInvoker.DisconnectProject(3965))
      {
        if (screensToLoad[index] != null)
        {
label_11:
          switch (7)
          {
            case 0:
              goto label_11;
            default:
              screenManager.AddScreen(screensToLoad[index]);
              continue;
          }
        }
      }
    }

    public static void SwitchBackFromTempScreen(
      ScreenManager screenManager,
      bool loadingIsSlow,
      params GameScreen[] screensToUnload)
    {
      for (int index = ReferenceInvoker.DisconnectProject(3969); index < (int) ImageTable.DisconnectProject(screensToUnload); index += ReferenceInvoker.DisconnectProject(3973))
        screensToUnload[index].ExitScreen();
      GameScreen[] screens = screenManager.GetScreens();
      for (int index = ReferenceInvoker.DisconnectProject(3977); index < (int) ImageTable.DisconnectProject(screens); index += ReferenceInvoker.DisconnectProject(3985))
        screens[index].HideScreen(ReferenceInvoker.DisconnectProject(3981) != 0);
label_6:
      switch (5)
      {
        case 0:
          goto label_6;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.SwitchBackFromTempScreen);
          break;
      }
    }

    public static void SwitchBackFromTempScreen(
      ScreenManager screenManager,
      bool loadingIsSlow,
      int numScreensToUnload)
    {
      GameScreen[] screens = screenManager.GetScreens();
      for (int index = (int) ImageTable.DisconnectProject(screens) - ReferenceInvoker.DisconnectProject(3989); index > (int) ImageTable.DisconnectProject(screens) - (ReferenceInvoker.DisconnectProject(3997) + numScreensToUnload); index -= ReferenceInvoker.DisconnectProject(3993))
        screens[index].ExitScreen();
label_3:
      switch (7)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.SwitchBackFromTempScreen);
          }
          for (int index = (int) ImageTable.DisconnectProject(screens) - (ReferenceInvoker.DisconnectProject(4001) + numScreensToUnload); index >= ReferenceInvoker.DisconnectProject(4013); index -= ReferenceInvoker.DisconnectProject(4009))
            screens[index].HideScreen(ReferenceInvoker.DisconnectProject(4005) != 0);
          break;
      }
    }

    public static void SwitchBackFromTempScreen(
      ScreenManager screenManager,
      GameScreen screenToSetActive)
    {
      GameScreen[] screens = screenManager.GetScreens();
      for (int index = (int) ImageTable.DisconnectProject(screens) - ReferenceInvoker.DisconnectProject(4017); index >= ReferenceInvoker.DisconnectProject(4025); index -= ReferenceInvoker.DisconnectProject(4021))
      {
        if (screens[index] != screenToSetActive)
        {
label_2:
          switch (3)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.SwitchBackFromTempScreen);
              }
              screens[index].ExitScreen();
              continue;
          }
        }
      }
label_8:
      switch (1)
      {
        case 0:
          goto label_8;
        default:
          screenToSetActive.HideScreen(ReferenceInvoker.DisconnectProject(4029) != 0);
          break;
      }
    }

    public void ForceEndNowWithoutRemove()
    {
      this.parentCancel = ReferenceInvoker.DisconnectProject(4033) != 0;
      for (int index = ReferenceInvoker.DisconnectProject(4037); index < (int) ImageTable.DisconnectProject(this.screensToLoad); index += ReferenceInvoker.DisconnectProject(4041))
      {
        if (this.screensToLoad[index] != null)
        {
label_2:
          switch (3)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.ForceEndNowWithoutRemove);
              }
              ScreenManager.Instance.AddScreen(this.screensToLoad[index]);
              continue;
          }
        }
      }
label_8:
      switch (2)
      {
        case 0:
          goto label_8;
        default:
          if (this.parentKeywords == null)
            break;
          for (int index = ReferenceInvoker.DisconnectProject(4045); index < (int) ImageTable.DisconnectProject(this.parentKeywords); index += ReferenceInvoker.DisconnectProject(4053))
          {
            if (this.parentKeywords[index] != null)
              this.parentKeywords[index].HideScreen(ReferenceInvoker.DisconnectProject(4049) != 0);
          }
label_15:
          switch (3)
          {
            case 0:
              goto label_15;
            default:
              return;
          }
      }
    }

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      if (this.parentCancel)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.Update);
            break;
        }
      }
      else
      {
        base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        if (this.currentUri)
        {
label_6:
          switch (4)
          {
            case 0:
              goto label_6;
            default:
              ScreenManager.Instance.RemoveScreen((GameScreen) this);
              for (int index = ReferenceInvoker.DisconnectProject(4057); index < (int) ImageTable.DisconnectProject(this.screensToLoad); index += ReferenceInvoker.DisconnectProject(4061))
              {
                if (this.screensToLoad[index] != null)
                {
label_9:
                  switch (3)
                  {
                    case 0:
                      goto label_9;
                    default:
                      ScreenManager.Instance.AddScreen(this.screensToLoad[index]);
                      continue;
                  }
                }
              }
label_13:
              switch (6)
              {
                case 0:
                  goto label_13;
                default:
                  GameBase.Instance.ResetElapsedTime();
                  break;
              }
              break;
          }
        }
        if (!this.filterID)
          return;
label_16:
        switch (3)
        {
          case 0:
            goto label_16;
          default:
            if (this.screensToLoad != null)
            {
              if ((int) ImageTable.DisconnectProject(this.screensToLoad) > ReferenceInvoker.DisconnectProject(4065))
                break;
label_19:
              switch (2)
              {
                case 0:
                  goto label_19;
              }
            }
            ScreenManager.Instance.RemoveScreen((GameScreen) this);
            if (this.parentKeywords == null)
              break;
label_21:
            switch (7)
            {
              case 0:
                goto label_21;
              default:
                for (int index = ReferenceInvoker.DisconnectProject(4069); index < (int) ImageTable.DisconnectProject(this.parentKeywords); index += ReferenceInvoker.DisconnectProject(4077))
                {
                  if (this.parentKeywords[index] != null)
                  {
label_24:
                    switch (3)
                    {
                      case 0:
                        goto label_24;
                      default:
                        this.parentKeywords[index].HideScreen(ReferenceInvoker.DisconnectProject(4073) != 0);
                        continue;
                    }
                  }
                }
label_28:
                switch (2)
                {
                  case 0:
                    goto label_28;
                  default:
                    return;
                }
            }
        }
      }
    }

    public override void Draw(GameTime gameTime)
    {
      if (this.parentCancel)
        return;
      if (this.ScreenState == (ScreenState) ReferenceInvoker.DisconnectProject(4081) && (int) ImageTable.DisconnectProject(ScreenManager.Instance.GetScreens()) == ReferenceInvoker.DisconnectProject(4085))
        this.currentUri = ReferenceInvoker.DisconnectProject(4089) != 0;
      this.filterID = ReferenceInvoker.DisconnectProject(4093) != 0;
      if (!this.parentKeywords)
        return;
label_5:
      switch (6)
      {
        case 0:
          goto label_5;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LoadingScreen.Draw);
          }
          SpriteFont menuFont = ScreenManager.Instance.MenuFont;
          Viewport viewport = ScreenManager.Instance.GraphicsDevice.Viewport;
          Vector2 position = WindowSite.DisconnectProject(SelectionFactory.DisconnectProject(new Vector2((float) viewport.Width, (float) viewport.Height), menuFont.MeasureString(EditorService.DisconnectProject(4387))), ReferenceInvoker.DisconnectProject(4097));
          Color color = WindowOptions.DisconnectProject(Color.White, this.TransitionAlpha);
          GameBase.Instance.SpriteBatch.DrawString(menuFont, EditorService.DisconnectProject(4387), position, color);
          break;
      }
    }
  }
}
