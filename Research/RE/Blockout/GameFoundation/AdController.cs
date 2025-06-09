// Decompiled with JetBrains decompiler
// Type: GameFoundation.AdController
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#nullable disable
namespace GameFoundation
{
  public class AdController : IInfoTextElement
  {
    public const bool IsHidingAdds = false;
    private const bool parentKeywords = true;
    internal const int parentKeywords = 5;
    public const int AdHeight = 80;
    public const int YAd = 0;
    public const bool DrawBackgroundBehindAd = true;
    public const bool DrawLogoBehindAd = true;
    private const int currentUri = 5000;
    private const int filterID = 300;
    private const int parentCancel = 7;
    protected const string backgroundTextureName = "Graphic\\name";
    public static AdController Instance;
    private int namesID;
    private ConfigStream[] parentKeywords;
    private bool currentUri;
    private EventHandler<EventArgs> parentKeywords;
    private EventHandler<EventArgs> currentUri;
    private int currentNode;
    private double parentKeywords;
    private bool filterID;
    private double currentUri;
    private bool parentCancel;
    private double filterID;
    private int idToken;
    public Texture2D texBackground;
    public Rectangle posBackground;
    private TimerEventless parentKeywords;
    private TimeSpan parentKeywords;
    private bool namesID;
    private VectorService parentKeywords;
    private StringBuilder parentKeywords;
    private StringBuilder currentUri;
    private StringBuilder filterID;
    private StringBuilder parentCancel;
    private StringBuilder namesID;
    private StringBuilder currentNode;
    private StringBuilder idToken;
    private KeyValuePair<StringBuilder, Color>[] parentKeywords;

    private AdController()
    {
      EventHandler eventHandler1 = FormEventArgs.parentKeywords;
      this.parentKeywords = TimeSpan.FromSeconds(ReferenceInvoker.DisconnectProject(5285));
      this.parentKeywords = new StringBuilder(EditorService.DisconnectProject(5279));
      this.currentUri = new StringBuilder(EditorService.DisconnectProject(5316));
      this.filterID = new StringBuilder(EditorService.DisconnectProject(5351));
      this.parentCancel = new StringBuilder(EditorService.DisconnectProject(5396));
      this.namesID = new StringBuilder(EditorService.DisconnectProject(5439));
      this.currentNode = new StringBuilder(EditorService.DisconnectProject(5460));
      this.idToken = new StringBuilder(EditorService.DisconnectProject(5499));
      this.parentKeywords = OutlineInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(5293));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      AdController.Instance = this;
      this.DisconnectProject();
      this.parentKeywords = new TimerEventless(this.parentKeywords, new Action(this.DisposeDrive));
      this.parentKeywords = FormType.DisconnectProject();
      this.parentKeywords.LoadDirectory();
      QueueManager.DisconnectProject();
      QueueManager.set_DisconnectProject(ReferenceInvoker.DisconnectProject(5297) != 0);
      if (MenuScreen.IsLandscapeMenu)
      {
        this.parentKeywords.SelectResource(ReferenceInvoker.DisconnectProject(5301) != 0);
        QueueManager.set_DisposeDrive(ReferenceInvoker.DisconnectProject(5305) != 0);
      }
      TouchPanel.EnabledGestures = (GestureType) ReferenceInvoker.DisconnectProject(5309);
      VectorService parentKeywords = this.parentKeywords;
      if (eventHandler1 == null)
        eventHandler1 = (EventHandler) ((_param1, _param2) => this.ExtractDockingPane());
      EventHandler eventHandler2 = eventHandler1;
      parentKeywords.add_DisconnectProject(eventHandler2);
      this.parentKeywords.add_DisconnectProject(new EventHandler(this.ListQueue));
      this.parentKeywords.add_DisposeDrive(new EventHandler(this.DisposeDrive));
      this.parentKeywords.add_ListQueue(new EventHandler(this.EnableNetwork));
      this.parentKeywords.add_EnableNetwork(new EventHandler(this.DisconnectProject));
      this.ListQueue();
      FormType.DisconnectProject(this.parentKeywords);
      this.LoadContent();
    }

