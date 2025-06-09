// Decompiled with JetBrains decompiler
// Type: BlockoutRt.Program
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\Blockout.exe

using System.CodeDom.Compiler;
using System.Diagnostics;
using Windows.UI.Xaml;

#nullable disable
namespace BlockoutRt
{
  public static class Program
  {
    [DebuggerNonUserCode]
    [GeneratedCode("Microsoft.Windows.UI.Xaml.Build.Tasks", " 4.0.0.0")]
    private static void DisconnectProject(string[] _param0_1)
    {
      App app;
      Application.Start((ApplicationInitializationCallback) (_param0_2 => app = new App()));
    }
  }
}
