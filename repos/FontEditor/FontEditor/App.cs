using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FontEditor
{
    public class App
    {
        private List<Document> documents;

        private App()
        {
            throw new System.NotImplementedException();
        }

        public Document ActiveDocument
        {
            get => default;
            set
            {
            }
        }

        public static App Instance
        {
            get => default;
            set
            {
            }
        }

        public void NewDocument()
        {
            throw new System.NotImplementedException();
        }

        public void OpenDocument()
        {
            throw new System.NotImplementedException();
        }

        public void SaveActiveDocument()
        {
            throw new System.NotImplementedException();
        }

        public void CloseActiveDocument()
        {
            throw new System.NotImplementedException();
        }
    }
}