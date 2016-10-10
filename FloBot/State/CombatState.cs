using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Tasks;
using System.Windows.Forms;
using System.Threading;
using FloBot.Model;

namespace FloBot.State
{
    class CombatState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc, Player player)
        {
            /*
            *   Focus a Target when you do not have any
            */
            if(main_form.cbAutoTarget.Checked)
                new FocusTargetTask().doTask(main_form,mc,player);

            while(new CheckCurrentTargetTask().doTask(main_form,mc,player))
            {
                if(main_form.cbAutoBattle.Checked)
                {
                    new EmergencyHPTask().doTask(main_form, mc, player);
                    new EmergencyMPTask().doTask(main_form, mc, player);
                    new AttackTargetTask().doTask(main_form, mc, player);
                }


                Thread.Sleep(100);
            }


            return new AfterCombatState();
        }
    }
}
