// Decompiled with JetBrains decompiler
// Type: GameFoundation.XmlFileSerializer
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using Microsoft.Advertising.WinRT.UI;
using MicrosoftAdvertising;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.UI.Xaml;

#nullable disable
namespace GameFoundation
{
  internal sealed class XmlFileSerializer : VectorService
  {
    private AdControl[] parentKeywords;
    private EventHandler parentKeywords;
    private EventHandler currentUri;
    private EventHandler filterID;
    private EventHandler parentCancel;
    private AdControl parentKeywords;

    internal XmlFileSerializer()
    {
      this.parentKeywords = DriveAttribute.DisconnectProject(ReferenceInvoker.DisconnectProject(1885));
    }

    [SpecialName]
    public void add_DisconnectProject(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.parentKeywords;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.parentKeywords, ToolbarInfo.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
label_2:
      switch (6)
      {
        case 0:
          goto label_2;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.add_DisconnectProject);
          break;
      }
    }

    [SpecialName]
    public void remove_DisconnectProject(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.parentKeywords;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.parentKeywords, ToolbarInfo.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
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
          RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.remove_DisconnectProject);
          break;
      }
    }

    [SpecialName]
    public void add_DisposeDrive(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.currentUri;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.currentUri, ToolbarInfo.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

    [SpecialName]
    public void remove_DisposeDrive(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.currentUri;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.currentUri, ToolbarInfo.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
    }

    [SpecialName]
    public void add_ListQueue(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.filterID;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.filterID, ToolbarInfo.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
label_2:
      switch (4)
      {
        case 0:
          goto label_2;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.add_ListQueue);
          break;
      }
    }

    [SpecialName]
    public void remove_ListQueue(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.filterID;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.filterID, ToolbarInfo.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
label_2:
      switch (4)
      {
        case 0:
          goto label_2;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.remove_ListQueue);
          break;
      }
    }

    [SpecialName]
    public void add_EnableNetwork(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.parentCancel;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.parentCancel, ToolbarInfo.DisconnectProject((object) Delegate.Combine((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
      }
      while (eventHandler1 != eventHandler2);
label_2:
      switch (6)
      {
        case 0:
          goto label_2;
        default:
          if (true)
            break;
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.add_EnableNetwork);
          break;
      }
    }

    [SpecialName]
    public void remove_EnableNetwork(EventHandler _param1)
    {
      EventHandler eventHandler1 = this.parentCancel;
      EventHandler eventHandler2;
      do
      {
        eventHandler2 = eventHandler1;
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.parentCancel, ToolbarInfo.DisconnectProject((object) Delegate.Remove((Delegate) eventHandler2, (Delegate) _param1)), eventHandler2);
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
          // ISSUE: method reference
          RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.remove_EnableNetwork);
          break;
      }
    }

    private AdControl ReplaceDeployment() => this.parentKeywords;

    private bool ReplaceDeployment(int _param1)
    {
      if (_param1 >= ReferenceInvoker.DisconnectProject(1805))
      {
        if (_param1 < (int) WindowConverter.DisconnectProject(this.parentKeywords))
          return (this.parentKeywords[_param1] == null ? 1 : 0) == ReferenceInvoker.DisconnectProject(1813);
label_2:
        switch (4)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.ReplaceDeployment);
              break;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(1809) != 0;
    }

    public bool TestConnection()
    {
      // ISSUE: variable of a compiler-generated type
      AdControl adControl = this.ReplaceDeployment();
      if (adControl == null)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.TestConnection);
            }
            return ReferenceInvoker.DisconnectProject(1817) != 0;
        }
      }
      else
      {
        try
        {
          return adControl.IsEngaged;
        }
        catch
        {
          return ReferenceInvoker.DisconnectProject(1821) != 0;
        }
      }
    }

    public bool ExtractDockingPane()
    {
      // ISSUE: variable of a compiler-generated type
      AdControl adControl = this.ReplaceDeployment();
      if (adControl == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.ExtractDockingPane);
            }
            return ReferenceInvoker.DisconnectProject(1825) != 0;
        }
      }
      else
      {
        try
        {
          return adControl.IsEngaged;
        }
        catch
        {
          return ReferenceInvoker.DisconnectProject(1829) != 0;
        }
      }
    }

    public void LoadDirectory()
    {
    }

    public void SelectResource(bool _param1)
    {
      // ISSUE: variable of a compiler-generated type
      AdControl adControl = this.ReplaceDeployment();
      if (adControl == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.SelectResource);
            break;
        }
      }
      else
      {
        try
        {
          if (!_param1)
            return;
          ((UIElement) adControl).put_Visibility((Visibility) ReferenceInvoker.DisconnectProject(1833));
        }
        catch
        {
        }
      }
    }

    public bool EnableDockingPane()
    {
      // ISSUE: variable of a compiler-generated type
      AdControl adControl = this.ReplaceDeployment();
      if (adControl == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.EnableDockingPane);
            }
            return ReferenceInvoker.DisconnectProject(1837) != 0;
        }
      }
      else
      {
        try
        {
          return ((UIElement) adControl).Visibility == ReferenceInvoker.DisconnectProject(1841);
        }
        catch
        {
          return ReferenceInvoker.DisconnectProject(1845) != 0;
        }
      }
    }

    public void CopyProject(int _param1, ConfigStream _param2)
    {
      if (_param1 < ReferenceInvoker.DisconnectProject(1849))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.CopyProject);
          }
          if (_param1 >= (int) WindowConverter.DisconnectProject(this.parentKeywords))
            break;
