// *************************************************************
// Type: GameFoundation.QueueManager
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace GameFoundation
{
  internal static class QueueManager
  {
    private const int parentKeywords = 20;
    private static EventHandler<BookmarkSite> parentKeywordsBookmarkSite;
    private static EventHandler<MenuOptions> parentKeywordsMenuOptions;
    private static EventHandler<EventArgs> parentKeywordsEventArgs;
    private static string parentKeywordsString = EditorService.DisconnectProject(5596);
    private static PackageOptions parentKeywordsPackageOptions;
    private static Vector2 parentKeywordsVector2 = new Vector2(ReferenceInvoker.DisconnectProject(5325), ReferenceInvoker.DisconnectProject(5329));
    private static bool parentKeywordsBool = ReferenceInvoker.DisconnectProject(5333) != 0;

    //[SpecialName]
    public static bool get_DisconnectProject() => QueueManager.parentKeywords.Enabled;

    //[SpecialName]
    public static void set_DisconnectProject(bool _param0)
    {
      QueueManager.parentKeywords.Enabled = _param0;
    }

    //[SpecialName]
    public static bool get_DisposeDrive() => QueueManager.parentKeywords.Visible;

    //[SpecialName]
    public static void set_DisposeDrive(bool _param0)
    {
      QueueManager.parentKeywords.Visible = _param0;
    }

    //[SpecialName]
    public static void add_DisconnectProject(EventHandler<BookmarkSite> _param0)
    {
      EventHandler<BookmarkSite> eventHandler1 = QueueManager.parentKeywords;
      EventHandler<BookmarkSite> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        EventHandler<BookmarkSite> eventHandler3 = MenuStream.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param0));
        eventHandler1 = Interlocked.CompareExchange<EventHandler<BookmarkSite>>(ref QueueManager.parentKeywords, eventHandler3, eventHandler2);
      }
      while (eventHandler1 != eventHandler2);

      {
          // ISSUE: method reference
          //this.add_DisconnectProject();
      }
    }

   // [SpecialName]
    public static void remove_DisconnectProject(EventHandler<BookmarkSite> _param0)
    {
      EventHandler<BookmarkSite> eventHandler1 = QueueManager.parentKeywords;
      EventHandler<BookmarkSite> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        EventHandler<BookmarkSite> eventHandler3 = MenuStream.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param0));
        eventHandler1 = Interlocked.CompareExchange<EventHandler<BookmarkSite>>(ref QueueManager.parentKeywords, eventHandler3, eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
      {
         //this.remove_DisconnectProject();
      }
    }

  //  [SpecialName]
    public static void add_DisconnectProject(EventHandler<MenuOptions> _param0)
    {
      EventHandler<MenuOptions> eventHandler1 = QueueManager.parentKeywordsMenuOptions;
      EventHandler<MenuOptions> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        EventHandler<MenuOptions> eventHandler3 = FunctionQueue.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param0));
        eventHandler1 = Interlocked.CompareExchange<EventHandler<MenuOptions>>(ref QueueManager.parentKeywords, eventHandler3, eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
label_2:
      switch (3)
      {
        case 0:
          goto label_2;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (QueueManager.add_DisconnectProject);
          break;
      }
    }

    [SpecialName]
    public static void remove_DisconnectProject(EventHandler<MenuOptions> _param0)
    {
      EventHandler<MenuOptions> eventHandler1 = QueueManager.parentKeywords;
      EventHandler<MenuOptions> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        EventHandler<MenuOptions> eventHandler3 = FunctionQueue.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param0));
        eventHandler1 = Interlocked.CompareExchange<EventHandler<MenuOptions>>(ref QueueManager.parentKeywords, eventHandler3, eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

    [SpecialName]
    public static void add_DisconnectProject(EventHandler<EventArgs> _param0)
    {
      EventHandler<EventArgs> eventHandler1 = QueueManager.parentKeywords;
      EventHandler<EventArgs> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        EventHandler<EventArgs> eventHandler3 = DomainDictionary.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param0));
        eventHandler1 = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref QueueManager.parentKeywords, eventHandler3, eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

    [SpecialName]
    public static void remove_DisconnectProject(EventHandler<EventArgs> _param0)
    {
      EventHandler<EventArgs> eventHandler1 = QueueManager.parentKeywords;
      EventHandler<EventArgs> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        EventHandler<EventArgs> eventHandler3 = DomainDictionary.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param0));
        eventHandler1 = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref QueueManager.parentKeywords, eventHandler3, eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

    internal static void DisconnectProject()
    {
      if (QueueManager.parentKeywords)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (QueueManager.DisconnectProject);
            }
            throw new Exception(EditorService.DisconnectProject(5524));
        }
      }
      else if (GameBase.Instance == null)
      {
label_6:
        switch (4)
        {
          case 0:
            goto label_6;
          default:
            throw new Exception(EditorService.DisconnectProject(5555));
        }
      }
      else
      {
        QueueManager.parentKeywords = new PackageOptions((Game) GameBase.Instance, QueueManager.parentKeywords);
        QueueManager.parentKeywords.DisconnectProject();
        QueueManager.parentKeywords.IsTest = ReferenceInvoker.DisconnectProject(5313) != 0;
        QueueManager.parentKeywords.add_DisconnectProject(new EventHandler<BookmarkSite>(QueueManager.DisconnectProject));
        QueueManager.parentKeywords.add_DisconnectProject(new EventHandler<MenuOptions>(QueueManager.DisconnectProject));
        QueueManager.parentKeywords.RefreshInterval = ReferenceInvoker.DisconnectProject(5317);
        QueueManager.parentKeywords = ReferenceInvoker.DisconnectProject(5321) != 0;
      }
    }

    private static void DisconnectProject(object _param0, EventArgs _param1)
    {
      if (QueueManager.parentKeywords == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (QueueManager.DisconnectProject);
          }
          QueueManager.parentKeywords(_param0, _param1);
          break;
      }
    }

    private static void DisconnectProject(object _param0, MenuOptions _param1)
    {
      if (QueueManager.parentKeywords == null)
        return;
      QueueManager.parentKeywords(_param0, _param1);
    }

    private static void DisconnectProject(object _param0, BookmarkSite _param1)
    {
      if (QueueManager.parentKeywords == null)
        return;
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (QueueManager.DisconnectProject);
          }
          QueueManager.parentKeywords(_param0, _param1);
          break;
      }
    }

    public static void DisconnectProject(GameTime _param0)
    {
      QueueManager.parentKeywords.DisconnectProject(_param0);
    }

    public static void DisposeDrive()
    {
      QueueManager.parentKeywords.DisconnectProject(GameBase.Instance.SpriteBatch, QueueManager.parentKeywords);
    }
  }
}
