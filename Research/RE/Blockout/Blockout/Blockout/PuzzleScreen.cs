// Decompiled with JetBrains decompiler
// Type: Blockout.PuzzleScreen
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class PuzzleScreen : MenuScreen
  {
    private const int parentKeywords = 4;
    private const int currentUri = 65;
    private const int filterID = 200;
    private const int parentCancel = 80;
    private const int namesID = 4;
    private const int currentNode = 5;
    private const int idToken = 190;
    [DataMember]
    public double DeserializeWorkaround;
    [DataMember]
    public ChallangeBlock _ChallangeMode;
    [DataMember]
    public int Page;
    private Texture2D parentKeywords;
    private Texture2D currentUri;
    private Texture2D filterID;
    private Texture2D parentCancel;
    private Rectangle[] parentKeywords;
    private Block[][] parentKeywords;
    private Texture2D namesID;
    private Texture2D currentNode;
    private Rectangle parentKeywords;
    private Rectangle currentUri;
    private Rectangle filterID;
    private Rectangle parentCancel;
    private bool parentKeywords;

    public PuzzleScreen()
      : base(DatabaseLoader.DisconnectProject(12295), ClientTree.DisconnectProject(1984217) != 0)
    {
      this.LoadContent();
    }

    public int MaxElementsPerPage => ClientTree.DisconnectProject(1983801);

    public ChallangeBlock ChallangeMode
    {
      set
      {
        if (value == this._ChallangeMode)
          return;
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.set_ChallangeMode);
            }
            this._ChallangeMode = value;
            this.Page = ClientTree.DisconnectProject(1983805);
            this.DisconnectProject();
            break;
        }
      }
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void HandleInput(InputState input)
    {
      if (input == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.HandleInput);
            }
            throw new ArgumentNullException(DatabaseLoader.DisconnectProject(11845));
        }
      }
      else if (input.IsNewButtonPress((Buttons) ClientTree.DisconnectProject(1983809)))
      {
label_6:
        switch (1)
        {
          case 0:
            goto label_6;
          default:
            LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ClientTree.DisconnectProject(1983813) != 0, ClientTree.DisconnectProject(1983817));
            break;
        }
      }
      else
      {
        this.HandleInput(input, out bool _);
        if (this.IgnoreHandleInput())
        {
label_9:
          switch (6)
          {
            case 0:
              goto label_9;
          }
        }
        else
        {
          if (this.parentKeywords == null || this.parentKeywords == null)
            return;
          TouchLocation[] touchStateHandyArea = input.TouchStateHandyArea;
          for (int index1 = (int) OptionsFactory.DisconnectProject(touchStateHandyArea) - ClientTree.DisconnectProject(1983821); index1 >= ClientTree.DisconnectProject(1983857); index1 -= ClientTree.DisconnectProject(1983853))
          {
            TouchLocation touchLocation = touchStateHandyArea[index1];
            if (touchLocation.State == (TouchLocationState) ClientTree.DisconnectProject(1983825))
            {
label_14:
              switch (6)
              {
                case 0:
                  goto label_14;
                default:
                  for (int index2 = ClientTree.DisconnectProject(1983829); index2 < (int) ContextSettings.DisconnectProject(this.parentKeywords); index2 += ClientTree.DisconnectProject(1983841))
                  {
label_29:
                    switch (7)
                    {
                      case 0:
                        goto label_29;
                      default:
                        if (index2 < (int) NetworkQueue.DisconnectProject(this.parentKeywords))
                        {
                          if (IntersectionHelper.InsideArea(this.parentKeywords[index2], touchLocation.Position))
                          {
                            int levelIndex = this.Page * this.MaxElementsPerPage + index2;
                            if (PredefinedLevels.LevelExists(this._ChallangeMode, levelIndex))
                            {
label_18:
                              switch (2)
                              {
                                case 0:
                                  goto label_18;
                                default:
                                  MenuEntryButton.PlayClickSound();
                                  GameplayScreen.Instance.LoadLevel(this._ChallangeMode, levelIndex);
                                  GameScreen[] screens = ScreenManager.Instance.GetScreens();
                                  for (int index3 = ClientTree.DisconnectProject(1983833); index3 < (int) ToolboxEventArgs.DisconnectProject(screens); index3 += ClientTree.DisconnectProject(1983837))
                                  {
                                    if (MenuCollection.DisconnectProject((object) screens[index3]) != null)
                                    {
label_21:
                                      switch (6)
                                      {
                                        case 0:
                                          goto label_21;
                                        default:
                                          LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, (GameScreen) GameplayScreen.Instance);
                                          return;
                                      }
                                    }
                                  }
label_25:
                                  switch (6)
                                  {
                                    case 0:
                                      goto label_25;
                                    default:
                                      ScreenManager.Instance.StartGame();
                                      continue;
                                  }
                              }
                            }
                            else
                              continue;
                          }
                          else
                            continue;
                        }
                        else
                          goto label_31;
                    }
                  }
label_31:
                  if (this.DisposeDrive())
                  {
label_32:
                    switch (6)
                    {
                      case 0:
                        goto label_32;
                      default:
                        if (IntersectionHelper.InsideArea(this.currentUri, touchLocation.Position))
                        {
label_34:
                          switch (1)
                          {
                            case 0:
                              goto label_34;
                            default:
                              MenuEntryButton.PlayClickSound();
                              this.Page -= ClientTree.DisconnectProject(1983845);
                              this.DisconnectProject();
                              return;
                          }
                        }
                        else
                          break;
                    }
                  }
                  if (this.DisconnectProject() && IntersectionHelper.InsideArea(this.parentCancel, touchLocation.Position))
                  {
label_37:
                    switch (1)
                    {
                      case 0:
                        goto label_37;
                      default:
                        MenuEntryButton.PlayClickSound();
                        this.Page += ClientTree.DisconnectProject(1983849);
                        this.DisconnectProject();
                        return;
                    }
                  }
                  else
                    continue;
              }
            }
          }
        }
      }
    }

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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ClientTree.DisconnectProject(1983861) != 0;
        base.LoadContent();
        this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12044));
        this.namesID = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10484));
        this.currentNode = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(10517));
        this.currentUri = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12083));
        this.filterID = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12140));
        this.parentCancel = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12209));
        this.DisconnectProject();
      }
    }

    private void DisconnectProject()
    {
      this.UpdateMenuEntries();
      this.DisposeDrive();
      this.DisconnectProject(this._ChallangeMode, this.Page * this.MaxElementsPerPage, Math.Min(this.MaxElementsPerPage, PredefinedLevels.LevelCount(this._ChallangeMode) - this.Page * this.MaxElementsPerPage));
    }

    private void DisconnectProject(ChallangeBlock _param1, int _param2, int _param3)
    {
      Block[][] blockArray = ProcessResolver.DisconnectProject(_param3);
      for (int index = ClientTree.DisconnectProject(1983865); index < (int) NetworkQueue.DisconnectProject(blockArray); index += ClientTree.DisconnectProject(1983869))
        blockArray[index] = PredefinedLevels.GetBlocksForLevel(_param1, _param2 + index);
label_3:
      switch (7)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.DisconnectProject);
          }
          this.parentKeywords = blockArray;
          break;
      }
    }

    private void DisposeDrive()
    {
      List<Rectangle> rectangleList = new List<Rectangle>();
      int y = ClientTree.DisconnectProject(1983873);
      int x = ClientTree.DisconnectProject(1983877);
      int num1 = (int) ((double) (GameBase.ScreenHeight - ClientTree.DisconnectProject(1983881) - ClientTree.DisconnectProject(1983885) - ClientTree.DisconnectProject(1983889)) / ClientTree.DisconnectProject(1983893));
      int num2 = (int) ((double) (GameBase.ScreenWidth - ClientTree.DisconnectProject(1983901) - ClientTree.DisconnectProject(1983905)) / ClientTree.DisconnectProject(1983909));
      for (int index1 = ClientTree.DisconnectProject(1983917); index1 < ClientTree.DisconnectProject(1983949); index1 += ClientTree.DisconnectProject(1983945))
      {
        for (int index2 = ClientTree.DisconnectProject(1983921); index2 < ClientTree.DisconnectProject(1983937); index2 += ClientTree.DisconnectProject(1983933))
        {
          Rectangle rectangle = new Rectangle(x, y, ClientTree.DisconnectProject(1983925), ClientTree.DisconnectProject(1983929));
          rectangleList.Add(rectangle);
          x += num2;
        }
label_4:
        switch (4)
        {
          case 0:
            goto label_4;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.DisposeDrive);
            }
            x = ClientTree.DisconnectProject(1983941);
            y += num1;
            continue;
        }
      }