label_5:
          switch (3)
          {
            case 0:
              goto label_5;
            default:
              if (_param2 == null)
                return;
              if (string.IsNullOrEmpty(_param2.parentKeywords))
              {
label_8:
                switch (5)
                {
                  case 0:
                    goto label_8;
                  default:
                    return;
                }
              }
              else
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                AdControl adControl = new AdControl();
                adControl.ApplicationId = MsAdOnline.DisconnectProject();
                adControl.AdUnitId = _param2.parentKeywords;
                ((FrameworkElement) adControl).put_Height((double) _param2.currentUri);
                ((FrameworkElement) adControl).put_Width((double) _param2.parentKeywords);
                adControl.IsAutoRefreshEnabled = ReferenceInvoker.DisconnectProject(1853) != 0;
                this.ReplaceDeployment(adControl);
                this.parentKeywords[_param1] = adControl;
                this.DisconnectWindow(_param1);
                return;
              }
          }
      }
    }

    private void ReplaceDeployment(AdControl _param1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      WindowsRuntimeMarshal.AddEventHandler<EventHandler<RoutedEventArgs>>(new Func<EventHandler<RoutedEventArgs>, EventRegistrationToken>(_param1.add_AdRefreshed), new Action<EventRegistrationToken>(_param1.remove_AdRefreshed), new EventHandler<RoutedEventArgs>(this.FormatContext));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      WindowsRuntimeMarshal.AddEventHandler<EventHandler<AdErrorEventArgs>>(new Func<EventHandler<AdErrorEventArgs>, EventRegistrationToken>(_param1.add_ErrorOccurred), new Action<EventRegistrationToken>(_param1.remove_ErrorOccurred), new EventHandler<AdErrorEventArgs>(this.ReplaceDeployment));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      WindowsRuntimeMarshal.AddEventHandler<EventHandler<RoutedEventArgs>>(new Func<EventHandler<RoutedEventArgs>, EventRegistrationToken>(_param1.add_IsEngagedChanged), new Action<EventRegistrationToken>(_param1.remove_IsEngagedChanged), new EventHandler<RoutedEventArgs>(this.ReplaceDeployment));
    }

    private void FormatContext(AdControl _param1)
    {
      // ISSUE: reference to a compiler-generated method
      WindowsRuntimeMarshal.RemoveEventHandler<EventHandler<RoutedEventArgs>>(new Action<EventRegistrationToken>(_param1.remove_AdRefreshed), new EventHandler<RoutedEventArgs>(this.FormatContext));
      // ISSUE: reference to a compiler-generated method
      WindowsRuntimeMarshal.RemoveEventHandler<EventHandler<AdErrorEventArgs>>(new Action<EventRegistrationToken>(_param1.remove_ErrorOccurred), new EventHandler<AdErrorEventArgs>(this.ReplaceDeployment));
      // ISSUE: reference to a compiler-generated method
      WindowsRuntimeMarshal.RemoveEventHandler<EventHandler<RoutedEventArgs>>(new Action<EventRegistrationToken>(_param1.remove_IsEngagedChanged), new EventHandler<RoutedEventArgs>(this.ReplaceDeployment));
    }

    private void PublishPciture(AdControl _param1)
    {
      this.parentKeywords = _param1;
      PlatformInheritBase.DisconnectProject().SetVisibileAdControl(_param1);
    }

    private void ReplaceDeployment(object _param1, RoutedEventArgs _param2)
    {
      this.parentKeywords((object) this, EventArgs.Empty);
    }

    private void ReplaceDeployment(object _param1, AdErrorEventArgs _param2)
    {
      bool flag = ReferenceInvoker.DisconnectProject(1857) != 0;
      try
      {
        if (_param2 != null)
        {
label_2:
          switch (2)
          {
            case 0:
              goto label_2;
            default:
              if (false)
              {
                // ISSUE: method reference
                RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.ReplaceDeployment);
              }
              if (_param2.ErrorCode == (ErrorCode) ReferenceInvoker.DisconnectProject(1861))
              {
                this.filterID((object) this, EventArgs.Empty);
                this.parentCancel((object) this, EventArgs.Empty);
                break;
              }
              break;
          }
        }
      }
      catch
      {
      }
      if (flag)
        return;
