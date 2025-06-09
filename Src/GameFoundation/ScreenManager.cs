// *************************************************************
// Type: GameFoundation.ScreenManager
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public class ScreenManager : DrawableGameComponent
  {
    public static ScreenManager Instance;
    private static Dictionary<Type, string> parentKeywords;
    public static Rectangle BoundsScreen = new Rectangle(ReferenceInvoker.DisconnectProject(3273), ReferenceInvoker.DisconnectProject(3277), GameBase.ScreenWidth, GameBase.ScreenHeight);
    private List<GameScreen> parentKeywords = new List<GameScreen>(ReferenceInvoker.DisconnectProject(3281));
    private InputState parentKeywords;
    private Texture2D parentKeywords;
    public Texture2D TexBlack;
    private Song parentKeywords;
    private bool parentKeywords;
    public SpriteFont MenuFont;
    public SoundEffectInstance SoundClickButtonInstance;
    public bool TraceEnabled;

    static ScreenManager()
    {
      ScreenManager.parentKeywords = new Dictionary<Type, string>();
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(DiskAttribute.DisconnectProject()), EditorService.DisconnectProject(3669));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(FormFactory.DisconnectProject()), EditorService.DisconnectProject(3702));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(GroupEventArgs.DisconnectProject()), EditorService.DisconnectProject(3737));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(NodeCollection.DisconnectProject()), EditorService.DisconnectProject(3774));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(SymbolLayout.DisconnectProject()), EditorService.DisconnectProject(3813));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(ProjectAttribute.DisconnectProject()), EditorService.DisconnectProject(3840));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(ServerService.DisconnectProject()), EditorService.DisconnectProject(3869));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(PaneInvoker.DisconnectProject()), EditorService.DisconnectProject(3902));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(AssistantTable.DisconnectProject()), EditorService.DisconnectProject(3937));
      ScreenManager.parentKeywords.Add(Type.GetTypeFromHandle(StreamSettings.DisconnectProject()), EditorService.DisconnectProject(3968));
      GameBase.Instance.AddScreenTypeNameMapping(ScreenManager.parentKeywords);
    }

    public ScreenManager(GameBase game)
      : base((Game) game)
    {
      ScreenManager.Instance = this;
      this.parentKeywords = new InputState(this);
    }

    private Type DisconnectProject(string _param1)
    {
      KeyValuePair<Type, string>[] array = ScreenManager.parentKeywords.ToArray<KeyValuePair<Type, string>>();
      for (int index = ReferenceInvoker.DisconnectProject(3041); index < (int) ActivityTable.DisconnectProject(array); index += ReferenceInvoker.DisconnectProject(3045))
      {
        if (RegistryScope.DisconnectProject(array[index].Value, _param1))
        {
label_2:
          switch (7)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.DisconnectProject);
              }
              return array[index].Key;
          }
        }
      }
