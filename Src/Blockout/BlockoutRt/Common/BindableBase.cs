// *************************************************************
// Type: BlockoutRt.Common.BindableBase
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Blockout;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Windows.Foundation.Metadata;

#nullable disable
namespace BlockoutRt.Common
{
  [WebHostHidden]
  public abstract class BindableBase : INotifyPropertyChanged
  {
    private PropertyChangedEventHandler parentKeywords;

    public event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        PropertyChangedEventHandler changedEventHandler1 = this.parentKeywords;
        PropertyChangedEventHandler changedEventHandler2;
        do
        {
          changedEventHandler2 = changedEventHandler1;
          changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.parentKeywords, DiskSerializer.DisconnectProject((object) Delegate.Combine((Delegate) changedEventHandler2, (Delegate) value)), changedEventHandler2);
        }
        while (changedEventHandler1 != changedEventHandler2);
      }
      remove
      {
        PropertyChangedEventHandler changedEventHandler1 = this.parentKeywords;
        PropertyChangedEventHandler changedEventHandler2;
        do
        {
          changedEventHandler2 = changedEventHandler1;
          changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.parentKeywords, DiskSerializer.DisconnectProject((object) Delegate.Remove((Delegate) changedEventHandler2, (Delegate) value)), changedEventHandler2);
        }
        while (changedEventHandler1 != changedEventHandler2);
label_2:
        switch (5)
        {
          case 0:
            goto label_2;
          default:
            if (true)
              break;
            RuntimeMethodHandle runtimeMethodHandle = __methodref (BindableBase.remove_PropertyChanged);
            break;
        }
      }
    }

    protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
      if (object.Equals((object) storage, (object) value))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (BindableBase.SetProperty);
            }
            return ClientTree.DisconnectProject(1984469) != 0;
        }
      }
      else
      {
        storage = value;
        this.OnPropertyChanged(propertyName);
        return ClientTree.DisconnectProject(1984473) != 0;
      }
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChangedEventHandler parentKeywords = this.parentKeywords;
      if (parentKeywords == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (BindableBase.OnPropertyChanged);
          }
          parentKeywords((object) this, new PropertyChangedEventArgs(propertyName));
          break;
      }
    }
  }
}
