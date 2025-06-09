// *************************************************************
// Type: BlockoutRt.Common.LayoutAwarePage
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Blockout;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

#nullable disable
/*namespace BlockoutRt.Common
{
  [WebHostHidden]
  public class LayoutAwarePage : Page
  {
    public static readonly DependencyProperty DefaultViewModelProperty = DependencyProperty.Register(DatabaseLoader.DisconnectProject(12844), Type.GetTypeFromHandle(WindowTable.DisconnectProject()), Type.GetTypeFromHandle(AddinInfo.DisconnectProject()), PcitureSite.parentKeywords);
    private List<Control> parentKeywords;
    private string parentKeywordsS;
        // Fix for CS0030: Cannot convert type 'BlockoutRt.Common.LayoutAwarePage.ActivityService<string, object>' to 'Windows.Foundation.Collections.IObservableMap<string, object>'
        // The issue arises because `ActivityService<string, object>` does not implement `IObservableMap<string, object>`.
        // To resolve this, we need to ensure that `ActivityService<string, object>` implements `IObservableMap<string, object>`.

        private sealed class ActivityService<K, V> : IObservableMap<K, V>
        {
            private readonly Dictionary<K, V> _dictionary = new Dictionary<K, V>();
            private readonly EventRegistrationTokenTable<MapChangedEventHandler<K, V>> _eventTable = new EventRegistrationTokenTable<MapChangedEventHandler<K, V>>();

            public event MapChangedEventHandler<K, V> MapChanged
            {
                add => _eventTable.AddEventHandler(value);
                remove => _eventTable.RemoveEventHandler(value);
            }

            public V this[K key]
            {
                get => _dictionary[key];
                set
                {
                    _dictionary[key] = value;
                    _eventTable.InvocationList?.Invoke(this, new MapChangedEventArgs<K>(CollectionChange.ItemChanged, key));
                }
            }

            public ICollection<K> Keys => _dictionary.Keys;
            public ICollection<V> Values => _dictionary.Values;
            public int Count => _dictionary.Count;
            public bool IsReadOnly => false;

            public void Add(K key, V value)
            {
                _dictionary.Add(key, value);
                _eventTable.InvocationList?.Invoke(this, new MapChangedEventArgs<K>(CollectionChange.ItemInserted, key));
            }

            public void Add(KeyValuePair<K, V> item) => Add(item.Key, item.Value);

            public void Clear()
            {
                var keys = _dictionary.Keys.ToList();
                _dictionary.Clear();
                foreach (var key in keys)
                {
                    _eventTable.InvocationList?.Invoke(this, new MapChangedEventArgs<K>(CollectionChange.ItemRemoved, key));
                }
            }

            public bool Contains(KeyValuePair<K, V> item) => _dictionary.Contains(item);

            public bool ContainsKey(K key) => _dictionary.ContainsKey(key);

            public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
            {
                foreach (var kvp in _dictionary)
                {
                    array[arrayIndex++] = kvp;
                }
            }

            public IEnumerator<KeyValuePair<K, V>> GetEnumerator() => _dictionary.GetEnumerator();

            public bool Remove(K key)
            {
                if (_dictionary.Remove(key))
                {
                    _eventTable.InvocationList?.Invoke(this, new MapChangedEventArgs<K>(CollectionChange.ItemRemoved, key));
                    return true;
                }
                return false;
            }

            public bool Remove(KeyValuePair<K, V> item) => Remove(item.Key);

            public bool TryGetValue(K key, out V value) => _dictionary.TryGetValue(key, out value);

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private class MapChangedEventArgs<T> : IMapChangedEventArgs<T>
            {
                public MapChangedEventArgs(CollectionChange change, T key)
                {
                    CollectionChange = change;
                    Key = key;
                }

                public CollectionChange CollectionChange { get; }
                public T Key { get; }
            }
        }
        // Fix for the reported errors in the constructor call
        public LayoutAwarePage()
        {
            // Correcting the base constructor call
            base(); // This replaces the invalid `base.\u002Ector();`

            if (DesignMode.DesignModeEnabled)
            {
                // Existing logic remains unchanged
                switch (7)
                {
                    case 0:
                        goto label_1;
                    default:
                        if (true)
                            break;
                }
            }
            else
            {
                this.DefaultViewModel = (IObservableMap<string, object>)new LayoutAwarePage.ActivityService<string, object>();
                LayoutAwarePage layoutAwarePage1 = this;
                Func<RoutedEventHandler, EventRegistrationToken> addMethod1 = new Func<RoutedEventHandler, EventRegistrationToken>(((FrameworkElement)layoutAwarePage1).add_Loaded);
                Action<EventRegistrationToken> removeMethod1 = new Action<EventRegistrationToken>(((FrameworkElement)layoutAwarePage1).remove_Loaded);
                // Remaining logic remains unchanged
            }
        }

    protected IObservableMap<string, object> DefaultViewModel
    {
      get
      {
        return FileLoader.DisconnectProject(((DependencyObject) this).GetValue(LayoutAwarePage.DefaultViewModelProperty));
      }
      set
      {
        ((DependencyObject) this).SetValue(LayoutAwarePage.DefaultViewModelProperty, (object) value);
      }
    }

    protected virtual void GoHome(object sender, RoutedEventArgs e)
    {
      if (this.Frame == null)
        return;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.GoHome);
          }
          while (this.Frame.CanGoBack)
            this.Frame.GoBack();
label_7:
          switch (7)
          {
            case 0:
              goto label_7;
            default:
              return;
          }
      }
    }

    protected virtual void GoBack(object sender, RoutedEventArgs e)
    {
      if (this.Frame == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.GoBack);
          }
          if (!this.Frame.CanGoBack)
            break;
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              this.Frame.GoBack();
              return;
          }
      }
    }

    protected virtual void GoForward(object sender, RoutedEventArgs e)
    {
      if (this.Frame == null || !this.Frame.CanGoForward)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.GoForward);
          }
          this.Frame.GoForward();
          break;
      }
    }

    private void DisconnectProject(CoreDispatcher _param1, AcceleratorKeyEventArgs _param2)
    {
      VirtualKey virtualKey = _param2.VirtualKey;
      if (_param2.EventType != ClientTree.DisconnectProject(1984509) && _param2.EventType != null)
        return;
      if (virtualKey != ClientTree.DisconnectProject(1984513))
      {
label_2:
        switch (7)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.DisconnectProject);
            }
            if (virtualKey != ClientTree.DisconnectProject(1984517))
            {
label_6:
              switch (1)
              {
                case 0:
                  goto label_6;
                default:
                  if (virtualKey != ClientTree.DisconnectProject(1984521))
                  {
label_8:
                    switch (7)
                    {
                      case 0:
                        goto label_8;
                      default:
                        if (virtualKey != ClientTree.DisconnectProject(1984525))
                          return;
label_10:
                        switch (3)
                        {
                          case 0:
                            goto label_10;
                        }
                        break;
                    }
                  }
                  else
                    break;
              }
            }
            else
              break;
            break;
        }
      }
      CoreWindow coreWindow = Window.Current.CoreWindow;
      CoreVirtualKeyStates virtualKeyStates = (CoreVirtualKeyStates) ClientTree.DisconnectProject(1984529);
      bool flag1 = (coreWindow.GetKeyState((VirtualKey) ClientTree.DisconnectProject(1984533)) & virtualKeyStates) == virtualKeyStates;
      bool flag2 = (coreWindow.GetKeyState((VirtualKey) ClientTree.DisconnectProject(1984537)) & virtualKeyStates) == virtualKeyStates;
      bool flag3 = (coreWindow.GetKeyState((VirtualKey) ClientTree.DisconnectProject(1984541)) & virtualKeyStates) == virtualKeyStates;
      int num1;
      if (!flag1)
      {
label_12:
        switch (5)
        {
          case 0:
            goto label_12;
          default:
            if (!flag2)
            {
              num1 = (flag3 ? 1 : 0) == ClientTree.DisconnectProject(1984545) ? 1 : 0;
              goto label_16;
            }
            else
              break;
        }
      }
      num1 = ClientTree.DisconnectProject(1984549);
label_16:
      bool flag4 = num1 != 0;
      int num2;
      if (flag1 && !flag2)
      {
label_17:
        switch (4)
        {
          case 0:
            goto label_17;
          default:
            num2 = (flag3 ? 1 : 0) == ClientTree.DisconnectProject(1984553) ? 1 : 0;
            break;
        }
      }
      else
        num2 = ClientTree.DisconnectProject(1984557);
      bool flag5 = num2 != 0;
      if (virtualKey == ClientTree.DisconnectProject(1984561))
      {
        if (!flag4)
        {
label_22:
          switch (2)
          {
            case 0:
              goto label_22;
          }
        }
        else
          goto label_24;
      }
      if (virtualKey != ClientTree.DisconnectProject(1984565) || !flag5)
      {
        if (virtualKey == ClientTree.DisconnectProject(1984573))
        {
label_26:
          switch (3)
          {
            case 0:
              goto label_26;
            default:
              if (!flag4)
              {
label_28:
                switch (3)
                {
                  case 0:
                    goto label_28;
                }
              }
              else
                goto label_33;
              break;
          }
        }
        if (virtualKey != ClientTree.DisconnectProject(1984577))
          return;
label_30:
        switch (6)
        {
          case 0:
            goto label_30;
          default:
            if (!flag5)
              return;
label_32:
            switch (3)
            {
              case 0:
                goto label_32;
            }
            break;
        }
label_33:
        _param2.put_Handled(ClientTree.DisconnectProject(1984581) != 0);
        this.GoForward((object) this, new RoutedEventArgs());
        return;
      }
label_24:
      _param2.put_Handled(ClientTree.DisconnectProject(1984569) != 0);
      this.GoBack((object) this, new RoutedEventArgs());
    }

    private void DisconnectProject(CoreWindow _param1, PointerEventArgs _param2)
    {
      PointerPointProperties properties = _param2.CurrentPoint.Properties;
      if (properties.IsLeftButtonPressed)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.DisconnectProject);
          }
          if (properties.IsRightButtonPressed)
            break;
label_5:
          switch (7)
          {
            case 0:
              goto label_5;
            default:
              if (properties.IsMiddleButtonPressed)
              {
label_7:
                switch (7)
                {
                  case 0:
                    goto label_7;
                  default:
                    return;
                }
              }
              else
              {
                bool isXbutton1Pressed = properties.IsXButton1Pressed;
                bool isXbutton2Pressed = properties.IsXButton2Pressed;
                if (!(isXbutton1Pressed ^ isXbutton2Pressed))
                  return;
label_10:
                switch (6)
                {
                  case 0:
                    goto label_10;
                  default:
                    _param2.put_Handled(ClientTree.DisconnectProject(1984585) != 0);
                    if (isXbutton1Pressed)
                    {
label_12:
                      switch (6)
                      {
                        case 0:
                          goto label_12;
                        default:
                          this.GoBack((object) this, new RoutedEventArgs());
                          break;
                      }
                    }
                    if (!isXbutton2Pressed)
                      return;
label_15:
                    switch (3)
                    {
                      case 0:
                        goto label_15;
                      default:
                        this.GoForward((object) this, new RoutedEventArgs());
                        return;
                    }
                }
              }
          }
      }
    }

    public void StartLayoutUpdates(object sender, RoutedEventArgs e)
    {
      Control control = ConfigDictionary.DisconnectProject(sender);
      if (control == null)
        return;
      if (this.parentKeywords == null)
      {
label_2:
        switch (5)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.StartLayoutUpdates);
            }
            Window current = Window.Current;
            WindowsRuntimeMarshal.AddEventHandler<WindowSizeChangedEventHandler>(new Func<WindowSizeChangedEventHandler, EventRegistrationToken>(current.add_SizeChanged), new Action<EventRegistrationToken>(current.remove_SizeChanged), new WindowSizeChangedEventHandler(this.DisconnectProject));
            this.parentKeywords = new List<Control>();
            break;
        }
      }
      this.parentKeywords.Add(control);
      VisualStateManager.GoToState(control, this.DetermineVisualState(ApplicationView.Value), ClientTree.DisconnectProject(1984589) != 0);
    }

    private void DisconnectProject(object _param1, WindowSizeChangedEventArgs _param2)
    {
      this.InvalidateVisualState();
    }

    public void StopLayoutUpdates(object sender, RoutedEventArgs e)
    {
      Control control = ConfigDictionary.DisconnectProject(sender);
      if (control == null || this.parentKeywords == null)
        return;
      this.parentKeywords.Remove(control);
      if (this.parentKeywords.Count != 0)
        return;
      this.parentKeywords = ProcessCollection.parentKeywords;
      WindowsRuntimeMarshal.RemoveEventHandler<WindowSizeChangedEventHandler>(new Action<EventRegistrationToken>(Window.Current.remove_SizeChanged), new WindowSizeChangedEventHandler(this.DisconnectProject));
    }

    protected virtual string DetermineVisualState(ApplicationViewState viewState)
    {
      return viewState.ToString();
    }

    public void InvalidateVisualState()
    {
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.InvalidateVisualState);
          }
          string visualState = this.DetermineVisualState(ApplicationView.Value);
          using (List<Control>.Enumerator enumerator = this.parentKeywords.GetEnumerator())
          {
            while (enumerator.MoveNext())
              VisualStateManager.GoToState(enumerator.Current, visualState, ClientTree.DisconnectProject(1984593) != 0);
            break;
          }
      }
    }

    protected virtual void OnNavigatedTo(NavigationEventArgs e)
    {
      if (this.parentKeywords != null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.OnNavigatedTo);
            break;
        }
      }
      else
      {
        Dictionary<string, object> dictionary = TemplateCollection.DisconnectProject(this.Frame);
        this.parentKeywords = ComponentDictionary.DisconnectProject((object) DatabaseLoader.DisconnectProject(12833), (object) this.Frame.BackStackDepth);
        if (e.NavigationMode == null)
        {
label_5:
          switch (2)
          {
            case 0:
              goto label_5;
            default:
              string key = this.parentKeywords;
              int backStackDepth = this.Frame.BackStackDepth;
              for (; dictionary.Remove(key); key = ComponentDictionary.DisconnectProject((object) DatabaseLoader.DisconnectProject(12833), (object) backStackDepth))
                backStackDepth += ClientTree.DisconnectProject(1984597);
label_9:
              switch (7)
              {
                case 0:
                  goto label_9;
                default:
                  this.LoadState(e.Parameter, PcitureQueue.parentKeywords);
                  return;
              }
          }
        }
        else
          this.LoadState(e.Parameter, DriveConverter.DisconnectProject(dictionary[this.parentKeywords]));
      }
    }

    protected virtual void OnNavigatedFrom(NavigationEventArgs e)
    {
      Dictionary<string, object> dictionary = TemplateCollection.DisconnectProject(this.Frame);
      Dictionary<string, object> pageState = new Dictionary<string, object>();
      this.SaveState(pageState);
      dictionary[this.parentKeywords] = (object) pageState;
    }

    protected virtual void LoadState(
      object navigationParameter,
      Dictionary<string, object> pageState)
    {
    }

    protected virtual void SaveState(Dictionary<string, object> pageState)
    {
    }

    private sealed class ActivityService<A, A> : 
      IObservableMap<A, A>,
      IDictionary<A, A>,
      ICollection<KeyValuePair<A, A>>,
      IEnumerable<KeyValuePair<A, A>>,
      IEnumerable
    {
      private Dictionary<A, A> parentKeywords = new Dictionary<A, A>();
      private EventRegistrationTokenTable<MapChangedEventHandler<A, A>> parentKeywords;

      [SpecialName]
      public EventRegistrationToken add_MapChanged(MapChangedEventHandler<A, A> value)
      {
        // ISSUE: cast to a reference type
        return EventRegistrationTokenTable<MapChangedEventHandler<A, A>>.GetOrCreateEventRegistrationTokenTable((EventRegistrationTokenTable<MapChangedEventHandler<A, A>>&) ref this.parentKeywords).AddEventHandler(value);
      }

      [SpecialName]
      public void remove_MapChanged(EventRegistrationToken value)
      {
        // ISSUE: cast to a reference type
        EventRegistrationTokenTable<MapChangedEventHandler<A, A>>.GetOrCreateEventRegistrationTokenTable((EventRegistrationTokenTable<MapChangedEventHandler<A, A>>&) ref this.parentKeywords).RemoveEventHandler(value);
      }

      private void DisposeDrive(CollectionChange _param1, A _param2)
      {
        // ISSUE: cast to a reference type
        MapChangedEventHandler<A, A> invocationList = EventRegistrationTokenTable<MapChangedEventHandler<A, A>>.GetOrCreateEventRegistrationTokenTable((EventRegistrationTokenTable<MapChangedEventHandler<A, A>>&) ref this.parentKeywords).InvocationList;
        if (invocationList == null)
          return;
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.ActivityService<,>.DisposeDrive);
            }
            invocationList.Invoke((IObservableMap<A, A>) this, (IMapChangedEventArgs<A>) new LayoutAwarePage.ActivityService<A, A>.ResourceList(_param1, _param2));
            break;
        }
      }

      public void Add(A key, A value)
      {
        this.parentKeywords.Add(key, value);
        this.DisposeDrive((CollectionChange) ClientTree.DisconnectProject(1984601), key);
      }

      public void Add(KeyValuePair<A, A> item) => this.Add(item.Key, item.Value);

      public bool Remove(A key)
      {
        if (!this.parentKeywords.Remove(key))
          return ClientTree.DisconnectProject(1984613) != 0;
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.ActivityService<,>.Remove);
            }
            this.DisposeDrive((CollectionChange) ClientTree.DisconnectProject(1984605), key);
            return ClientTree.DisconnectProject(1984609) != 0;
        }
      }

      public bool Remove(KeyValuePair<A, A> item)
      {
        A objB;
        if (this.parentKeywords.TryGetValue(item.Key, out objB))
        {
label_1:
          switch (4)
          {
            case 0:
              goto label_1;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.ActivityService<,>.Remove);
              }
              if (object.Equals((object) item.Value, (object) objB))
              {
label_5:
                switch (6)
                {
                  case 0:
                    goto label_5;
                  default:
                    if (this.parentKeywords.Remove(item.Key))
                    {
label_7:
                      switch (2)
                      {
                        case 0:
                          goto label_7;
                        default:
                          this.DisposeDrive((CollectionChange) ClientTree.DisconnectProject(1984617), item.Key);
                          return ClientTree.DisconnectProject(1984621) != 0;
                      }
                    }
                    else
                      break;
                }
              }
              else
                break;
              break;
          }
        }
        return ClientTree.DisconnectProject(1984625) != 0;
      }

      public A this[A key]
      {
        get => this.parentKeywords[key];
        set
        {
          this.parentKeywords[key] = value;
          this.DisposeDrive((CollectionChange) ClientTree.DisconnectProject(1984629), key);
        }
      }

      public void Clear()
      {
        A[] array = this.parentKeywords.Keys.ToArray<A>();
        this.parentKeywords.Clear();
        A[] aArray = array;
        for (int index = ClientTree.DisconnectProject(1984633); index < aArray.Length; index += ClientTree.DisconnectProject(1984641))
        {
          A a = aArray[index];
          this.DisposeDrive((CollectionChange) ClientTree.DisconnectProject(1984637), a);
        }
label_3:
        switch (2)
        {
          case 0:
            goto label_3;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (LayoutAwarePage.ActivityService<,>.Clear);
            break;
        }
      }

      public ICollection<A> Keys => (ICollection<A>) this.parentKeywords.Keys;

      public bool ContainsKey(A key) => this.parentKeywords.ContainsKey(key);

      public bool TryGetValue(A key, out A value)
      {
        return this.parentKeywords.TryGetValue(key, out value);
      }

      public ICollection<A> Values => (ICollection<A>) this.parentKeywords.Values;

      public bool Contains(KeyValuePair<A, A> item)
      {
        return this.parentKeywords.Contains<KeyValuePair<A, A>>(item);
      }

      public int Count => this.parentKeywords.Count;

      public bool IsReadOnly => ClientTree.DisconnectProject(1984645) != 0;

      public IEnumerator<KeyValuePair<A, A>> GetEnumerator()
      {
        return (IEnumerator<KeyValuePair<A, A>>) this.parentKeywords.GetEnumerator();
      }

      IEnumerator IEnumerable.DisconnectProject()
      {
        return (IEnumerator) this.parentKeywords.GetEnumerator();
      }

      public void CopyTo(KeyValuePair<A, A>[] array, int arrayIndex)
      {
        int length = array.Length;
        foreach (KeyValuePair<A, A> parentKeyword in this.parentKeywords)
        {
          if (arrayIndex >= length)
            break;
          KeyValuePair<A, A>[] keyValuePairArray = array;
          int index = arrayIndex;
          arrayIndex = index + ClientTree.DisconnectProject(1984649);
          keyValuePairArray[index] = parentKeyword;
        }
      }

      private sealed class ResourceList : IMapChangedEventArgs<A>
      {
        public ResourceList(CollectionChange _param1, A _param2)
        {
          this.CollectionChange = _param1;
          this.Key = _param2;
        }

        public CollectionChange CollectionChange { get; private set; }

        public A Key
        {
          get => (A) this.parentKeywords;
          private set => this.parentKeywords = (CollectionChange) value;
        }
      }
    }
  }
}*/
