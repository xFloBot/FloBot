using FloBot.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;

namespace FloBot.Tasks
{
    class FindGameHandlerTask : ITask
    {

        private const String gameName = "FlorensiaEN.bin";
        public bool doTask(MemoryRW mc)
        {
            return mc.Process_Handle(gameName);
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
