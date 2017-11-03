using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Tasks;
using FloBot.Model;
using System.Threading;

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
             *    Revive incase you DIED Noob.
             */
            if (new ReviveIfNeededTask().doTask(main_form, mc, player))
                return new PreCombatState();

            /*
            *   Check if you need to rest when yes set State to FindGameState
            */
            if (new GetRestTask().doTask(main_form, mc, player))
                return new PreCombatState();
            /*
            *   Loot leftovers
            */
            if (main_form.cbAutoLoot.Checked)
                new AutoLootTask().doTask(main_form, mc, player);

            /*
            *   Buff yourself if buffs are set
            */
            new BuffMyselfTask().doTask(main_form, mc, player);


            if (main_form.cbAutoTarget.Checked)
                new FocusTargetTask().doTask(main_form, mc, player);

            Thread.Sleep(100);
            if (main_form.cbAutoBattle.Checked)
                return new CombatState();
            
                

            return new IdleState();
        }
    }
}
