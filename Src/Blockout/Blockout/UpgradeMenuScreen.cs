// *************************************************************
// Type: Blockout.UpgradeMenuScreen
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

#nullable disable
namespace Blockout
{
  [DataContract]
  public class UpgradeMenuScreen : MenuScreen
  {
    private const int parentKeywords = 2;
    private const int currentUri = 20;
    public const int MaxPowerupLevels = 5;
    private const int filterID = 6;
    [DataMember]
    public double DeserializeWorkaround;
    private Texture2D parentKeywords;
    private Texture2D currentUri;
    private Rectangle parentKeywords;
    private Rectangle currentUri;
    private List<Texture2D> parentKeywords;
    private Rectangle filterID;
    private Rectangle parentCancel;
    private Rectangle[] parentKeywords;
    private Rectangle[] currentUri;
    private Rectangle[][] parentKeywords;
    private Rectangle namesID;
    private Rectangle currentNode;
    private StringBuilder parentKeywords = new StringBuilder(DatabaseLoader.DisconnectProject(12769));
    private Vector2 parentKeywords;
    private bool parentKeywords;

    public UpgradeMenuScreen()
      : base(DatabaseLoader.DisconnectProject(12822), ClientTree.DisconnectProject(1984449) != 0)
    {
      this.LoadContent();
    }

    [OnDeserialized]
    public void SetValuesOnDeserialized(StreamingContext context) => this.LoadContent();

    public override void LoadContent()
    {
      if (this.parentKeywords)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (UpgradeMenuScreen.LoadContent);
            break;
        }
      }
      else
      {
        this.parentKeywords = ClientTree.DisconnectProject(1984221) != 0;
        base.LoadContent();
        this.parentKeywords = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12308));
        this.namesID = new Rectangle(ClientTree.DisconnectProject(1984225), ClientTree.DisconnectProject(1984229), this.parentKeywords.Width / ClientTree.DisconnectProject(1984233), this.parentKeywords.Height);
        this.currentNode = new Rectangle(this.parentKeywords.Width / ClientTree.DisconnectProject(1984237), ClientTree.DisconnectProject(1984241), this.parentKeywords.Width / ClientTree.DisconnectProject(1984245), this.parentKeywords.Height);
        this.currentUri = GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12357));
        this.parentKeywords = new Rectangle(ClientTree.DisconnectProject(1984249), ClientTree.DisconnectProject(1984253), this.currentUri.Width / ClientTree.DisconnectProject(1984257), this.currentUri.Height);
        this.currentUri = new Rectangle(this.currentUri.Width / ClientTree.DisconnectProject(1984261), ClientTree.DisconnectProject(1984265), this.currentUri.Width / ClientTree.DisconnectProject(1984269), this.currentUri.Height);
        this.parentKeywords = new List<Texture2D>();
        this.parentKeywords.Add(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12426)));
        this.parentKeywords.Add(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12481)));
        this.parentKeywords.Add(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12536)));
        this.parentKeywords.Add(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12591)));
        this.parentKeywords.Add(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12646)));
        this.parentKeywords.Add(GameBase.Instance.Content.Load<Texture2D>(DatabaseLoader.DisconnectProject(12701)));
        this.filterID = new Rectangle(ClientTree.DisconnectProject(1984273), ClientTree.DisconnectProject(1984277), this.parentKeywords[ClientTree.DisconnectProject(1984281)].Width / ClientTree.DisconnectProject(1984285), this.parentKeywords[ClientTree.DisconnectProject(1984289)].Height);
        this.parentCancel = new Rectangle(this.parentKeywords[ClientTree.DisconnectProject(1984293)].Width / ClientTree.DisconnectProject(1984297), ClientTree.DisconnectProject(1984301), this.parentKeywords[ClientTree.DisconnectProject(1984305)].Width / ClientTree.DisconnectProject(1984309), this.parentKeywords[ClientTree.DisconnectProject(1984313)].Height);
        this.parentKeywords = new Vector2(ClientTree.DisconnectProject(1984317), ClientTree.DisconnectProject(1984321));
        int num = ClientTree.DisconnectProject(1984325);
        int y = num;
        int x = ClientTree.DisconnectProject(1984329);
        this.parentKeywords = DatabaseType.DisconnectProject(ClientTree.DisconnectProject(1984333));
        this.parentKeywords = TreeNodeTree.DisconnectProject(ClientTree.DisconnectProject(1984337));
        this.currentUri = TreeNodeTree.DisconnectProject(ClientTree.DisconnectProject(1984341));
        for (int index1 = ClientTree.DisconnectProject(1984345); index1 < ClientTree.DisconnectProject(1984421); index1 += ClientTree.DisconnectProject(1984417))
        {
          this.parentKeywords[index1] = new Rectangle(x, y, this.filterID.Width, this.filterID.Height);
          this.parentKeywords[index1] = TreeNodeTree.DisconnectProject(ClientTree.DisconnectProject(1984349));
          for (int index2 = ClientTree.DisconnectProject(1984353); index2 < ClientTree.DisconnectProject(1984377); index2 += ClientTree.DisconnectProject(1984373))
            this.parentKeywords[index1][index2] = new Rectangle(x + this.filterID.Width + ClientTree.DisconnectProject(1984357) + index2 * (ClientTree.DisconnectProject(1984361) + this.parentKeywords.Width / ClientTree.DisconnectProject(1984365)), y, this.parentKeywords.Width / ClientTree.DisconnectProject(1984369), this.parentKeywords.Height);
label_8:
          switch (2)
          {
            case 0:
              goto label_8;
            default:
              this.currentUri[index1] = new Rectangle(x + this.filterID.Width + ClientTree.DisconnectProject(1984381) + ClientTree.DisconnectProject(1984385) * (ClientTree.DisconnectProject(1984389) + this.parentKeywords.Width / ClientTree.DisconnectProject(1984393)), y, this.currentUri.Width / ClientTree.DisconnectProject(1984397), this.currentUri.Height);
              y += ClientTree.DisconnectProject(1984401) + this.filterID.Height;
              if (index1 == ClientTree.DisconnectProject(1984405))
              {
                x = ClientTree.DisconnectProject(1984409);
                y = num + ClientTree.DisconnectProject(1984413);
                continue;
              }
              continue;
          }
        }
label_13:
        switch (5)
        {
          case 0:
            goto label_13;
          default:
            MenuEntryButton menuEntryButton = new MenuEntryButton(DatabaseLoader.DisconnectProject(12756));
            menuEntryButton.Scale = ClientTree.DisconnectProject(1984425);
            menuEntryButton.IsManualPosition = ClientTree.DisconnectProject(1984429) != 0;
            menuEntryButton.Position = new Vector2(ClientTree.DisconnectProject(1984433), ClientTree.DisconnectProject(1984437));
            menuEntryButton.Selected += new EventHandler<RelativeClickEventArg>(this.DisconnectProject);
            this.MenuEntries.Add((MenuEntry) menuEntryButton);
            break;
        }
      }
    }

    public override void HandleInput(InputState input)
    {
    }

    private void DisconnectProject(object _param1, RelativeClickEventArg _param2)
    {
      LoadingScreen.SwitchBackFromTempScreen(ScreenManager.Instance, ClientTree.DisconnectProject(1984441) != 0, ClientTree.DisconnectProject(1984445));
    }

    private void DisconnectProject()
    {
    }

    public override void Draw(GameTime gameTime) => base.Draw(gameTime);
  }
}
