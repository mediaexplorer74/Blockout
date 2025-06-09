// *************************************************************
// Type: GameFoundation.ManagedTimeLimitedBase
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public abstract class ManagedTimeLimitedBase
  {
    [DataMember]
    public double timeToBeActive;
    [DataMember]
    public double timeActiveElapsed;
    [DataMember]
    public bool IsActive;

    public ManagedTimeLimitedBase(double millisecondsToBeActive)
    {
      this.timeToBeActive = millisecondsToBeActive > ReferenceInvoker.DisconnectProject(1061) ? millisecondsToBeActive : throw new ArgumentException();
    }

    public virtual void Start()
    {
      this.timeActiveElapsed = ReferenceInvoker.DisconnectProject(1045);
      this.IsActive = ReferenceInvoker.DisconnectProject(1053) != 0;
      GameplayScreenBase.Instance.TimeLimitedManagedToUpdate.Add(this);
    }

    public virtual void Update(double elapsedGameTimeMs)
    {
      this.timeActiveElapsed += elapsedGameTimeMs;
      if (this.timeActiveElapsed < this.timeToBeActive)
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ManagedTimeLimitedBase.Update);
          }
          GameplayScreenBase.Instance.TimeLimitedManagedToUpdate.Remove(this);
          this.IsActive = ReferenceInvoker.DisconnectProject(1057) != 0;
          break;
      }
    }

    public abstract void Draw();
  }
}
