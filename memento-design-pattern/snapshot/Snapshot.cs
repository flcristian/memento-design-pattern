using memento_design_pattern.editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_design_pattern.snapshot
{
    public class Snapshot : ISnapshot
    {
        public IEditor Editor { get; set; }
        public string Text { get; set; }
        public int CursorX { get; set; }
        public int CursorY { get; set; }
        public int SelectionWidth { get; set; }

        public Snapshot(IEditor editor, string text, int cursorX, int cursorY, int selectionWidth)
        {
            Editor = editor;
            Text = text;
            CursorX = cursorX;
            CursorY = cursorY;
            SelectionWidth = selectionWidth;
        }

        public void Restore()
        {
            Editor.SetText(Text);
            Editor.SetCursorX(CursorX);
            Editor.SetCursorY(CursorY);
            Editor.SetSelectionWidth(SelectionWidth);
        }
    }
}
