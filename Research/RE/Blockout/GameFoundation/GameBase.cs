// Decompiled with JetBrains decompiler
// Type: GameFoundation.GameBase
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace GameFoundation
{
  public abstract class GameBase : Game
  {
    private const string parentKeywords = "GameBase";
    private const string currentUri = "GameBase\\GameSettings.dat";
    private const string filterID = "GameBase\\GameSettings.bak";
    public const bool ShowDebugInfoText = false;
    private const bool parentKeywords = true;
    public const bool IsPortraitGraphics = true;
    private const double parentKeywords = 1000.0;
    public const bool HasGameSound = false;
    public static GameBase Instance;
    public Point ScreenBackBufferDimensions;
    public InfoText InfoText;
    public GraphicsDeviceManager Graphics;
    public SpriteBatch SpriteBatch;
    public GameSettings GameSettings;
    private DateTime parentKeywords;
    private DateTime currentUri;
    private bool currentUri;
    private bool filterID;
    private bool parentCancel;
    private Texture2D parentKeywords;
    private Rectangle parentKeywords;
    private DataHandler parentKeywords;
    private Texture2D currentUri;
    private RenderTarget2D parentKeywords;

    public GameBase()
    {
      this.currentUri = ReferenceInvoker.DisconnectProject(368) != 0;
      GameBase.Instance = this;
      this.Content.RootDirectory = EditorService.DisconnectProject(510);
      this.Graphics = new GraphicsDeviceManager((Game) this);
      this.Graphics.IsFullScreen = ReferenceInvoker.DisconnectProject(372) != 0;
      this.DisconnectProject(ReferenceInvoker.DisconnectProject(376) != 0);
      this.IsFixedTimeStep = ReferenceInvoker.DisconnectProject(380) != 0;
    }

    public static int ScreenWidth => ReferenceInvoker.DisconnectProject(80);

    public static int ScreenHeight => ReferenceInvoker.DisconnectProject(84);

    public void UpdateVolume()
    {
      if (!MediaPlayer.GameHasControl)
        return;
      MediaPlayer.Volume = MathHelper.Clamp((float) (Math.Pow((double) this.GameSettings.MusicVolume, ReferenceInvoker.DisconnectProject(88)) / ReferenceInvoker.DisconnectProject(96)), ReferenceInvoker.DisconnectProject(104), ReferenceInvoker.DisconnectProject(108));
    }

    public void UpdateMusicIsOn()
    {
      try
      {
        if (this.GameSettings.MusicIsOn)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.UpdateMusicIsOn);
              }
              MediaPlayer.IsMuted = ReferenceInvoker.DisconnectProject(112) != 0;
              if (MediaPlayer.State == (MediaState) ReferenceInvoker.DisconnectProject(116))
                break;
label_5:
              switch (6)
              {
                case 0:
                  goto label_5;
                default:
                  ScreenManager.Instance.PlaySound();
                  return;
              }
          }
        }
        else
          MediaPlayer.IsMuted = ReferenceInvoker.DisconnectProject(120) != 0;
      }
      catch
      {
      }
    }

    protected override sealed void Initialize()
    {
      base.Initialize();
      this.parentKeywords = this.Content.Load<Texture2D>(EditorService.DisconnectProject(163));
      this.SpriteBatch = new SpriteBatch(this.GraphicsDevice);
      this.SpriteBatch.Begin();
      this.SpriteBatch.Draw(this.parentKeywords, this.parentKeywords, Color.White);
      this.SpriteBatch.End();
      this.GraphicsDevice.Present();
      this.currentUri = DateTime.Now;
      this.parentCancel = ReferenceInvoker.DisconnectProject(124) != 0;
      this.DisconnectProject();
    }

    private void DisconnectProject()
    {
      this.filterID = ReferenceInvoker.DisconnectProject(128) != 0;
      bool flag1;
      this.DisconnectProject(out flag1);
      try
      {
        if (MediaPlayer.GameHasControl)
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.DisconnectProject);
              }
              MediaPlayer.IsMuted = ReferenceInvoker.DisconnectProject(132) != 0;
              break;
          }
        }
        GameScreen[] screens = ScreenManager.Instance.GetScreens();
        bool flag2 = ReferenceInvoker.DisconnectProject(136) != 0;
        for (int index = (int) ImageTable.DisconnectProject(screens) - ReferenceInvoker.DisconnectProject(140); index >= ReferenceInvoker.DisconnectProject(152); index -= ReferenceInvoker.DisconnectProject(148))
        {
          if (ProjectList.DisconnectProject((object) screens[index]) == null)
          {
label_8:
            switch (4)
            {
              case 0:
                goto label_8;
              default:
                if (TreeNodeLayout.DisconnectProject((object) screens[index]) == null)
                {
label_10:
                  switch (3)
                  {
                    case 0:
                      goto label_10;
                    default:
                      if (PathLoader.DisconnectProject((object) screens[index]) == null)
                        continue;
                      break;
                  }
                }
                else
                  break;
                break;
            }
          }
          flag2 = ReferenceInvoker.DisconnectProject(144) != 0;
          goto label_16;
        }
