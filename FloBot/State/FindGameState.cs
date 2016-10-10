using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Tasks;
using System.Threading;
using FloBot.Model;

namespace FloBot.State
{
    class FindGameState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc, Player player)
        {

            while (!new FindGameHandlerTask().doTask(main_form,mc,player)) Thread.Sleep(1000);

            return new PreCombatState();
        }
         
    }
}
