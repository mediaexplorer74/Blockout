// *************************************************************
// Type: Blockout.FunctionLoader
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Markup;

#nullable disable
namespace Blockout
{
  [DebuggerNonUserCode]
  [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]
  internal sealed class FunctionLoader : IXamlMember
  {
    private SymbolContext parentKeywords;
    private string parentKeywords;
    private bool parentKeywords;
    private bool currentUri;
    private bool filterID;
    private string currentUri;
    private string filterID;

    public FunctionLoader(SymbolContext _param1, string _param2, string _param3)
    {
      this.parentKeywords = _param2;
      this.currentUri = _param3;
      this.parentKeywords = _param1;
    }

    [SpecialName]
    public string get_Name() => this.parentKeywords;

    [SpecialName]
    public IXamlType get_Type() => this.parentKeywords.DisconnectProject(this.currentUri);

    public void DisconnectProject(string _param1) => this.filterID = _param1;

    [SpecialName]
    public IXamlType get_TargetType() => this.parentKeywords.DisconnectProject(this.filterID);

    public void DisconnectProject()
    {
      this.parentKeywords = ClientTree.DisconnectProject(1984881) != 0;
    }

    [SpecialName]
    public bool get_IsAttachable() => this.parentKeywords;

    public void DisposeDrive() => this.currentUri = ClientTree.DisconnectProject(1984885) != 0;

    [SpecialName]
    public bool get_IsDependencyProperty() => this.currentUri;

    public void ListQueue() => this.filterID = ClientTree.DisconnectProject(1984889) != 0;

    [SpecialName]
    public bool get_IsReadOnly() => this.filterID;

    public ProjectInvoker Getter { get; set; }

    public object GetValue(object instance)
    {
      if (this.Getter == null)
        throw new InvalidOperationException(DatabaseLoader.DisconnectProject(13897));
label_1:
      switch (5)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (FunctionLoader.GetValue);
          }
          return this.Getter(instance);
      }
    }

    public ProcessStack Setter { get; set; }

    public void SetValue(object instance, object value)
    {
      if (this.Setter == null)
        throw new InvalidOperationException(DatabaseLoader.DisconnectProject(13914));
      this.Setter(instance, value);
    }
  }
}
