// *************************************************************
// Type: Blockout.EnemyPointsVisual
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using System;
using System.Text;

#nullable disable
namespace Blockout
{
  public class EnemyPointsVisual : ManagedTimeLimitedBase
  {
    private Vector2 parentKeywords;
    private StringBuilder parentKeywords;

    public EnemyPointsVisual(double millisecondsToBeActive, int points)
      : base(millisecondsToBeActive)
    {
      this.parentKeywords = new StringBuilder(NetworkDesigner.DisconnectProject(points.ToString(), DatabaseLoader.DisconnectProject(10113)));
    }

    public void Start(int startX, int startY, bool centerPosition)
    {
      this.Start();
      if (centerPosition)
        throw new NotImplementedException();
      this.parentKeywords.X = (float) startX;
      this.parentKeywords.Y = (float) startY;
    }

    public override void Update(double elapsedGameTimeMs)
    {
      base.Update(elapsedGameTimeMs);
      this.parentKeywords.Y -= ClientTree.DisconnectProject(2016);
    }

    public override void Draw()
    {
    }
  }
}
