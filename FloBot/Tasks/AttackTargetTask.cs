using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Threading;

namespace FloBot.Tasks
{
    class AttackTargetTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            mc.sendKeystroke(Keys.NumPad1);
            mc.sendKeystroke(Keys.Space);
            

            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
