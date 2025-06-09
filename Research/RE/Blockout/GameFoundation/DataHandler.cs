// Decompiled with JetBrains decompiler
// Type: GameFoundation.DataHandler
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// Assembly location: C:\Users\Admin\Desktop\RE\BlockOut_V1\GameFoundation.dll

using System;

#nullable disable
namespace GameFoundation
{
  public class DataHandler
  {
    public GameData gameData;

    public DataHandler()
    {
      if (this.DisconnectProject())
        return;
label_1:
      switch (6)
      {
        case 0:
          goto label_1;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (DataHandler.\u002Ector);
          }
          this.gameData = new GameData();
          break;
      }
    }

    private void DisconnectProject()
    {
      if (PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(99)))
        PlatformLocalStorage.DeleteFiles(EditorService.DisconnectProject(99));
      else
        PlatformLocalStorage.CreateDirectory(EditorService.DisconnectProject(99));
      PlatformLocalStorage.SerializeObjectToFile(EditorService.DisconnectProject(122), (object) this.gameData);
    }

    private bool DisconnectProject()
    {
      if (!PlatformLocalStorage.DirectoryExists(EditorService.DisconnectProject(99)))
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
              RuntimeMethodHandle runtimeMethodHandle = __methodref (DataHandler.DisconnectProject);
            }
            return ReferenceInvoker.DisconnectProject(0) != 0;
        }
      }
      else if (!PlatformLocalStorage.FileExists(EditorService.DisconnectProject(122)))
      {
label_6:
        switch (2)
        {
          case 0:
            goto label_6;
          default:
            return ReferenceInvoker.DisconnectProject(4) != 0;
        }
      }
      else
      {
        GameData gameData = StoreDesigner.DisconnectProject(PlatformLocalStorage.DeserializeObjectFromFile(EditorService.DisconnectProject(122), Type.GetTypeFromHandle(SymbolSerializer.DisconnectProject())));
        if (gameData == null)
          return ReferenceInvoker.DisconnectProject(8) != 0;
        this.gameData = gameData;
        return ReferenceInvoker.DisconnectProject(12) != 0;
      }
    }

    public void Unload() => this.DisconnectProject();
  }
}
