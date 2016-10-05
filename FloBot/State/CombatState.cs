using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FloBot.State
{
    class CombatState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc)
        {
            if (new ReviveIfNeededTask().doTask(mc))
                return new FindGameState();

            //Update Charinfo
            new UpdateCharInfoTask().doTask(main_form, mc);


            //Check current Target
             new CheckCurrentTarget().doTask(main_form, mc);
         
            //check if you need rest and if you not checked autobattle
      
           
            if (!main_form.cbAutoBattle.Checked||new GetRestTask().doTask(main_form,mc))
                return new FindGameState();

            //Focus a target
            new FocusTargetTask().doTask(main_form,mc);
  

            while (new CheckCurrentTarget().doTask(main_form,mc) && !main_form.IsDisposed && AddressUtil.getCurrentCharHP()>0)
            {
                new AttackTargetTask().doTask(mc);
                new UpdateCharInfoTask().doTask(main_form,mc);
                new EmergencyHealTask().doTask(main_form, mc);
                Thread.Sleep(1000);
            }

            return new FindGameState();
        }
    }
}
