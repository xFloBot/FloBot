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
    class AutoLootTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            Console.WriteLine("Mobs zu looten: {0}",CheckCurrentTarget.mobsToLoot);
            Thread.Sleep(1000);

            while(CheckCurrentTarget.mobsToLoot>0)
            {
                int counter = 0;
                while (counter < 30 && AddressUtil.getTargetCurrentHP() == 0)
                {
                    if (counter == 0)
                    {
                        mc.sendKeystroke(Keys.X);
                        Console.WriteLine("Looting: {0}", CheckCurrentTarget.mobsToLoot);
                    }
                        
                    Thread.Sleep(100);
                    counter++;
                }
                if (AddressUtil.getTargetCurrentHP() == 0)
                    CheckCurrentTarget.mobsToLoot--;
                else
                    return true;
            }

            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
