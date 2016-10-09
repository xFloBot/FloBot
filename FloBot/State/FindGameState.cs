using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Tasks;
using System.Threading;

namespace FloBot.State
{
    class FindGameState : IState
    {
        public IState doTasks(mainForm main_form, MemoryRW mc)
        {
            ITask nextTask = new FindGameHandlerTask();

           
                while (!nextTask.doTask(mc)) Thread.Sleep(1000);
            
            main_form.lblGameFound.Text = "Florensia gefunden";
            mc.getPixelsByPercent(50, 50);

            if (main_form.cbEnableCombatState.Checked)
                return new CombatState();
            else return this;
        }
         
    }
}
