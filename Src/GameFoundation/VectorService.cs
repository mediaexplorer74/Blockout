// *************************************************************
// Type: GameFoundation.VectorService
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace GameFoundation
{
    internal interface VectorService
    {
        // Removed [SpecialName] attribute as it is causing CS0246 errors and is not necessary for the functionality.  
        void add_DisconnectProject(EventHandler _param1);

        void remove_DisconnectProject(EventHandler _param1);

        void add_DisposeDrive(EventHandler _param1);

        void remove_DisposeDrive(EventHandler _param1);

        void add_ListQueue(EventHandler _param1);

        void remove_ListQueue(EventHandler _param1);

        void add_EnableNetwork(EventHandler _param1);

        void remove_EnableNetwork(EventHandler _param1);

        bool TestConnection();

        bool ExtractDockingPane();

        void LoadDirectory();

        void SelectResource(bool _param1);

        bool EnableDockingPane();

        void CopyProject(int _param1, ConfigStream _param2);

        bool LoadDeployment(int _param1);

        void DisconnectWindow(int _param1);

        string SaveAssistant(int _param1);
    }
}
