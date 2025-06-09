// Decompiled with JetBrains decompiler
// Type: Blockout.Player
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class Player : PlayerBase
  {
    private const int parentKeywords = 3;
    public const int MaxLives = 10;
    private const bool parentKeywords = true;
    private const bool currentUri = false;
    private const int currentUri = 100;
    private const int filterID = 40;
    private const bool filterID = true;
    private const bool parentCancel = true;
    private const double parentKeywords = 3.0;
    private const double currentUri = 12.0;
    [DataMember]
    public int Lives;
    [DataMember]
    public int LivesEarnedCounter;
    public int currentImageIndex;
    public static Player Instance;
    [DataMember]
    public Color DrawColor;
    [DataMember]
    public Rectangle posPlayer;
    public Rectangle posPlayerSubImage;
    private double filterID;
    [DataMember]
    public bool IsEnabled;
    private SoundEffectInstance parentKeywords;

    private Player()
    {
      this.IsAlive = ClientTree.DisconnectProject(1983401) != 0;
      this.IsEnabled = ClientTree.DisconnectProject(1983405) != 0;
      this.LoadContent();
      this.ListQueue();
    }

    public static Player Init()
    {
      if (Player.Instance == null)
        return new Player();
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Player.Init);
          }
          return Player.Instance;
      }
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    private void DisconnectProject()
    {
    }

    public void LoadContent()
    {
      if (Player.Instance != null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Player.LoadContent);
            break;
        }
      }
      else
      {
        Player.Instance = this;
        this.posPlayer.Width = ClientTree.DisconnectProject(1983185);
        this.posPlayer.Height = ClientTree.DisconnectProject(1983189);
        this.posPlayer.X = GameplayScreenBase.BoundsGame.Width / ClientTree.DisconnectProject(1983193) - this.posPlayer.Width / ClientTree.DisconnectProject(1983197);
        this.posPlayer.Y = ClientTree.DisconnectProject(1983201);
        this.DisposeDrive();
        this.DisconnectProject();
      }
    }

    private void DisposeDrive()
    {
      this.posPlayerSubImage.X = ClientTree.DisconnectProject(1983205);
      this.posPlayerSubImage.Y = ClientTree.DisconnectProject(1983209);
      this.posPlayerSubImage.Width = this.posPlayer.Width;
      this.posPlayerSubImage.Height = this.posPlayer.Height;
    }

    private void ListQueue()
    {
      this.posPlayer.X = GameplayScreenBase.BoundsGame.Width / ClientTree.DisconnectProject(1983213) - this.posPlayer.Width / ClientTree.DisconnectProject(1983217);
      this.posPlayer.Y = GameplayScreenBase.BoundsGame.Center.Y + ClientTree.DisconnectProject(1983221);
      this.DisposeDrive();
    }

    public void Update(double elapsedGameTimeMs)
    {
      double num = Math.Abs(this.filterID);
      if (num < ClientTree.DisconnectProject(1983225))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (Player.Update);
            }
            this.currentImageIndex = ClientTree.DisconnectProject(1983233);
            break;
        }
      }
      else if (num < ClientTree.DisconnectProject(1983237))
      {
label_6:
        switch (5)
        {
          case 0:
            goto label_6;
          default:
            if (this.filterID > ClientTree.DisconnectProject(1983245))
            {
              this.currentImageIndex = ClientTree.DisconnectProject(1983253);
              break;
            }
            this.currentImageIndex = ClientTree.DisconnectProject(1983257);
            break;
        }
      }
      else if (this.filterID > ClientTree.DisconnectProject(1983261))
      {
label_11:
        switch (2)
        {
          case 0:
            goto label_11;
          default:
            this.currentImageIndex = ClientTree.DisconnectProject(1983269);
            break;
        }
      }
      else
        this.currentImageIndex = ClientTree.DisconnectProject(1983273);
    }

    public void Draw()
    {
      int num = this.IsEnabled ? 1 : 0;
    }

    private void EnableNetwork()
    {
    }

    internal void DisconnectProject(InputState _param1)
    {
      if (!this.IsEnabled)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Player.DisconnectProject);
            break;
        }
      }
      else
      {
        this.EnableNetwork();
        double y = (double) this.posPlayer.Y;
        if (GameplayScreen.Instance.TempUpdatePause > ClientTree.DisconnectProject(1983277))
        {
label_6:
          switch (6)
          {
            case 0:
              goto label_6;
          }
        }
        else if (!this.IsAlive)
        {
label_9:
          switch (2)
          {
            case 0:
              goto label_9;
          }
        }
        else
        {
          if (AdController.Instance.InputConsumed)
            return;
          TouchLocation[] touchStateHandyArea = _param1.TouchStateHandyArea;
          for (int index = (int) OptionsFactory.DisconnectProject(touchStateHandyArea) - ClientTree.DisconnectProject(1983285); index >= ClientTree.DisconnectProject(1983333); index -= ClientTree.DisconnectProject(1983329))
          {
            TouchLocation touchLocation = touchStateHandyArea[index];
            if (touchLocation.State != (TouchLocationState) ClientTree.DisconnectProject(1983289))
            {
              if (touchLocation.State == (TouchLocationState) ClientTree.DisconnectProject(1983293))
              {
label_15:
                switch (2)
                {
                  case 0:
                    goto label_15;
                }
              }
              else
                continue;
            }
            int val1_1 = (int) touchLocation.Position.X - this.posPlayer.Width / ClientTree.DisconnectProject(1983297) - this.posPlayer.X;
            int val1_2 = (int) touchLocation.Position.Y - ClientTree.DisconnectProject(1983301) - this.posPlayer.Y;
            if (val1_1 > ClientTree.DisconnectProject(1983305))
              this.posPlayer.X += Math.Min(val1_1, ClientTree.DisconnectProject(1983309));
            else
              this.posPlayer.X += Math.Max(val1_1, ClientTree.DisconnectProject(1983313));
            if (val1_2 > ClientTree.DisconnectProject(1983317))
            {
              this.posPlayer.Y += Math.Min(val1_2, ClientTree.DisconnectProject(1983321));
              break;
            }
            this.posPlayer.Y += Math.Max(val1_2, ClientTree.DisconnectProject(1983325));
            break;
          }
          this.filterID = y - (double) this.posPlayer.Y;
        }
      }
    }

    internal void TestConnection()
    {
      this.ListQueue();
      this.IsEnabled = ClientTree.DisconnectProject(1983337) != 0;
      this.IsAlive = ClientTree.DisconnectProject(1983341) != 0;
      this.Lives = ClientTree.DisconnectProject(1983345);
      this.LivesEarnedCounter = ClientTree.DisconnectProject(1983349);
      this.currentImageIndex = ClientTree.DisconnectProject(1983353);
      this.DrawColor = Color.WhiteSmoke;
      this.filterID = ClientTree.DisconnectProject(1983357);
      this.EnableNetwork();
    }

    internal void ExtractDockingPane()
    {
      this.Lives -= ClientTree.DisconnectProject(1983365);
      if (this.Lives > ClientTree.DisconnectProject(1983369))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Player.ExtractDockingPane);
          }
          this.LoadDirectory();
          break;
      }
    }

    private void LoadDirectory()
    {
      this.IsAlive = ClientTree.DisconnectProject(1983373) != 0;
      EnemyManager.Instance.IsActive = ClientTree.DisconnectProject(1983377) != 0;
      GameplayScreen.Instance.showNoLifeLeft = ClientTree.DisconnectProject(1983381) != 0;
      GameplayScreen.Instance.IsGameToContinue = ClientTree.DisconnectProject(1983385) != 0;
    }

    internal void SelectResource()
    {
      if (this.Lives >= ClientTree.DisconnectProject(1983389))
        return;
      this.Lives += ClientTree.DisconnectProject(1983393);
      this.LivesEarnedCounter += ClientTree.DisconnectProject(1983397);
    }
  }
}
