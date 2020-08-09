using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FontEditor
{
    public class FontEditorDocument : Document
    {
        private Dictionary<char, CharDef> charDefs;

        public override void LoadDocument(string path)
        {
            throw new System.NotImplementedException();
        }

        public override void SaveDocument()
        {
            throw new System.NotImplementedException();
        }

        public CharDef GetCharDef(char c)
        {
            throw new System.NotImplementedException();
        }
    }
}