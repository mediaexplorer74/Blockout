// Decompiled with JetBrains decompiler
// Type: Blockout.GameplayScreen
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class GameplayScreen : GameplayScreenBase
  {
    private const bool parentKeywords = true;
    private const double parentKeywords = 500.0;
    public static GameplayScreen Instance;
    [DataMember]
    public int serializationVersion = ClientTree.DisconnectProject(1983725);
    [DataMember]
    public double deadSince;
    [DataMember]
    public bool showNoLifeLeft;
    private Texture2D parentKeywords;
    public bool ContentLoaded;
    [DataMember]
    public Player player;
    [DataMember]
    public Background background;
    [DataMember]
    public Gui gui;
    [DataMember]
    public ChallangeBlock currentChallange;
    [DataMember]
    public int currentLevel;
    [DataMember]
    public EnemyManager enemyManager;
    [DataMember]
    public GameLevel gameLevel;

    public GameplayScreen()
    {
      this.ContentLoaded = ClientTree.DisconnectProject(1983729) != 0;
      this.player = Player.Instance;
      this.background = Background.Instance;
      this.gui = Gui.Instance;
      this.enemyManager = EnemyManager.Instance;
      this.currentLevel = ClientTree.DisconnectProject(1983733);
      this.currentChallange = (ChallangeBlock) ClientTree.DisconnectProject(1983737);
      this.LoadContent();
      this.DisconnectProject();
    }

    [OnDeserialized]
    public new void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void LoadContent()
    {
      if (GameplayScreen.Instance != null)
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreen.LoadContent);
            break;
        }
      }
      else
      {
        GameplayScreen.Instance = this;
        if (this.ContentLoaded)
          return;
        Gui.Init();
        base.LoadContent();
        this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(11916));
        Player.Init();
        Background.Init();
        Scores.Init();
        EnemyManager.Init();
        AchievementManager.Init();
        AchievementTracker.Init();
        this.ContentLoaded = ClientTree.DisconnectProject(1983565) != 0;
      }
    }

    public void NextLevel()
    {
      if (!this.HigherLevelExists())
      {
        int currentChallange = (int) this.currentChallange;
        ChallangeBlock[] types = ChallangeBlockTypes.GetTypes();
        for (int index = ClientTree.DisconnectProject(1983569); index < (int) StreamManager.DisconnectProject(types); index += ClientTree.DisconnectProject(1983577))
        {
          if (index > currentChallange)
          {
            this.currentChallange = types[index];
            this.currentLevel = ClientTree.DisconnectProject(1983573);
            this.DisconnectProject();
            return;
          }
        }
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreen.NextLevel);
            break;
        }
      }
      else
      {
        this.currentLevel += ClientTree.DisconnectProject(1983581);
        this.DisconnectProject();
      }
    }

    public void PreviousLevel()
    {
      if (!this.LowerLevelExists())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreen.PreviousLevel);
            }
            int currentChallange = (int) this.currentChallange;
            ChallangeBlock[] types = ChallangeBlockTypes.GetTypes();
            for (int index = (int) StreamManager.DisconnectProject(types) - ClientTree.DisconnectProject(1983585); index >= ClientTree.DisconnectProject(1983597); index -= ClientTree.DisconnectProject(1983593))
            {
              if (index < currentChallange)
              {
label_6:
                switch (4)
                {
                  case 0:
                    goto label_6;
                  default:
                    this.currentChallange = types[index];
                    this.currentLevel = PredefinedLevels.LevelCount(this.currentChallange) - ClientTree.DisconnectProject(1983589);
                    this.DisconnectProject();
                    return;
                }
              }
            }