label_10:
      switch (6)
      {
        case 0:
          goto label_10;
        default:
          this.currentUri((object) this, EventArgs.Empty);
          break;
      }
    }

    private void FormatContext(object _param1, RoutedEventArgs _param2)
    {
      this.filterID((object) this, EventArgs.Empty);
      // ISSUE: variable of a compiler-generated type
      AdControl adControl = LineDictionary.DisconnectProject(_param1);
      if (adControl == null)
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.FormatContext);
            break;
        }
      }
      else
      {
        if (this.parentKeywords == adControl)
          return;
        this.PublishPciture(adControl);
      }
    }

    public bool LoadDeployment(int _param1)
    {
      if (_param1 >= ReferenceInvoker.DisconnectProject(1865))
      {
        if (_param1 < (int) WindowConverter.DisconnectProject(this.parentKeywords))
          return (this.parentKeywords[_param1] == null ? 1 : 0) == ReferenceInvoker.DisconnectProject(1873);
label_2:
        switch (7)
        {
          case 0:
            goto label_2;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.LoadDeployment);
              break;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(1869) != 0;
    }

    public void DisconnectWindow(int _param1)
    {
      if (_param1 < ReferenceInvoker.DisconnectProject(1877) || _param1 >= (int) WindowConverter.DisconnectProject(this.parentKeywords))
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.DisconnectWindow);
          }
          if (this.parentKeywords[_param1] == null)
            break;
          // ISSUE: variable of a compiler-generated type
          AdControl parentKeyword = this.parentKeywords[_param1];
          // ISSUE: variable of a compiler-generated type
          AdControl adControl = this.ReplaceDeployment();
          if (adControl != parentKeyword)
            this.PublishPciture(parentKeyword);
          try
          {
            // ISSUE: reference to a compiler-generated method
            parentKeyword.Refresh();
            break;
          }
          catch
          {
            break;
          }
      }
    }

    public string SaveAssistant(int _param1)
    {
      if (_param1 >= ReferenceInvoker.DisconnectProject(1881))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (XmlFileSerializer.SaveAssistant);
            }
            if (_param1 < (int) WindowConverter.DisconnectProject(this.parentKeywords))
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
                default:
                  if (this.parentKeywords[_param1] == null)
                  {
label_7:
                    switch (6)
                    {
                      case 0:
                        goto label_7;
                    }
                  }
                  else
                  {
                    // ISSUE: variable of a compiler-generated type
                    AdControl parentKeyword = this.parentKeywords[_param1];
                    return parentKeyword.AdUnitId;
                  }
                  break;
              }
            }
            else
              break;
        }
      }
      return (string) null;
    }
  }
}
