// Decompiled with JetBrains decompiler
// Type: GameFoundation.Managed.ImageLooper
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace GameFoundation.Managed
{
  public class ImageLooper
  {
    private const int parentKeywords = 60;
    private Texture2D parentKeywords;
    public Rectangle RecPosition;
    public bool StopAfterOneAnimation;
    private Rectangle parentKeywords;
    private bool parentKeywords;
    private bool currentUri;
    private int currentUri;
    private bool filterID;
    private double parentKeywords;
    private bool parentCancel;
    private int filterID;
    private int parentCancel;
    public bool Animate;

    public ImageLooper(
      Texture2D imageToLoop,
      int numSubImages,
      bool rightToLeftSubimageAnimation,
      bool jumpFromEndToBeginningOfSubImages)
    {
      if (imageToLoop != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ImageLooper.\u002Ector);
            }
            if (numSubImages <= ReferenceInvoker.DisconnectProject(981))
            {
label_5:
              switch (3)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              this.parentKeywords = imageToLoop;
              this.parentKeywords = rightToLeftSubimageAnimation;
              this.currentUri = jumpFromEndToBeginningOfSubImages;
              this.parentCancel = numSubImages;
              this.currentUri = (int) ((double) imageToLoop.Width / (double) numSubImages);
              if (!rightToLeftSubimageAnimation)
              {
label_8:
                switch (7)
                {
                  case 0:
                    goto label_8;
                  default:
                    this.parentKeywords = new Rectangle(ReferenceInvoker.DisconnectProject(985), ReferenceInvoker.DisconnectProject(989), this.currentUri, imageToLoop.Height);
                    break;
                }
              }
              else
                this.parentKeywords = new Rectangle(imageToLoop.Width - this.currentUri, ReferenceInvoker.DisconnectProject(993), this.currentUri, imageToLoop.Height);
              this.RecPosition = new Rectangle(ReferenceInvoker.DisconnectProject(997), ReferenceInvoker.DisconnectProject(1001), this.parentKeywords.Width, this.parentKeywords.Height);
              return;
            }
            break;
        }
      }
      throw new ArgumentNullException(EditorService.DisconnectProject(531));
    }

    public void Start(Vector2 startPos, bool startToAnimate)
    {
      this.filterID = ReferenceInvoker.DisconnectProject(849) != 0;
      if (startToAnimate)
        this.Animate = ReferenceInvoker.DisconnectProject(853) != 0;
      this.RecPosition = new Rectangle((int) startPos.X, (int) startPos.Y, this.parentKeywords.Width, this.parentKeywords.Height);
      this.parentKeywords = ReferenceInvoker.DisconnectProject(857);
      if (this.parentKeywords)
      {
label_3:
        switch (4)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ImageLooper.Start);
            }
            this.parentCancel = ReferenceInvoker.DisconnectProject(865) != 0;
            this.filterID = ReferenceInvoker.DisconnectProject(869);
            break;
        }
      }
      else
      {
        this.parentCancel = ReferenceInvoker.DisconnectProject(873) != 0;
        this.filterID = this.parentCancel - ReferenceInvoker.DisconnectProject(877);
      }
      this.DisconnectProject();
    }

    public void RestartAnimation()
    {
      this.Animate = ReferenceInvoker.DisconnectProject(881) != 0;
      this.parentKeywords = ReferenceInvoker.DisconnectProject(885);
      if (this.parentKeywords)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ImageLooper.RestartAnimation);
            }
            this.parentCancel = ReferenceInvoker.DisconnectProject(893) != 0;
            this.filterID = ReferenceInvoker.DisconnectProject(897);
            break;
        }
      }
      else
      {
        this.parentCancel = ReferenceInvoker.DisconnectProject(901) != 0;
        this.filterID = this.parentCancel - ReferenceInvoker.DisconnectProject(905);
      }
      this.DisconnectProject();
    }

    public void Update(double elapsedGameTimeMs)
    {
      if (!this.Animate)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ImageLooper.Update);
            break;
        }
      }
      else
      {
        this.parentKeywords += elapsedGameTimeMs;
        if (this.parentKeywords < ReferenceInvoker.DisconnectProject(909))
        {
label_6:
          switch (1)
          {
            case 0:
              goto label_6;
          }
        }
        else
        {
          this.parentKeywords -= ReferenceInvoker.DisconnectProject(917);
          if (this.parentCancel)
          {
label_8:
            switch (3)
            {
              case 0:
                goto label_8;
              default:
                this.filterID -= ReferenceInvoker.DisconnectProject(925);
                if (this.filterID < ReferenceInvoker.DisconnectProject(929))
                {
label_10:
                  switch (6)
                  {
                    case 0:
                      goto label_10;
                    default:
                      if (this.StopAfterOneAnimation)
                      {
                        if (!this.currentUri)
                        {
label_13:
                          switch (4)
                          {
                            case 0:
                              goto label_13;
                          }
                        }
                        else
                        {
                          this.filterID = ReferenceInvoker.DisconnectProject(945);
                          this.Animate = ReferenceInvoker.DisconnectProject(949) != 0;
                          break;
                        }
                      }
                      if (this.currentUri)
                      {
label_15:
                        switch (3)
                        {
                          case 0:
                            goto label_15;
                          default:
                            this.filterID = this.parentCancel - ReferenceInvoker.DisconnectProject(933);
                            break;
                        }
                      }
                      else
                      {
                        this.filterID = ReferenceInvoker.DisconnectProject(937);
                        this.parentCancel = (this.parentCancel ? 1 : 0) == ReferenceInvoker.DisconnectProject(941);
                        break;
                      }
                      break;
                  }
                }
                else
                  break;
                break;
            }
          }
          else
          {
            this.filterID += ReferenceInvoker.DisconnectProject(953);
            if (this.filterID >= this.parentCancel)
            {
              if (this.StopAfterOneAnimation)
              {
label_21:
                switch (4)
                {
                  case 0:
                    goto label_21;
                  default:
                    if (!this.currentUri)
                    {
label_23:
                      switch (2)
                      {
                        case 0:
                          goto label_23;
                      }
                    }
                    else
                    {
                      this.filterID = this.parentCancel - ReferenceInvoker.DisconnectProject(969);
                      this.Animate = ReferenceInvoker.DisconnectProject(973) != 0;
                      goto label_29;
                    }
                    break;
                }
              }
              if (this.currentUri)
              {
label_25:
                switch (1)
                {
                  case 0:
                    goto label_25;
                  default:
                    this.filterID = ReferenceInvoker.DisconnectProject(957);
                    break;
                }
              }
              else
              {
                this.filterID = this.parentCancel - ReferenceInvoker.DisconnectProject(961);
                this.parentCancel = (this.parentCancel ? 1 : 0) == ReferenceInvoker.DisconnectProject(965);
              }
            }
          }
label_29:
          this.DisconnectProject();
        }
      }
    }

    private void DisconnectProject()
    {
      this.parentKeywords = new Rectangle(this.currentUri * this.filterID, ReferenceInvoker.DisconnectProject(977), this.currentUri, this.parentKeywords.Height);
    }

    public void Draw()
    {
      if (!this.filterID)
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ImageLooper.Draw);
            break;
        }
      }
      else
        GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, this.RecPosition, new Rectangle?(this.parentKeywords), Color.White);
    }

    public void Draw(Color visibilityColor)
    {
      if (!this.filterID)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ImageLooper.Draw);
            break;
        }
      }
      else
        GameBase.Instance.SpriteBatch.Draw(this.parentKeywords, this.RecPosition, new Rectangle?(this.parentKeywords), visibilityColor);
    }
  }
}
