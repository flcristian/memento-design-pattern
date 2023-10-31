using memento_design_pattern.snapshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_design_pattern.editor
{
    public interface IEditor
    {
        public void SetText(String text);
        public void SetCursorX(int cursorX);
        public void SetCursorY(int cursorY);
        public void SetSelectionWidth(int selectionWidth);
        ISnapshot CreateSnapshot();
    }
}
