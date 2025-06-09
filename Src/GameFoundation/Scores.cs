// *************************************************************
// Type: GameFoundation.Scores
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.Serialization;
using System.Text;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class Scores
  {
    private const bool parentKeywords = false;
    private const int parentKeywords = 999999999;
    private const bool currentUri = false;
    private const double parentKeywords = 200.0;
    private const bool filterID = false;
    private const double currentUri = 200.0;
    private const float parentKeywords = 0.8f;
    public static Scores Instance;
    [DataMember]
    public TimeElapsedHandler increaseScoresHandler;
    [DataMember]
    public TimeElapsedHandler decreaseScoresHandler;
    [DataMember]
    public int Points;
    private StringBuilder parentKeywords;
    private int currentUri;
    private Vector2 parentKeywords;

    private Scores()
    {
      this.Points = ReferenceInvoker.DisconnectProject(2805);
      this.parentKeywords = new StringBuilder(EditorService.DisconnectProject(3271), EditorService.DisconnectProject(3271).Length + ReferenceInvoker.DisconnectProject(2809).ToString().Length);
      this.parentKeywords = new Vector2(ReferenceInvoker.DisconnectProject(2813), ReferenceInvoker.DisconnectProject(2817));
      this.increaseScoresHandler = new TimeElapsedHandler(ReferenceInvoker.DisconnectProject(2821));
      this.decreaseScoresHandler = new TimeElapsedHandler(ReferenceInvoker.DisconnectProject(2829));
      this.LoadContent();
    }

    public static Scores Init()
    {
      if (Scores.Instance == null)
        return new Scores();
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Scores.Init);
          }
          return Scores.Instance;
      }
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public void LoadContent()
    {
      if (Scores.Instance != null)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Scores.LoadContent);
            break;
        }
      }
      else
        Scores.Instance = this;
    }

    public void IncreaseScore(int increaseBy)
    {
      if (!PlayerBase.Instance.IsAlive)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Scores.IncreaseScore);
            break;
        }
      }
      else
      {
        int num = this.Points + increaseBy;
        if (num > ReferenceInvoker.DisconnectProject(2681))
        {
label_5:
          switch (1)
          {
            case 0:
              goto label_5;
            default:
              num = ReferenceInvoker.DisconnectProject(2685);
              break;
          }
        }
        this.Points = num;
      }
    }

    public void Update(double elapsedGameTimeMs)
    {
      this.parentKeywords.Remove(EditorService.DisconnectProject(3271).Length, this.parentKeywords.Length - EditorService.DisconnectProject(3271).Length);
      this.parentKeywords.Concat(this.Points);
    }

    public void Draw()
    {
      GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, new Vector2(this.parentKeywords.X - ReferenceInvoker.DisconnectProject(2689), this.parentKeywords.Y - ReferenceInvoker.DisconnectProject(2693)), Color.White, ReferenceInvoker.DisconnectProject(2697), Vector2.Zero, ReferenceInvoker.DisconnectProject(2701), (SpriteEffects) ReferenceInvoker.DisconnectProject(2705), ReferenceInvoker.DisconnectProject(2709));
      GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, new Vector2(this.parentKeywords.X - ReferenceInvoker.DisconnectProject(2713), this.parentKeywords.Y + ReferenceInvoker.DisconnectProject(2717)), Color.White, ReferenceInvoker.DisconnectProject(2721), Vector2.Zero, ReferenceInvoker.DisconnectProject(2725), (SpriteEffects) ReferenceInvoker.DisconnectProject(2729), ReferenceInvoker.DisconnectProject(2733));
      GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, new Vector2(this.parentKeywords.X + ReferenceInvoker.DisconnectProject(2737), this.parentKeywords.Y + ReferenceInvoker.DisconnectProject(2741)), Color.White, ReferenceInvoker.DisconnectProject(2745), Vector2.Zero, ReferenceInvoker.DisconnectProject(2749), (SpriteEffects) ReferenceInvoker.DisconnectProject(2753), ReferenceInvoker.DisconnectProject(2757));
      GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, new Vector2(this.parentKeywords.X + ReferenceInvoker.DisconnectProject(2761), this.parentKeywords.Y - ReferenceInvoker.DisconnectProject(2765)), Color.White, ReferenceInvoker.DisconnectProject(2769), Vector2.Zero, ReferenceInvoker.DisconnectProject(2773), (SpriteEffects) ReferenceInvoker.DisconnectProject(2777), ReferenceInvoker.DisconnectProject(2781));
      GameBase.Instance.SpriteBatch.DrawString(ScreenManager.Instance.MenuFont, this.parentKeywords, this.parentKeywords, Color.Black, ReferenceInvoker.DisconnectProject(2785), Vector2.Zero, ReferenceInvoker.DisconnectProject(2789), (SpriteEffects) ReferenceInvoker.DisconnectProject(2793), ReferenceInvoker.DisconnectProject(2797));
    }

    public void Reset()
    {
      this.Points = ReferenceInvoker.DisconnectProject(2801);
      this.increaseScoresHandler.Reset();
      this.decreaseScoresHandler.Reset();
    }
  }
}
