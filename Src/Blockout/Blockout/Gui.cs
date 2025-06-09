// *************************************************************
// Type: Blockout.Gui
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Runtime.Serialization;
using System.Text;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class Gui : GuiBase
  {
    private const int parentKeywords = 5;
    private const float parentKeywords = 0.65f;
    public const int HitMargin = 10;
    public const int arrowHorizontalAdditionalHit = 20;
    public static Gui Instance;
    private bool parentKeywords;
    private Texture2D parentKeywords;
    private Vector2 parentKeywords;
    private StringBuilder parentKeywords;
    private Vector2 currentUri;
    private StringBuilder currentUri;
    private Vector2 filterID;
    private StringBuilder filterID;
    private Vector2 parentCancel;
    private StringBuilder parentCancel;
    private Vector2 namesID;
    private StringBuilder namesID;
    private Vector2 currentNode;
    private StringBuilder currentNode;
    private Vector2 idToken;
    private StringBuilder idToken;
    private Vector2 nextOutput;
    private StringBuilder nextOutput;
    private Vector2 timerDisposed;
    private StringBuilder timerDisposed;
    private Vector2 messageCount;
    private StringBuilder messageCount;
    private Vector2 generatorToken;
    private Texture2D currentUri;
    private Texture2D filterID;
    private Rectangle parentKeywords;
    private Rectangle currentUri;
    private Texture2D parentCancel;
    private Rectangle filterID;
    private Rectangle parentCancel;
    private Texture2D namesID;
    private Rectangle namesID;
    private Rectangle currentNode;
    private Texture2D currentNode;
    private Rectangle idToken;
    private Rectangle nextOutput;
    private Texture2D idToken;
    private Rectangle timerDisposed;
    private Rectangle messageCount;
    private Texture2D nextOutput;
    private Rectangle generatorToken;
    private Rectangle currentValues;
    private Texture2D timerDisposed;
    private Rectangle windowPosition;
    private Rectangle handlerHandle;

    private Gui() => this.LoadContent();

    public static Gui Init() => Gui.Instance != null ? Gui.Instance : new Gui();

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void LoadContent()
    {
      if (Gui.Instance != null)
        return;
      Gui.Instance = this;
      this.parentKeywords = new Vector2(ClientTree.DisconnectProject(2064), ClientTree.DisconnectProject(2068));
      this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10342));
      this.parentKeywords = new StringBuilder(DatabaseLoader.DisconnectProject(10375));
      this.currentUri = new Vector2(ClientTree.DisconnectProject(2072) - ScreenManager.Instance.MenuFont.MeasureString(this.parentKeywords).X * ClientTree.DisconnectProject(2076), ClientTree.DisconnectProject(2080));
      this.currentUri = new StringBuilder(DatabaseLoader.DisconnectProject(10386));
      this.filterID = new StringBuilder(DatabaseLoader.DisconnectProject(10391));
      this.parentCancel = new Vector2(ClientTree.DisconnectProject(2084) - ScreenManager.Instance.MenuFont.MeasureString(this.filterID).X * ClientTree.DisconnectProject(2088), ClientTree.DisconnectProject(2092));
      this.parentCancel = new StringBuilder(DatabaseLoader.DisconnectProject(10386));
      this.namesID = new StringBuilder(DatabaseLoader.DisconnectProject(10406));
      this.currentNode = new Vector2(ClientTree.DisconnectProject(2096) - ScreenManager.Instance.MenuFont.MeasureString(this.namesID).X * ClientTree.DisconnectProject(2100), ClientTree.DisconnectProject(2104));
      this.currentNode = new StringBuilder(DatabaseLoader.DisconnectProject(10386));
      this.timerDisposed = new StringBuilder(DatabaseLoader.DisconnectProject(10417));
      this.messageCount = new Vector2(ClientTree.DisconnectProject(2108) - ScreenManager.Instance.MenuFont.MeasureString(this.timerDisposed).X * ClientTree.DisconnectProject(2112), ClientTree.DisconnectProject(2116));
      this.messageCount = new StringBuilder(DatabaseLoader.DisconnectProject(10386));
      this.idToken = new StringBuilder(DatabaseLoader.DisconnectProject(10426));
      this.nextOutput = new Vector2(ClientTree.DisconnectProject(2120) - ScreenManager.Instance.MenuFont.MeasureString(this.idToken).X * ClientTree.DisconnectProject(2124), ClientTree.DisconnectProject(2128));
      this.nextOutput = new StringBuilder(DatabaseLoader.DisconnectProject(10386));
      this.DisposeDrive();
      this.currentUri = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10439));
      this.parentKeywords = new Rectangle(ClientTree.DisconnectProject(2132), ClientTree.DisconnectProject(2136), ClientTree.DisconnectProject(2140), ClientTree.DisconnectProject(2144));
      this.filterID = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10439));
      this.currentUri = new Rectangle(ClientTree.DisconnectProject(2148), ClientTree.DisconnectProject(2152), ClientTree.DisconnectProject(2156), ClientTree.DisconnectProject(2160));
      this.parentCancel = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10484));
      this.filterID = new Rectangle(ClientTree.DisconnectProject(2164), ClientTree.DisconnectProject(2168), ClientTree.DisconnectProject(2172), ClientTree.DisconnectProject(2176));
      this.parentCancel = new Rectangle(this.filterID.X - ClientTree.DisconnectProject(2180) - ClientTree.DisconnectProject(2184), this.filterID.Y - ClientTree.DisconnectProject(2188), this.filterID.Width + ClientTree.DisconnectProject(2192) + ClientTree.DisconnectProject(2196), this.filterID.Height + ClientTree.DisconnectProject(2200));
      this.namesID = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10517));
      this.namesID = new Rectangle(ClientTree.DisconnectProject(2204), ClientTree.DisconnectProject(2208), ClientTree.DisconnectProject(2212), ClientTree.DisconnectProject(2216));
      this.currentNode = new Rectangle(this.namesID.X - ClientTree.DisconnectProject(2220) - ClientTree.DisconnectProject(2224), this.namesID.Y - ClientTree.DisconnectProject(2228), this.namesID.Width + ClientTree.DisconnectProject(2232) + ClientTree.DisconnectProject(2236), this.namesID.Height + ClientTree.DisconnectProject(2240));
      this.currentNode = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10552));
      this.idToken = new Rectangle(ClientTree.DisconnectProject(2244), ClientTree.DisconnectProject(2248), ClientTree.DisconnectProject(2252), ClientTree.DisconnectProject(2256));
      this.nextOutput = new Rectangle(this.idToken.X - ClientTree.DisconnectProject(2260), this.idToken.Y - ClientTree.DisconnectProject(2264), this.idToken.Width + ClientTree.DisconnectProject(2268), this.idToken.Height + ClientTree.DisconnectProject(2272));
      this.idToken = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10593));
      this.timerDisposed = new Rectangle(ClientTree.DisconnectProject(2276), ClientTree.DisconnectProject(2280), ClientTree.DisconnectProject(2284), ClientTree.DisconnectProject(2288));
      this.messageCount = new Rectangle(this.timerDisposed.X - ClientTree.DisconnectProject(2292), this.timerDisposed.Y - ClientTree.DisconnectProject(2296), this.timerDisposed.Width + ClientTree.DisconnectProject(2300), this.timerDisposed.Height + ClientTree.DisconnectProject(2304));
      this.timerDisposed = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10638));
      this.windowPosition = new Rectangle(ClientTree.DisconnectProject(2308), ClientTree.DisconnectProject(2312), ClientTree.DisconnectProject(2316), ClientTree.DisconnectProject(2320));
      this.handlerHandle = new Rectangle(this.windowPosition.X - ClientTree.DisconnectProject(2324), this.windowPosition.Y - ClientTree.DisconnectProject(2328), this.windowPosition.Width + ClientTree.DisconnectProject(2332), this.windowPosition.Height + ClientTree.DisconnectProject(2336));
      this.nextOutput = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10679));
      this.generatorToken = new Rectangle(ClientTree.DisconnectProject(2340), ClientTree.DisconnectProject(2344), ClientTree.DisconnectProject(2348), ClientTree.DisconnectProject(2352));
      this.currentValues = new Rectangle(this.generatorToken.X - ClientTree.DisconnectProject(2356), this.generatorToken.Y - ClientTree.DisconnectProject(2360), this.generatorToken.Width + ClientTree.DisconnectProject(2364), this.generatorToken.Height + ClientTree.DisconnectProject(2368));
    }

    public void Update(double elapsedGameTimeMs)
    {
      this.parentKeywords = ClientTree.DisconnectProject(2372) != 0;
      this.DisconnectProject();
    }

    private void DisconnectProject()
    {
      this.currentUri.Clear();
      this.currentUri.Append(GameplayScreen.Instance.currentChallange.ToString());
      this.parentCancel.Clear();
      this.parentCancel.Concat(GameplayScreen.Instance.currentLevel + ClientTree.DisconnectProject(2376));
      this.messageCount.Clear();
      this.messageCount.Concat(PredefinedLevels.GetPerfectSolutionMoves(GameplayScreen.Instance.currentChallange, GameplayScreen.Instance.currentLevel));
      this.nextOutput.Clear();
      if (GameplayScreen.Instance.gameLevel != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Gui.DisconnectProject);
            }
            this.nextOutput.Concat(GameplayScreen.Instance.gameLevel.MovementCounter);
            break;
        }
      }
      else
        this.nextOutput.Concat(ClientTree.DisconnectProject(2380));
      this.currentNode.Clear();
      int currentChallange = (int) GameplayScreen.Instance.currentChallange;
      int currentLevel = GameplayScreen.Instance.currentLevel;
      if (GameBase.Instance.GameSettings.BestPlayResults[currentChallange] != null)
      {
label_7:
        switch (4)
        {
          case 0:
            goto label_7;
          default:
            if (GameBase.Instance.GameSettings.BestPlayResults[currentChallange][currentLevel] > ClientTree.DisconnectProject(2384))
            {
              this.currentNode.Concat(GameBase.Instance.GameSettings.BestPlayResults[currentChallange][currentLevel]);
              return;
            }
            break;
        }
      }
      this.currentNode.Append(DatabaseLoader.DisconnectProject(10386));
    }

    private void DisposeDrive()
    {
      int num = ClientTree.DisconnectProject(2388);
      this.filterID = new Vector2((float) (ClientTree.DisconnectProject(2392) + num), this.currentUri.Y);
      this.namesID = new Vector2((float) (ClientTree.DisconnectProject(2396) + num), this.parentCancel.Y);
      this.idToken = new Vector2((float) (ClientTree.DisconnectProject(2400) + num), this.currentNode.Y);
      this.generatorToken = new Vector2((float) (ClientTree.DisconnectProject(2404) + num), this.messageCount.Y);
      this.timerDisposed = new Vector2((float) (ClientTree.DisconnectProject(2408) + num), this.nextOutput.Y);
    }

    private bool DisconnectProject()
    {
      GameScreen[] screens = ScreenManager.Instance.GetScreens();
      for (int index = ClientTree.DisconnectProject(2412); index < (int) ToolboxEventArgs.DisconnectProject(screens); index += ClientTree.DisconnectProject(2420))
      {
        if (MenuTable.DisconnectProject((object) screens[index]) != null)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (Gui.DisconnectProject);
              }
              return ClientTree.DisconnectProject(2416) != 0;
          }
        }
      }
      return ClientTree.DisconnectProject(2424) != 0;
    }

    public void Draw()
    {
      this.parentKeywords = ClientTree.DisconnectProject(2428) != 0;
      bool flag = this.DisposeDrive();
      int num = ClientTree.DisconnectProject(2432);
      if (flag)
      {
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, new Vector2(this.currentUri.X + (float) num, this.currentUri.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2436), Vector2.Zero, ClientTree.DisconnectProject(2440), (SpriteEffects) ClientTree.DisconnectProject(2444), ClientTree.DisconnectProject(2448));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, this.currentUri, Color.White, ClientTree.DisconnectProject(2452), Vector2.Zero, ClientTree.DisconnectProject(2456), (SpriteEffects) ClientTree.DisconnectProject(2460), ClientTree.DisconnectProject(2464));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.currentUri, new Vector2(this.filterID.X + (float) num, this.filterID.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2468), Vector2.Zero, ClientTree.DisconnectProject(2472), (SpriteEffects) ClientTree.DisconnectProject(2476), ClientTree.DisconnectProject(2480));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.currentUri, this.filterID, Color.LightBlue, ClientTree.DisconnectProject(2484), Vector2.Zero, ClientTree.DisconnectProject(2488), (SpriteEffects) ClientTree.DisconnectProject(2492), ClientTree.DisconnectProject(2496));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.filterID, new Vector2(this.parentCancel.X + (float) num, this.parentCancel.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2500), Vector2.Zero, ClientTree.DisconnectProject(2504), (SpriteEffects) ClientTree.DisconnectProject(2508), ClientTree.DisconnectProject(2512));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.filterID, this.parentCancel, Color.White, ClientTree.DisconnectProject(2516), Vector2.Zero, ClientTree.DisconnectProject(2520), (SpriteEffects) ClientTree.DisconnectProject(2524), ClientTree.DisconnectProject(2528));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentCancel, new Vector2(this.namesID.X + (float) num, this.namesID.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2532), Vector2.Zero, ClientTree.DisconnectProject(2536), (SpriteEffects) ClientTree.DisconnectProject(2540), ClientTree.DisconnectProject(2544));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentCancel, this.namesID, Color.LightBlue, ClientTree.DisconnectProject(2548), Vector2.Zero, ClientTree.DisconnectProject(2552), (SpriteEffects) ClientTree.DisconnectProject(2556), ClientTree.DisconnectProject(2560));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.namesID, new Vector2(this.currentNode.X + (float) num, this.currentNode.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2564), Vector2.Zero, ClientTree.DisconnectProject(2568), (SpriteEffects) ClientTree.DisconnectProject(2572), ClientTree.DisconnectProject(2576));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.namesID, this.currentNode, Color.White, ClientTree.DisconnectProject(2580), Vector2.Zero, ClientTree.DisconnectProject(2584), (SpriteEffects) ClientTree.DisconnectProject(2588), ClientTree.DisconnectProject(2592));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.currentNode, new Vector2(this.idToken.X + (float) num, this.idToken.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2596), Vector2.Zero, ClientTree.DisconnectProject(2600), (SpriteEffects) ClientTree.DisconnectProject(2604), ClientTree.DisconnectProject(2608));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.currentNode, this.idToken, Color.LightBlue, ClientTree.DisconnectProject(2612), Vector2.Zero, ClientTree.DisconnectProject(2616), (SpriteEffects) ClientTree.DisconnectProject(2620), ClientTree.DisconnectProject(2624));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.idToken, new Vector2(this.nextOutput.X + (float) num, this.nextOutput.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2628), Vector2.Zero, ClientTree.DisconnectProject(2632), (SpriteEffects) ClientTree.DisconnectProject(2636), ClientTree.DisconnectProject(2640));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.idToken, this.nextOutput, Color.White, ClientTree.DisconnectProject(2644), Vector2.Zero, ClientTree.DisconnectProject(2648), (SpriteEffects) ClientTree.DisconnectProject(2652), ClientTree.DisconnectProject(2656));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.nextOutput, new Vector2(this.timerDisposed.X + (float) num, this.timerDisposed.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2660), Vector2.Zero, ClientTree.DisconnectProject(2664), (SpriteEffects) ClientTree.DisconnectProject(2668), ClientTree.DisconnectProject(2672));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.nextOutput, this.timerDisposed, Color.LightBlue, ClientTree.DisconnectProject(2676), Vector2.Zero, ClientTree.DisconnectProject(2680), (SpriteEffects) ClientTree.DisconnectProject(2684), ClientTree.DisconnectProject(2688));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.timerDisposed, new Vector2(this.messageCount.X + (float) num, this.messageCount.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2692), Vector2.Zero, ClientTree.DisconnectProject(2696), (SpriteEffects) ClientTree.DisconnectProject(2700), ClientTree.DisconnectProject(2704));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.timerDisposed, this.messageCount, Color.White, ClientTree.DisconnectProject(2708), Vector2.Zero, ClientTree.DisconnectProject(2712), (SpriteEffects) ClientTree.DisconnectProject(2716), ClientTree.DisconnectProject(2720));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.messageCount, new Vector2(this.generatorToken.X + (float) num, this.generatorToken.Y + (float) num), Color.Black, ClientTree.DisconnectProject(2724), Vector2.Zero, ClientTree.DisconnectProject(2728), (SpriteEffects) ClientTree.DisconnectProject(2732), ClientTree.DisconnectProject(2736));
        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.messageCount, this.generatorToken, Color.LightBlue, ClientTree.DisconnectProject(2740), Vector2.Zero, ClientTree.DisconnectProject(2744), (SpriteEffects) ClientTree.DisconnectProject(2748), ClientTree.DisconnectProject(2752));
      }
      GameBase.Instance.SpriteBatch.Draw(this.currentNode, new Rectangle(this.idToken.X + num, this.idToken.Y + num, this.idToken.Width, this.idToken.Height), Color.Black);
      GameBase.Instance.SpriteBatch.Draw(this.currentNode, this.idToken, Color.White);
      Color color1;
      if (!this.DisconnectProject())
      {
label_3:
        switch (3)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Gui.Draw);
            }
            color1 = Color.White;
            break;
        }
      }
      else
        color1 = Color.Gray;
      Color color2 = color1;
      GameBase.Instance.SpriteBatch.Draw(this.idToken, new Rectangle(this.timerDisposed.X + num, this.timerDisposed.Y + num, this.timerDisposed.Width, this.timerDisposed.Height), Color.Black);
      GameBase.Instance.SpriteBatch.Draw(this.idToken, this.timerDisposed, color2);
      Color color3;
      if (GameplayScreen.Instance.gameLevel.HastMovementsToUndo())
      {
label_9:
        switch (1)
        {
          case 0:
            goto label_9;
          default:
            color3 = Color.White;
            break;
        }
      }
      else
        color3 = Color.Gray;
      GameBase.Instance.SpriteBatch.Draw(this.nextOutput, new Rectangle(this.generatorToken.X + num, this.generatorToken.Y + num, this.generatorToken.Width, this.generatorToken.Height), Color.Black);
      GameBase.Instance.SpriteBatch.Draw(this.nextOutput, this.generatorToken, color3);
      GameBase.Instance.SpriteBatch.Draw(this.timerDisposed, new Rectangle(this.windowPosition.X + num, this.windowPosition.Y + num, this.generatorToken.Width, this.generatorToken.Height), Color.Black);
      GameBase.Instance.SpriteBatch.Draw(this.timerDisposed, this.windowPosition, color3);
    }

    private bool DisposeDrive()
    {
      GameScreen[] screens = ScreenManager.Instance.GetScreens();
      if ((int) ToolboxEventArgs.DisconnectProject(screens) == ClientTree.DisconnectProject(2756))
        return ActivityQueue.DisconnectProject((object) screens[ClientTree.DisconnectProject(2764)]) > MenuInvoker.parentKeywords;
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Gui.DisposeDrive);
          }
          return ClientTree.DisconnectProject(2760) != 0;
      }
    }

    internal void DisconnectProject(InputState _param1)
    {
      if (!this.parentKeywords)
        return;
      if (AdController.Instance.InputConsumed)
      {
label_3:
        switch (5)
        {
          case 0:
            goto label_3;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Gui.DisconnectProject);
            break;
        }
      }
      else
      {
        TouchLocation[] touchStateOriginal = _param1.TouchStateOriginal;
        bool flag = this.DisconnectProject();
        for (int index = (int) OptionsFactory.DisconnectProject(touchStateOriginal) - ClientTree.DisconnectProject(2768); index >= ClientTree.DisconnectProject(2804); index -= ClientTree.DisconnectProject(2800))
        {
          TouchLocation touchLocation = touchStateOriginal[index];
          if (!IntersectionHelper.InsideArea(this.parentKeywords, touchLocation.Position))
          {
label_9:
            switch (1)
            {
              case 0:
                goto label_9;
              default:
                if (!IntersectionHelper.InsideArea(this.currentUri, touchLocation.Position))
                  continue;
                break;
            }
          }
          if (touchLocation.State == (TouchLocationState) ClientTree.DisconnectProject(2772))
          {
            if (IntersectionHelper.InsideArea(this.nextOutput, touchLocation.Position))
            {
              MenuEntryButton.PlayClickSound();
              ScreenManager instance = ScreenManager.Instance;
              int num = ClientTree.DisconnectProject(2776);
              GameScreen[] gameScreenArray1 = DriveService.DisconnectProject(ClientTree.DisconnectProject(2780));
              gameScreenArray1[ClientTree.DisconnectProject(2784)] = (GameScreen) new MainMenuScreen();
              GameScreen[] gameScreenArray2 = gameScreenArray1;
              LoadingScreen.Load(instance, num != 0, gameScreenArray2);
            }
            else
            {
              if (!flag)
              {
label_15:
                switch (3)
                {
                  case 0:
                    goto label_15;
                  default:
                    if (IntersectionHelper.InsideArea(this.messageCount, touchLocation.Position))
                    {
label_17:
                      switch (2)
                      {
                        case 0:
                          goto label_17;
                        default:
                          if (GameplayScreen.Instance.IsActive)
                          {
label_19:
                            switch (2)
                            {
                              case 0:
                                goto label_19;
                              default:
                                MenuEntryButton.PlayClickSound();
                                ScreenManager instance = ScreenManager.Instance;
                                int num = ClientTree.DisconnectProject(2788);
                                GameScreen[] gameScreenArray3 = DriveService.DisconnectProject(ClientTree.DisconnectProject(2792));
                                gameScreenArray3[ClientTree.DisconnectProject(2796)] = (GameScreen) new PuzzlePacksScreen();
                                GameScreen[] gameScreenArray4 = gameScreenArray3;
                                LoadingScreen.Load(instance, num != 0, gameScreenArray4);
                                continue;
                            }
                          }
                          else
                            continue;
                      }
                    }
                    else
                      break;
                }
              }
              if (IntersectionHelper.InsideArea(this.handlerHandle, touchLocation.Position))
              {
label_22:
                switch (7)
                {
                  case 0:
                    goto label_22;
                  default:
                    if (GameplayScreen.Instance.gameLevel != null)
                    {
label_24:
                      switch (7)
                      {
                        case 0:
                          goto label_24;
                        default:
                          if (GameplayScreen.Instance.gameLevel.HastMovementsToUndo())
                          {
label_26:
                            switch (6)
                            {
                              case 0:
                                goto label_26;
                              default:
                                MenuEntryButton.PlayClickSound();
                                GameplayScreen.Instance.gameLevel.DisposeDrive();
                                continue;
                            }
                          }
                          else
                            continue;
                      }
                    }
                    else
                      continue;
                }
              }
              else if (IntersectionHelper.InsideArea(this.currentValues, touchLocation.Position) && GameplayScreen.Instance.gameLevel.HastMovementsToUndo())
              {
label_29:
                switch (2)
                {
                  case 0:
                    goto label_29;
                  default:
                    MenuEntryButton.PlayClickSound();
                    GameplayScreen.Instance.LoadLevel(GameplayScreen.Instance.currentChallange, GameplayScreen.Instance.currentLevel);
                    continue;
                }
              }
            }
          }
        }
      }
    }

    internal void ListQueue()
    {
    }
  }
}
