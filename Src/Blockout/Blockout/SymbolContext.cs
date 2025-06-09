// *************************************************************
// Type: Blockout.SymbolContext
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Microsoft.Advertising.WinRT.UI.XamlAdControl_XamlTypeInfo;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace Blockout
{
  [DebuggerNonUserCode]
  [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]
  internal sealed class SymbolContext
  {
    private Dictionary<string, IXamlType> parentKeywords = new Dictionary<string, IXamlType>();
    private Dictionary<string, IXamlMember> parentKeywords = new Dictionary<string, IXamlMember>();
    private Dictionary<Type, string> parentKeywords = new Dictionary<Type, string>();
    private List<IXamlMetadataProvider> parentKeywords;

    public IXamlType DisconnectProject(Type _param1)
    {
      IXamlType parentKeywords = ContextList.parentKeywords;
      string str;
      IXamlType ixamlType;
      if (this.parentKeywords.TryGetValue(_param1, out str))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolContext.DisconnectProject);
            }
            ixamlType = this.DisconnectProject(str);
            break;
        }
      }
      else
        ixamlType = this.DisconnectProject(_param1.FullName);
      if (ixamlType == null)
      {
label_7:
        switch (5)
        {
          case 0:
            goto label_7;
          default:
            ixamlType = this.DisposeDrive(_param1);
            break;
        }
      }
      return ixamlType;
    }

    public IXamlType DisconnectProject(string _param1)
    {
      if (string.IsNullOrEmpty(_param1))
      {
label_1:
        switch (6)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolContext.DisconnectProject);
            }
            return (IXamlType) null;
        }
      }
      else
      {
        IXamlType ixamlType1;
        if (this.parentKeywords.TryGetValue(_param1, out ixamlType1))
        {
label_6:
          switch (3)
          {
            case 0:
              goto label_6;
            default:
              return ixamlType1;
          }
        }
        else
        {
          IXamlType ixamlType2 = this.DisposeDrive(_param1);
          if (ixamlType2 == null)
          {
label_9:
            switch (5)
            {
              case 0:
                goto label_9;
              default:
                ixamlType2 = this.ListQueue(_param1);
                break;
            }
          }
          if (ixamlType2 != null)
            this.parentKeywords.Add(_param1, ixamlType2);
          return ixamlType2;
        }
      }
    }

    public IXamlMember DisconnectProject(string _param1)
    {
      if (string.IsNullOrEmpty(_param1))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolContext.DisconnectProject);
            }
            return (IXamlMember) null;
        }
      }
      else
      {
        IXamlMember ixamlMember1;
        if (this.parentKeywords.TryGetValue(_param1, out ixamlMember1))
        {
label_6:
          switch (1)
          {
            case 0:
              goto label_6;
            default:
              return ixamlMember1;
          }
        }
        else
        {
          IXamlMember ixamlMember2 = this.DisposeDrive(_param1);
          if (ixamlMember2 != null)
            this.parentKeywords.Add(_param1, ixamlMember2);
          return ixamlMember2;
        }
      }
    }

    private void DisconnectProject(Type _param1, string _param2)
    {
      if (this.parentKeywords.ContainsKey(_param1))
        return;
      this.parentKeywords.Add(_param1, _param2);
    }

    private IXamlType DisposeDrive(string _param1)
    {
      EmulatorFactory emulatorFactory = BuilderProvider.parentKeywords;
      string str;
      if ((str = _param1) != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolContext.DisposeDrive);
            }
            if (!ServerInvoker.DisconnectProject(str, DatabaseLoader.DisconnectProject(13583)))
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
                default:
                  if (!ServerInvoker.DisconnectProject(str, DatabaseLoader.DisconnectProject(13682)))
                  {
                    if (!ServerInvoker.DisconnectProject(str, DatabaseLoader.DisconnectProject(13743)))
                    {
                      if (!ServerInvoker.DisconnectProject(str, DatabaseLoader.DisconnectProject(13816)))
                      {
label_9:
                        switch (3)
                        {
                          case 0:
                            goto label_9;
                          default:
                            if (!ServerInvoker.DisconnectProject(str, DatabaseLoader.DisconnectProject(13855)))
                            {
label_11:
                              switch (6)
                              {
                                case 0:
                                  goto label_11;
                              }
                            }
                            else
                            {
                              emulatorFactory = (EmulatorFactory) new ActivatorOptions(this, _param1, Type.GetTypeFromHandle(DomainTree.DisconnectProject()), this.DisconnectProject(DatabaseLoader.DisconnectProject(13743)));
                              break;
                            }
                            break;
                        }
                      }
                      else
                      {
                        emulatorFactory = (EmulatorFactory) new ActivatorOptions(this, _param1, Type.GetTypeFromHandle(TextFileSettings.DisconnectProject()), this.DisconnectProject(DatabaseLoader.DisconnectProject(13583)));
                        break;
                      }
                    }
                    else
                    {
                      emulatorFactory = new EmulatorFactory(_param1, Type.GetTypeFromHandle(MemoryEventArgs.DisconnectProject()));
                      break;
                    }
                  }
                  else
                  {
                    emulatorFactory = new EmulatorFactory(_param1, Type.GetTypeFromHandle(PartitionService.DisconnectProject()));
                    break;
                  }
                  break;
              }
            }
            else
            {
              emulatorFactory = new EmulatorFactory(_param1, Type.GetTypeFromHandle(ConnectionInvoker.DisconnectProject()));
              break;
            }
            break;
        }
      }
      return (IXamlType) emulatorFactory;
    }

    [SpecialName]
    private List<IXamlMetadataProvider> get_DisconnectProject()
    {
      if (this.parentKeywords == null)
      {
        this.parentKeywords = new List<IXamlMetadataProvider>();
        // ISSUE: object of a compiler-generated type is created
        this.parentKeywords.Add((IXamlMetadataProvider) new XamlMetaDataProvider());
      }
      return this.parentKeywords;
    }

    private IXamlType ListQueue(string _param1)
    {
      IXamlType parentKeywords = ContextList.parentKeywords;
      using (List<IXamlMetadataProvider>.Enumerator enumerator = this.get_DisconnectProject().GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          IXamlType xamlType = enumerator.Current.GetXamlType(_param1);
          if (xamlType != null)
          {
label_3:
            switch (7)
            {
              case 0:
                goto label_3;
              default:
                if (false)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolContext.ListQueue);
                }
                return xamlType;
            }
          }
        }
label_8:
        switch (1)
        {
          case 0:
            goto label_8;
        }
      }
      return (IXamlType) null;
    }

    private IXamlType DisposeDrive(Type _param1)
    {
      IXamlType parentKeywords = ContextList.parentKeywords;
      using (List<IXamlMetadataProvider>.Enumerator enumerator = this.get_DisconnectProject().GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          IXamlType xamlType = enumerator.Current.GetXamlType(_param1);
          if (xamlType != null)
          {
label_3:
            switch (2)
            {
              case 0:
                goto label_3;
              default:
                if (false)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (SymbolContext.DisposeDrive);
                }
                return xamlType;
            }
          }
        }
label_8:
        switch (7)
        {
          case 0:
            goto label_8;
        }
      }
      return (IXamlType) null;
    }

    private IXamlMember DisposeDrive(string _param1) => (IXamlMember) DialogContext.parentKeywords;
  }
}
