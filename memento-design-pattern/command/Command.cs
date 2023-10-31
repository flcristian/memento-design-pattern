using memento_design_pattern.editor;
using memento_design_pattern.snapshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_design_pattern.command
{
    public class Command : ICommand
    {
        private ISnapshot Backup { get; set; }
        private IEditor Editor { get; set; }

        public Command(IEditor editor)
        {
            Editor = editor;
        }

        public void MakeBackup()
        {
            Backup = Editor.CreateSnapshot();
        }

        public void Undo()
        {
            if(Backup != null)
            {
                Backup.Restore();
            }
        }
    }
}
