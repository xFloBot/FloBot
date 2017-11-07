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
    class IdleState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc, Player player)
        {

            while (!new FindGameHandlerTask().doTask(main_form, mc, player))
            {
                Thread.Sleep(500);
                return new IdleState();
            }
            Thread.Sleep(100);
            if( main_form.cbEnableCombatState.Checked &&  !player.PlayerName.Equals("") )
                return new PreCombatState();

            new UpdateCharInfoTask().doTask(main_form, player);

            new UpdateTargetInfo().doTask(main_form, player);

            return new IdleState();
        }
         
    }
}
