using FloBot.MemoryClass;
using FloBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBot.Tasks
{
    interface ITask
    {
        bool doTask(mainForm main_form,Player player);
        bool doTask(mainForm main_form,MemoryRW mc, Player player);
    }
}
