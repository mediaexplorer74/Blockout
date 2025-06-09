// Decompiled with JetBrains decompiler
// Type: GameFoundation.TimerEventless
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;

#nullable disable
namespace GameFoundation
{
  public class TimerEventless
  {
    private double parentKeywords;
    private double currentUri;
    private bool parentKeywords;
    private Action parentKeywords;

    public TimerEventless(TimeSpan timeForTimer, Action methodToExecute)
    {
      if (methodToExecute == null)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TimerEventless.\u002Ector);
            }
            throw new ArgumentNullException();
        }
      }
      else
      {
        this.parentKeywords = methodToExecute;
        this.parentKeywords = timeForTimer.TotalMilliseconds;
        this.DisconnectProject();
      }
    }

    public void StartOrContinue()
    {
      if (this.currentUri <= ReferenceInvoker.DisconnectProject(805))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TimerEventless.StartOrContinue);
            }
            this.DisconnectProject();
            break;
        }
      }
      this.parentKeywords = ReferenceInvoker.DisconnectProject(813) != 0;
    }

    public void Stop()
    {
      this.DisconnectProject();
      this.parentKeywords = ReferenceInvoker.DisconnectProject(817) != 0;
    }

    public void Pause() => this.parentKeywords = ReferenceInvoker.DisconnectProject(821) != 0;

    public void Resume() => this.parentKeywords = ReferenceInvoker.DisconnectProject(825) != 0;

    private void DisconnectProject() => this.currentUri = this.parentKeywords;

    public void Update(double elapsedGameTimeMs, bool restartIfElapsed)
    {
      if (!this.parentKeywords)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (TimerEventless.Update);
            break;
        }
      }
      else
      {
        this.currentUri -= elapsedGameTimeMs;
        if (!this.DisconnectProject(restartIfElapsed))
          return;
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            this.parentKeywords();
            break;
        }
      }
    }

    private bool DisconnectProject(bool _param1)
    {
      if (!this.parentKeywords)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TimerEventless.DisconnectProject);
            }
            return ReferenceInvoker.DisconnectProject(829) != 0;
        }
      }
      else
      {
        bool flag = (this.currentUri > ReferenceInvoker.DisconnectProject(833) ? 1 : 0) == ReferenceInvoker.DisconnectProject(841);
        if (flag)
        {
label_6:
          switch (5)
          {
            case 0:
              goto label_6;
            default:
              if (_param1)
              {
                this.DisconnectProject();
                break;
              }
              this.parentKeywords = ReferenceInvoker.DisconnectProject(845) != 0;
              break;
          }
        }
        return flag;
      }
    }
  }
}
