// *************************************************************
// Type: GameFoundation.PlayerBase
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public abstract class PlayerBase
  {
    public static PlayerBase Instance;
    [DataMember]
    public bool IsAlive;

    public PlayerBase() => PlayerBase.Instance = this;
  }
}
