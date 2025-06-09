// *************************************************************
// Type: GameFoundation.BackgroundScreen
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
  public class BackgroundScreen : GameScreen
  {
    [DataMember]
    public double DeserializeWorkaround;
    private Texture2D parentKeywords;
    private Texture2D currentUri;
    [DataMember]
    public bool useSimpleBackground;
    private bool parentKeywords;

    public BackgroundScreen()
      : this(ReferenceInvoker.DisconnectProject(3309) != 0)
    {
    }

    public BackgroundScreen(bool useSimpleBackground)
    {
      this.useSimpleBackground = useSimpleBackground;
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void LoadContent()
    {
      if (this.parentKeywords)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (BackgroundScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ReferenceInvoker.DisconnectProject(3285) != 0;
        this.TransitionOnTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(3289));
        this.TransitionOffTime = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(3297));
        this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(3999));
        this.currentUri = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(4054));
      }
    }

    public override void Update(
      GameTime gameTime,
      bool otherScreenHasFocus,
      bool coveredByOtherScreen)
    {
      base.Update(gameTime, otherScreenHasFocus, ReferenceInvoker.DisconnectProject(3305) != 0);
    }

    public override void Draw(GameTime gameTime)
    {
    }
  }
}