label_15:
        switch (2)
        {
          case 0:
            goto label_15;
        }
label_16:
        if (flag2)
        {
label_17:
          switch (1)
          {
            case 0:
              goto label_17;
            default:
              GameplayScreenBase.Instance.PlaySound();
              break;
          }
        }
        else
          this.UpdateMusicIsOn();
        this.UpdateVolume();
        if (MediaPlayer.GameHasControl)
        {
label_21:
          switch (7)
          {
            case 0:
              goto label_21;
            default:
              MediaPlayer.IsMuted = ReferenceInvoker.DisconnectProject(156) != 0;
              break;
          }
        }
      }
      catch
      {
      }
      while (TimeSpan.FromTicks(DateTime.Now.Ticks - this.currentUri.Ticks).TotalMilliseconds < ReferenceInvoker.DisconnectProject(164))
        PlatformHelper.Sleep(ReferenceInvoker.DisconnectProject(160));
label_26:
      switch (2)
      {
        case 0:
          goto label_26;
        default:
          this.ResetElapsedTime();
          if (flag1)
          {
label_28:
            switch (5)
            {
              case 0:
                goto label_28;
              default:
                if (GameplayScreenBase.Instance.IsActive)
                {
label_30:
                  switch (6)
                  {
                    case 0:
                      goto label_30;
                    default:
                      if ((int) ImageTable.DisconnectProject(ScreenManager.Instance.GetScreens()) == ReferenceInvoker.DisconnectProject(172))
                      {
label_32:
                        switch (5)
                        {
                          case 0:
                            goto label_32;
                          default:
                            GameplayScreenBase.Instance.SwitchToPauseScreen(ReferenceInvoker.DisconnectProject(176) != 0);
                            break;
                        }
                      }
                      else
                        break;
                      break;
                  }
                }
                else
                  break;
                break;
            }
          }
          this.currentUri = ReferenceInvoker.DisconnectProject(180) != 0;
          this.filterID = ReferenceInvoker.DisconnectProject(184) != 0;
          break;
      }
    }

    private void DisconnectProject(out bool _param1)
    {
      this.parentKeywords = new DataHandler();
      if (!this.DeserializeOnlineCommunication())
        OnlineCommunications.Init();
      if (PlatformHelper.DisconnectProject())
      {
label_3:
        switch (7)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.DisconnectProject);
            }
            OnlineCommunications.Instance.RegisterUsage();
            OnlineCommunications.Instance.GetTop6Scores();
            break;
        }
      }
      ScreenManager screenManager = new ScreenManager(this);
      this.Components.Add((IGameComponent) ScreenManager.Instance);
      screenManager.Initialize();
      if (this.GameSettings == null)
      {
label_8:
        switch (6)
        {
          case 0:
            goto label_8;
          default:
            this.GameSettings = new GameSettings();
            break;
        }
      }
      if (!this.DeserializeStateBackup() && !this.DeserializeState())
      {
label_11:
        switch (4)
        {
          case 0:
            goto label_11;
          default:
            this.GameSettings = new GameSettings();
            break;
        }
      }
      PlatformHelper.DisposeDrive();
      AdController.Init();
      GameData.Instance.DisposeDrive();
      bool flag1 = ReferenceInvoker.DisconnectProject(188) != 0;
      if (ScreenManager.Instance.DeserializeState())
      {
label_14:
        switch (5)
        {
          case 0:
            goto label_14;
          default:
            flag1 = ReferenceInvoker.DisconnectProject(192) != 0;
            break;
        }
      }
      if (flag1)
      {
label_17:
        switch (4)
        {
          case 0:
            goto label_17;
          default:
            if (PlatformHelper.DisconnectProject())
            {
label_19:
              switch (3)
              {
                case 0:
                  goto label_19;
              }
            }
            else
              goto label_31;
            break;
        }
      }
      bool flag2 = ReferenceInvoker.DisconnectProject(196) != 0;
      GameScreen[] screens = ScreenManager.Instance.GetScreens();
      for (int index = ReferenceInvoker.DisconnectProject(200); index < (int) ImageTable.DisconnectProject(screens); index += ReferenceInvoker.DisconnectProject(208))
      {
        if (StubQueue.DisconnectProject((object) screens[index]) != null)
          flag2 = ReferenceInvoker.DisconnectProject(204) != 0;
        else if (PcitureStream.DisconnectProject((object) screens[index]) == null)
          ScreenManager.Instance.RemoveScreen(screens[index]);
      }
