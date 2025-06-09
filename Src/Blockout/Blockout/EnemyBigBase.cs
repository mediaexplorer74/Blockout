// *************************************************************
// Type: Blockout.EnemyBigBase
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class EnemyBigBase
  {
    private const int parentKeywords = 2;
    private const int currentUri = 8;
    private const int filterID = -100;
    private const int parentCancel = 300;
    private const int namesID = 400;
    [DataMember]
    public Vector2 pos;
    [DataMember]
    public bool isMovingLeft;
    [DataMember]
    public bool isMovingUp;
    [DataMember]
    public double XMovementPerCall;
    [DataMember]
    public double YMovementPerCall;
    [DataMember]
    public bool isActive;
    [DataMember]
    public int shapeType;
    [DataMember]
    public Color ShapeColor;
    private static Color[] parentKeywords;
    public SoundEffectInstance soundEffectOnHit;
    private static Color[][] parentKeywords;
    private static SoundEffectInstance parentKeywords;
    private static SoundEffectInstance currentUri;
    private static SoundEffectInstance filterID;

    static EnemyBigBase()
    {
      Color[] colorArray = ConfigProvider.DisconnectProject(ClientTree.DisconnectProject(1744));
      colorArray[ClientTree.DisconnectProject(1748)] = Color.AntiqueWhite;
      colorArray[ClientTree.DisconnectProject(1752)] = Color.Aquamarine;
      colorArray[ClientTree.DisconnectProject(1756)] = Color.Brown;
      colorArray[ClientTree.DisconnectProject(1760)] = Color.BurlyWood;
      colorArray[ClientTree.DisconnectProject(1764)] = Color.CadetBlue;
      colorArray[ClientTree.DisconnectProject(1768)] = Color.Chocolate;
      colorArray[ClientTree.DisconnectProject(1772)] = Color.Coral;
      colorArray[ClientTree.DisconnectProject(1776)] = Color.CornflowerBlue;
      colorArray[ClientTree.DisconnectProject(1780)] = Color.DarkSalmon;
      colorArray[ClientTree.DisconnectProject(1784)] = Color.DarkSeaGreen;
      colorArray[ClientTree.DisconnectProject(1788)] = Color.Gold;
      colorArray[ClientTree.DisconnectProject(1792)] = Color.Lavender;
      colorArray[ClientTree.DisconnectProject(1796)] = Color.LightPink;
      colorArray[ClientTree.DisconnectProject(1800)] = Color.LightSteelBlue;
      colorArray[ClientTree.DisconnectProject(1804)] = Color.MediumAquamarine;
      colorArray[ClientTree.DisconnectProject(1808)] = Color.MediumOrchid;
      colorArray[ClientTree.DisconnectProject(1812)] = Color.DarkOrange;
      colorArray[ClientTree.DisconnectProject(1816)] = Color.PaleGoldenrod;
      colorArray[ClientTree.DisconnectProject(1820)] = Color.PaleTurquoise;
      colorArray[ClientTree.DisconnectProject(1824)] = Color.PaleVioletRed;
      colorArray[ClientTree.DisconnectProject(1828)] = Color.PapayaWhip;
      colorArray[ClientTree.DisconnectProject(1832)] = Color.Peru;
      colorArray[ClientTree.DisconnectProject(1836)] = Color.Plum;
      colorArray[ClientTree.DisconnectProject(1840)] = Color.PowderBlue;
      EnemyBigBase.parentKeywords = colorArray;
      EnemyBigBase.parentKeywords = GameBase.Instance.Content.Load<SoundEffect>(DatabaseLoader.DisconnectProject(10034)).CreateInstance();
      EnemyBigBase.currentUri = GameBase.Instance.Content.Load<SoundEffect>(DatabaseLoader.DisconnectProject(10055)).CreateInstance();
      EnemyBigBase.filterID = GameBase.Instance.Content.Load<SoundEffect>(DatabaseLoader.DisconnectProject(10084)).CreateInstance();
    }

    public EnemyBigBase()
    {
      this.LoadContent();
      this.DisconnectProject();
    }

    public int Width => ClientTree.DisconnectProject(1652);

    public int Height => ClientTree.DisconnectProject(1656);

    public Color[] ColorCollision => EnemyBigBase.parentKeywords[this.shapeType];

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context)
    {
      this.LoadContent();
      this.DisposeDrive();
    }

    private void DisconnectProject()
    {
      this.EnableNetwork();
      this.ShapeColor = EnemyBigBase.parentKeywords[RandomManager.Rnd.Next((int) DirectoryHelper.DisconnectProject(EnemyBigBase.parentKeywords))];
      this.shapeType = RandomManager.Rnd.Next(ClientTree.DisconnectProject(1660));
      this.ListQueue();
      this.DisposeDrive();
    }

    private void DisposeDrive()
    {
      if (this.shapeType == 0)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyBigBase.DisposeDrive);
            }
            this.soundEffectOnHit = EnemyBigBase.filterID;
            break;
        }
      }
      else if (this.shapeType == ClientTree.DisconnectProject(1664))
      {
        this.soundEffectOnHit = EnemyBigBase.parentKeywords;
      }
      else
      {
        if (this.shapeType != ClientTree.DisconnectProject(1668))
          throw new NotImplementedException();
label_8:
        switch (7)
        {
          case 0:
            goto label_8;
          default:
            this.soundEffectOnHit = EnemyBigBase.currentUri;
            break;
        }
      }
    }

    protected void LoadContent()
    {
    }

    private void ListQueue()
    {
      this.XMovementPerCall = (double) RandomManager.Rnd.Next(ClientTree.DisconnectProject(1672), ClientTree.DisconnectProject(1676));
      this.YMovementPerCall = (double) RandomManager.Rnd.Next(ClientTree.DisconnectProject(1680), ClientTree.DisconnectProject(1684));
    }

    public void SpawnTop()
    {
      this.isMovingLeft = (RandomManager.Rnd.Next(ClientTree.DisconnectProject(1688)) > ClientTree.DisconnectProject(1692) ? 1 : 0) == ClientTree.DisconnectProject(1696);
      this.isActive = ClientTree.DisconnectProject(1700) != 0;
    }

    private void EnableNetwork()
    {
    }

    public void Move(float movementBase)
    {
      if (!this.isActive)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyBigBase.Move);
            break;
        }
      }
      else
      {
        float num1 = (float) this.XMovementPerCall * movementBase;
        float num2 = (float) this.YMovementPerCall * movementBase;
        if (this.isMovingLeft)
        {
label_6:
          switch (3)
          {
            case 0:
              goto label_6;
            default:
              this.pos.X -= num1;
              if ((double) this.pos.X <= (double) ClientTree.DisconnectProject(1704))
              {
label_8:
                switch (3)
                {
                  case 0:
                    goto label_8;
                  default:
                    this.pos.X = ClientTree.DisconnectProject(1708);
                    this.isMovingLeft = ClientTree.DisconnectProject(1712) != 0;
                    break;
                }
              }
              else
                break;
              break;
          }
        }
        else
          this.pos.X += num1;
        if (this.isMovingUp)
        {
label_12:
          switch (5)
          {
            case 0:
              goto label_12;
            default:
              this.pos.Y -= num2;
              if ((double) this.pos.Y > (double) ClientTree.DisconnectProject(1716))
                break;
label_14:
              switch (5)
              {
                case 0:
                  goto label_14;
                default:
                  this.isMovingUp = ClientTree.DisconnectProject(1720) != 0;
                  return;
              }
          }
        }
        else
        {
          this.pos.Y += num2;
          if ((double) this.pos.Y < (double) GameplayScreenBase.BoundsGame.Y2())
            return;
          Player.Instance.ExtractDockingPane();
          this.isActive = ClientTree.DisconnectProject(1724) != 0;
          EnemyManager.Instance.ActiveEnemies -= ClientTree.DisconnectProject(1728);
          EnemyManager.Instance.BounceCounterWhithoutDrop = ClientTree.DisconnectProject(1732);
        }
      }
    }

    public void Draw()
    {
      int num = this.isActive ? 1 : 0;
    }

    internal void TestConnection()
    {
      this.isMovingUp = ClientTree.DisconnectProject(1736) != 0;
      this.isActive = ClientTree.DisconnectProject(1740) != 0;
      this.DisconnectProject();
    }
  }
}
