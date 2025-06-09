// *************************************************************
// Type: GameFoundation.TimeElapsedHandler
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class TimeElapsedHandler
  {
    [DataMember]
    public double timeToCycle;
    [DataMember]
    public int minCycle;
    [DataMember]
    public int additionalMarginMaxCycle;
    [DataMember]
    public double openTimeToCycle;

    public TimeElapsedHandler(double timeToCycle)
    {
      this.timeToCycle = timeToCycle;
      this.Reset();
    }

    public TimeElapsedHandler(int minCycle, int additionalMarginMaxCycle)
    {
      this.timeToCycle = ReferenceInvoker.DisconnectProject(5817);
      this.minCycle = minCycle;
      this.additionalMarginMaxCycle = additionalMarginMaxCycle;
      this.Reset();
    }

    public bool Update(double elapsedGameTimeMs)
    {
      this.openTimeToCycle -= elapsedGameTimeMs;
      if (this.openTimeToCycle > ReferenceInvoker.DisconnectProject(5785))
        return ReferenceInvoker.DisconnectProject(5805) != 0;
      if (this.timeToCycle > ReferenceInvoker.DisconnectProject(5793))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TimeElapsedHandler.Update);
            }
            this.openTimeToCycle += this.timeToCycle;
            break;
        }
      }
      else
        this.openTimeToCycle = (double) RandomManager.Rnd.Next(this.minCycle, this.minCycle + this.additionalMarginMaxCycle);
      return ReferenceInvoker.DisconnectProject(5801) != 0;
    }

    public void Reset()
    {
      if (this.timeToCycle > ReferenceInvoker.DisconnectProject(5809))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TimeElapsedHandler.Reset);
            }
            this.openTimeToCycle = this.timeToCycle;
            break;
        }
      }
      else
        this.openTimeToCycle = (double) RandomManager.Rnd.Next(this.minCycle, this.minCycle + this.additionalMarginMaxCycle);
    }
  }
}