label_27:
      switch (7)
      {
        case 0:
          goto label_27;
        default:
          if (!flag2)
          {
label_29:
            switch (6)
            {
              case 0:
                goto label_29;
              default:
                ScreenManager.Instance.AddScreen((GameScreen) new BackgroundScreen());
                ScreenManager.Instance.AddScreen((GameScreen) new MainMenuScreen());
                break;
            }
          }
          else
            break;
          break;
      }
label_31:
      _param1 = flag1;
      this.Exiting += new EventHandler<EventArgs>(this.DisposeDrive);
      this.Activated += new EventHandler<EventArgs>(this.DisconnectProject);
      if (GameplayScreenBase.Instance != null)
        return;
      GameBase.Instance.CreateGameplayScreen();
    }

    private void DisconnectProject(object _param1, EventArgs _param2)
    {
      this.DisconnectProject(TextFileSet.parentKeywords);
    }

    private void DisconnectProject(object _param1)
    {
      if (((IEnumerable<GameScreen>) ScreenManager.Instance.GetScreens()).Contains<GameScreen>((GameScreen) GameplayScreenBase.Instance))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.DisconnectProject);
            }
            GameBase.Instance.ResetElapsedTime();
            GameplayScreenBase.Instance.IsPaused = ReferenceInvoker.DisconnectProject(212) != 0;
            break;
        }
      }
      try
      {
        if (!GameBase.Instance.GameSettings.MusicIsOn)
          return;
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            if (!MediaPlayer.GameHasControl)
              break;
label_8:
            switch (1)
            {
              case 0:
                goto label_8;
              default:
                if (MediaPlayer.State == (MediaState) ReferenceInvoker.DisconnectProject(216))
                {
label_10:
                  switch (7)
                  {
                    case 0:
                      goto label_10;
                    default:
                      MediaPlayer.Resume();
                      return;
                  }
                }
                else
                {
                  if (MediaPlayer.State != MediaState.Stopped)
                    return;
label_13:
                  switch (3)
                  {
                    case 0:
                      goto label_13;
                    default:
                      if (((IEnumerable<GameScreen>) ScreenManager.Instance.GetScreens()).Contains<GameScreen>((GameScreen) GameplayScreenBase.Instance))
                      {
                        GameplayScreenBase.Instance.PlaySound();
                        return;
                      }
                      ScreenManager.Instance.PlaySound();
                      return;
                  }
                }
            }
        }
      }
      catch (Exception ex)
      {
      }
    }

    protected override void OnDeactivated(object sender, EventArgs args)
    {
      GameplayScreenBase instance = GameplayScreenBase.Instance;
      if (instance != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.OnDeactivated);
            }
            instance.IsPaused = ReferenceInvoker.DisconnectProject(220) != 0;
            break;
        }
      }
      try
      {
        if (MediaPlayer.GameHasControl)
        {
label_6:
          switch (7)
          {
            case 0:
              goto label_6;
            default:
              MediaPlayer.Pause();
              break;
          }
        }
      }
      catch (Exception ex)
      {
      }
      this.ResetElapsedTime();
      this.DisposeDrive();
      base.OnDeactivated(sender, args);
    }

    protected override void OnExiting(object sender, EventArgs args)
    {
      this.DisposeDrive();
      if (this.parentKeywords != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.OnExiting);
            }
            this.parentKeywords.Unload();
            break;
        }
      }
      base.OnExiting(sender, args);
    }

    private void DisposeDrive()
    {
      this.SerializeState();
      this.SerializeOnlineCommunication();
      ScreenManager instance = ScreenManager.Instance;
      if (instance == null)
        return;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.DisposeDrive);
          }
          instance.SerializeState();
          break;
      }
    }

    private void DisconnectProject(bool _param1)
    {
      int num1 = ReferenceInvoker.DisconnectProject(224);
      int num2 = ReferenceInvoker.DisconnectProject(228);
      _param1 = ReferenceInvoker.DisconnectProject(232) != 0;
      if (_param1)
      {
        this.Graphics.SupportedOrientations = (DisplayOrientation) ReferenceInvoker.DisconnectProject(236);
        this.parentKeywords = new Rectangle(ReferenceInvoker.DisconnectProject(240), ReferenceInvoker.DisconnectProject(244), num1, num2);
        this.ScreenBackBufferDimensions = new Point(num1, num2);
        this.Graphics.PreferredBackBufferWidth = num1;
        this.Graphics.PreferredBackBufferHeight = num2;
      }
      else
      {
        this.Graphics.SupportedOrientations = (DisplayOrientation) ReferenceInvoker.DisconnectProject(248);
        this.parentKeywords = new Rectangle(ReferenceInvoker.DisconnectProject(252), ReferenceInvoker.DisconnectProject(256), num1, num2);
        this.ScreenBackBufferDimensions = new Point(num1, num2);
        this.Graphics.PreferredBackBufferWidth = num1;
        this.Graphics.PreferredBackBufferHeight = num2;
      }
    }

    protected override sealed void LoadContent()
    {
      base.LoadContent();
      this.ListQueue();
      this.currentUri = this.Content.Load<Texture2D>(EditorService.DisconnectProject(194));
    }

    private void ListQueue()
    {
      this.parentKeywords = new RenderTarget2D(this.GraphicsDevice, ReferenceInvoker.DisconnectProject(260), ReferenceInvoker.DisconnectProject(264));
    }

    private void DisposeDrive(object _param1, EventArgs _param2)
    {
    }

    protected override void UnloadContent()
    {
      PlatformHelper.TestConnection();
      base.UnloadContent();
    }

    protected override void Update(GameTime gameTime)
    {
      if (this.currentUri)
      {
        if (PlatformHelper.DisconnectProject())
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.Update);
              }
              this.SuppressDraw();
              break;
          }
        }
        else
        {
          if (!this.parentCancel)
            return;
label_7:
          switch (1)
          {
            case 0:
              goto label_7;
            default:
              if (this.filterID)
                break;
label_9:
              switch (4)
              {
                case 0:
                  goto label_9;
                default:
                  this.currentUri = DateTime.Now;
                  this.DisconnectProject();
                  return;
              }
          }
        }
      }
      else
      {
        AdController.Instance.Update(gameTime);
        if (AdController.Instance.Engaged)
          return;
        base.Update(gameTime);
      }
    }

    protected override void Draw(GameTime gameTime)
    {
      if (this.currentUri)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.Draw);
            }
            this.SpriteBatch.Begin();
            this.SpriteBatch.Draw(this.parentKeywords, this.parentKeywords, Color.White);
            this.SpriteBatch.End();
            this.parentCancel = ReferenceInvoker.DisconnectProject(268) != 0;
            break;
        }
      }
      else
      {
        int preferredBackBufferWidth = this.Graphics.PreferredBackBufferWidth;
        int backBufferHeight = this.Graphics.PreferredBackBufferHeight;
        if (PlatformHelper.DisconnectProject() == (PlatformHelper.ScreenModeTypes) ReferenceInvoker.DisconnectProject(272))
        {
label_6:
          switch (7)
          {
            case 0:
              goto label_6;
            default:
              this.Graphics.GraphicsDevice.Clear(Color.Black);
              this.SpriteBatch.Begin();
              PlatformHelper.ExtractDockingPane(preferredBackBufferWidth, backBufferHeight);
              this.SpriteBatch.End();
              break;
          }
        }
        else
        {
          if (this.parentKeywords == null)
            this.ListQueue();
          this.GraphicsDevice.SetRenderTarget(this.parentKeywords);
          this.Graphics.GraphicsDevice.Clear(Color.Transparent);
          base.Draw(gameTime);
          this.GraphicsDevice.SetRenderTarget(AssemblyAttribute.parentKeywords);
          this.SpriteBatch.Begin();
          this.SpriteBatch.Draw(this.currentUri, new Rectangle(ReferenceInvoker.DisconnectProject(276), ReferenceInvoker.DisconnectProject(280), this.Graphics.PreferredBackBufferWidth, this.Graphics.PreferredBackBufferHeight), Color.White);
          this.SpriteBatch.Draw((Texture2D) this.parentKeywords, this.GetHandyCenteredDrawPos(), Color.White);
          this.DrawNormalScaledStuff();
          this.SpriteBatch.End();
        }
      }
    }

    public Rectangle GetHandyCenteredDrawPos()
    {
      int backBufferHeight = this.Graphics.PreferredBackBufferHeight;
      int width = (int) (ReferenceInvoker.DisconnectProject(284) * (double) backBufferHeight);
      return new Rectangle(this.Graphics.PreferredBackBufferWidth / ReferenceInvoker.DisconnectProject(292) - width / ReferenceInvoker.DisconnectProject(296), ReferenceInvoker.DisconnectProject(300), width, backBufferHeight);
    }

    public virtual void SerializeState()
    {
      if (PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(265)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.SerializeState);
            }
            int num = ReferenceInvoker.DisconnectProject(304);
            bool flag = ReferenceInvoker.DisconnectProject(308) != 0;
            for (; num > ReferenceInvoker.DisconnectProject(316); num -= ReferenceInvoker.DisconnectProject(312))
            {
              if (!flag)
              {
                if (PlatformLocalStorage.FileExists(EditorService.DisconnectProject(282)))
                {
label_6:
                  switch (2)
                  {
                    case 0:
                      goto label_6;
                    default:
                      if (PlatformLocalStorage.FileExists(EditorService.DisconnectProject(333)))
                      {
label_8:
                        switch (7)
                        {
                          case 0:
                            goto label_8;
                          default:
                            PlatformLocalStorage.DeleteFile(EditorService.DisconnectProject(333));
                            break;
                        }
                      }
                      flag = PlatformLocalStorage.MoveFile(EditorService.DisconnectProject(282), EditorService.DisconnectProject(333));
                      continue;
                  }
                }
              }
              else
              {
label_14:
                switch (2)
                {
                  case 0:
                    goto label_14;
                  default:
                    goto label_15;
                }
              }
            }
