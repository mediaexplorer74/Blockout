// *************************************************************
// Type: Blockout.Background
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class Background
  {
    private const bool parentKeywords = false;
    private const int parentKeywords = 15;
    public static Background Instance;
    public Rectangle recBackground;
    private double parentKeywords;
    [DataMember]
    public BackgroundObjects backgroundObjects;

    private Background()
    {
      this.backgroundObjects = new BackgroundObjects();
      this.DisconnectProject();
    }

    public static Background Init()
    {
      return Background.Instance != null ? Background.Instance : new Background();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.DisconnectProject();

    private void DisconnectProject()
    {
      if (Background.Instance != null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (Background.DisconnectProject);
            break;
        }
      }
      else
      {
        Background.Instance = this;
        this.recBackground.X = ScreenManager.BoundsScreen.X;
        this.recBackground.Y = ScreenManager.BoundsScreen.Y;
        this.recBackground.Width = ScreenManager.BoundsScreen.Width;
        this.recBackground.Height = ScreenManager.BoundsScreen.Height;
      }
    }

    public void Update(double elapsedGameTimeMs)
    {
      this.backgroundObjects.DisconnectProject(elapsedGameTimeMs);
    }

    public void Draw() => this.backgroundObjects.DisposeDrive();

    internal void DisposeDrive() => this.backgroundObjects.ListQueue();
  }
}
