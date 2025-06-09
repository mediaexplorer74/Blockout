// Decompiled with JetBrains decompiler
// Type: Blockout.GameLevel
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class GameLevel
  {
    private const int parentKeywords = 4;
    private const int currentUri = 1;
    private const int filterID = 74;
    private Texture2D parentKeywords;
    [DataMember]
    public Rectangle posLevelPos;
    private Color[] parentKeywords;
    [DataMember]
    public Block[] blocks;
    private static SoundEffectInstance parentKeywords;
    private static SoundEffectInstance currentUri = GameBase.Instance.Content.Load<SoundEffect>(DatabaseLoader.DisconnectProject(11638)).CreateInstance();
    [DataMember]
    public bool soundDragPlayed;
    [DataMember]
    public int texLevelIndex;
    private bool parentKeywords = ClientTree.DisconnectProject(3868) != 0;
    private Vector2 parentKeywords;
    private int parentCancel;
    private double[] parentKeywords;
    private double[] currentUri;
    private int namesID;
    [DataMember]
    public Vector2[] lastBlockRasterPositions;
    [DataMember]
    public Vector2[] lastBlockPositions;
    [DataMember]
    public List<BlockMovement> blockMovementTracking;
    [DataMember]
    public int _MoveCounter;

    public GameLevel(int texToUseIndex, Rectangle posToPlace, Block[] blocks)
    {
      if (texToUseIndex >= ClientTree.DisconnectProject(3872))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.\u002Ector);
            }
            if (texToUseIndex >= (int) DeviceQueue.DisconnectProject(GameGenerator.texLevelNames))
            {
label_5:
              switch (2)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              this.texLevelIndex = texToUseIndex;
              this.posLevelPos = posToPlace;
              this.blocks = blocks;
              this.namesID = ClientTree.DisconnectProject(3876);
              this.blockMovementTracking = new List<BlockMovement>();
              this.lastBlockRasterPositions = ViewInvoker.DisconnectProject((int) ConnectionContext.DisconnectProject(blocks));
              for (int index = ClientTree.DisconnectProject(3880); index < (int) ConnectionContext.DisconnectProject(blocks); index += ClientTree.DisconnectProject(3884))
                this.lastBlockRasterPositions[index] = new Vector2((float) blocks[index].ClosestRasterPosX, (float) blocks[index].ClosestRasterPosY);
label_10:
              switch (7)
              {
                case 0:
                  goto label_10;
                default:
                  this.lastBlockPositions = ViewInvoker.DisconnectProject((int) ConnectionContext.DisconnectProject(blocks));
                  this.ListQueue();
                  this.LoadContent();
                  return;
              }
            }
            break;
        }
      }
      throw new ArgumentNullException();
    }

    static GameLevel()
    {
      GameLevel.parentKeywords = GameBase.Instance.Content.Load<SoundEffect>(DatabaseLoader.DisconnectProject(11659)).CreateInstance();
    }

    public void LoadContent()
    {
      this.parentKeywords = ImageAttribute.DisconnectProject((int) ConnectionContext.DisconnectProject(this.blocks));
      this.currentUri = ImageAttribute.DisconnectProject((int) ConnectionContext.DisconnectProject(this.blocks));
      this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(GameGenerator.texLevelNames[this.texLevelIndex]);
      this.parentKeywords = ConfigProvider.DisconnectProject(this.parentKeywords.Width * this.parentKeywords.Height);
      this.parentKeywords.GetData<Color>(this.parentKeywords);
      this.parentCancel = ClientTree.DisconnectProject(3316);
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void Draw(float transitionAlpha)
    {
      GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, this.posLevelPos, ActivityInvoker.DisconnectProject(Color.White, transitionAlpha));
      for (int index = ClientTree.DisconnectProject(3320); index < (int) ConnectionContext.DisconnectProject(this.blocks); index += ClientTree.DisconnectProject(3324))
        this.blocks[index].Draw(transitionAlpha);
    }

    public int MovementCounter
    {
      get => this._MoveCounter;
      set => this._MoveCounter = Math.Min(value, ClientTree.DisconnectProject(3328));
    }

    internal void DisconnectProject(InputState _param1)
    {
      if (_param1 == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.DisconnectProject);
            break;
        }
      }
      else
      {
        TouchLocation[] touchStateHandyArea = _param1.TouchStateHandyArea;
        if ((int) OptionsFactory.DisconnectProject(touchStateHandyArea) <= ClientTree.DisconnectProject(3332))
        {
label_5:
          switch (4)
          {
            case 0:
              goto label_5;
            default:
              this.namesID = ClientTree.DisconnectProject(3336);
              break;
          }
        }
label_24:
        for (int index1 = ClientTree.DisconnectProject(3340); index1 < (int) OptionsFactory.DisconnectProject(touchStateHandyArea); index1 += ClientTree.DisconnectProject(3372))
        {
          TouchLocation touchLocation = touchStateHandyArea[index1];
          if (touchLocation.State == (TouchLocationState) ClientTree.DisconnectProject(3344))
          {
label_9:
            switch (5)
            {
              case 0:
                goto label_9;
              default:
                this.namesID = ClientTree.DisconnectProject(3348);
                continue;
            }
          }
          else if (this.namesID < ClientTree.DisconnectProject(3352))
          {
            if (touchLocation.State != (TouchLocationState) ClientTree.DisconnectProject(3356))
            {
label_13:
              switch (6)
              {
                case 0:
                  goto label_13;
                default:
                  if (touchLocation.State == (TouchLocationState) ClientTree.DisconnectProject(3360))
                  {
label_15:
                    switch (3)
                    {
                      case 0:
                        goto label_15;
                    }
                  }
                  else
                    continue;
                  break;
              }
            }
            for (int index2 = ClientTree.DisconnectProject(3364); index2 < (int) ConnectionContext.DisconnectProject(this.blocks); index2 += ClientTree.DisconnectProject(3368))
            {
              if (IntersectionHelper.InsideArea(this.blocks[index2].pos, touchLocation.Position))
              {
label_18:
                switch (6)
                {
                  case 0:
                    goto label_18;
                  default:
                    this.namesID = index2;
                    this.parentKeywords = new Vector2(touchLocation.Position.X - (float) this.blocks[this.namesID].pos.X, touchLocation.Position.Y - (float) this.blocks[this.namesID].pos.Y);
                    goto label_24;
                }
              }
            }
label_22:
            switch (6)
            {
              case 0:
                goto label_22;
              default:
                continue;
            }
          }
        }
label_25:
        switch (4)
        {
          case 0:
            goto label_25;
          default:
            if (this.namesID >= ClientTree.DisconnectProject(3376))
            {
label_27:
              switch (1)
              {
                case 0:
                  goto label_27;
                default:
                  for (int index = (int) OptionsFactory.DisconnectProject(touchStateHandyArea) - ClientTree.DisconnectProject(3380); index >= ClientTree.DisconnectProject(3432); index -= ClientTree.DisconnectProject(3428))
                  {
                    TouchLocation touchLocation = touchStateHandyArea[index];
                    if (this.namesID >= ClientTree.DisconnectProject(3384))
                    {
label_30:
                      switch (5)
                      {
                        case 0:
                          goto label_30;
                        default:
                          if (touchLocation.State == (TouchLocationState) ClientTree.DisconnectProject(3388))
                          {
                            int val1_1 = ClientTree.DisconnectProject(3392);
                            int val1_2 = ClientTree.DisconnectProject(3396);
                            if (this.blocks[this.namesID].MovementDirection != (BlockMovementDirection) ClientTree.DisconnectProject(3400))
                            {
label_33:
                              switch (5)
                              {
                                case 0:
                                  goto label_33;
                                default:
                                  val1_1 = (int) touchLocation.Position.X - (int) this.parentKeywords.X - this.blocks[this.namesID].pos.X;
                                  break;
                              }
                            }
                            if (this.blocks[this.namesID].MovementDirection != BlockMovementDirection.Horizontal)
                              val1_2 = (int) touchLocation.Position.Y - (int) this.parentKeywords.Y - this.blocks[this.namesID].pos.Y;
                            this.parentKeywords[this.namesID] = (double) val1_1;
                            this.currentUri[this.namesID] = (double) val1_2;
                            int num1;
                            if (val1_1 > ClientTree.DisconnectProject(3404))
                            {
label_38:
                              switch (5)
                              {
                                case 0:
                                  goto label_38;
                                default:
                                  num1 = Math.Min(val1_1, ClientTree.DisconnectProject(3408));
                                  break;
                              }
                            }
                            else
                              num1 = Math.Max(val1_1, ClientTree.DisconnectProject(3412));
                            int num2;
                            if (val1_2 > ClientTree.DisconnectProject(3416))
                            {
label_42:
                              switch (7)
                              {
                                case 0:
                                  goto label_42;
                                default:
                                  num2 = Math.Min(val1_2, ClientTree.DisconnectProject(3420));
                                  break;
                              }
                            }
                            else
                              num2 = Math.Max(val1_2, ClientTree.DisconnectProject(3424));
                            this.DisconnectProject(this.namesID, new Rectangle(this.blocks[this.namesID].pos.X + num1, this.blocks[this.namesID].pos.Y + num2, this.blocks[this.namesID].pos.Width, this.blocks[this.namesID].pos.Height), num1, num2);
                            goto label_49;
                          }
                          else
                            continue;
                      }
                    }
                  }
label_48:
                  switch (4)
                  {
                    case 0:
                      goto label_48;
                  }
                  break;
              }
            }
label_49:
            for (int index = ClientTree.DisconnectProject(3436); index < (int) ConnectionContext.DisconnectProject(this.blocks); index += ClientTree.DisconnectProject(3616))
            {
              if (index != this.namesID)
              {
label_51:
                switch (2)
                {
                  case 0:
                    goto label_51;
                  default:
                    if (this.blocks[index].isBlueBlock)
                    {
label_53:
                      switch (1)
                      {
                        case 0:
                          goto label_53;
                        default:
                          if (this.blocks[index].ClosestRasterPosX >= ClientTree.DisconnectProject(3440))
                          {
label_55:
                            switch (3)
                            {
                              case 0:
                                goto label_55;
                              default:
                                this.parentKeywords[index] = Math.Max(this.parentKeywords[index], ClientTree.DisconnectProject(3444));
                                break;
                            }
                          }
                          else
                            break;
                          break;
                      }
                    }
                    int num3 = (this.blocks[index].pos.X - ClientTree.DisconnectProject(3452)) % ClientTree.DisconnectProject(3456);
                    int num4 = (this.blocks[index].pos.Y - ClientTree.DisconnectProject(3460) - ClientTree.DisconnectProject(3464)) % ClientTree.DisconnectProject(3468);
                    bool flag1 = (num3 > ClientTree.DisconnectProject(3472) ? 1 : 0) == ClientTree.DisconnectProject(3476);
                    bool flag2 = (num4 > ClientTree.DisconnectProject(3480) ? 1 : 0) == ClientTree.DisconnectProject(3484);
                    int num5 = ClientTree.DisconnectProject(3488);
                    int num6 = ClientTree.DisconnectProject(3492);
                    if (Math.Abs(this.parentKeywords[index]) > ClientTree.DisconnectProject(3496))
                    {
label_58:
                      switch (5)
                      {
                        case 0:
                          goto label_58;
                        default:
                          this.parentKeywords[index] /= ClientTree.DisconnectProject(3504);
                          this.parentKeywords[index] = Math.Min(this.parentKeywords[index], ClientTree.DisconnectProject(3512));
                          this.parentKeywords[index] = Math.Max(this.parentKeywords[index], ClientTree.DisconnectProject(3520));
                          break;
                      }
                    }
                    else
                      this.parentKeywords[index] = ClientTree.DisconnectProject(3528);
                    if (Math.Abs(this.currentUri[index]) > ClientTree.DisconnectProject(3536))
                    {
label_62:
                      switch (2)
                      {
                        case 0:
                          goto label_62;
                        default:
                          this.currentUri[index] /= ClientTree.DisconnectProject(3544);
                          this.currentUri[index] = Math.Min(this.currentUri[index], ClientTree.DisconnectProject(3552));
                          this.currentUri[index] = Math.Max(this.currentUri[index], ClientTree.DisconnectProject(3560));
                          break;
                      }
                    }
                    else
                      this.currentUri[index] = ClientTree.DisconnectProject(3568);
                    if (this.parentKeywords[index] != ClientTree.DisconnectProject(3576))
                    {
label_66:
                      switch (1)
                      {
                        case 0:
                          goto label_66;
                        default:
                          num5 = (int) this.parentKeywords[index];
                          break;
                      }
                    }
                    else if (num3 != 0)
                    {
label_69:
                      switch (6)
                      {
                        case 0:
                          goto label_69;
                        default:
                          if (flag1)
                          {
label_71:
                            switch (1)
                            {
                              case 0:
                                goto label_71;
                              default:
                                num5 = Math.Max(ClientTree.DisconnectProject(3584), -num3);
                                break;
                            }
                          }
                          else
                          {
                            num5 = Math.Min(ClientTree.DisconnectProject(3588), Math.Abs(num3 - ClientTree.DisconnectProject(3592)));
                            break;
                          }
                          break;
                      }
                    }
                    if (this.currentUri[index] != ClientTree.DisconnectProject(3596))
                    {
label_75:
                      switch (6)
                      {
                        case 0:
                          goto label_75;
                        default:
                          num6 = (int) this.currentUri[index];
                          break;
                      }
                    }
                    else if (num4 != 0)
                    {
label_78:
                      switch (7)
                      {
                        case 0:
                          goto label_78;
                        default:
                          if (flag2)
                          {
label_80:
                            switch (1)
                            {
                              case 0:
                                goto label_80;
                              default:
                                num6 = Math.Max(ClientTree.DisconnectProject(3604), -num4);
                                break;
                            }
                          }
                          else
                          {
                            num6 = Math.Min(ClientTree.DisconnectProject(3608), Math.Abs(num4 - ClientTree.DisconnectProject(3612)));
                            break;
                          }
                          break;
                      }
                    }
                    Rectangle rectangle = new Rectangle(this.blocks[index].pos.X + num5, this.blocks[index].pos.Y + num6, this.blocks[index].pos.Width, this.blocks[index].pos.Height);
                    this.DisconnectProject(index, rectangle, num5, num6);
                    continue;
                }
              }
            }
label_86:
            switch (7)
            {
              case 0:
                goto label_86;
              default:
                for (int index = ClientTree.DisconnectProject(3620); index < (int) ConnectionContext.DisconnectProject(this.blocks); index += ClientTree.DisconnectProject(3716))
                {
                  int val1_3 = ClientTree.DisconnectProject(3624);
                  int val1_4 = ClientTree.DisconnectProject(3628);
                  if ((double) this.lastBlockPositions[index].X > (double) ClientTree.DisconnectProject(3632))
                  {
label_89:
                    switch (5)
                    {
                      case 0:
                        goto label_89;
                      default:
                        val1_3 = Math.Max(ClientTree.DisconnectProject(3636), ClientTree.DisconnectProject(3640) - this.blocks[index].pos.X);
                        break;
                    }
                  }
                  this.blocks[index].pos.X = Math.Max(this.blocks[index].pos.X, ClientTree.DisconnectProject(3644));
                  if (this.blocks[index].isBlueBlock)
                  {
                    if (this.blocks[index].ClosestRasterPosX >= ClientTree.DisconnectProject(3648))
                    {
label_93:
                      switch (1)
                      {
                        case 0:
                          goto label_93;
                        default:
                          if (!this.soundDragPlayed)
                          {
                            if (GameBase.Instance.GameSettings.SoundFxIsOn)
                            {
label_96:
                              switch (4)
                              {
                                case 0:
                                  goto label_96;
                                default:
                                  GameLevel.currentUri.Play();
                                  break;
                              }
                            }
                            this.soundDragPlayed = ClientTree.DisconnectProject(3652) != 0;
                            break;
                          }
                          break;
                      }
                    }
                    if (this.blocks[index].ClosestRasterPosX > ClientTree.DisconnectProject(3656))
                    {
label_100:
                      switch (2)
                      {
                        case 0:
                          goto label_100;
                        default:
                          this.DisconnectProject();
                          break;
                      }
                    }
                  }
                  if (this.blocks[index].isBlueBlock)
                  {
label_103:
                    switch (1)
                    {
                      case 0:
                        goto label_103;
                      default:
                        if (this.blocks[index].ClosestRasterPosX < ClientTree.DisconnectProject(3660))
                        {
label_105:
                          switch (3)
                          {
                            case 0:
                              goto label_105;
                          }
                        }
                        else
                          goto label_110;
                        break;
                    }
                  }
                  if ((double) this.lastBlockPositions[index].X + (double) this.blocks[index].pos.Width < (double) ClientTree.DisconnectProject(3664))
                  {
label_107:
                    switch (7)
                    {
                      case 0:
                        goto label_107;
                      default:
                        val1_3 = Math.Max(val1_3, this.blocks[index].pos.X2() - ClientTree.DisconnectProject(3668));
                        ClientTree.DisconnectProject(3672);
                        break;
                    }
                  }
                  this.blocks[index].pos.X = Math.Min(this.blocks[index].pos.X, ClientTree.DisconnectProject(3676) - this.blocks[index].pos.Width);
label_110:
                  if ((double) this.lastBlockPositions[index].Y > (double) ClientTree.DisconnectProject(3680))
                    val1_4 = Math.Max(val1_4, ClientTree.DisconnectProject(3684) - this.blocks[index].pos.Y);
                  this.blocks[index].pos.Y = Math.Max(this.blocks[index].pos.Y, ClientTree.DisconnectProject(3688));
                  if ((double) this.lastBlockPositions[index].Y + (double) this.blocks[index].pos.Height < (double) ClientTree.DisconnectProject(3692))
                  {
label_113:
                    switch (2)
                    {
                      case 0:
                        goto label_113;
                      default:
                        val1_4 = Math.Max(val1_4, this.blocks[index].pos.Y2() - ClientTree.DisconnectProject(3696));
                        ClientTree.DisconnectProject(3700);
                        break;
                    }
                  }
                  this.blocks[index].pos.Y = Math.Min(this.blocks[index].pos.Y, ClientTree.DisconnectProject(3704) - this.blocks[index].pos.Height);
                  if (GameBase.Instance.GameSettings.SoundFxIsOn)
                  {
label_116:
                    switch (6)
                    {
                      case 0:
                        goto label_116;
                      default:
                        if (val1_3 < ClientTree.DisconnectProject(3708))
                        {
label_118:
                          switch (6)
                          {
                            case 0:
                              goto label_118;
                            default:
                              if (val1_4 < ClientTree.DisconnectProject(3712))
                                continue;
                              break;
                          }
                        }
                        GameLevel.parentKeywords.Play();
                        continue;
                    }
                  }
                }
label_123:
                switch (3)
                {
                  case 0:
                    goto label_123;
                  default:
                    if (this.namesID >= ClientTree.DisconnectProject(3720))
                    {
label_125:
                      switch (2)
                      {
                        case 0:
                          goto label_125;
                        default:
                          Vector2 newRasterPosition = new Vector2((float) this.blocks[this.namesID].ClosestRasterPosX, (float) this.blocks[this.namesID].ClosestRasterPosY);
                          if (ActivityProvider.DisconnectProject(this.lastBlockRasterPositions[this.namesID], newRasterPosition))
                          {
label_127:
                            switch (3)
                            {
                              case 0:
                                goto label_127;
                              default:
                                if (this.blockMovementTracking.Count > ClientTree.DisconnectProject(3724))
                                {
label_129:
                                  switch (3)
                                  {
                                    case 0:
                                      goto label_129;
                                    default:
                                      BlockMovement blockMovement = this.blockMovementTracking[this.blockMovementTracking.Count - ClientTree.DisconnectProject(3728)];
                                      if (blockMovement.BlockIndex == this.namesID)
                                      {
label_131:
                                        switch (7)
                                        {
                                          case 0:
                                            goto label_131;
                                          default:
                                            blockMovement.NewRasterPosition = newRasterPosition;
                                            break;
                                        }
                                      }
                                      else
                                      {
                                        this.blockMovementTracking.Add(new BlockMovement(this.namesID, this.lastBlockRasterPositions[this.namesID], newRasterPosition));
                                        this.MovementCounter += ClientTree.DisconnectProject(3732);
                                        break;
                                      }
                                      break;
                                  }
                                }
                                else
                                {
                                  this.blockMovementTracking.Add(new BlockMovement(this.namesID, this.lastBlockRasterPositions[this.namesID], newRasterPosition));
                                  this.MovementCounter += ClientTree.DisconnectProject(3736);
                                }
                                this.lastBlockRasterPositions[this.namesID] = newRasterPosition;
                                break;
                            }
                          }
                          else
                            break;
                          break;
                      }
                    }
                    this.ListQueue();
                    return;
                }
            }
        }
      }
    }

    private void DisconnectProject()
    {
      ChallangeBlock currentChallange1 = GameplayScreen.Instance.currentChallange;
      int currentChallange2 = (int) GameplayScreen.Instance.currentChallange;
      int currentLevel = GameplayScreen.Instance.currentLevel;
      if (GameBase.Instance.GameSettings.BestPlayResults[currentChallange2] == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.DisconnectProject);
            }
            GameBase.Instance.GameSettings.BestPlayResults[currentChallange2] = FormConverter.DisconnectProject(PredefinedLevels.LevelCount(currentChallange1));
            break;
        }
      }
      if (GameBase.Instance.GameSettings.BestPlayResults[currentChallange2][currentLevel] > ClientTree.DisconnectProject(3740))
      {
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            if (GameBase.Instance.GameSettings.BestPlayResults[currentChallange2][currentLevel] > this.MovementCounter)
            {
label_8:
              switch (2)
              {
                case 0:
                  goto label_8;
              }
            }
            else
              goto label_10;
            break;
        }
      }
      GameBase.Instance.GameSettings.BestPlayResults[currentChallange2][currentLevel] = this.MovementCounter;
      GameBase.Instance.GameSettings.CurrentModeHighScore = GameLevel.CalculateScores();
