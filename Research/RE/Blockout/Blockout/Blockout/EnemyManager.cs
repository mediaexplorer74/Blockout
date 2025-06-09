// Decompiled with JetBrains decompiler
// Type: Blockout.EnemyManager
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class EnemyManager
  {
    public const int MaxEnemies = 400;
    public const int MsForNewEnemySpawn = 3000;
    public const int DefaultStartBouncesForNewLive = 250;
    private const double parentKeywords = 1.3;
    private const int parentKeywords = 200;
    private const float parentKeywords = 0.02f;
    public static EnemyManager Instance;
    public bool IsActive;
    [DataMember]
    public EnemyBigBase[] enemies;
    [DataMember]
    public double MsRemainingForEnemySpawn;
    [DataMember]
    public int CurrentStartBouncesForNewLive;
    [DataMember]
    public int BouncesOpenForNewLive;
    [DataMember]
    public int BounceCounter;
    [DataMember]
    public int ActiveEnemies;
    [DataMember]
    public int BounceCounterWhithoutDrop;

    private EnemyManager()
    {
      this.IsActive = ClientTree.DisconnectProject(1992) != 0;
      this.CurrentStartBouncesForNewLive = ClientTree.DisconnectProject(1996);
      this.DisconnectProject();
      this.enemies = DirectoryContext.DisconnectProject(ClientTree.DisconnectProject(2000));
      for (int index = ClientTree.DisconnectProject(2004); index < ClientTree.DisconnectProject(2012); index += ClientTree.DisconnectProject(2008))
        this.enemies[index] = new EnemyBigBase();
label_3:
      switch (3)
      {
        case 0:
          goto label_3;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyManager.\u002Ector);
          }
          this.LoadContent();
          break;
      }
    }

    public static EnemyManager Init()
    {
      if (EnemyManager.Instance == null)
        return new EnemyManager();
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyManager.Init);
          }
          return EnemyManager.Instance;
      }
    }

    private void DisconnectProject()
    {
      this.CurrentStartBouncesForNewLive = (int) ((double) this.CurrentStartBouncesForNewLive * ClientTree.DisconnectProject(1844));
      this.BouncesOpenForNewLive = this.CurrentStartBouncesForNewLive;
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void LoadContent()
    {
      if (EnemyManager.Instance != null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyManager.LoadContent);
            break;
        }
      }
      else
        EnemyManager.Instance = this;
    }

    private void DisposeDrive()
    {
      this.BouncesOpenForNewLive -= ClientTree.DisconnectProject(1852);
      if (this.BouncesOpenForNewLive <= ClientTree.DisconnectProject(1856))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyManager.DisposeDrive);
            }
            Player.Instance.SelectResource();
            this.DisconnectProject();
            break;
        }
      }
      this.BounceCounter += ClientTree.DisconnectProject(1860);
      this.BounceCounterWhithoutDrop += ClientTree.DisconnectProject(1864);
      Scores.Instance.Points += ClientTree.DisconnectProject(1868);
    }

    private void ListQueue() => this.MsRemainingForEnemySpawn = ClientTree.DisconnectProject(1872);

    private void EnableNetwork()
    {
      for (int index = ClientTree.DisconnectProject(1880); index < (int) DomainStack.DisconnectProject(this.enemies); index += ClientTree.DisconnectProject(1888))
      {
        if (!this.enemies[index].isActive)
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
                RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyManager.EnableNetwork);
              }
              this.enemies[index].SpawnTop();
              this.ActiveEnemies += ClientTree.DisconnectProject(1884);
              goto label_9;
          }
        }
      }
label_8:
      switch (5)
      {
        case 0:
          goto label_8;
      }
label_9:
      if (this.ActiveEnemies < ClientTree.DisconnectProject(1892))
        return;
label_10:
      switch (3)
      {
        case 0:
          goto label_10;
        default:
          for (int index = ClientTree.DisconnectProject(1896); index < (int) DomainStack.DisconnectProject(this.enemies); index += ClientTree.DisconnectProject(1916))
          {
            this.enemies[index].XMovementPerCall += ClientTree.DisconnectProject(1900);
            this.enemies[index].YMovementPerCall += ClientTree.DisconnectProject(1908);
          }
label_14:
          switch (6)
          {
            case 0:
              goto label_14;
            default:
              return;
          }
      }
    }

    public void Update(double timeElapsed)
    {
      if (!this.IsActive)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (EnemyManager.Update);
            break;
        }
      }
      else
      {
        this.MsRemainingForEnemySpawn -= timeElapsed;
        if (this.MsRemainingForEnemySpawn <= ClientTree.DisconnectProject(1920))
        {
label_5:
          switch (4)
          {
            case 0:
              goto label_5;
            default:
              this.EnableNetwork();
              this.ListQueue();
              break;
          }
        }
        float movementBase = (float) (timeElapsed / ClientTree.DisconnectProject(1928));
        for (int index = ClientTree.DisconnectProject(1936); index < (int) DomainStack.DisconnectProject(this.enemies); index += ClientTree.DisconnectProject(1940))
          this.enemies[index].Move(movementBase);
label_10:
        switch (4)
        {
          case 0:
            goto label_10;
          default:
            this.CheckCollision();
            break;
        }
      }
    }

    public void Draw()
    {
      for (int index = ClientTree.DisconnectProject(1944); index < (int) DomainStack.DisconnectProject(this.enemies); index += ClientTree.DisconnectProject(1948))
        this.enemies[index].Draw();
    }

    public void CheckCollision()
    {
    }

    public void Reset()
    {
      for (int index = ClientTree.DisconnectProject(1952); index < (int) DomainStack.DisconnectProject(this.enemies); index += ClientTree.DisconnectProject(1956))
        this.enemies[index].TestConnection();
      this.MsRemainingForEnemySpawn = ClientTree.DisconnectProject(1960);
      this.CurrentStartBouncesForNewLive = ClientTree.DisconnectProject(1968);
      this.DisconnectProject();
      this.BounceCounter = ClientTree.DisconnectProject(1972);
      Scores.Instance.Points = ClientTree.DisconnectProject(1976);
      this.ActiveEnemies = ClientTree.DisconnectProject(1980);
      this.BounceCounterWhithoutDrop = ClientTree.DisconnectProject(1984);
      this.IsActive = ClientTree.DisconnectProject(1988) != 0;
    }
  }
}
