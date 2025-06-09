// *************************************************************
// Type: GameFoundation.XmlFileSerializer
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

//using Microsoft.Advertising.WinRT.UI;
//using MicrosoftAdvertising;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.UI.Xaml;

#nullable disable
namespace GameFoundation
{
    internal sealed class XmlFileSerializer : VectorService
    {
        private AdControl[] parentKeywordsAC;
        private EventHandler parentKeywordsEH;
        private EventHandler currentUri;
        private EventHandler filterID;
        private EventHandler parentCancel;
        private AdControl parentKeywords;

        internal XmlFileSerializer()
        {
            this.parentKeywordsAC = DriveAttribute.DisconnectProject(ReferenceInvoker.DisconnectProject(1885));
        }

        // Fix for CS1503: Correctly combine EventHandler delegates instead of AdControl[]
        public void add_DisconnectProject(EventHandler _param1)
        {
            lock (this)
            {
                this.parentKeywordsEH = (EventHandler)Delegate.Combine(this.parentKeywordsEH, _param1);
            }
        }

        public void remove_DisconnectProject(EventHandler _param1)
        {
            lock (this)
            {
                this.parentKeywordsEH = (EventHandler)Delegate.Remove(this.parentKeywordsEH, _param1);
            }
        }

        public void add_DisposeDrive(EventHandler _param1)
        {
            lock (this)
            {
                this.currentUri = (EventHandler)Delegate.Combine(this.currentUri, _param1);
            }
        }

        public void remove_DisposeDrive(EventHandler _param1)
        {
            lock (this)
            {
                this.currentUri = (EventHandler)Delegate.Remove(this.currentUri, _param1);
            }
        }

        public void add_ListQueue(EventHandler _param1)
        {
            throw new NotImplementedException();
        }

        public void remove_ListQueue(EventHandler _param1)
        {
            throw new NotImplementedException();
        }

        public void add_EnableNetwork(EventHandler _param1)
        {
            throw new NotImplementedException();
        }

        public void remove_EnableNetwork(EventHandler _param1)
        {
            throw new NotImplementedException();
        }

        public bool TestConnection()
        {
            throw new NotImplementedException();
        }

        public bool ExtractDockingPane()
        {
            throw new NotImplementedException();
        }

        public void LoadDirectory()
        {
            throw new NotImplementedException();
        }

        public void SelectResource(bool _param1)
        {
            throw new NotImplementedException();
        }

        public bool EnableDockingPane()
        {
            throw new NotImplementedException();
        }

        public void CopyProject(int _param1, ConfigStream _param2)
        {
            throw new NotImplementedException();
        }

        public bool LoadDeployment(int _param1)
        {
            throw new NotImplementedException();
        }

        public void DisconnectWindow(int _param1)
        {
            throw new NotImplementedException();
        }

        public string SaveAssistant(int _param1)
        {
            throw new NotImplementedException();
        }
    }
}
