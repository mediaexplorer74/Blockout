// Decompiled with JetBrains decompiler
// Type: Blockout.Game1
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

#nullable disable
namespace Blockout
{
  public class Game1 : GameBase
  {
    private float parentKeywords;
    private Block parentKeywords;

    public override GameplayScreenBase CreateGameplayScreen()
    {
      return (GameplayScreenBase) new GameplayScreen();
    }

    public override void AddScreenTypeNameMapping(Dictionary<Type, string> screensNameMapping)
    {
      screensNameMapping.Add(Type.GetTypeFromHandle(StubSerializer.DisconnectProject()), DatabaseLoader.DisconnectProject(10116));
      screensNameMapping.Add(Type.GetTypeFromHandle(ActivitySet.DisconnectProject()), DatabaseLoader.DisconnectProject(10145));
      screensNameMapping.Add(Type.GetTypeFromHandle(DeploymentSite.DisconnectProject()), DatabaseLoader.DisconnectProject(10180));
      screensNameMapping.Add(Type.GetTypeFromHandle(StoreToken.DisconnectProject()), DatabaseLoader.DisconnectProject(10217));
      screensNameMapping.Add(Type.GetTypeFromHandle(ImageStream.DisconnectProject()), DatabaseLoader.DisconnectProject(10252));
    }

    public override void SerializeState()
    {
      SymbolStack.DisconnectProject(this.GameSettings);
      base.SerializeState();
    }

    public override bool DeserializeState() => base.DeserializeState();

    public override void SerializeGameplay()
    {
      PlatformLocalStorage.SerializeObjectToFile(DatabaseLoader.DisconnectProject(10277), (object) GameplayScreen.Instance);
    }

    public override void DeserializeGameplay()
    {
      if (!PlatformLocalStorage.FileExists(DatabaseLoader.DisconnectProject(10277)))
        return;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Game1.DeserializeGameplay);
          }
          GameplayScreen.Instance = ActivityQueue.DisconnectProject(PlatformLocalStorage.DeserializeObjectFromFile(DatabaseLoader.DisconnectProject(10277), Type.GetTypeFromHandle(StubSerializer.DisconnectProject())));
          GameplayScreenBase.Instance = (GameplayScreenBase) GameplayScreen.Instance;
          GameplayScreen instance = GameplayScreen.Instance;
          break;
      }
    }

    protected override bool DeserializeStateBackup() => SymbolStack.DisconnectProject();

    public override MenuScreen GetAchievementScreen() => (MenuScreen) new AchievementsScreen();

    public override MenuScreen GetPuzzleScreen() => (MenuScreen) new PuzzlePacksScreen();

    public override int GetBestSolution(int challangeIndex, int levelIndex)
    {
      return PredefinedLevels.GetPerfectSolutionMoves((ChallangeBlock) challangeIndex, levelIndex);
    }

    public override bool IsAnyGameplyScreenType(Type screenType)
    {
      return (object) screenType != (object) Type.GetTypeFromHandle(StubSerializer.DisconnectProject()) ? (object) screenType == (object) Type.GetTypeFromHandle(ContextTree.DisconnectProject()) : ClientTree.DisconnectProject(2020) != 0;
    }

    public override PlatformInheritBase CreatePlatformInheritClass()
    {
      return StoreManager.DisconnectProject();
    }

    protected override void DrawNormalScaledStuff()
    {
      Block parentKeywords = this.parentKeywords;
      if (parentKeywords != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Game1.DrawNormalScaledStuff);
            }
            Rectangle handyCenteredDrawPos = this.GetHandyCenteredDrawPos();
            float scaleX = (float) handyCenteredDrawPos.Width / ClientTree.DisconnectProject(2024);
            float scaleY = (float) handyCenteredDrawPos.Height / ClientTree.DisconnectProject(2028);
            parentKeywords.Draw(this.parentKeywords, scaleX, scaleY, handyCenteredDrawPos.Left, handyCenteredDrawPos.Top);
            break;
        }
      }
      this.parentKeywords = ActivatorFactory.parentKeywords;
      this.parentKeywords = ClientTree.DisconnectProject(2032);
      GameScreen[] screens = ScreenManager.Instance.GetScreens();
      bool flag = ClientTree.DisconnectProject(2036) != 0;
