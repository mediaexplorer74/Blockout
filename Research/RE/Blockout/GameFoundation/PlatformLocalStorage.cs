// Decompiled with JetBrains decompiler
// Type: GameFoundation.PlatformLocalStorage
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Windows.Storage;

#nullable disable
namespace GameFoundation
{
  public static class PlatformLocalStorage
  {
    public static bool DirectoryExists(string directory)
    {
      if (string.IsNullOrEmpty(directory))
        return ReferenceInvoker.DisconnectProject(2205) != 0;
      bool flag = ReferenceInvoker.DisconnectProject(2209) != 0;
      try
      {
        flag = PlatformLocalStorage.DisconnectProject(directory);
      }
      catch (Exception ex)
      {
      }
      return flag;
    }

    private static bool DisconnectProject(string _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.TextFileScope textFileScope = new PlatformLocalStorage.TextFileScope();
      // ISSUE: reference to a compiler-generated field
      textFileScope.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      textFileScope.parentKeywords = ApplicationData.Current.LocalFolder;
      StorageFolder parentKeywords = DiskManager.parentKeywords;
      // ISSUE: reference to a compiler-generated method
      if (AssemblyInfo.DisconnectProject<StorageFolder>(new Func<Task<StorageFolder>>(textFileScope.DisconnectProject)) == null)
        return ReferenceInvoker.DisconnectProject(2217) != 0;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
          }
          return ReferenceInvoker.DisconnectProject(2213) != 0;
      }
    }

    private static Task<StorageFolder> DisconnectProject(string _param0, StorageFolder _param1)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ToolboxStream stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<StorageFolder>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2221);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.ToolboxStream>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    public static bool FileExists(string filename)
    {
      if (string.IsNullOrEmpty(filename))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.FileExists);
            }
            return ReferenceInvoker.DisconnectProject(2225) != 0;
        }
      }
      else
      {
        bool flag = ReferenceInvoker.DisconnectProject(2229) != 0;
        try
        {
          flag = PlatformLocalStorage.DisposeDrive(filename);
        }
        catch (Exception ex)
        {
        }
        return flag;
      }
    }

    private static bool DisposeDrive(string _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ConnectionProvider connectionProvider = new PlatformLocalStorage.ConnectionProvider();
      // ISSUE: reference to a compiler-generated field
      connectionProvider.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      connectionProvider.parentKeywords = ApplicationData.Current.LocalFolder;
      StorageFile parentKeywords = ContextResolver.parentKeywords;
      // ISSUE: reference to a compiler-generated method
      if (AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(connectionProvider.DisconnectProject)) == null)
        return ReferenceInvoker.DisconnectProject(2237) != 0;
