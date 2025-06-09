// *************************************************************
// Type: GameFoundation.PackageOptions
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace GameFoundation
{
  internal sealed class PackageOptions
  {
    private EventHandler<EmulatorTable> parentKeywordsEmulatorTable;
    private EventHandler<BookmarkSite> parentKeywordsBookmarkSite;
    private EventHandler<MenuOptions> parentKeywordsMenuOptions;

    internal PackageOptions(Game _param1, string _param2)
    {
    }

    internal bool Enabled { get; set; }

    internal bool IsTest { get; set; }

    internal int RefreshInterval { get; set; }

    internal bool Visible { get; set; }

    //[SpecialName]
    internal void add_DisconnectProject(EventHandler<EmulatorTable> _param1)
    {
      EventHandler<EmulatorTable> eventHandler1 = this.parentKeywordsEmulatorTable;
      EventHandler<EmulatorTable> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler<EmulatorTable>>(
            ref this.parentKeywordsEmulatorTable, 
            OptionsAttribute.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, 
            (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
//label_2:
//      switch (6)
      {
//        case 0:
//          goto label_2;
//        default:
//          if (true)
//            break;
          // ISSUE: method reference
          //base.add_DisconnectProject();
 //         break;
      }
    }

    //[SpecialName]
    internal void remove_DisconnectProject(EventHandler<EmulatorTable> _param1)
    {
      EventHandler<EmulatorTable> eventHandler1 = this.parentKeywordsEmulatorTable;
      EventHandler<EmulatorTable> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler<EmulatorTable>>(
            ref this.parentKeywordsEmulatorTable, 
            OptionsAttribute.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2,
            (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

   // [SpecialName]
    internal void add_DisconnectProject(EventHandler<BookmarkSite> _param1)
    {
      EventHandler<BookmarkSite> eventHandler1 = this.parentKeywordsBookmarkSite;
      EventHandler<BookmarkSite> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler<BookmarkSite>>(
            ref this.parentKeywordsBookmarkSite, 
            MenuStream.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, 
            (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

    //[SpecialName]
    internal void remove_DisconnectProject(EventHandler<BookmarkSite> _param1)
    {
      EventHandler<BookmarkSite> eventHandler1 = this.parentKeywordsBookmarkSite;
      EventHandler<BookmarkSite> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler<BookmarkSite>>(
            ref this.parentKeywordsBookmarkSite, MenuStream.DisconnectProject(
                (object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param1)), 
            eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
//label_2:
//      switch (7)
      {
//        case 0:
//          goto label_2;
//        default:
//          if (true)
//            break;
           // this.remove_DisconnectProject();
 //         break;
      }
    }

    //[SpecialName]
    internal void add_DisconnectProject(EventHandler<MenuOptions> _param1)
    {
      EventHandler<MenuOptions> eventHandler1 = this.parentKeywordsMenuOptions;
      EventHandler<MenuOptions> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler<MenuOptions>>(
            ref this.parentKeywordsMenuOptions, 
            FunctionQueue.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2,
            (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
//label_2:
//      switch (2)
      {
//        case 0:
//          goto label_2;
//        default:
//          if (true)
//            break;
          // ISSUE: method reference
         // this.add_DisconnectProject();
//          break;
      }
    }

    //[SpecialName]
    internal void remove_DisconnectProject(EventHandler<MenuOptions> _param1)
    {
      EventHandler<MenuOptions> eventHandler1 = this.parentKeywordsMenuOptions;
      EventHandler<MenuOptions> eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler<MenuOptions>>(
            ref this.parentKeywordsMenuOptions, FunctionQueue.DisconnectProject(
                (object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
//label_2:
//      switch (6)
      {
//        case 0:
//          goto label_2;
//        default:
//          if (true)
//            break;
          //this.remove_DisconnectProject();
//          break;
      }
    }

    internal void DisconnectProject(SpriteBatch _param1, Vector2 _param2)
    {
    }

    internal void DisconnectProject(SpriteBatch _param1, Vector2 _param2, bool _param3)
    {
    }

    internal void DisconnectProject()
    {
    }

    internal void DisconnectProject(GameTime _param1)
    {
    }
  }
}
