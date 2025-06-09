// Decompiled with JetBrains decompiler
// Type: Blockout.AchievementHighscore
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class AchievementHighscore(AchievementProperties achievements) : Achievement(achievements)
  {
    protected override bool ShowLeftSide => ClientTree.DisconnectProject(308) != 0;

    protected override void DrawIcon(int index)
    {
    }
  }
}
