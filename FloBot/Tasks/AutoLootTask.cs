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
            Console.WriteLine("___________________________\nMobs zu looten: {0}", DataNeededCrossTaskUtil.MobToLootCount);
            Thread.Sleep(1000);

            DataNeededCrossTaskUtil.LastX = AddressUtil.getCharPosX();
            DataNeededCrossTaskUtil.LastY = AddressUtil.getCharPosY();
            DataNeededCrossTaskUtil.LastZ = AddressUtil.getCharPosZ();
           
            while(DataNeededCrossTaskUtil.MobToLootCount > 0 && AddressUtil.getTargetCurrentHP() == 0)
            {
                bool pressedX = false;
                while ( AddressUtil.getTargetCurrentHP() == 0)
                {
                    if (!pressedX)
                    {
                        Console.WriteLine("Pressing X");
                        mc.sendKeystroke(Keys.X);
                        pressedX = true;
                        Console.WriteLine("Looting: {0}", DataNeededCrossTaskUtil.MobToLootCount);
                    }
                        
                    Thread.Sleep(100);
                    if (!DataNeededCrossTaskUtil.hasMoved())
                        break;
                }

                if (AddressUtil.getTargetCurrentHP() == 0 && DataNeededCrossTaskUtil.MobToLootCount > 0)
                    DataNeededCrossTaskUtil.MobToLootCount--;
                else
                    return true;
                Thread.Sleep(2000);

            }
            Console.WriteLine("___________________________");
            return true;
        }
       

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