label_26:
      for (int index1 = ClientTree.DisconnectProject(2040); index1 < (int) ToolboxEventArgs.DisconnectProject(screens); index1 += ClientTree.DisconnectProject(2060))
      {
        GameScreen gameScreen1 = screens[index1];
        if (ActivityQueue.DisconnectProject((object) gameScreen1) == null)
        {
label_7:
          switch (6)
          {
            case 0:
              goto label_7;
            default:
              if (MenuTable.DisconnectProject((object) gameScreen1) == null && GroupSet.DisconnectProject((object) gameScreen1) == null)
              {
label_9:
                switch (7)
                {
                  case 0:
                    goto label_9;
                  default:
                    if (ConfigConverter.DisconnectProject((object) gameScreen1) != null)
                    {
label_11:
                      switch (1)
                      {
                        case 0:
                          goto label_11;
                      }
                    }
                    else if (EmulatorToken.DisconnectProject((object) gameScreen1) != null)
                    {
                      GameScreen[] screensToLoad = EmulatorToken.DisconnectProject((object) gameScreen1).screensToLoad;
                      for (int index2 = ClientTree.DisconnectProject(2048); index2 < (int) ToolboxEventArgs.DisconnectProject(screensToLoad); index2 += ClientTree.DisconnectProject(2056))
                      {
                        GameScreen gameScreen2 = screensToLoad[index2];
                        if (ActivityQueue.DisconnectProject((object) gameScreen2) == null && MenuTable.DisconnectProject((object) gameScreen2) == null)
                        {
label_16:
                          switch (5)
                          {
                            case 0:
                              goto label_16;
                            default:
                              if (GroupSet.DisconnectProject((object) gameScreen2) == null)
                              {
label_18:
                                switch (4)
                                {
                                  case 0:
                                    goto label_18;
                                  default:
                                    if (ConfigConverter.DisconnectProject((object) gameScreen2) != null)
                                    {
label_20:
                                      switch (3)
                                      {
                                        case 0:
                                          goto label_20;
                                      }
                                    }
                                    else
                                      continue;
                                    break;
                                }
                              }
                              else
                                break;
                          }
                        }
                        flag = ClientTree.DisconnectProject(2052) != 0;
                        goto label_26;
                      }
label_24:
                      switch (1)
                      {
                        case 0:
                          goto label_24;
                        default:
                          continue;
                      }
                    }
                    else
                      continue;
                    break;
                }
              }
              else
                break;
          }
        }
        flag = ClientTree.DisconnectProject(2044) != 0;
        goto label_28;
      }
label_27:
      switch (3)
      {
        case 0:
          goto label_27;
      }
label_28:
      if (!flag)
        return;
label_29:
      switch (6)
      {
        case 0:
          goto label_29;
        default:
          Gui.Instance.Draw();
          break;
      }
    }

    public void DrawingBlueBlock(Block blueBlock, float blueBlockTransitionAlpha)
    {
      this.parentKeywords = blueBlock;
      this.parentKeywords = blueBlockTransitionAlpha;
    }

    protected override void Update(GameTime gameTime)
    {
      base.Update(gameTime);
      Gui instance = Gui.Instance;
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Game1.Update);
          }
          instance.Update(gameTime.ElapsedGameTime.TotalMilliseconds);
          break;
      }
    }

    public override void HandleGuiInput(InputState input)
    {
      Gui instance = Gui.Instance;
      if (instance == null)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Game1.HandleGuiInput);
            break;
        }
      }
      else
        instance.DisconnectProject(input);
    }
  }
}
