// *************************************************************
// Type: GameFoundation.TimerEventless
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;

#nullable disable
namespace GameFoundation
{
    public class TimerEventless
    {
        private double parentKeywords;
        private double currentUri;
        private bool parentKeywords2;
        private Action parentKeywords3;

        public TimerEventless(TimeSpan timeForTimer, Action methodToExecute)
        {
            if (methodToExecute == null)
            {
                throw new ArgumentNullException(nameof(methodToExecute));
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
                this.DisconnectProject();
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
                return;
            }
            else
            {
                this.currentUri -= elapsedGameTimeMs;
                if (!this.DisconnectProject(restartIfElapsed))
                    return;

                this.parentKeywords();
            }
        }

        private bool DisconnectProject(bool _param1)
        {
            if (!this.parentKeywords)
            {
                return ReferenceInvoker.DisconnectProject(829) != 0;
            }
            else
            {
                bool flag = (this.currentUri > ReferenceInvoker.DisconnectProject(833) ? 1 : 0) == ReferenceInvoker.DisconnectProject(841);
                if (flag)
                {
                    if (_param1)
                    {
                        this.DisconnectProject();
                    }
                    else
                    {
                        this.parentKeywords = ReferenceInvoker.DisconnectProject(845) != 0;
                    }
                }
                return flag;
            }
        }
    }
}
