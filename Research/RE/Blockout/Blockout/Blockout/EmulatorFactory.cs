// Decompiled with JetBrains decompiler
// Type: Blockout.EmulatorFactory
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace Blockout
{
  [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]
  [DebuggerNonUserCode]
  internal class EmulatorFactory : IXamlType
  {
    private string parentKeywords;
    private Type parentKeywords;

    public EmulatorFactory(string _param1, Type _param2)
    {
      this.parentKeywords = _param1;
      this.parentKeywords = _param2;
    }

    [SpecialName]
    public string get_FullName() => this.parentKeywords;

    [SpecialName]
    public Type get_UnderlyingType() => this.parentKeywords;

    [SpecialName]
    public virtual IXamlType get_BaseType() => throw new NotImplementedException();

    [SpecialName]
    public virtual IXamlMember get_ContentProperty() => throw new NotImplementedException();

    public virtual IXamlMember GetMember(string name) => throw new NotImplementedException();

    [SpecialName]
    public virtual bool get_IsArray() => throw new NotImplementedException();

    [SpecialName]
    public virtual bool get_IsCollection() => throw new NotImplementedException();

    [SpecialName]
    public virtual bool get_IsConstructible() => throw new NotImplementedException();

    [SpecialName]
    public virtual bool get_IsDictionary() => throw new NotImplementedException();

    [SpecialName]
    public virtual bool get_IsMarkupExtension() => throw new NotImplementedException();

    [SpecialName]
    public virtual bool get_IsBindable() => throw new NotImplementedException();

    [SpecialName]
    public virtual IXamlType get_ItemType() => throw new NotImplementedException();

    [SpecialName]
    public virtual IXamlType get_KeyType() => throw new NotImplementedException();

    public virtual object ActivateInstance() => throw new NotImplementedException();

    public virtual void AddToMap(object instance, object key, object item)
    {
      throw new NotImplementedException();
    }

    public virtual void AddToVector(object instance, object item)
    {
      throw new NotImplementedException();
    }

    public virtual void RunInitializer() => throw new NotImplementedException();

    public virtual object CreateFromString(string input) => throw new NotImplementedException();
  }
}
