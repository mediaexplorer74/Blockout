// Decompiled with JetBrains decompiler
// Type: Blockout.BackgroundMovingObject
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace Blockout
{
  public class BackgroundMovingObject
  {
    private Texture2D parentKeywords;
    public Rectangle Pos;
    public bool IsActive;

    public BackgroundMovingObject(Texture2D texToUse)
    {
      if (texToUse == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (BackgroundMovingObject.\u002Ector);
            }
            throw new ArgumentNullException(DatabaseLoader.DisconnectProject(9864));
        }
      }
      else
      {
        this.parentKeywords = texToUse;
        this.Pos.Width = this.parentKeywords.Width;
        this.Pos.Height = this.parentKeywords.Height;
      }
    }

    public void Start(Vector2 startPosition)
    {
      this.Pos.X = (int) startPosition.X;
      this.Pos.Y = (int) startPosition.Y;
      this.IsActive = ClientTree.DisconnectProject(1476) != 0;
    }

    public void Start()
    {
      this.Pos.X = RandomManager.Rnd.Next(GameplayScreenBase.BoundsGame.X - this.parentKeywords.Width + ClientTree.DisconnectProject(1480), GameplayScreenBase.BoundsGame.X2() - ClientTree.DisconnectProject(1484));
      this.Pos.Y = RandomManager.Rnd.Next(GameplayScreenBase.BoundsGame.Y - this.parentKeywords.Height + ClientTree.DisconnectProject(1488), GameplayScreenBase.BoundsGame.Y2() - ClientTree.DisconnectProject(1492));
      this.IsActive = ClientTree.DisconnectProject(1496) != 0;
    }

    public void Update()
    {
      if (!this.IsActive)
        return;
      if (this.Pos.X2() >= ScreenManager.BoundsScreen.X && this.Pos.X <= ScreenManager.BoundsScreen.X2())
      {
label_3:
        switch (4)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (BackgroundMovingObject.Update);
            }
            if (this.Pos.Y2() >= ScreenManager.BoundsScreen.Y)
            {
label_7:
              switch (7)
              {
                case 0:
                  goto label_7;
                default:
                  if (this.Pos.Y <= ScreenManager.BoundsScreen.Y2())
                    return;
                  break;
              }
            }
            else
              break;
            break;
        }
      }
      this.IsActive = ClientTree.DisconnectProject(1500) != 0;
    }

    public void Draw()
    {
      if (!this.IsActive)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (BackgroundMovingObject.Draw);
            break;
        }
      }
      else
        GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, this.Pos, Color.White);
    }
  }
}
