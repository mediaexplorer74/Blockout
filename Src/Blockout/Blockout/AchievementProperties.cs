// *************************************************************
// Type: Blockout.AchievementProperties
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System;

#nullable disable
namespace Blockout
{
  public class AchievementProperties
  {
    public Func<bool>[] AchievedTest;
    public string[] Line1;
    public string[] Line2;
    public string[] Line2Extended;

    public AchievementProperties(
      Func<bool>[] achievementReachedTest,
      string[] line1,
      string[] line2,
      string[] line2Extended)
    {
      this.AchievedTest = achievementReachedTest;
      this.Line1 = line1;
      this.Line2 = line2;
      this.Line2Extended = line2Extended;
    }
  }
}
