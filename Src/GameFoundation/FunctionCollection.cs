// *************************************************************
// Type: GameFoundation.FunctionCollection
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;

#nullable disable
namespace GameFoundation
{
  internal static class FunctionCollection
  {
    internal static string DisconnectProject()
    {
      string parentCancel = FunctionResolver.parentCancel;
      string namesId = FunctionResolver.namesID;
      string stringToEscape = ResourceSerializer.DisconnectProject(namesId, EditorService.DisconnectProject(1908));
      string format = EditorService.DisconnectProject(1929);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2389));
      objArray1[ReferenceInvoker.DisconnectProject(2393)] = (object) Uri.EscapeDataString(namesId);
      objArray1[ReferenceInvoker.DisconnectProject(2397)] = (object) Uri.EscapeDataString(EditorService.DisconnectProject(2069));
      objArray1[ReferenceInvoker.DisconnectProject(2401)] = (object) Uri.EscapeDataString(stringToEscape);
      object[] objArray2 = objArray1;
      return string.Format(format, objArray2);
    }

    internal static string DisposeDrive()
    {
      string namesId = FunctionResolver.namesID;
      string parentKeywords = FunctionResolver.parentKeywords;
      string currentUri = FunctionResolver.currentUri;
      string filterId = FunctionResolver.filterID;
      string idToken = FunctionResolver.idToken;
      string currentNode = FunctionResolver.currentNode;
      string parentCancel = FunctionResolver.parentCancel;
      string[] strArray = RegistryInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(2405));
      strArray[ReferenceInvoker.DisconnectProject(2409)] = namesId;
      strArray[ReferenceInvoker.DisconnectProject(2413)] = EditorService.DisconnectProject(2086);
      strArray[ReferenceInvoker.DisconnectProject(2417)] = idToken;
      strArray[ReferenceInvoker.DisconnectProject(2421)] = EditorService.DisconnectProject(2089);
      strArray[ReferenceInvoker.DisconnectProject(2425)] = currentNode;
      strArray[ReferenceInvoker.DisconnectProject(2429)] = EditorService.DisconnectProject(2094);
      string stringToEscape = IconSite.DisconnectProject(strArray);
      string format = EditorService.DisconnectProject(2099);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2433));
      objArray1[ReferenceInvoker.DisconnectProject(2437)] = (object) Uri.EscapeDataString(namesId);
      objArray1[ReferenceInvoker.DisconnectProject(2441)] = (object) Uri.EscapeDataString(idToken);
      objArray1[ReferenceInvoker.DisconnectProject(2445)] = (object) Uri.EscapeDataString(currentNode);
      objArray1[ReferenceInvoker.DisconnectProject(2449)] = (object) Uri.EscapeDataString(parentKeywords);
      objArray1[ReferenceInvoker.DisconnectProject(2453)] = (object) Uri.EscapeDataString(currentUri);
      objArray1[ReferenceInvoker.DisconnectProject(2457)] = (object) Uri.EscapeDataString(filterId);
      objArray1[ReferenceInvoker.DisconnectProject(2461)] = (object) Uri.EscapeDataString(parentCancel);
      objArray1[ReferenceInvoker.DisconnectProject(2465)] = (object) Uri.EscapeDataString(stringToEscape);
      objArray1[ReferenceInvoker.DisconnectProject(2469)] = (object) Uri.EscapeDataString(EditorService.DisconnectProject(2069));
      object[] objArray2 = objArray1;
      return string.Format(format, objArray2);
    }

    internal static string ListQueue()
    {
      string str1 = EditorService.DisconnectProject(2309);
      string namesId = FunctionResolver.namesID;
      string str2 = str1;
      string format = EditorService.DisconnectProject(2414);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2473));
      objArray1[ReferenceInvoker.DisconnectProject(2477)] = (object) Uri.EscapeDataString(namesId);
      objArray1[ReferenceInvoker.DisconnectProject(2481)] = (object) Uri.EscapeDataString(EditorService.DisconnectProject(2069));
      object[] objArray2 = objArray1;
      string str3 = string.Format(format, objArray2);
      return ResourceSerializer.DisconnectProject(str2, str3);
    }

    internal static string[] DisconnectProject()
    {
      string[] strArray1 = RegistryInvoker.DisconnectProject(ReferenceInvoker.DisconnectProject(2485));
      string namesId = FunctionResolver.namesID;
      strArray1[ReferenceInvoker.DisconnectProject(2489)] = EditorService.DisconnectProject(2437);
      string[] strArray2 = strArray1;
      int index = ReferenceInvoker.DisconnectProject(2493);
      string format = EditorService.DisconnectProject(2414);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2497));
      objArray1[ReferenceInvoker.DisconnectProject(2501)] = (object) Uri.EscapeDataString(namesId);
      objArray1[ReferenceInvoker.DisconnectProject(2505)] = (object) Uri.EscapeDataString(EditorService.DisconnectProject(2069));
      object[] objArray2 = objArray1;
      string str = string.Format(format, objArray2);
      strArray2[index] = str;
      return strArray1;
    }

    internal static string EnableNetwork()
    {
      string str1 = EditorService.DisconnectProject(2538);
      string namesId = FunctionResolver.namesID;
      string str2 = str1;
      string format = EditorService.DisconnectProject(2414);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2509));
      objArray1[ReferenceInvoker.DisconnectProject(2513)] = (object) Uri.EscapeDataString(namesId);
      objArray1[ReferenceInvoker.DisconnectProject(2517)] = (object) Uri.EscapeDataString(EditorService.DisconnectProject(2069));
      object[] objArray2 = objArray1;
      string str3 = string.Format(format, objArray2);
      return ResourceSerializer.DisconnectProject(str2, str3);
    }

    internal static string TestConnection()
    {
      string str1 = EditorService.DisconnectProject(2645);
      string namesId = FunctionResolver.namesID;
      string str2 = str1;
      string format = EditorService.DisconnectProject(2414);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2521));
      objArray1[ReferenceInvoker.DisconnectProject(2525)] = (object) Uri.EscapeDataString(namesId);
      objArray1[ReferenceInvoker.DisconnectProject(2529)] = (object) Uri.EscapeDataString(EditorService.DisconnectProject(2069));
      object[] objArray2 = objArray1;
      string str3 = string.Format(format, objArray2);
      return ResourceSerializer.DisconnectProject(str2, str3);
    }

    internal static string DisconnectProject(string _param0) => ViewSet.parentKeywords;

    internal static string ExtractDockingPane()
    {
      return string.Format(EditorService.DisconnectProject(2760), DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2533)));
    }

    internal static string LoadDirectory()
    {
      string namesId = FunctionResolver.namesID;
      string format = EditorService.DisconnectProject(2871);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2537));
      objArray1[ReferenceInvoker.DisconnectProject(2541)] = (object) Uri.EscapeDataString(namesId);
      object[] objArray2 = objArray1;
      return string.Format(format, objArray2);
    }

    internal static string SelectResource()
    {
      string str1 = EditorService.DisconnectProject(2998);
      string namesId = FunctionResolver.namesID;
      string str2 = str1;
      string format = EditorService.DisconnectProject(3128);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2545));
      objArray1[ReferenceInvoker.DisconnectProject(2549)] = (object) Uri.EscapeDataString(namesId);
      object[] objArray2 = objArray1;
      string str3 = string.Format(format, objArray2);
      return ResourceSerializer.DisconnectProject(str2, str3);
    }

    internal static string EnableDockingPane()
    {
      string str1 = EditorService.DisconnectProject(3139);
      string namesId = FunctionResolver.namesID;
      string str2 = str1;
      string format = EditorService.DisconnectProject(3128);
      object[] objArray1 = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2553));
      objArray1[ReferenceInvoker.DisconnectProject(2557)] = (object) Uri.EscapeDataString(namesId);
      object[] objArray2 = objArray1;
      string str3 = string.Format(format, objArray2);
      return ResourceSerializer.DisconnectProject(str2, str3);
    }
  }
}
