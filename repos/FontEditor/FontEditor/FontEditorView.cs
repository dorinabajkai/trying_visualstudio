using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FontEditor
{
    public class FontEditorView : IView
    {
        private FontEditorDocument document;
        private char editedChar;
        private double zoom;

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw(System.Drawing.Graphics g)
        {
            throw new System.NotImplementedException();
        }

        public void InvertCharDefPixel(char c, int x, int y)
        {
            throw new System.NotImplementedException();
        }
    }
}