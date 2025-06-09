// *************************************************************
// Type: GameFoundation.ScorePoints
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class ScorePoints
  {
    private EventHandler<EventArgs> parentKeywords;
    [DataMember]
    public ChallangeLevels forChallangeLevel;
    [DataMember]
    public DateTime localTimeWhenAchived;
    private DateTime parentKeywords;
    [DataMember]
    public int Scores;
    [DataMember]
    public bool SucessfullySentToServer;

    public ScorePoints(ChallangeLevels challangeLevel) => this.forChallangeLevel = challangeLevel;

    public event EventHandler<EventArgs> NewHighScores
    {
      add
      {
        EventHandler<EventArgs> eventHandler1 = this.parentKeywords;
        EventHandler<EventArgs> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.parentKeywords, DomainDictionary.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (6)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScorePoints.add_NewHighScores);
            break;
        }
      }
      remove
      {
        EventHandler<EventArgs> eventHandler1 = this.parentKeywords;
        EventHandler<EventArgs> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.parentKeywords, DomainDictionary.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
      }
    }

    internal KeyValuePair<DateTime, int> DisconnectProject()
    {
      if (!this.SucessfullySentToServer)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScorePoints.DisconnectProject);
            }
            if (this.Scores > ReferenceInvoker.DisconnectProject(2649))
            {
              this.parentKeywords = DateTime.Now;
              return new KeyValuePair<DateTime, int>(this.localTimeWhenAchived, this.Scores);
            }
            break;
        }
      }
      return new KeyValuePair<DateTime, int>(DateTime.Now, ReferenceInvoker.DisconnectProject(2653));
    }

    internal KeyValuePair<DateTime, int> DisposeDrive()
    {
      if (!this.SucessfullySentToServer)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ScorePoints.DisposeDrive);
            }
            if (this.Scores > ReferenceInvoker.DisconnectProject(2657))
              return new KeyValuePair<DateTime, int>(this.localTimeWhenAchived, this.Scores);
label_5:
            switch (6)
            {
              case 0:
                goto label_5;
            }
            break;
        }
      }
      return new KeyValuePair<DateTime, int>(DateTime.Now, ReferenceInvoker.DisconnectProject(2661));
    }

    internal void DisconnectProject()
    {
      if (this.SucessfullySentToServer || ClientContext.DisconnectProject(this.parentKeywords, DateTime.Now.AddMinutes(ReferenceInvoker.DisconnectProject(2665))))
        return;
      this.SucessfullySentToServer = ReferenceInvoker.DisconnectProject(2673) != 0;
    }

    internal void DisposeDrive()
    {
      if (this.SucessfullySentToServer)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScorePoints.DisposeDrive);
            break;
        }
      }
      else
        this.parentKeywords = DateTime.MinValue;
    }

    internal void DisconnectProject(int _param1)
    {
      if (this.Scores > _param1)
        return;
label_1:
      switch (1)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScorePoints.DisconnectProject);
          }
          this.DisposeDrive(_param1);
          break;
      }
    }

    private void DisposeDrive(int _param1)
    {
      this.Scores = _param1;
      this.localTimeWhenAchived = DateTime.Now;
      this.parentKeywords = DateTime.MinValue;
      this.SucessfullySentToServer = ReferenceInvoker.DisconnectProject(2677) != 0;
      if (this.parentKeywords == null)
        return;
label_1:
      switch (2)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ScorePoints.DisposeDrive);
          }
          this.parentKeywords((object) this, (EventArgs) null);
          break;
      }
    }
  }
}
