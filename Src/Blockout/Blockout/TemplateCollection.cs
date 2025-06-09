// *************************************************************
// Type: Blockout.TemplateCollection
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

#nullable disable
namespace Blockout
{
  internal sealed class TemplateCollection
  {
    private const string parentKeywords = "_sessionState.xml";
    private static Dictionary<string, object> parentKeywords = new Dictionary<string, object>();
    private static List<Type> parentKeywords = new List<Type>();
    private static DependencyProperty parentKeywords = DependencyProperty.RegisterAttached(DatabaseLoader.DisconnectProject(13265), Type.GetTypeFromHandle(PaneService.DisconnectProject()), Type.GetTypeFromHandle(AddinConverter.DisconnectProject()), PcitureSite.parentKeywords);
    private static DependencyProperty currentUri = DependencyProperty.RegisterAttached(DatabaseLoader.DisconnectProject(13308), Type.GetTypeFromHandle(ReferenceHelper.DisconnectProject()), Type.GetTypeFromHandle(AddinConverter.DisconnectProject()), PcitureSite.parentKeywords);
    private static List<WeakReference<Frame>> parentKeywords = new List<WeakReference<Frame>>();

    [SpecialName]
    public static Dictionary<string, object> get_DisconnectProject()
    {
      return TemplateCollection.parentKeywords;
    }

    [SpecialName]
    public static List<Type> get_DisconnectProject() => TemplateCollection.parentKeywords;

    public static Task DisconnectProject()
    {
      // ISSUE: variable of a compiler-generated type
      TemplateCollection.PartitionAttribute stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ClientTree.DisconnectProject(1984717);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<TemplateCollection.PartitionAttribute>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    public static Task DisposeDrive()
    {
      // ISSUE: variable of a compiler-generated type
      TemplateCollection.PluginList stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = AsyncTaskMethodBuilder.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords = ClientTree.DisconnectProject(1984721);
      // ISSUE: reference to a compiler-generated field
      stateMachine.parentKeywords.Start<TemplateCollection.PluginList>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.parentKeywords.Task;
    }

    public static void DisconnectProject(Frame _param0, string _param1)
    {
      if (((DependencyObject) _param0).GetValue(TemplateCollection.parentKeywords) != null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TemplateCollection.DisconnectProject);
            }
            throw new InvalidOperationException(DatabaseLoader.DisconnectProject(12937));
        }
      }
      else if (((DependencyObject) _param0).GetValue(TemplateCollection.currentUri) != null)
      {
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
          default:
            throw new InvalidOperationException(DatabaseLoader.DisconnectProject(13046));
        }
      }
      else
      {
        ((DependencyObject) _param0).SetValue(TemplateCollection.parentKeywords, (object) _param1);
        TemplateCollection.parentKeywords.Add(new WeakReference<Frame>(_param0));
        TemplateCollection.DisposeDrive(_param0);
      }
    }

    public static void DisconnectProject(Frame _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      TemplateCollection.BuilderOptions builderOptions = new TemplateCollection.BuilderOptions();
      // ISSUE: reference to a compiler-generated field
      builderOptions.parentKeywords = _param0;
      // ISSUE: reference to a compiler-generated field
      TemplateCollection.get_DisconnectProject().Remove(DockingPane.DisconnectProject(((DependencyObject) builderOptions.parentKeywords).GetValue(TemplateCollection.parentKeywords)));
      // ISSUE: reference to a compiler-generated method
      TemplateCollection.parentKeywords.RemoveAll(new Predicate<WeakReference<Frame>>(builderOptions.DisconnectProject));
    }

    public static Dictionary<string, object> DisconnectProject(Frame _param0)
    {
      Dictionary<string, object> dictionary = DriveConverter.DisconnectProject(((DependencyObject) _param0).GetValue(TemplateCollection.currentUri));
      if (dictionary == null)
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (TemplateCollection.DisconnectProject);
            }
            string key = DockingPane.DisconnectProject(((DependencyObject) _param0).GetValue(TemplateCollection.parentKeywords));
            if (key != null)
            {
label_5:
              switch (1)
              {
                case 0:
                  goto label_5;
                default:
                  if (!TemplateCollection.parentKeywords.ContainsKey(key))
                  {
label_7:
                    switch (6)
                    {
                      case 0:
                        goto label_7;
                      default:
                        TemplateCollection.parentKeywords[key] = (object) new Dictionary<string, object>();
                        break;
                    }
                  }
                  dictionary = DriveConverter.DisconnectProject(TemplateCollection.parentKeywords[key]);
                  break;
              }
            }
            else
              dictionary = new Dictionary<string, object>();
            ((DependencyObject) _param0).SetValue(TemplateCollection.currentUri, (object) dictionary);
            break;
        }
      }
      return dictionary;
    }

    private static void DisposeDrive(Frame _param0)
    {
      Dictionary<string, object> dictionary = TemplateCollection.DisconnectProject(_param0);
      if (!dictionary.ContainsKey(DatabaseLoader.DisconnectProject(13244)))
        return;
      _param0.SetNavigationState(DockingPane.DisconnectProject(dictionary[DatabaseLoader.DisconnectProject(13244)]));
    }

    private static void ListQueue(Frame _param0)
    {
      TemplateCollection.DisconnectProject(_param0)[DatabaseLoader.DisconnectProject(13244)] = (object) _param0.GetNavigationState();
    }
  }
}
