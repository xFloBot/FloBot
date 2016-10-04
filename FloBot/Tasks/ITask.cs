using FloBot.MemoryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBot.Tasks
{
    interface ITask
    {
        bool doTask(MemoryRW mc);
        bool doTask(mainForm main_form,MemoryRW mc);
    }
}
