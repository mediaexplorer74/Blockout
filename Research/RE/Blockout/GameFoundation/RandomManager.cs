// Decompiled with JetBrains decompiler
// Type: GameFoundation.RandomManager
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace GameFoundation
{
  public class RandomManager
  {
    public static Random Rnd = new Random();

    private RandomManager()
    {
    }

    public static Vector2 GetRandomArea(int x1, int x2, int y1, int y2)
    {
      return new Vector2((float) RandomManager.Rnd.Next(x1, x2), (float) RandomManager.Rnd.Next(y1, y2));
    }
  }
}
