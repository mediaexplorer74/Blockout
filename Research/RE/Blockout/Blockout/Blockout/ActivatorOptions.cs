// Decompiled with JetBrains decompiler
// Type: Blockout.ActivatorOptions
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

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
  internal sealed class ActivatorOptions : EmulatorFactory
  {
    private SymbolContext parentKeywords;
    private IXamlType parentKeywords;
    private bool parentKeywords;
    private bool currentUri;
    private bool filterID;
    private string parentKeywords;
    private string currentUri;
    private string filterID;
    private Dictionary<string, string> parentKeywords;
    private Dictionary<string, object> parentKeywords;

    public ActivatorOptions(
      SymbolContext _param1,
      string _param2,
      Type _param3,
      IXamlType _param4)
      : base(_param2, _param3)
    {
      this.parentKeywords = _param1;
      this.parentKeywords = _param4;
    }

    [SpecialName]
    public override IXamlType get_BaseType() => this.parentKeywords;

    [SpecialName]
    public override bool get_IsArray() => this.parentKeywords;

    [SpecialName]
    public override bool get_IsCollection()
    {
      return (this.CollectionAdd == PluginFactory.parentKeywords ? 1 : 0) == ClientTree.DisconnectProject(1984825);
    }

    [SpecialName]
    public override bool get_IsConstructible()
    {
      return (this.Activator == ProjectService.parentKeywords ? 1 : 0) == ClientTree.DisconnectProject(1984829);
    }

    [SpecialName]
    public override bool get_IsDictionary()
    {
      return (this.DictionaryAdd == EditorType.parentKeywords ? 1 : 0) == ClientTree.DisconnectProject(1984833);
    }

    [SpecialName]
    public override bool get_IsMarkupExtension() => this.currentUri;

    [SpecialName]
    public override bool get_IsBindable() => this.filterID;

    [SpecialName]
    public override IXamlMember get_ContentProperty()
    {
      return this.parentKeywords.DisconnectProject(this.parentKeywords);
    }

    [SpecialName]
    public override IXamlType get_ItemType()
    {
      return this.parentKeywords.DisconnectProject(this.currentUri);
    }

    [SpecialName]
    public override IXamlType get_KeyType() => this.parentKeywords.DisconnectProject(this.filterID);

    public override IXamlMember GetMember(string name)
    {
      if (this.parentKeywords == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ActivatorOptions.GetMember);
            }
            return (IXamlMember) null;
        }
      }
      else
      {
        string str;
        if (!this.parentKeywords.TryGetValue(name, out str))
          return (IXamlMember) null;
label_6:
        switch (7)
        {
          case 0:
            goto label_6;
          default:
            return this.parentKeywords.DisconnectProject(str);
        }
      }
    }

    public override object ActivateInstance() => this.Activator();

    public override void AddToMap(object instance, object key, object item)
    {
      this.DictionaryAdd(instance, key, item);
    }

    public override void AddToVector(object instance, object item)
    {
      this.CollectionAdd(instance, item);
    }

    public override void RunInitializer()
    {
      RuntimeHelpers.RunClassConstructor(this.get_UnderlyingType().TypeHandle);
    }

    public override object CreateFromString(string input)
    {
      if (this.parentKeywords == null)
        throw new ArgumentException(input, this.get_FullName());
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (ActivatorOptions.CreateFromString);
          }
          int fromString = ClientTree.DisconnectProject(1984837);
          string str1 = input;
          char[] chArray1 = XmlFileContext.DisconnectProject(ClientTree.DisconnectProject(1984841));
          chArray1[ClientTree.DisconnectProject(1984845)] = (char) ClientTree.DisconnectProject(1984849);
          char[] chArray2 = chArray1;
          string[] strArray = str1.Split(chArray2);
          for (int index = ClientTree.DisconnectProject(1984853); index < (int) DeviceQueue.DisconnectProject(strArray); index += ClientTree.DisconnectProject(1984865))
          {
            string str2 = strArray[index];
            int num = ClientTree.DisconnectProject(1984857);
            try
            {
              object obj;
              if (this.parentKeywords.TryGetValue(str2.Trim(), out obj))
              {
label_7:
                switch (5)
                {
                  case 0:
                    goto label_7;
                  default:
                    num = Convert.ToInt32(obj);
                    break;
                }
              }
              else
              {
                try
                {
                  num = Convert.ToInt32(str2.Trim());
                }
                catch (FormatException ex)
                {
                  using (Dictionary<string, object>.KeyCollection.Enumerator enumerator = this.parentKeywords.Keys.GetEnumerator())
                  {
                    while (enumerator.MoveNext())
                    {
                      string current = enumerator.Current;
                      if (string.Compare(str2.Trim(), current, (StringComparison) ClientTree.DisconnectProject(1984861)) == 0)
                      {
label_13:
                        switch (6)
                        {
                          case 0:
                            goto label_13;
                          default:
                            if (this.parentKeywords.TryGetValue(current.Trim(), out obj))
                            {
label_15:
                              switch (1)
                              {
                                case 0:
                                  goto label_15;
                                default:
                                  num = Convert.ToInt32(obj);
                                  goto label_20;
                              }
                            }
                            else
                              continue;
                        }
                      }
                    }
label_18:
                    switch (6)
                    {
                      case 0:
                        goto label_18;
                    }
                  }
                }
              }
label_20:
              fromString |= num;
            }
            catch (FormatException ex)
            {
              throw new ArgumentException(input, this.get_FullName());
            }
          }
label_24:
          switch (5)
          {
            case 0:
              goto label_24;
            default:
              return (object) fromString;
          }
      }
    }

    public ProjectToken Activator { get; set; }

    public TreeNodeAttribute CollectionAdd { get; set; }

    public ServerResolver DictionaryAdd { get; set; }

    public void DisconnectProject(string _param1) => this.parentKeywords = _param1;

    public void DisconnectProject()
    {
      this.parentKeywords = ClientTree.DisconnectProject(1984869) != 0;
    }

    public void DisposeDrive() => this.currentUri = ClientTree.DisconnectProject(1984873) != 0;

    public void ListQueue() => this.filterID = ClientTree.DisconnectProject(1984877) != 0;

    public void DisposeDrive(string _param1) => this.currentUri = _param1;

    public void ListQueue(string _param1) => this.filterID = _param1;

    public void EnableNetwork(string _param1)
    {
      if (this.parentKeywords == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (ActivatorOptions.EnableNetwork);
            }
            this.parentKeywords = new Dictionary<string, string>();
            break;
        }
      }
      this.parentKeywords.Add(_param1, NodeOptions.DisconnectProject(this.get_FullName(), DatabaseLoader.DisconnectProject(13894), _param1));
    }

    public void DisconnectProject(string _param1, object _param2)
    {
      if (this.parentKeywords == null)
        this.parentKeywords = new Dictionary<string, object>();
      this.parentKeywords.Add(_param1, _param2);
    }
  }
}
