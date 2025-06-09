// *************************************************************
// Type: GameFoundation.AssemblyStack
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace GameFoundation
{
  internal sealed class AssemblyStack : MenuEntry
  {
    private const bool parentKeywords = false;
    public Vector2 parentKeywords;
    public bool currentUri;

    public AssemblyStack(Vector2 _param1)
      : base(nameof ())
    {
      this.parentKeywords = _param1;
    }

    protected internal override void OnSelectEntry(Point relativeHitPosition)
    {
      base.OnSelectEntry(relativeHitPosition);
      if (!this.currentUri || !GameBase.Instance.GameSettings.SoundFxIsOn)
        return;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AssemblyStack.OnSelectEntry);
          }
          ScreenManager.Instance.SoundClickButtonInstance.Play();
          break;
      }
    }

    public override void Update(double elapsedGameTimeMs)
    {
    }

    public override void Draw(MenuScreen screen)
    {
      if (!this.IsVisible)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AssemblyStack.Draw);
            break;
        }
      }
      else
        base.Draw(screen);
    }

    public override int GetHeight() => (int) this.parentKeywords.Y;

    public override int GetWidth() => (int) this.parentKeywords.X;
  }
}
