// Decompiled with JetBrains decompiler
// Type: GameFoundation.GameSettings
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class GameSettings
  {
    public const int MinMusicVolume = 0;
    public const int MaxMusicVolume = 100;
    [DataMember]
    public ScorePoints LocalHighScoreHard;
    [DataMember]
    public bool MusicIsOn;
    [DataMember]
    public bool SoundFxIsOn;
    [DataMember]
    public int MusicVolume;
    [DataMember]
    public bool IsFirstTimePlaying;
    [DataMember]
    public string PlayerName;
    [DataMember]
    public int[][] BestPlayResults;

    public GameSettings()
    {
      this.MusicIsOn = ReferenceInvoker.DisconnectProject(392) != 0;
      this.SoundFxIsOn = ReferenceInvoker.DisconnectProject(396) != 0;
      this.MusicVolume = ReferenceInvoker.DisconnectProject(400);
      this.IsFirstTimePlaying = ReferenceInvoker.DisconnectProject(404) != 0;
      this.PlayerName = "";
      this.LocalHighScoreHard = new ScorePoints((ChallangeLevels) ReferenceInvoker.DisconnectProject(408));
      this.BestPlayResults = PartitionManager.DisconnectProject((int) IconStack.DisconnectProject(ChallangeBlockTypes.GetTypes()));
    }

    public int CurrentModeHighScore
    {
      get => this.LocalHighScoreHard.Scores;
      set => this.LocalHighScoreHard.DisconnectProject(value);
    }

    public void InvertOptionMusicIsOn()
    {
      this.MusicIsOn = (this.MusicIsOn ? 1 : 0) == ReferenceInvoker.DisconnectProject(384);
      GameBase.Instance.UpdateMusicIsOn();
      GameBase.Instance.SerializeState();
    }

    public void InvertOptionSoundIsOn()
    {
      this.SoundFxIsOn = (this.SoundFxIsOn ? 1 : 0) == ReferenceInvoker.DisconnectProject(388);
      GameBase.Instance.SerializeState();
    }
  }
}