label_10:
      GameBase.Instance.SerializeState();
      GameplayScreen.Instance.NextLevel();
    }

    public static int CalculateScores()
    {
      if (GameBase.Instance.GameSettings.BestPlayResults == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.CalculateScores);
            }
            return ClientTree.DisconnectProject(3744);
        }
      }
      else
      {
        int scores = ClientTree.DisconnectProject(3748);
        for (int challangeIndex = ClientTree.DisconnectProject(3752); challangeIndex < (int) FileScope.DisconnectProject(GameBase.Instance.GameSettings.BestPlayResults); challangeIndex += ClientTree.DisconnectProject(3772))
        {
          if (GameBase.Instance.GameSettings.BestPlayResults[challangeIndex] != null)
          {
label_7:
            switch (5)
            {
              case 0:
                goto label_7;
              default:
                for (int levelIndex = ClientTree.DisconnectProject(3756); levelIndex < GameBase.Instance.GameSettings.BestPlayResults[challangeIndex].Length; levelIndex += ClientTree.DisconnectProject(3768))
                {
                  int num1 = GameBase.Instance.GameSettings.BestPlayResults[challangeIndex][levelIndex];
                  if (num1 > ClientTree.DisconnectProject(3760))
                  {
label_10:
                    switch (4)
                    {
                      case 0:
                        goto label_10;
                      default:
                        int bestSolution = GameBase.Instance.GetBestSolution(challangeIndex, levelIndex);
                        if (num1 >= bestSolution)
                        {
label_12:
                          switch (6)
                          {
                            case 0:
                              goto label_12;
                            default:
                              int num2 = bestSolution - (num1 - bestSolution);
                              if (num2 > ClientTree.DisconnectProject(3764))
                              {
label_14:
                                switch (5)
                                {
                                  case 0:
                                    goto label_14;
                                  default:
                                    scores += num2;
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
                }
label_18:
                switch (2)
                {
                  case 0:
                    goto label_18;
                  default:
                    continue;
                }
            }
          }
        }
label_21:
        switch (6)
        {
          case 0:
            goto label_21;
          default:
            return scores;
        }
      }
    }

    private void DisconnectProject(int _param1, Rectangle _param2, int _param3, int _param4)
    {
      for (int index = ClientTree.DisconnectProject(3776); index < (int) ConnectionContext.DisconnectProject(this.blocks); index += ClientTree.DisconnectProject(3828))
      {
        if (index != _param1)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.DisconnectProject);
              }
              if (_param2.Intersects(this.blocks[index].pos))
              {
                int num1 = ClientTree.DisconnectProject(3780);
                int num2 = ClientTree.DisconnectProject(3784);
                if (_param3 > ClientTree.DisconnectProject(3788))
                {
label_7:
                  switch (5)
                  {
                    case 0:
                      goto label_7;
                    default:
                      if (_param2.X2() > this.blocks[index].pos.X && _param2.X < this.blocks[index].pos.X2())
                      {
label_9:
                        switch (7)
                        {
                          case 0:
                            goto label_9;
                          default:
                            _param3 = this.blocks[index].pos.X - _param2.Width - this.blocks[_param1].pos.X;
                            if ((double) this.lastBlockPositions[_param1].X < (double) (this.blocks[_param1].pos.X + _param3))
                            {
label_11:
                              switch (3)
                              {
                                case 0:
                                  goto label_11;
                                default:
                                  num1 = _param2.X2() - this.blocks[_param1].pos.X;
                                  goto label_21;
                              }
                            }
                            else
                              goto label_21;
                        }
                      }
                      else
                        break;
                  }
                }
                if (_param3 < ClientTree.DisconnectProject(3792))
                {
label_14:
                  switch (1)
                  {
                    case 0:
                      goto label_14;
                    default:
                      if (_param2.X < this.blocks[index].pos.X2())
                      {
label_16:
                        switch (5)
                        {
                          case 0:
                            goto label_16;
                          default:
                            if (_param2.X2() > this.blocks[index].pos.X)
                            {
label_18:
                              switch (6)
                              {
                                case 0:
                                  goto label_18;
                                default:
                                  _param3 = this.blocks[index].pos.X2() - this.blocks[_param1].pos.X;
                                  if ((double) this.lastBlockPositions[_param1].X > (double) (this.blocks[_param1].pos.X + _param3))
                                  {
                                    num1 = this.blocks[_param1].pos.X2() - _param2.X;
                                    break;
                                  }
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
label_21:
                if (_param4 > ClientTree.DisconnectProject(3796))
                {
label_22:
                  switch (7)
                  {
                    case 0:
                      goto label_22;
                    default:
                      if (_param2.Y2() > this.blocks[index].pos.Y)
                      {
label_24:
                        switch (1)
                        {
                          case 0:
                            goto label_24;
                          default:
                            if (_param2.Y < this.blocks[index].pos.Y2())
                            {
label_26:
                              switch (5)
                              {
                                case 0:
                                  goto label_26;
                                default:
                                  _param4 = this.blocks[index].pos.Y - _param2.Height - this.blocks[_param1].pos.Y;
                                  if ((double) this.lastBlockPositions[_param1].Y < (double) (this.blocks[_param1].pos.Y + _param4))
                                  {
label_28:
                                    switch (7)
                                    {
                                      case 0:
                                        goto label_28;
                                      default:
                                        num2 = _param2.Y2() - this.blocks[_param1].pos.Y;
                                        goto label_38;
                                    }
                                  }
                                  else
                                    goto label_38;
                              }
                            }
                            else
                              break;
                        }
                      }
                      else
                        break;
                      break;
                  }
                }
                if (_param4 < ClientTree.DisconnectProject(3800))
                {
label_31:
                  switch (3)
                  {
                    case 0:
                      goto label_31;
                    default:
                      if (_param2.Y < this.blocks[index].pos.Y2())
                      {
label_33:
                        switch (6)
                        {
                          case 0:
                            goto label_33;
                          default:
                            if (_param2.Y2() > this.blocks[index].pos.Y)
                            {
                              _param4 = this.blocks[index].pos.Y2() - this.blocks[_param1].pos.Y;
                              if ((double) this.lastBlockPositions[_param1].Y > (double) (this.blocks[_param1].pos.Y + _param4))
                              {
label_36:
                                switch (4)
                                {
                                  case 0:
                                    goto label_36;
                                  default:
                                    num2 = this.blocks[_param1].pos.Y2() - _param2.Y;
                                    break;
                                }
                              }
                              else
                                break;
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
label_38:
                if (GameBase.Instance.GameSettings.SoundFxIsOn)
                {
label_39:
                  switch (1)
                  {
                    case 0:
                      goto label_39;
                    default:
                      if (num1 < ClientTree.DisconnectProject(3804))
                      {
label_41:
                        switch (1)
                        {
                          case 0:
                            goto label_41;
                          default:
                            if (num2 >= ClientTree.DisconnectProject(3808))
                            {
label_43:
                              switch (4)
                              {
                                case 0:
                                  goto label_43;
                              }
                            }
                            else
                              goto label_45;
                            break;
                        }
                      }
                      GameLevel.parentKeywords.Play();
                      break;
                  }
                }
label_45:
                this.parentKeywords[_param1] = ClientTree.DisconnectProject(3812);
                this.currentUri[_param1] = ClientTree.DisconnectProject(3820);
                goto label_49;
              }
              else
                continue;
          }
        }
      }
label_48:
      switch (2)
      {
        case 0:
          goto label_48;
      }
label_49:
      this.blocks[_param1].pos.X += _param3;
      this.blocks[_param1].pos.Y += _param4;
    }

    public bool HastMovementsToUndo()
    {
      return this.blockMovementTracking.Count > ClientTree.DisconnectProject(3832);
    }

    internal void DisposeDrive()
    {
      if (this.namesID >= ClientTree.DisconnectProject(3836))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.DisposeDrive);
            break;
        }
      }
      else if (this.blockMovementTracking.Count <= ClientTree.DisconnectProject(3840))
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
        }
      }
      else
      {
        BlockMovement blockMovement = this.blockMovementTracking[this.blockMovementTracking.Count - ClientTree.DisconnectProject(3844)];
        this.blockMovementTracking.RemoveAt(this.blockMovementTracking.Count - ClientTree.DisconnectProject(3848));
        Block block = this.blocks[blockMovement.BlockIndex];
        block.Place((int) blockMovement.OldRasterPosition.X, (int) blockMovement.OldRasterPosition.Y);
        this.lastBlockRasterPositions[blockMovement.BlockIndex] = new Vector2((float) block.ClosestRasterPosX, (float) block.ClosestRasterPosY);
        this.MovementCounter = Math.Max(this.MovementCounter - ClientTree.DisconnectProject(3852), ClientTree.DisconnectProject(3856));
        this.ListQueue();
      }
    }

    private void ListQueue()
    {
      for (int index = ClientTree.DisconnectProject(3860); index < (int) ConnectionContext.DisconnectProject(this.blocks); index += ClientTree.DisconnectProject(3864))
        this.lastBlockPositions[index] = new Vector2((float) this.blocks[index].pos.X, (float) this.blocks[index].pos.Y);
label_3:
      switch (6)
      {
        case 0:
          goto label_3;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.ListQueue);
          break;
      }
    }
  }
}
