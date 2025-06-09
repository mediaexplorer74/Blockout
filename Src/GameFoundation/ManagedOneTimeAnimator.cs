// *************************************************************
// Type: GameFoundation.ManagedOneTimeAnimator
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace GameFoundation
{
  [DataContract]
  public class ManagedOneTimeAnimator
  {
    private Texture2D parentKeywords;
    private Rectangle parentKeywords;
    private Rectangle currentUri;
    private int parentKeywords;
    private int currentUri;
    private int filterID;
    [DataMember]
    public double elapsedOpenTime;

    public ManagedOneTimeAnimator(string textureName, int numColumns)
      : this(textureName, numColumns, ReferenceInvoker.DisconnectProject(1009))
    {
    }

    public ManagedOneTimeAnimator(string textureName, int numColumns, int numRows)
      : this(GameBase.Instance.Content.Load<Texture2D>(textureName), numColumns, numRows, ReferenceInvoker.DisconnectProject(1013))
    {
    }

    public ManagedOneTimeAnimator(Texture2D texture2D, int numColumns)
      : this(texture2D, numColumns, ReferenceInvoker.DisconnectProject(1017), ReferenceInvoker.DisconnectProject(1021))
    {
    }

    public ManagedOneTimeAnimator(Texture2D texture2D, int numColumns, int numRows)
      : this(texture2D, numColumns, numRows, ReferenceInvoker.DisconnectProject(1025))
    {
    }

    public ManagedOneTimeAnimator(
      Texture2D texture2D,
      int numColumns,
      int numRows,
      int numStayOnImage)
    {
      this.parentKeywords = texture2D;
      this.parentKeywords = numStayOnImage;
      this.elapsedOpenTime = ReferenceInvoker.DisconnectProject(1029);
      this.currentUri = (int) ((double) this.parentKeywords.Width / (double) numColumns);
      this.filterID = (int) ((double) this.parentKeywords.Height / (double) numRows);
      this.parentKeywords.Width = this.currentUri;
      this.parentKeywords.Height = this.filterID;
      this.currentUri.X = ReferenceInvoker.DisconnectProject(1037);
      this.currentUri.Y = ReferenceInvoker.DisconnectProject(1041);
      this.currentUri.Width = this.currentUri;
      this.currentUri.Height = this.filterID;
    }

    public void Start(int startX, int startY, bool centerPosition)
    {
      if (!centerPosition)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ManagedOneTimeAnimator.Start);
            }
            this.parentKeywords.X = startX;
            this.parentKeywords.Y = startY;
            break;
        }
      }
      else
      {
        this.parentKeywords.X = startX - this.parentKeywords.Center.X;
        this.parentKeywords.Y = startY - this.parentKeywords.Center.Y;
      }
      GameplayScreenBase.Instance.OneTimeElementsToDraw.Add(this);
    }

    public void Update(double elapsedGameTimeMs)
    {
      this.elapsedOpenTime += elapsedGameTimeMs;
      if (this.elapsedOpenTime < GameBase.Instance.TargetElapsedTime.TotalMilliseconds)
        return;
label_1:
      switch (3)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ManagedOneTimeAnimator.Update);
          }
          this.elapsedOpenTime -= GameBase.Instance.TargetElapsedTime.TotalMilliseconds;
          this.currentUri.X += this.currentUri;
          if (this.currentUri.X < this.parentKeywords.Width)
            break;
label_5:
          switch (5)
          {
            case 0:
              goto label_5;
            default:
              this.currentUri.X = ReferenceInvoker.DisconnectProject(1005);
              if (this.currentUri.Y >= this.parentKeywords.Height)
              {
label_7:
                switch (6)
                {
                  case 0:
                    goto label_7;
                  default:
                    GameplayScreenBase.Instance.OneTimeElementsToDraw.Remove(this);
                    return;
                }
              }
              else
              {
                this.currentUri.Y += this.filterID;
                return;
              }
          }
      }
    }

    public void Draw()
    {
      if (this.parentKeywords == null)
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ManagedOneTimeAnimator.Draw);
            break;
        }
      }
      else
        GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, this.parentKeywords, new Rectangle?(this.currentUri), Color.White);
    }
  }
}