    public event EventHandler<EventArgs> AdEngagedChangedEvent
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
        switch (2)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.add_AdEngagedChangedEvent);
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

    public event EventHandler<EventArgs> AdClickedEvent
    {
      add
      {
        EventHandler<EventArgs> eventHandler1 = this.currentUri;
        EventHandler<EventArgs> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.currentUri, DomainDictionary.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (2)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.add_AdClickedEvent);
            break;
        }
      }
      remove
      {
        EventHandler<EventArgs> eventHandler1 = this.currentUri;
        EventHandler<EventArgs> eventHandler2;
        do
        {
          eventHandler2 = eventHandler1;
          eventHandler1 = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.currentUri, DomainDictionary.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) value)), eventHandler2);
        }
        while (eventHandler1 != eventHandler2);
label_2:
        switch (1)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.remove_AdClickedEvent);
            break;
        }
      }
    }

    public static AdController Init() => new AdController();

    public bool InputConsumed => this.parentKeywords.TestConnection();

    public bool Engaged => this.parentKeywords.ExtractDockingPane();

    internal void DisconnectProject()
    {
      this.currentNode = (int) TimeSpan.FromSeconds((double) MsAdOnline.DisposeDrive()).TotalMilliseconds;
    }

    private void DisconnectProject(object _param1, EventArgs _param2) => this.DisconnectProject();

    private void DisposeDrive(object _param1, EventArgs _param2)
    {
      this.currentUri = ReferenceInvoker.DisconnectProject(5025) != 0;
      this.parentKeywords = ReferenceInvoker.DisconnectProject(5029);
      this.idToken += ReferenceInvoker.DisconnectProject(5037);
      this.AdErrorEventOccured();
    }

    private void DisposeDrive()
    {
      double num = this.parentKeywords.TotalMilliseconds / (double) this.currentNode;
      if (this.idToken < ReferenceInvoker.DisconnectProject(5041))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.DisposeDrive);
            break;
        }
      }
      else
      {
        this.idToken = Math.Min(this.idToken - ReferenceInvoker.DisconnectProject(5045), ReferenceInvoker.DisconnectProject(5049));
        this.parentKeywords.SelectResource(ReferenceInvoker.DisconnectProject(5053) != 0);
        this.parentKeywords = ReferenceInvoker.DisconnectProject(5057);
        this.currentUri = ReferenceInvoker.DisconnectProject(5065) != 0;
        this.namesID = ReferenceInvoker.DisconnectProject(5069) != 0;
      }
    }

    private void ListQueue(object _param1, EventArgs _param2) => this.AdClickedOccured();

    public void AdRefreshEventOccured()
    {
      this.currentUri = ReferenceInvoker.DisconnectProject(5073);
      this.filterID = ReferenceInvoker.DisconnectProject(5081) != 0;
      this.idToken = ReferenceInvoker.DisconnectProject(5085);
      GameData.Instance.AdsReceivedCounter += ReferenceInvoker.DisconnectProject(5089);
    }

    public void AdErrorEventOccured()
    {
      GameData.Instance.AdsRequestErrorCounter += ReferenceInvoker.DisconnectProject(5093);
    }

    public void AdRequestedEventOccured()
    {
      GameData.Instance.AdsRequestSentCounter += ReferenceInvoker.DisconnectProject(5097);
    }

    public void AdClickedOccured()
    {
      if (this.currentUri == null)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.AdClickedOccured);
          }
          this.currentUri((object) this, (EventArgs) null);
          break;
      }
    }

    public void AdEngagedChangedOccured()
    {
      if (this.parentKeywords == null)
        return;
      this.parentKeywords((object) this, (EventArgs) null);
    }

    private void ListQueue()
    {
    }

    private void EnableNetwork()
    {
    }

    private void TestConnection()
    {
    }

    private void ExtractDockingPane()
    {
      if (this.parentKeywords.ExtractDockingPane())
        return;
      while (TouchPanel.IsGestureAvailable)
        TouchPanel.ReadGesture();
label_4:
      switch (7)
      {
        case 0:
          goto label_4;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.ExtractDockingPane);
          break;
      }
    }

    public static int GetAdWidth() => GameBase.ScreenWidth;

    public static bool IsBigAd()
    {
      return AdController.GetAdWidth() > ReferenceInvoker.DisconnectProject(5101);
    }

    public void LoadContent()
    {
      this.parentKeywords = MsAdOnline.DisconnectProject(ReferenceInvoker.DisconnectProject(5105) != 0, ReferenceInvoker.DisconnectProject(5109) != 0);
      this.namesID = ReferenceInvoker.DisconnectProject(5113);
      this.parentKeywords.CopyProject(this.namesID, this.parentKeywords[this.namesID]);
      this.parentKeywords = (double) this.currentNode;
      this.texBackground = GameBase.Instance.Content.Load<Texture2D>(EditorService.DisconnectProject(5254));
      this.posBackground.X = ReferenceInvoker.DisconnectProject(5117);
      this.posBackground.Y = ReferenceInvoker.DisconnectProject(5121);
      this.posBackground.Width = this.texBackground.Width;
      this.posBackground.Height = this.texBackground.Height;
      this.EnableNetwork();
    }

    private void DisconnectProject(bool _param1)
    {
      bool flag = ReferenceInvoker.DisconnectProject(5125) != 0;
      if (_param1)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.DisconnectProject);
            }
            int index = this.namesID + ReferenceInvoker.DisconnectProject(5129);
            if (index >= (int) OptionsSet.DisconnectProject(this.parentKeywords))
              index = ReferenceInvoker.DisconnectProject(5133);
            if (!this.parentKeywords.LoadDeployment(index))
            {
label_7:
              switch (6)
              {
                case 0:
                  goto label_7;
                default:
                  this.parentKeywords.CopyProject(index, this.parentKeywords[index]);
                  flag = ReferenceInvoker.DisconnectProject(5137) != 0;
                  break;
              }
            }
            this.namesID = index;
            break;
        }
      }
      if (!flag)
        return;
      this.LoadDirectory();
    }

    private void EnableNetwork(object _param1, EventArgs _param2) => this.AdRefreshEventOccured();

    private void LoadDirectory()
    {
      this.parentKeywords = (double) this.currentNode;
      if (this.parentKeywords.ExtractDockingPane())
        return;
      if (this.parentKeywords.LoadDeployment(this.namesID))
      {
label_2:
        switch (3)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.LoadDirectory);
            }
            if (this.parentKeywords[this.namesID] != null && PcitureService.DisconnectProject(this.parentKeywords[this.namesID].parentKeywords, this.parentKeywords.SaveAssistant(this.namesID)))
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
              this.parentKeywords.DisconnectWindow(this.namesID);
              goto label_9;
            }
            break;
        }
      }
      this.parentKeywords.CopyProject(this.namesID, this.parentKeywords[this.namesID]);