label_1:
      switch (4)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisposeDrive);
          }
          return ReferenceInvoker.DisconnectProject(2233) != 0;
      }
    }

    private static Task<StorageFile> DisconnectProject(string _param0, StorageFolder _param1)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.CommandSerializer stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<StorageFile>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2241);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.CommandSerializer>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    internal static string[] DisconnectProject(string _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ConditionSite conditionSite = new PlatformLocalStorage.ConditionSite()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      conditionSite.currentUri = AssemblyInfo.DisconnectProject<StorageFolder>(new Func<Task<StorageFolder>>(conditionSite.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (conditionSite.currentUri == null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            }
            return (string[]) null;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        IReadOnlyList<StorageFile> storageFileList = AssemblyInfo.DisconnectProject<IReadOnlyList<StorageFile>>(new Func<Task<IReadOnlyList<StorageFile>>>(conditionSite.DisconnectProject));
        List<string> stringList = new List<string>();
        IEnumerator<StorageFile> enumerator = storageFileList.GetEnumerator();
        try
        {
          while (enumerator.MoveNext())
          {
            StorageFile current = enumerator.Current;
            stringList.Add(current.Name);
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_10:
            switch (1)
            {
              case 0:
                goto label_10;
              default:
                enumerator.Dispose();
                break;
            }
          }
        }
        return stringList.ToArray();
      }
    }

    public static bool SerializeObjectToFile(string filename, object toSerialize)
    {
      if (toSerialize == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.SerializeObjectToFile);
            }
            return ReferenceInvoker.DisconnectProject(2245) != 0;
        }
      }
      else
      {
        string filename1 = filename;
        object[] objArray = DomainFactory.DisconnectProject(ReferenceInvoker.DisconnectProject(2249));
        objArray[ReferenceInvoker.DisconnectProject(2253)] = toSerialize;
        object[] toSerialize1 = objArray;
        return PlatformLocalStorage.SerializeObjectsToFile(filename1, toSerialize1);
      }
    }

    public static bool SerializeObjectsToFile(string filename, object[] toSerialize)
    {
      if (!string.IsNullOrEmpty(filename))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.SerializeObjectsToFile);
            }
            if (toSerialize != null)
            {
              try
              {
                PlatformLocalStorage.DisconnectProject(filename, toSerialize);
              }
              catch
              {
                return ReferenceInvoker.DisconnectProject(2261) != 0;
              }
              return ReferenceInvoker.DisconnectProject(2265) != 0;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(2257) != 0;
    }

    private static void DisconnectProject(string _param0, object[] _param1)
    {
      Func<Task<Stream>> func = ToolbarResolver.parentKeywords;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.AspectTree aspectTree = new PlatformLocalStorage.AspectTree()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      aspectTree.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(aspectTree.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (aspectTree.parentKeywords == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            break;
        }
      }
      else
      {
        if (func == null)
        {
label_6:
          switch (3)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated method
              func = new Func<Task<Stream>>(aspectTree.DisconnectProject);
              break;
          }
        }
        Stream stream = AssemblyInfo.DisconnectProject<Stream>(func);
        try
        {
          for (int index = ReferenceInvoker.DisconnectProject(2269); index < (int) BitmapStream.DisconnectProject(_param1); index += ReferenceInvoker.DisconnectProject(2273))
          {
            object graph = _param1[index];
            new DataContractSerializer(graph.GetType()).WriteObject(stream, graph);
          }
label_12:
          switch (6)
          {
            case 0:
              goto label_12;
          }
        }
        finally
        {
          if (stream != null)
          {
label_15:
            switch (3)
            {
              case 0:
                goto label_15;
              default:
                stream.Dispose();
                break;
            }
          }
        }
      }
    }

    private static Task<StorageFile> DisposeDrive(string _param0, StorageFolder _param1)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.StoreHelper stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<StorageFile>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2277);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.StoreHelper>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    private static Task<StorageFolder> DisposeDrive(string _param0, StorageFolder _param1)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.MenuItemFactory stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<StorageFolder>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2281);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.MenuItemFactory>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    private static Task<Stream> DisconnectProject(StorageFile _param0, bool _param1)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ConnectionHelper stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<Stream>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2285);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.ConnectionHelper>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    public static object DeserializeObjectFromFile(string filename, Type typeExpected)
    {
      if (!string.IsNullOrEmpty(filename))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DeserializeObjectFromFile);
            }
            if ((object) typeExpected != null)
            {
              try
              {
                return PlatformLocalStorage.DisconnectProject(filename, typeExpected);
              }
              catch
              {
              }
              return (object) null;
            }
            break;
        }
      }
      return (object) null;
    }

    private static object DisconnectProject(string _param0, Type _param1)
    {
      Func<Task<Stream>> func = ToolbarResolver.parentKeywords;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ResourceSet resourceSet = new PlatformLocalStorage.ResourceSet()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      resourceSet.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(resourceSet.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (resourceSet.parentKeywords == null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            }
            return (object) null;
        }
      }
      else
      {
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated method
          func = new Func<Task<Stream>>(resourceSet.DisconnectProject);
        }
        using (Stream stream = AssemblyInfo.DisconnectProject<Stream>(func))
        {
          object parentKeywords = TextFileSet.parentKeywords;
          object obj = new DataContractSerializer(_param1).ReadObject(stream);
          if (obj != null)
          {
label_9:
            switch (6)
            {
              case 0:
                goto label_9;
              default:
                if ((object) obj.GetType() == (object) _param1)
                  return obj;
label_11:
                switch (2)
                {
                  case 0:
                    goto label_11;
                }
                break;
            }
          }
          return TextFileSet.parentKeywords;
        }
      }
    }

    public static object[] DeserializeObjectsFromFile(string filename, Type[] typesExpected)
    {
      return string.IsNullOrEmpty(filename) ? (object[]) null : PlatformLocalStorage.DisconnectProject(filename, typesExpected);
    }

    private static object[] DisconnectProject(string _param0, Type[] _param1)
    {
      Func<Task<Stream>> func = ToolbarResolver.parentKeywords;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.BuilderScope builderScope = new PlatformLocalStorage.BuilderScope()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      builderScope.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(builderScope.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (builderScope.parentKeywords == null)
      {
label_1:
        switch (3)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            }
            return (object[]) null;
        }
      }
      else
      {
        if (func == null)
        {
label_6:
          switch (1)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated method
              func = new Func<Task<Stream>>(builderScope.DisconnectProject);
              break;
          }
        }
        Stream stream = AssemblyInfo.DisconnectProject<Stream>(func);
        try
        {
          object[] objArray = DomainFactory.DisconnectProject((int) PluginQueue.DisconnectProject(_param1));
          for (int index = ReferenceInvoker.DisconnectProject(2289); index < (int) PluginQueue.DisconnectProject(_param1); index += ReferenceInvoker.DisconnectProject(2293))
          {
            Type type = _param1[index];
            object obj = new DataContractSerializer(type).ReadObject(stream);
            if (obj != null)
            {
              if ((object) obj.GetType() != (object) type)
              {
label_12:
                switch (4)
                {
                  case 0:
                    goto label_12;
                }
              }
              else
              {
                objArray[index] = obj;
                continue;
              }
            }
            return ControlSet.parentKeywords;
          }
          return objArray;
        }
        finally
        {
          if (stream != null)
          {
label_18:
            switch (2)
            {
              case 0:
                goto label_18;
              default:
                stream.Dispose();
                break;
            }
          }
        }
      }
    }

    public static string LoadTextFromFile(string filename)
    {
      if (string.IsNullOrEmpty(filename))
        return (string) null;
      string str = ViewSet.parentKeywords;
      try
      {
        str = PlatformLocalStorage.DisconnectProject(filename);
      }
      catch
      {
      }
      return str;
    }

    private static string DisconnectProject(string _param0)
    {
      Func<Task<Stream>> func = ToolbarResolver.parentKeywords;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.QueueTree queueTree = new PlatformLocalStorage.QueueTree();
      // ISSUE: reference to a compiler-generated field
      queueTree.parentKeywords = _param0;
      string parentKeywords = ViewSet.parentKeywords;
      // ISSUE: reference to a compiler-generated field
      queueTree.parentKeywords = ApplicationData.Current.LocalFolder;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      queueTree.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(queueTree.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (queueTree.parentKeywords == null)
        return (string) null;
      if (func == null)
      {
label_3:
        switch (4)
        {
          case 0:
            goto label_3;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            }
            // ISSUE: reference to a compiler-generated method
            func = new Func<Task<Stream>>(queueTree.DisconnectProject);
            break;
        }
      }
      StreamReader streamReader = new StreamReader(AssemblyInfo.DisconnectProject<Stream>(func));
      try
      {
        return streamReader.ReadToEnd();
      }
      finally
      {
        if (streamReader != null)
        {
label_10:
          switch (4)
          {
            case 0:
              goto label_10;
            default:
              streamReader.Dispose();
              break;
          }
        }
      }
    }

    public static bool SaveTextToFile(string filename, string contentForFile)
    {
      if (!string.IsNullOrEmpty(filename))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.SaveTextToFile);
            }
            if (contentForFile == null)
            {
label_5:
              switch (3)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              try
              {
                PlatformLocalStorage.DisconnectProject(filename, contentForFile);
              }
              catch
              {
                return ReferenceInvoker.DisconnectProject(2301) != 0;
              }
              return ReferenceInvoker.DisconnectProject(2305) != 0;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(2297) != 0;
    }

    private static void DisconnectProject(string _param0, string _param1)
    {
      Func<Task<Stream>> func = ToolbarResolver.parentKeywords;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.TreeNode treeNode = new PlatformLocalStorage.TreeNode()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      treeNode.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(treeNode.DisconnectProject));
      if (func == null)
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            }
            // ISSUE: reference to a compiler-generated method
            func = new Func<Task<Stream>>(treeNode.DisconnectProject);
            break;
        }
      }
      StreamWriter streamWriter = new StreamWriter(AssemblyInfo.DisconnectProject<Stream>(func));
      try
      {
        streamWriter.Write(_param1);
      }
      finally
      {
        if (streamWriter != null)
        {
label_8:
          switch (5)
          {
            case 0:
              goto label_8;
            default:
              streamWriter.Dispose();
              break;
          }
        }
      }
    }

    public static bool DeleteFiles(string baseDirectory)
    {
      if (string.IsNullOrEmpty(baseDirectory))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DeleteFiles);
            }
            return ReferenceInvoker.DisconnectProject(2309) != 0;
        }
      }
      else
      {
        try
        {
          PlatformLocalStorage.DisconnectProject(baseDirectory);
        }
        catch
        {
          return ReferenceInvoker.DisconnectProject(2313) != 0;
        }
        return ReferenceInvoker.DisconnectProject(2317) != 0;
      }
    }

    private static Task<IReadOnlyList<StorageFile>> DisconnectProject(StorageFolder _param0)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.TreeNodeEditor stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<IReadOnlyList<StorageFile>>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2321);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.TreeNodeEditor>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    private static void DisconnectProject(string _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.SolutionProvider solutionProvider = new PlatformLocalStorage.SolutionProvider()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      solutionProvider.currentUri = AssemblyInfo.DisconnectProject<StorageFolder>(new Func<Task<StorageFolder>>(solutionProvider.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (solutionProvider.currentUri == null)
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
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisconnectProject);
            break;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        IEnumerator<StorageFile> enumerator = AssemblyInfo.DisconnectProject<IReadOnlyList<StorageFile>>(new Func<Task<IReadOnlyList<StorageFile>>>(solutionProvider.DisconnectProject)).GetEnumerator();
        try
        {
          while (enumerator.MoveNext())
          {
            Func<Task<bool>> func = PathInvoker.parentKeywords;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            PlatformLocalStorage.AddinLoader addinLoader = new PlatformLocalStorage.AddinLoader();
            // ISSUE: reference to a compiler-generated field
            addinLoader.parentKeywords = solutionProvider;
            // ISSUE: reference to a compiler-generated field
            addinLoader.parentKeywords = enumerator.Current;
            if (func == null)
            {
label_8:
              switch (4)
              {
                case 0:
                  goto label_8;
                default:
                  // ISSUE: reference to a compiler-generated method
                  func = new Func<Task<bool>>(addinLoader.DisconnectProject);
                  break;
              }
            }
            AssemblyInfo.DisconnectProject<bool>(func);
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_14:
            switch (3)
            {
              case 0:
                goto label_14;
              default:
                enumerator.Dispose();
                break;
            }
          }
        }
      }
    }

    public static bool CreateDirectory(string directoryToCreate)
    {
      if (string.IsNullOrEmpty(directoryToCreate))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.CreateDirectory);
            }
            return ReferenceInvoker.DisconnectProject(2325) != 0;
        }
      }
      else
      {
        try
        {
          PlatformLocalStorage.DisposeDrive(directoryToCreate);
        }
        catch
        {
          return ReferenceInvoker.DisconnectProject(2329) != 0;
        }
        return ReferenceInvoker.DisconnectProject(2333) != 0;
      }
    }

    private static void DisposeDrive(string _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      AssemblyInfo.DisconnectProject<StorageFolder>(new Func<Task<StorageFolder>>(new PlatformLocalStorage.DirectoryFactory()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      }.DisconnectProject));
    }

    public static bool RequestAdditionalStorageIfNotEnough()
    {
      return ReferenceInvoker.DisconnectProject(2337) != 0;
    }

    public static bool DeleteFile(string fileToRemove)
    {
      if (string.IsNullOrEmpty(fileToRemove))
        return ReferenceInvoker.DisconnectProject(2341) != 0;
      try
      {
        PlatformLocalStorage.ListQueue(fileToRemove);
      }
      catch
      {
        return ReferenceInvoker.DisconnectProject(2345) != 0;
      }
      return ReferenceInvoker.DisconnectProject(2349) != 0;
    }

    private static void ListQueue(string _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.PcitureResolver pcitureResolver = new PlatformLocalStorage.PcitureResolver()
      {
        parentKeywords = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      pcitureResolver.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(pcitureResolver.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      if (pcitureResolver.parentKeywords == null)
      {
label_1:
        switch (5)
        {
          case 0:
            goto label_1;
          default:
            if (true)
              break;
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.ListQueue);
            break;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        AssemblyInfo.DisconnectProject<bool>(new Func<Task<bool>>(pcitureResolver.DisconnectProject));
      }
    }

    private static Task<bool> DisconnectProject(StorageFile _param0)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ResourceDictionary stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<bool>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2353);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.ResourceDictionary>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    public static bool MoveFile(string sourceFile, string targetFile)
    {
      if (!string.IsNullOrEmpty(sourceFile))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.MoveFile);
            }
            if (string.IsNullOrEmpty(targetFile))
            {
label_5:
              switch (5)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              try
              {
                PlatformLocalStorage.DisposeDrive(sourceFile, targetFile);
              }
              catch
              {
                return ReferenceInvoker.DisconnectProject(2361) != 0;
              }
              return ReferenceInvoker.DisconnectProject(2365) != 0;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(2357) != 0;
    }

    private static void DisposeDrive(string _param0, string _param1)
    {
      Func<Task<StorageFolder>> func = Form.parentKeywords;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ToolbarDesigner toolbarDesigner1 = new PlatformLocalStorage.ToolbarDesigner()
      {
        filterID = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      toolbarDesigner1.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(toolbarDesigner1.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      toolbarDesigner1.parentKeywords = Path.GetDirectoryName(_param1);
      // ISSUE: reference to a compiler-generated field
      toolbarDesigner1.currentUri = Path.GetFileName(_param1);
      // ISSUE: reference to a compiler-generated field
      toolbarDesigner1.currentUri = DiskManager.parentKeywords;
      // ISSUE: reference to a compiler-generated field
      if (string.IsNullOrEmpty(toolbarDesigner1.parentKeywords))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.DisposeDrive);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            toolbarDesigner1.currentUri = toolbarDesigner1.parentKeywords;
            break;
        }
      }
      else
      {
        // ISSUE: variable of a compiler-generated type
        PlatformLocalStorage.ToolbarDesigner toolbarDesigner2 = toolbarDesigner1;
        if (func == null)
        {
label_6:
          switch (7)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated method
              func = new Func<Task<StorageFolder>>(toolbarDesigner1.DisconnectProject);
              break;
          }
        }
        StorageFolder storageFolder = AssemblyInfo.DisconnectProject<StorageFolder>(func);
        // ISSUE: reference to a compiler-generated field
        toolbarDesigner2.currentUri = storageFolder;
      }
      // ISSUE: reference to a compiler-generated method
      AssemblyInfo.DisconnectProject<bool>(new Func<Task<bool>>(toolbarDesigner1.DisconnectProject));
    }

    private static Task<bool> DisconnectProject(
      StorageFile _param0,
      StorageFolder _param1,
      string _param2)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.NodeDictionary stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param2;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<bool>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2369);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.NodeDictionary>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    public static bool CopyFile(string sourceFile, string targetFile)
    {
      if (!string.IsNullOrEmpty(sourceFile))
      {
label_1:
        switch (2)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (PlatformLocalStorage.CopyFile);
            }
            if (string.IsNullOrEmpty(targetFile))
            {
label_5:
              switch (7)
              {
                case 0:
                  goto label_5;
              }
            }
            else
            {
              try
              {
                PlatformLocalStorage.ListQueue(sourceFile, targetFile);
              }
              catch
              {
                return ReferenceInvoker.DisconnectProject(2377) != 0;
              }
              return ReferenceInvoker.DisconnectProject(2381) != 0;
            }
            break;
        }
      }
      return ReferenceInvoker.DisconnectProject(2373) != 0;
    }

    private static void ListQueue(string _param0, string _param1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.ConfigCollection configCollection = new PlatformLocalStorage.ConfigCollection()
      {
        filterID = _param0,
        parentKeywords = ApplicationData.Current.LocalFolder
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      configCollection.parentKeywords = AssemblyInfo.DisconnectProject<StorageFile>(new Func<Task<StorageFile>>(configCollection.DisconnectProject));
      // ISSUE: reference to a compiler-generated field
      configCollection.parentKeywords = Path.GetDirectoryName(_param1);
      // ISSUE: reference to a compiler-generated field
      configCollection.currentUri = Path.GetFileName(_param1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      configCollection.currentUri = AssemblyInfo.DisconnectProject<StorageFolder>(new Func<Task<StorageFolder>>(configCollection.DisconnectProject));
      // ISSUE: reference to a compiler-generated method
      AssemblyInfo.DisconnectProject<bool>(new Func<Task<bool>>(configCollection.DisconnectProject));
    }

    private static Task<bool> DisposeDrive(
      StorageFile _param0,
      StorageFolder _param1,
      string _param2)
    {
      // ISSUE: variable of a compiler-generated type
      PlatformLocalStorage.TextFileManager stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = _param2;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder<bool>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ReferenceInvoker.DisconnectProject(2385);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<PlatformLocalStorage.TextFileManager>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }
  }
}