label_8:
      switch (7)
      {
        case 0:
          goto label_8;
        default:
          throw new NotImplementedException(EditorService.DisconnectProject(3286));
      }
    }

    public override void Initialize()
    {
      base.Initialize();
      this.parentKeywords = ReferenceInvoker.DisconnectProject(3049) != 0;
    }

    protected override void LoadContent()
    {
      ContentManager content = this.Game.Content;
      this.MenuFont = content.Load<SpriteFont>(EditorService.DisconnectProject(3357));
      this.parentKeywords = content.Load<Texture2D>(EditorService.DisconnectProject(3384));
      this.TexBlack = content.Load<Texture2D>(EditorService.DisconnectProject(3423));
      this.SoundClickButtonInstance = content.Load<SoundEffect>(EditorService.DisconnectProject(3462)).CreateInstance();
      this.parentKeywords = content.Load<Song>(EditorService.DisconnectProject(3497));
    }

    public void PlaySound()
    {
    }

    protected override void UnloadContent()
    {
      for (int index = ReferenceInvoker.DisconnectProject(3053); index < this.parentKeywords.Count; index += ReferenceInvoker.DisconnectProject(3057))
        this.parentKeywords[index].UnloadContent();
label_3:
      switch (2)
      {
        case 0:
          goto label_3;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.UnloadContent);
          break;
      }
    }

    public override void Update(GameTime gameTime)
    {
      this.parentKeywords.DisconnectProject();
      GameScreen[] array = this.parentKeywords.ToArray();
      bool otherScreenHasFocus = (this.Game.IsActive ? 1 : 0) == ReferenceInvoker.DisconnectProject(3061);
      bool coveredByOtherScreen = ReferenceInvoker.DisconnectProject(3065) != 0;
      PlatformHelper.ScreenModeTypes screenModeTypes = PlatformHelper.DisconnectProject();
      for (int index = (int) ImageTable.DisconnectProject(array) - ReferenceInvoker.DisconnectProject(3069); index >= ReferenceInvoker.DisconnectProject(3093); index -= ReferenceInvoker.DisconnectProject(3089))
      {
        GameScreen gameScreen = array[index];
        gameScreen.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        if (gameScreen.ScreenState != ScreenState.TransitionOn)
        {
label_2:
          switch (6)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.Update);
              }
              if (gameScreen.ScreenState != (ScreenState) ReferenceInvoker.DisconnectProject(3073))
                continue;
              break;
          }
        }
        if (!otherScreenHasFocus && screenModeTypes != (PlatformHelper.ScreenModeTypes) ReferenceInvoker.DisconnectProject(3077))
        {
label_7:
          switch (4)
          {
            case 0:
              goto label_7;
            default:
              gameScreen.HandleInput(this.parentKeywords);
              otherScreenHasFocus = ReferenceInvoker.DisconnectProject(3081) != 0;
              break;
          }
        }
        if (!gameScreen.IsPopup)
        {
label_10:
          switch (3)
          {
            case 0:
              goto label_10;
            default:
              coveredByOtherScreen = ReferenceInvoker.DisconnectProject(3085) != 0;
              continue;
          }
        }
      }
label_14:
      switch (2)
      {
        case 0:
          goto label_14;
        default:
          GameBase.Instance.HandleGuiInput(this.parentKeywords);
          break;
      }
    }

    private void DisconnectProject()
    {
    }

    public override void Draw(GameTime gameTime)
    {
      GameBase.Instance.SpriteBatch.Begin();
      GameScreen[] array = this.parentKeywords.ToArray();
      for (int index = ReferenceInvoker.DisconnectProject(3097); index < (int) ImageTable.DisconnectProject(array); index += ReferenceInvoker.DisconnectProject(3105))
      {
        if (array[index].ScreenState != (ScreenState) ReferenceInvoker.DisconnectProject(3101))
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.Draw);
              }
              array[index].Draw(gameTime);
              continue;
          }
        }
      }
      AdController.Instance.Draw();
      GameBase.Instance.SpriteBatch.End();
    }

    public void AddScreen(GameScreen screen)
    {
      screen.IsExiting = ReferenceInvoker.DisconnectProject(3109) != 0;
      this.parentKeywords.Add(screen);
      if (screen.EnabledGestures == GestureType.None)
        return;
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.AddScreen);
          }
          TouchPanel.EnabledGestures = screen.EnabledGestures;
          break;
      }
    }

    public void RemoveScreen(GameScreen screen)
    {
      if (screen == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.RemoveScreen);
            break;
        }
      }
      else
      {
        if (this.parentKeywords)
          screen.UnloadContent();
        this.parentKeywords.Remove(screen);
        if (this.parentKeywords.Count <= ReferenceInvoker.DisconnectProject(3113))
          return;
label_8:
        switch (3)
        {
          case 0:
            goto label_8;
          default:
            if (this.parentKeywords[this.parentKeywords.Count - ReferenceInvoker.DisconnectProject(3117)].EnabledGestures == GestureType.None)
              break;
label_10:
            switch (3)
            {
              case 0:
                goto label_10;
              default:
                TouchPanel.EnabledGestures = this.parentKeywords[this.parentKeywords.Count - ReferenceInvoker.DisconnectProject(3121)].EnabledGestures;
                return;
            }
        }
      }
    }

    public GameScreen[] GetScreens() => this.parentKeywords.ToArray();

    public void FadeBackBufferToBlack(float alpha)
    {
      Viewport viewport = this.GraphicsDevice.Viewport;
      GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, new Rectangle(ReferenceInvoker.DisconnectProject(3125), ReferenceInvoker.DisconnectProject(3129), viewport.Width, viewport.Height), WindowOptions.DisconnectProject(Color.Black, alpha));
    }

    public void SerializeState()
    {
      if (PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(3530)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.SerializeState);
            }
            PlatformLocalStorage.DeleteFiles(EditorService.DisconnectProject(3530));
            break;
        }
      }
      else
        PlatformLocalStorage.CreateDirectory(EditorService.DisconnectProject(3530));
      for (int index = this.parentKeywords.Count - ReferenceInvoker.DisconnectProject(3133); index >= ReferenceInvoker.DisconnectProject(3141); index -= ReferenceInvoker.DisconnectProject(3137))
      {
        GameScreen parentKeyword = this.parentKeywords[index];
        if (parentKeyword != null)
        {
label_8:
          switch (7)
          {
            case 0:
              goto label_8;
            default:
              if (parentKeyword.IsExiting)
              {
label_10:
                switch (6)
                {
                  case 0:
                    goto label_10;
                  default:
                    this.parentKeywords.RemoveAt(index);
                    continue;
                }
              }
              else
                continue;
          }
        }
      }