label_9:
      this.filterID = ReferenceInvoker.DisconnectProject(5141);
      this.parentCancel = ReferenceInvoker.DisconnectProject(5149) != 0;
      this.AdRequestedEventOccured();
    }

    private bool DisconnectProject() => ReferenceInvoker.DisconnectProject(5153) != 0;

    private bool DisposeDrive() => this.DisconnectProject();

    public void Update(GameTime gameTime)
    {
      Math.Min(gameTime.ElapsedGameTime.TotalMilliseconds, ReferenceInvoker.DisconnectProject(5157));
      this.parentKeywords.Update(gameTime.ElapsedGameTime.TotalMilliseconds, ReferenceInvoker.DisconnectProject(5165) != 0);
      if (!this.namesID)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.Update);
            }
            this.parentKeywords.SelectResource(ReferenceInvoker.DisconnectProject(5169) != 0);
            break;
        }
      }
      if (this.idToken >= ReferenceInvoker.DisconnectProject(5173))
      {
label_6:
        switch (3)
        {
          case 0:
            goto label_6;
          default:
            if (!this.parentKeywords.ExtractDockingPane())
            {
              if (!this.namesID)
              {
label_9:
                switch (6)
                {
                  case 0:
                    goto label_9;
                  default:
                    if (this.DisposeDrive())
                    {
label_11:
                      switch (6)
                      {
                        case 0:
                          goto label_11;
                        default:
                          return;
                      }
                    }
                    else
                    {
                      this.parentKeywords.StartOrContinue();
                      this.namesID = ReferenceInvoker.DisconnectProject(5177) != 0;
                      break;
                    }
                }
              }
              if (this.parentKeywords.EnableDockingPane())
              {
                this.parentKeywords.SelectResource(ReferenceInvoker.DisconnectProject(5181) != 0);
                if (!QueueManager.get_DisconnectProject())
                {
label_16:
                  switch (4)
                  {
                    case 0:
                      goto label_16;
                    default:
                      QueueManager.set_DisconnectProject(ReferenceInvoker.DisconnectProject(5185) != 0);
                      break;
                  }
                }
              }
              QueueManager.DisconnectProject(gameTime);
              return;
            }
            break;
        }
      }
      this.parentKeywords -= gameTime.ElapsedGameTime.TotalMilliseconds;
      if (this.parentKeywords <= ReferenceInvoker.DisconnectProject(5189))
      {
label_20:
        switch (6)
        {
          case 0:
            goto label_20;
          default:
            if (this.DisposeDrive())
              return;
            if (this.currentUri)
            {
label_24:
              switch (6)
              {
                case 0:
                  goto label_24;
                default:
                  this.currentUri = ReferenceInvoker.DisconnectProject(5197) != 0;
                  this.parentKeywords = (double) this.currentNode;
                  this.DisconnectProject(ReferenceInvoker.DisconnectProject(5201) != 0);
                  break;
              }
            }
            else
            {
              if (!ScreenManager.Instance.DisconnectProject() || GameplayScreenBase.Instance.IsPaused)
              {
                this.parentKeywords = (double) this.currentNode;
                this.DisconnectProject(ReferenceInvoker.DisconnectProject(5205) != 0);
                break;
              }
              break;
            }
            break;
        }
      }
      if (this.filterID)
      {
label_29:
        switch (6)
        {
          case 0:
            goto label_29;
          default:
            this.currentUri += gameTime.ElapsedGameTime.TotalMilliseconds;
            if (this.currentUri >= ReferenceInvoker.DisconnectProject(5209))
            {
              this.filterID = ReferenceInvoker.DisconnectProject(5217) != 0;
              break;
            }
            break;
        }
      }
      if (!this.parentCancel)
        return;
      this.filterID += gameTime.ElapsedGameTime.TotalMilliseconds;
      if (this.filterID < ReferenceInvoker.DisconnectProject(5221))
        return;
