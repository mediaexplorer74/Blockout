// Decompiled with JetBrains decompiler
// Type: GameFoundation.AssemblyInfo
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace GameFoundation
{
  internal static class AssemblyInfo
  {
    internal static void DisconnectProject(Func<Task> _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      AssemblyInfo.StreamResolver streamResolver = new AssemblyInfo.StreamResolver();
      // ISSUE: reference to a compiler-generated field
      streamResolver.parentKeywords = _param0;
      SynchronizationContext current = SynchronizationContext.Current;
      // ISSUE: reference to a compiler-generated field
      streamResolver.parentKeywords = new AssemblyInfo.ProcessScope();
      // ISSUE: reference to a compiler-generated field
      SynchronizationContext.SetSynchronizationContext((SynchronizationContext) streamResolver.parentKeywords);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      streamResolver.parentKeywords.Post(new SendOrPostCallback(streamResolver.DisconnectProject), TextFileSet.parentKeywords);
      // ISSUE: reference to a compiler-generated field
      streamResolver.parentKeywords.DisposeDrive();
      SynchronizationContext.SetSynchronizationContext(current);
    }

    internal static A DisconnectProject<A>(Func<Task<A>> _param0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      AssemblyInfo.TextFileConverter<A> textFileConverter = new AssemblyInfo.TextFileConverter<A>();
      // ISSUE: reference to a compiler-generated field
      textFileConverter.parentKeywords = (AssemblyInfo.ProcessScope) _param0;
      SynchronizationContext current = SynchronizationContext.Current;
      // ISSUE: reference to a compiler-generated field
      textFileConverter.parentKeywords = new AssemblyInfo.ProcessScope();
      // ISSUE: reference to a compiler-generated field
      SynchronizationContext.SetSynchronizationContext((SynchronizationContext) textFileConverter.parentKeywords);
      // ISSUE: reference to a compiler-generated field
      textFileConverter.parentKeywords = (AssemblyInfo.ProcessScope) default (A);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      textFileConverter.parentKeywords.Post(new SendOrPostCallback(textFileConverter.DisconnectProject), TextFileSet.parentKeywords);
      // ISSUE: reference to a compiler-generated field
      textFileConverter.parentKeywords.DisposeDrive();
      SynchronizationContext.SetSynchronizationContext(current);
      // ISSUE: reference to a compiler-generated field
      return (A) textFileConverter.parentKeywords;
    }

    private sealed class ProcessScope : SynchronizationContext
    {
      private bool parentKeywords;
      private readonly AutoResetEvent parentKeywords = new AutoResetEvent(ReferenceInvoker.DisconnectProject(1905) != 0);
      private readonly Queue<Tuple<SendOrPostCallback, object>> parentKeywords = new Queue<Tuple<SendOrPostCallback, object>>();

      public Exception InnerException { get; set; }

      public override void Send(SendOrPostCallback d, object state)
      {
        throw new NotSupportedException(EditorService.DisconnectProject(1508));
      }

      public override void Post(SendOrPostCallback d, object state)
      {
        bool lockTaken = ReferenceInvoker.DisconnectProject(1889) != 0;
        Queue<Tuple<SendOrPostCallback, object>> parentKeywords;
        try
        {
          Monitor.Enter((object) (parentKeywords = this.parentKeywords), ref lockTaken);
          this.parentKeywords.Enqueue(Tuple.Create<SendOrPostCallback, object>(d, state));
        }
        finally
        {
          if (lockTaken)
          {
label_3:
            switch (5)
            {
              case 0:
                goto label_3;
              default:
                if (false)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (AssemblyInfo.ProcessScope.Post);
                }
                Monitor.Exit((object) parentKeywords);
                break;
            }
          }
        }
        this.parentKeywords.Set();
      }

      public void DisconnectProject()
      {
        this.Post((SendOrPostCallback) (_param1 => this.parentKeywords = ReferenceInvoker.DisconnectProject(1901) != 0), TextFileSet.parentKeywords);
      }

      public void DisposeDrive()
      {
        while (!this.parentKeywords)
        {
          Tuple<SendOrPostCallback, object> tuple = IconEditor.parentKeywords;
          bool lockTaken = ReferenceInvoker.DisconnectProject(1893) != 0;
          Queue<Tuple<SendOrPostCallback, object>> parentKeywords;
          try
          {
            Monitor.Enter((object) (parentKeywords = this.parentKeywords), ref lockTaken);
            if (this.parentKeywords.Count > ReferenceInvoker.DisconnectProject(1897))
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
                    RuntimeMethodHandle runtimeMethodHandle = __methodref (AssemblyInfo.ProcessScope.DisposeDrive);
                  }
                  tuple = this.parentKeywords.Dequeue();
                  break;
              }
            }
          }
          finally
          {
            if (lockTaken)
            {
label_9:
              switch (4)
              {
                case 0:
                  goto label_9;
                default:
                  Monitor.Exit((object) parentKeywords);
                  break;
              }
            }
          }
          if (tuple != null)
          {
label_13:
            switch (1)
            {
              case 0:
                goto label_13;
              default:
                tuple.Item1(tuple.Item2);
                if (this.InnerException != null)
                  throw new AggregateException(EditorService.DisconnectProject(1575), this.InnerException);
                continue;
            }
          }
          else
            this.parentKeywords.WaitOne();
        }
label_18:
        switch (6)
        {
          case 0:
            goto label_18;
        }
      }

      public override SynchronizationContext CreateCopy() => (SynchronizationContext) this;
    }
  }
}