label_14:
      switch (7)
      {
        case 0:
          goto label_14;
        default:
          for (int index = this.parentKeywords.Count - ReferenceInvoker.DisconnectProject(3145); index >= ReferenceInvoker.DisconnectProject(3153); index -= ReferenceInvoker.DisconnectProject(3149))
          {
            GameScreen parentKeyword = this.parentKeywords[index];
            if (parentKeyword != null)
            {
label_17:
              switch (3)
              {
                case 0:
                  goto label_17;
                default:
                  if (AssistantType.DisconnectProject((object) parentKeyword) != null)
                  {
label_19:
                    switch (2)
                    {
                      case 0:
                        goto label_19;
                      default:
                        FileList.DisconnectProject((object) parentKeyword).ForceEndNowWithoutRemove();
                        this.parentKeywords.RemoveAt(index);
                        continue;
                    }
                  }
                  else
                    continue;
              }
            }
          }
label_23:
          switch (5)
          {
            case 0:
              goto label_23;
            default:
              StringBuilder stringBuilder = new StringBuilder();
              for (int index = ReferenceInvoker.DisconnectProject(3157); index < this.parentKeywords.Count; index += ReferenceInvoker.DisconnectProject(3161))
              {
                GameScreen parentKeyword = this.parentKeywords[index];
                if (parentKeyword != null)
                {
label_26:
                  switch (7)
                  {
                    case 0:
                      goto label_26;
                    default:
                      stringBuilder.AppendLine(ScreenManager.parentKeywords[parentKeyword.GetType()]);
                      continue;
                  }
                }
              }
label_30:
              switch (1)
              {
                case 0:
                  goto label_30;
                default:
                  PlatformLocalStorage.SaveTextToFile(EditorService.DisconnectProject(3557), stringBuilder.ToString());
                  int num = ReferenceInvoker.DisconnectProject(3165);
                  for (int index = ReferenceInvoker.DisconnectProject(3169); index < this.parentKeywords.Count; index += ReferenceInvoker.DisconnectProject(3185))
                  {
                    GameScreen parentKeyword = this.parentKeywords[index];
                    if (parentKeyword != null)
                    {
label_33:
                      switch (6)
                      {
                        case 0:
                          goto label_33;
                        default:
                          if (ProjectList.DisconnectProject((object) parentKeyword) == null)
                          {
                            string format = EditorService.DisconnectProject(3614);
                            object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(3173));
                            objArray1[ReferenceInvoker.DisconnectProject(3177)] = (object) num;
                            object[] objArray2 = objArray1;
                            PlatformLocalStorage.SerializeObjectToFile(string.Format(format, objArray2), (object) parentKeyword);
                            num += ReferenceInvoker.DisconnectProject(3181);
                            continue;
                          }
                          continue;
                      }
                    }
                  }
label_38:
                  switch (2)
                  {
                    case 0:
                      goto label_38;
                    default:
                      GameBase.Instance.SerializeGameplay();
                      return;
                  }
              }
          }
      }
    }

    public bool DeserializeState()
    {
      if (!PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(3530)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.DeserializeState);
            }
            return ReferenceInvoker.DisconnectProject(3189) != 0;
        }
      }
      else
      {
        if (!PlatformLocalStorage.FileExists(EditorService.DisconnectProject(3557)))
          return ReferenceInvoker.DisconnectProject(3193) != 0;
        List<Type> typeList = new List<Type>();
        StringLinewiseReadHelper linewiseReadHelper = new StringLinewiseReadHelper(PlatformLocalStorage.LoadTextFromFile(EditorService.DisconnectProject(3557)));
        while (!linewiseReadHelper.IsEndReached())
        {
          string str = linewiseReadHelper.ReadLine();
          if (!string.IsNullOrEmpty(str))
          {
label_9:
            switch (7)
            {
              case 0:
                goto label_9;
              default:
                Type screenType = this.DisconnectProject(str);
                if ((object) screenType == null)
                {
label_11:
                  switch (5)
                  {
                    case 0:
                      goto label_11;
                    default:
                      return ReferenceInvoker.DisconnectProject(3197) != 0;
                  }
                }
                else if (GameBase.Instance.IsAnyGameplyScreenType(screenType))
                {
label_14:
                  switch (2)
                  {
                    case 0:
                      goto label_14;
                    default:
                      int count = this.parentKeywords.Count;
                      continue;
                  }
                }
                else
                {
                  typeList.Add(screenType);
                  continue;
                }
            }
          }
        }
label_18:
        switch (7)
        {
          case 0:
            goto label_18;
          default:
            GameBase.Instance.DeserializeGameplay();
            int num = ReferenceInvoker.DisconnectProject(3201);
            for (int index = ReferenceInvoker.DisconnectProject(3205); index < typeList.Count; index += ReferenceInvoker.DisconnectProject(3229))
            {
              string format = EditorService.DisconnectProject(3614);
              object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(3209));
              objArray1[ReferenceInvoker.DisconnectProject(3213)] = (object) num;
              object[] objArray2 = objArray1;
              string filename = string.Format(format, objArray2);
              num += ReferenceInvoker.DisconnectProject(3217);
              if (!PlatformLocalStorage.FileExists(filename))
                return ReferenceInvoker.DisconnectProject(3221) != 0;
              GameScreen screen = PageDictionary.DisconnectProject(PlatformLocalStorage.DeserializeObjectFromFile(filename, typeList[index]));
              if (screen == null)
              {
label_23:
                switch (7)
                {
                  case 0:
                    goto label_23;
                  default:
                    return ReferenceInvoker.DisconnectProject(3225) != 0;
                }
              }
              else
                this.AddScreen(screen);
            }
label_27:
            switch (3)
            {
              case 0:
                goto label_27;
              default:
                return ReferenceInvoker.DisconnectProject(3233) != 0;
            }
        }
      }
    }

    internal void DisposeDrive() => GameplayScreenBase.Instance.RestartGame();

    internal void ListQueue() => GameplayScreenBase.Instance.ResetGame();

    public void StartGame()
    {
      GameBase.Instance.GameSettings.IsFirstTimePlaying = ReferenceInvoker.DisconnectProject(3237) != 0;
      GameplayScreenBase.Instance.RestartGame();
      int num = ReferenceInvoker.DisconnectProject(3241);
      GameScreen[] gameScreenArray1 = ImageEditor.DisconnectProject(ReferenceInvoker.DisconnectProject(3245));
      gameScreenArray1[ReferenceInvoker.DisconnectProject(3249)] = (GameScreen) GameplayScreenBase.Instance;
      GameScreen[] gameScreenArray2 = gameScreenArray1;
      LoadingScreen.Load(this, num != 0, gameScreenArray2);
      GameplayScreenBase.Instance.PlaySound();
    }

    /*internal bool DisconnectProject()
    {
      GameScreen[] array = this.parentKeywords.ToArray();
      if ((int) ImageTable.DisconnectProject(array) != ReferenceInvoker.DisconnectProject(3253))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScreenManager.DisconnectProject);
            }
            return ReferenceInvoker.DisconnectProject(3257) != 0;
        }
      }
      else
        return ProjectList.DisconnectProject((object) array[ReferenceInvoker.DisconnectProject(3261)]) != null ? ReferenceInvoker.DisconnectProject(3265) != 0 : ReferenceInvoker.DisconnectProject(3269) != 0;
    }*/
  }
}
