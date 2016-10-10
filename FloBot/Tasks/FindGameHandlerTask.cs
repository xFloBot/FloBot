using FloBot.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;

namespace FloBot.Tasks
{
    class FindGameHandlerTask : ITask
    {

        private const String gameName = "FlorensiaEN.bin";


        public bool doTask(mainForm main_form)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            if (mc.Process_Handle(gameName))
            {
                main_form.lblGameFound.Text = "Florensia gefunden";
                return true;
            }
            main_form.lblGameFound.Text = "Florensia nicht gefunden";

            return false;
        }
    }
}