label_9:
      switch (4)
      {
        case 0:
          goto label_9;
        default:
          this.parentKeywords = rectangleList.ToArray();
          break;
      }
    }

    public void UpdateMenuEntries()
    {
      this.MenuEntries.Clear();
      MenuEntry menuEntry1 = new MenuEntry(ComponentDictionary.DisconnectProject((object) DatabaseLoader.DisconnectProject(12274), (object) this._ChallangeMode));
      menuEntry1.AdditionalBottomMargin = ClientTree.DisconnectProject(1983953);
      MenuEntry menuEntry2 = new MenuEntry("");
      menuEntry2.AdditionalBottomMargin = ClientTree.DisconnectProject(1983957);
      MenuEntryButton menuEntryButton = new MenuEntryButton(DatabaseLoader.DisconnectProject(11881));
      menuEntryButton.Selected += new EventHandler<RelativeClickEventArg>(this.ListQueue);
      menuEntryButton.Scale = ClientTree.DisconnectProject(1983961);
      menuEntryButton.AdditionalBottomMargin = ClientTree.DisconnectProject(1983965);
      if (MenuScreen.IsLandscapeMenu)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.UpdateMenuEntries);
            }
            menuEntryButton.MenuLocation = (MenuLocation) ClientTree.DisconnectProject(1983969);
            break;
        }
      }
      this.MenuEntries.Add(menuEntry1);
      this.MenuEntries.Add(menuEntry2);
      int y = GameBase.ScreenHeight / ClientTree.DisconnectProject(1983973) - ClientTree.DisconnectProject(1983977);
      this.parentKeywords = new Rectangle(ClientTree.DisconnectProject(1983981), y, ClientTree.DisconnectProject(1983985), ClientTree.DisconnectProject(1983989));
      this.currentUri = new Rectangle(this.parentKeywords.X - ClientTree.DisconnectProject(1983993) - ClientTree.DisconnectProject(1983997), this.parentKeywords.Y - ClientTree.DisconnectProject(1984001), this.parentKeywords.Width + ClientTree.DisconnectProject(1984005) + ClientTree.DisconnectProject(1984009), this.parentKeywords.Height + ClientTree.DisconnectProject(1984013));
      this.filterID = new Rectangle(ClientTree.DisconnectProject(1984017), y, ClientTree.DisconnectProject(1984021), ClientTree.DisconnectProject(1984025));
      this.parentCancel = new Rectangle(this.filterID.X - ClientTree.DisconnectProject(1984029) - ClientTree.DisconnectProject(1984033), this.filterID.Y - ClientTree.DisconnectProject(1984037), this.filterID.Width + ClientTree.DisconnectProject(1984041) + ClientTree.DisconnectProject(1984045), this.filterID.Height + ClientTree.DisconnectProject(1984049));
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
    }

    private void DisposeDrive(object _param1, RelativeClickEventArg _param2)
    {
      OnlineCommunications.Instance.OpenHomepage();
    }

    private void ListQueue(object _param1, RelativeClickEventArg _param2) => this.ExitScreen();

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
    }

    public override void Draw(GameTime gameTime)
    {
      base.Draw(gameTime);
      Color color1 = ActivityInvoker.DisconnectProject(Color.White, this.TransitionAlpha);
      Color color2 = ActivityInvoker.DisconnectProject(Color.Black, this.TransitionAlpha);
      if (this.parentKeywords != null && this.parentKeywords != null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PuzzleScreen.Draw);
            }
            StringBuilder stringBuilder = new StringBuilder();
            for (int index1 = ClientTree.DisconnectProject(1984053); index1 < (int) ContextSettings.DisconnectProject(this.parentKeywords); index1 += ClientTree.DisconnectProject(1984209))
            {
label_20:
              switch (5)
              {
                case 0:
                  goto label_20;
                default:
                  if (index1 < (int) NetworkQueue.DisconnectProject(this.parentKeywords))
                  {
                    Rectangle parentKeyword = this.parentKeywords[index1];
                    GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, parentKeyword, color1);
                    for (int index2 = ClientTree.DisconnectProject(1984057); index2 < this.parentKeywords[index1].Length; index2 += ClientTree.DisconnectProject(1984085))
                      this.parentKeywords[index1][index2].DrawInSpecificArea(new Rectangle(parentKeyword.X + ClientTree.DisconnectProject(1984061) + ClientTree.DisconnectProject(1984065), parentKeyword.Y + ClientTree.DisconnectProject(1984069) + ClientTree.DisconnectProject(1984073), parentKeyword.Width - ClientTree.DisconnectProject(1984077), parentKeyword.Height - ClientTree.DisconnectProject(1984081)), color1);
label_8:
                    switch (6)
                    {
                      case 0:
                        goto label_8;
                      default:
                        Color color3 = ActivityInvoker.DisconnectProject(color1, ClientTree.DisconnectProject(1984089));
                        GameBase.Instance.SpriteBatch.Draw(ScreenManager.Instance.TexBlack, new Rectangle(parentKeyword.X + ClientTree.DisconnectProject(1984093), parentKeyword.Y + ClientTree.DisconnectProject(1984097), parentKeyword.Width - ClientTree.DisconnectProject(1984101), parentKeyword.Height - ClientTree.DisconnectProject(1984105)), color3);
                        stringBuilder.Clear();
                        stringBuilder.Concat(this.MaxElementsPerPage * this.Page + index1 + ClientTree.DisconnectProject(1984109));
                        float scale1 = ClientTree.DisconnectProject(1984113);
                        Vector2 vector2 = PackageProvider.DisconnectProject(ScreenManager.Instance.MenuFont.MeasureString(stringBuilder), scale1);
                        Vector2 position = new Vector2((float) parentKeyword.XCenterAbsolute() - vector2.X / ClientTree.DisconnectProject(1984117), (float) parentKeyword.YCenterAbsolute() - vector2.Y / ClientTree.DisconnectProject(1984121));
                        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, stringBuilder, position, color1, ClientTree.DisconnectProject(1984125), Vector2.Zero, scale1, (SpriteEffects) ClientTree.DisconnectProject(1984129), ClientTree.DisconnectProject(1984133));
                        Rectangle rectangle = new Rectangle(parentKeyword.X2() - ClientTree.DisconnectProject(1984137), parentKeyword.Y, ClientTree.DisconnectProject(1984141), ClientTree.DisconnectProject(1984145));
                        GameBase.Instance.SpriteBatch.Draw(this.currentUri, rectangle, color1);
                        stringBuilder.Clear();
                        stringBuilder.Concat(PredefinedLevels.GetPerfectSolutionMoves(this._ChallangeMode, this.MaxElementsPerPage * this.Page + index1));
                        float scale2 = ClientTree.DisconnectProject(1984149);
                        vector2 = PackageProvider.DisconnectProject(ScreenManager.Instance.MenuFont.MeasureString(stringBuilder), scale2);
                        position = new Vector2((float) rectangle.XCenterAbsolute() - vector2.X / ClientTree.DisconnectProject(1984153), (float) rectangle.YCenterAbsolute() - vector2.Y / ClientTree.DisconnectProject(1984157));
                        GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, stringBuilder, position, color1, ClientTree.DisconnectProject(1984161), Vector2.Zero, scale2, (SpriteEffects) ClientTree.DisconnectProject(1984165), ClientTree.DisconnectProject(1984169));
                        if (GameBase.Instance.GameSettings.BestPlayResults[(int) this._ChallangeMode] != null)
                        {
label_10:
                          switch (7)
                          {
                            case 0:
                              goto label_10;
                            default:
                              int int_val = GameBase.Instance.GameSettings.BestPlayResults[(int) this._ChallangeMode][this.MaxElementsPerPage * this.Page + index1];
                              if (int_val > ClientTree.DisconnectProject(1984173))
                              {
label_12:
                                switch (3)
                                {
                                  case 0:
                                    goto label_12;
                                  default:
                                    bool flag = (int_val > PredefinedLevels.GetPerfectSolutionMoves(this._ChallangeMode, this.MaxElementsPerPage * this.Page + index1) ? 1 : 0) == ClientTree.DisconnectProject(1984177);
                                    rectangle = new Rectangle(parentKeyword.X, parentKeyword.Y, ClientTree.DisconnectProject(1984181), ClientTree.DisconnectProject(1984185));
                                    if (flag)
                                    {
label_14:
                                      switch (5)
                                      {
                                        case 0:
                                          goto label_14;
                                        default:
                                          GameBase.Instance.SpriteBatch.Draw(this.parentCancel, rectangle, color1);
                                          break;
                                      }
                                    }
                                    else
                                      GameBase.Instance.SpriteBatch.Draw(this.filterID, rectangle, color1);
                                    stringBuilder.Clear();
                                    stringBuilder.Concat(int_val);
                                    vector2 = PackageProvider.DisconnectProject(ScreenManager.Instance.MenuFont.MeasureString(stringBuilder), scale2);
                                    position = new Vector2((float) rectangle.XCenterAbsolute() - vector2.X / ClientTree.DisconnectProject(1984189), (float) rectangle.YCenterAbsolute() - vector2.Y / ClientTree.DisconnectProject(1984193));
                                    GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, stringBuilder, position, color2, ClientTree.DisconnectProject(1984197), Vector2.Zero, scale2, (SpriteEffects) ClientTree.DisconnectProject(1984201), ClientTree.DisconnectProject(1984205));
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
                  else
                  {
label_22:
                    switch (4)
                    {
                      case 0:
                        goto label_22;
                      default:
                        goto label_23;
                    }
                  }
              }
            }
            break;
        }
      }
label_23:
      if (this.DisposeDrive())
      {
label_24:
        switch (1)
        {
          case 0:
            goto label_24;
          default:
            GameBase.Instance.SpriteBatch.Draw(this.namesID, this.parentKeywords, Color.White);
            break;
        }
      }
      if (!this.DisconnectProject())
        return;
label_27:
      switch (3)
      {
        case 0:
          goto label_27;
        default:
          GameBase.Instance.SpriteBatch.Draw(this.currentNode, this.filterID, Color.White);
          break;
      }
    }

    private bool DisconnectProject()
    {
      return PredefinedLevels.LevelCount(this._ChallangeMode) > this.Page * this.MaxElementsPerPage + this.MaxElementsPerPage;
    }

    private bool DisposeDrive() => this.Page > ClientTree.DisconnectProject(1984213);
  }
}
