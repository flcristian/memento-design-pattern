using memento_design_pattern.snapshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_design_pattern.editor
{
    public class Editor : IEditor
    {
        private string Text { get; set; }
        private int CursorX { get; set; }
        private int CursorY { get; set; }
        private int SelectionWidth { get; set; }

        public Editor(string text, int cursorX, int cursorY, int selectionWidth)
        {
            Text = text;
            CursorX = cursorX;
            CursorY = cursorY;
            SelectionWidth = selectionWidth;
        }

        public ISnapshot CreateSnapshot()
        {
            return new Snapshot(this, Text, CursorX, CursorY, SelectionWidth);
        }

        public void SetCursorX(int cursorX)
        {
            CursorX = cursorX;
        }

        public void SetCursorY(int cursorY)
        {
            CursorY = cursorY;
        }

        public void SetSelectionWidth(int selectionWidth)
        {
            SelectionWidth = selectionWidth;
        }

        public void SetText(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            string desc = "";
            desc += $"Text : {Text}\n";
            desc += $"Cursor X : {CursorX}\n";
            desc += $"Cursor Y : {CursorY}\n";
            desc += $"Selection Width : {SelectionWidth}\n";
            return desc;
        }
    }
}