label_34:
      switch (4)
      {
        case 0:
          goto label_34;
        default:
          this.parentCancel = ReferenceInvoker.DisconnectProject(5229) != 0;
          break;
      }
    }

    public KeyValuePair<StringBuilder, Color>[] GetTextToDraw()
    {
      if (this.Engaged)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.GetTextToDraw);
            }
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5233)] = new KeyValuePair<StringBuilder, Color>(this.parentKeywords, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5237)] = new KeyValuePair<StringBuilder, Color>(this.currentUri, Color.White);
      if (this.InputConsumed)
      {
label_7:
        switch (3)
        {
          case 0:
            goto label_7;
          default:
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5241)] = new KeyValuePair<StringBuilder, Color>(this.filterID, Color.Red);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5245)] = new KeyValuePair<StringBuilder, Color>(this.parentCancel, Color.White);
      if (this.filterID)
      {
label_11:
        switch (7)
        {
          case 0:
            goto label_11;
          default:
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5249)] = new KeyValuePair<StringBuilder, Color>(this.namesID, Color.Green);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5253)] = new KeyValuePair<StringBuilder, Color>(this.namesID, Color.White);
      if (this.parentCancel)
      {
label_15:
        switch (5)
        {
          case 0:
            goto label_15;
          default:
            this.parentKeywords[ReferenceInvoker.DisconnectProject(5257)] = new KeyValuePair<StringBuilder, Color>(this.idToken, Color.Green);
            break;
        }
      }
      else
        this.parentKeywords[ReferenceInvoker.DisconnectProject(5261)] = new KeyValuePair<StringBuilder, Color>(this.idToken, Color.White);
      return this.parentKeywords;
    }

    public void Draw()
    {
      if (!this.parentKeywords.EnableDockingPane())
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.Draw);
            }
            if (QueueManager.get_DisposeDrive())
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
              }
            }
            else
              goto label_7;
            break;
        }
      }
      GameBase.Instance.SpriteBatch.Draw(this.texBackground, this.posBackground, Color.White);
label_7:
      if (this.idToken < ReferenceInvoker.DisconnectProject(5265))
        return;
      GameBase.Instance.SpriteBatch.End();
      QueueManager.DisposeDrive();
      GameBase.Instance.SpriteBatch.Begin();
    }

    public void HideAd(bool hideAd)
    {
      if (!hideAd)
        return;
label_1:
      switch (7)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (AdController.HideAd);
          }
          this.parentKeywords.SelectResource(ReferenceInvoker.DisconnectProject(5269) != 0);
          QueueManager.set_DisposeDrive(ReferenceInvoker.DisconnectProject(5273) != 0);
          break;
      }
    }

    internal void SelectResource()
    {
      this.parentKeywords = MsAdOnline.DisconnectProject(ReferenceInvoker.DisconnectProject(5277) != 0, ReferenceInvoker.DisconnectProject(5281) != 0);
    }
  }
}