label_10:
            switch (7)
            {
              case 0:
                goto label_10;
              default:
                return;
            }
        }
      }
      else
      {
        this.currentLevel -= ClientTree.DisconnectProject(1983601);
        this.DisconnectProject();
      }
    }

    public bool HigherLevelExists()
    {
      return PredefinedLevels.LevelExists(this.currentChallange, this.currentLevel + ClientTree.DisconnectProject(1983605));
    }

    public bool LowerLevelExists()
    {
      return PredefinedLevels.LevelExists(this.currentChallange, this.currentLevel - ClientTree.DisconnectProject(1983609));
    }

    public void LoadLevel(ChallangeBlock challange, int levelIndex)
    {
      this.currentChallange = challange;
      this.currentLevel = levelIndex;
      this.DisconnectProject();
    }

    private void DisconnectProject()
    {
      if (this.currentLevel >= ClientTree.DisconnectProject(1983613))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreen.DisconnectProject);
            }
            if (!GameGenerator.DisconnectProject(this.currentChallange, this.currentLevel))
            {
label_5:
              switch (3)
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
      this.currentLevel = ClientTree.DisconnectProject(1983617);
      this.currentChallange = (ChallangeBlock) ClientTree.DisconnectProject(1983621);
label_7:
      this.gameLevel = GameGenerator.GenerateLevel(this.currentChallange, this.currentLevel);
    }

    public override Song GetSoundBackground()
    {
      return GameBase.Instance.Content.Load<Song>(DatabaseLoader.DisconnectProject(11963));
    }

    public override void UnloadContent() => base.UnloadContent();

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
      if (this.IsPaused)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreen.Update);
          }
          if (!this.IsActive)
          {
label_5:
            switch (7)
            {
              case 0:
                goto label_5;
              default:
                return;
            }
          }
          else
          {
            double totalMilliseconds = gameTime.ElapsedGameTime.TotalMilliseconds;
            if (Player.Instance.IsAlive)
              Player.Instance.Update(totalMilliseconds);
            Background.Instance.Update(totalMilliseconds);
            if (!this.showNoLifeLeft)
              break;
label_10:
            switch (6)
            {
              case 0:
                goto label_10;
              default:
                this.deadSince += gameTime.ElapsedGameTime.TotalMilliseconds;
                if (this.deadSince < ClientTree.DisconnectProject(1983625))
                  return;
label_12:
                switch (1)
                {
                  case 0:
                    goto label_12;
                  default:
                    this.showNoLifeLeft = ClientTree.DisconnectProject(1983633) != 0;
                    ScreenManager instance = ScreenManager.Instance;
                    int num1 = ClientTree.DisconnectProject(1983637);
                    int num2 = ClientTree.DisconnectProject(1983641);
                    GameScreen[] gameScreenArray1 = DriveService.DisconnectProject(ClientTree.DisconnectProject(1983645));
                    gameScreenArray1[ClientTree.DisconnectProject(1983649)] = (GameScreen) new BackgroundScreen();
                    gameScreenArray1[ClientTree.DisconnectProject(1983653)] = (GameScreen) new ScoreMenuScreen(Scores.Instance.Points);
                    GameScreen[] gameScreenArray2 = gameScreenArray1;
                    LoadingScreen.SwitchToTempScreen(instance, num1 != 0, num2 != 0, gameScreenArray2);
                    return;
                }
            }
          }
      }
    }

    public override void Draw(GameTime gameTime)
    {
      this.gameLevel.Draw(this.TransitionAlpha);
      base.Draw(gameTime);
    }

    protected override GuiBase InitGameGui() => (GuiBase) Gui.Instance;

    public override void HandleInput(InputState input)
    {
      if (input.IsNewButtonPress((Buttons) ClientTree.DisconnectProject(1983657)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameplayScreen.HandleInput);
            }
            if (Player.Instance.IsAlive)
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
                default:
                  ScreenManager instance = ScreenManager.Instance;
                  int num = ClientTree.DisconnectProject(1983661);
                  GameScreen[] gameScreenArray1 = DriveService.DisconnectProject(ClientTree.DisconnectProject(1983665));
                  gameScreenArray1[ClientTree.DisconnectProject(1983669)] = (GameScreen) new BackgroundScreen();
                  gameScreenArray1[ClientTree.DisconnectProject(1983673)] = (GameScreen) new MainMenuScreen();
                  GameScreen[] gameScreenArray2 = gameScreenArray1;
                  LoadingScreen.Load(instance, num != 0, gameScreenArray2);
                  return;
              }
            }
            else
            {
              ScreenManager instance = ScreenManager.Instance;
              int num1 = ClientTree.DisconnectProject(1983677);
              int num2 = ClientTree.DisconnectProject(1983681);
              GameScreen[] gameScreenArray3 = DriveService.DisconnectProject(ClientTree.DisconnectProject(1983685));
              gameScreenArray3[ClientTree.DisconnectProject(1983689)] = (GameScreen) new BackgroundScreen();
              gameScreenArray3[ClientTree.DisconnectProject(1983693)] = (GameScreen) new ScoreMenuScreen(Scores.Instance.Points);
              GameScreen[] gameScreenArray4 = gameScreenArray3;
              LoadingScreen.SwitchToTempScreen(instance, num1 != 0, num2 != 0, gameScreenArray4);
              break;
            }
        }
      }
      else
      {
        base.HandleInput(input);
        this.gameLevel.DisconnectProject(input);
      }
    }

    public override void SwitchToPauseScreen(bool useLoadingScreen)
    {
    }

    public override void Resume()
    {
      base.Resume();
      EnemyManager.Instance.IsActive = ClientTree.DisconnectProject(1983697) != 0;
    }

    public override void ResetGame()
    {
      base.ResetGame();
      Player.Instance.TestConnection();
      Background.Instance.DisposeDrive();
      Gui.Instance.ListQueue();
      EnemyManager.Instance.Reset();
      AchievementManager.Instance.Reset();
      AchievementTracker.Instance.Reset();
      this.showNoLifeLeft = ClientTree.DisconnectProject(1983701) != 0;
      this.deadSince = ClientTree.DisconnectProject(1983705);
      this.ContentLoaded = ClientTree.DisconnectProject(1983713) != 0;
    }

    internal bool DisconnectProject()
    {
      return this.currentChallange > (ChallangeBlock) ClientTree.DisconnectProject(1983717);
    }

    internal bool DisposeDrive()
    {
      return this.currentChallange < (ChallangeBlock) ((int) StreamManager.DisconnectProject(ChallangeBlockTypes.GetTypes()) - ClientTree.DisconnectProject(1983721));
    }
  }
}
