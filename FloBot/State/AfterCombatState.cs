using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;
using FloBot.Tasks;

namespace FloBot.State
{
    class AfterCombatState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc, Player player)
        {
            /*
            *    Revive incase you DIED Noob.
            */
            new ReviveIfNeededTask().doTask(main_form,mc,player);

            if (player.inCombat && main_form.cbAutoBattle.Checked)
                return new CombatState();

            if (main_form.cbAutoLoot.Checked)
                new AutoLootTask().doTask(main_form, mc, player);

            return new FindGameState();
        }
    }
}
