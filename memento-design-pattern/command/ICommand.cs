﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_design_pattern.command
{
    public interface ICommand
    {
        void MakeBackup();
        void Undo();
    }
}
