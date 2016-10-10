using FloBot.MemoryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.Tasks;
using FloBot.Model;

namespace FloBot.State
{
    interface IState
    {
        IState doTasks(mainForm main_form,MemoryRW mc,Player player);

    }
}