label_15:
            if (!flag && PlatformLocalStorage.FileExists(EditorService.DisconnectProject(282)))
            {
label_16:
              switch (7)
              {
                case 0:
                  goto label_16;
                default:
                  PlatformLocalStorage.DeleteFile(EditorService.DisconnectProject(282));
                  break;
              }
            }
            else
              break;
            break;
        }
      }
      else
        PlatformLocalStorage.CreateDirectory(EditorService.DisconnectProject(265));
      bool flag1 = ReferenceInvoker.DisconnectProject(320) != 0;
      for (int index = ReferenceInvoker.DisconnectProject(324); index > ReferenceInvoker.DisconnectProject(332); index -= ReferenceInvoker.DisconnectProject(328))
      {
label_25:
        switch (7)
        {
          case 0:
            goto label_25;
          default:
            if (!flag1)
            {
              flag1 = PlatformLocalStorage.SerializeObjectToFile(EditorService.DisconnectProject(282), (object) this.GameSettings);
              if (!flag1)
              {
label_21:
                switch (2)
                {
                  case 0:
                    goto label_21;
                  default:
                    PlatformLocalStorage.RequestAdditionalStorageIfNotEnough();
                    continue;
                }
              }
              else
                continue;
            }
            else
            {
label_27:
              switch (6)
              {
                case 0:
                  goto label_27;
                default:
                  return;
              }
            }
        }
      }
    }

    public void SerializeOnlineCommunication()
    {
      if (PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(384)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.SerializeOnlineCommunication);
            }
            PlatformLocalStorage.DeleteFiles(EditorService.DisconnectProject(384));
            break;
        }
      }
      else
        PlatformLocalStorage.CreateDirectory(EditorService.DisconnectProject(384));
      OnlineCommunications instance = OnlineCommunications.Instance;
      if (instance == null)
        return;
      PlatformLocalStorage.SerializeObjectToFile(EditorService.DisconnectProject(423), (object) instance);
    }

    public virtual bool DeserializeState()
    {
      if (!PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(265)))
        return ReferenceInvoker.DisconnectProject(352) != 0;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.DeserializeState);
          }
          bool flag = ReferenceInvoker.DisconnectProject(336) != 0;
          Type typeFromHandle = Type.GetTypeFromHandle(GroupToken.DisconnectProject());
          if (PlatformLocalStorage.FileExists(EditorService.DisconnectProject(282)))
          {
label_5:
            switch (4)
            {
              case 0:
                goto label_5;
              default:
                this.GameSettings = LineScope.DisconnectProject(PlatformLocalStorage.DeserializeObjectFromFile(EditorService.DisconnectProject(282), typeFromHandle));
                if (this.GameSettings != null)
                {
label_7:
                  switch (2)
                  {
                    case 0:
                      goto label_7;
                    default:
                      flag = ReferenceInvoker.DisconnectProject(340) != 0;
                      break;
                  }
                }
                else
                  break;
                break;
            }
          }
          if (flag)
            return ReferenceInvoker.DisconnectProject(344) != 0;
          if (PlatformLocalStorage.FileExists(EditorService.DisconnectProject(333)))
          {
            this.GameSettings = LineScope.DisconnectProject(PlatformLocalStorage.DeserializeObjectFromFile(EditorService.DisconnectProject(333), typeFromHandle));
            if (this.GameSettings != null)
            {
label_13:
              switch (5)
              {
                case 0:
                  goto label_13;
                default:
                  flag = ReferenceInvoker.DisconnectProject(348) != 0;
                  break;
              }
            }
          }
          return flag;
      }
    }

    public bool DeserializeOnlineCommunication()
    {
      if (PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(384)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameBase.DeserializeOnlineCommunication);
            }
            if (PlatformLocalStorage.FileExists(EditorService.DisconnectProject(423)))
            {
label_5:
              switch (6)
              {
                case 0:
                  goto label_5;
                default:
                  OnlineCommunications.Instance = ResourceConverter.DisconnectProject(PlatformLocalStorage.DeserializeObjectFromFile(EditorService.DisconnectProject(423), Type.GetTypeFromHandle(VectorConverter.DisconnectProject())));
                  return OnlineCommunications.Instance == null ? ReferenceInvoker.DisconnectProject(356) != 0 : ReferenceInvoker.DisconnectProject(360) != 0;
              }
            }
            else
              break;
        }
      }
      return ReferenceInvoker.DisconnectProject(364) != 0;
    }

    public abstract GameplayScreenBase CreateGameplayScreen();

    public abstract void AddScreenTypeNameMapping(Dictionary<Type, string> screensNameMapping);

    public abstract void SerializeGameplay();

    public abstract void DeserializeGameplay();

    public abstract MenuScreen GetAchievementScreen();

    public abstract MenuScreen GetPuzzleScreen();

    public abstract int GetBestSolution(int challangeIndex, int levelIndex);

    protected abstract bool DeserializeStateBackup();

    public abstract bool IsAnyGameplyScreenType(Type screenType);

    public abstract PlatformInheritBase CreatePlatformInheritClass();

    protected abstract void DrawNormalScaledStuff();

    public abstract void HandleGuiInput(InputState input);
  }
}
