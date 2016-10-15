using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Tasks;
using FloBot.Model;

namespace FloBot.State
{
    class PreCombatState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc, Player player)
        {
         
            /*
            *   Update Form infos
            */
            new UpdateCharInfoTask().doTask(main_form,player);

            new UpdateTargetInfo().doTask(main_form,player);

            /*
            *   Check if you need to rest when yes set State to FindGameState
            */
            if(new GetRestTask().doTask(main_form, mc, player))
                return new FindGameState();
            /*
            *   Buff yourself if buffs are set
            */
            new BuffMyselfTask().doTask(main_form, mc, player);

            if (main_form.cbEnableCombatState.Checked)
            {

                if (main_form.cbAutoTarget.Checked)
                    new FocusTargetTask().doTask(main_form, mc, player);
                return new CombatState();
            }
                

            return new FindGameState();
        }
    }
}
