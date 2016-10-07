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
            Thread.Sleep(700);
            lastX = AddressUtil.getCharPosX();
            lastY = AddressUtil.getCharPosY();
            lastZ = AddressUtil.getCharPosZ();

            while(DataNeededCrossTaskUtil.MobToLootCount > 0)
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
                    if (!hasMoved())
                        break;
                }
                Thread.Sleep(1000);
                if (AddressUtil.getTargetCurrentHP() ==0 && DataNeededCrossTaskUtil.MobToLootCount > 0)
                    DataNeededCrossTaskUtil.MobToLootCount--;
                
            }
            Console.WriteLine("___________________________");
            return true;
        }
        private Single lastX = 0;
        private Single lastY = 0;
        private Single lastZ = 0;

        private bool hasMoved()
        {
            bool moved = AddressUtil.getCharPosX() != lastX
            || AddressUtil.getCharPosY() != lastY
            || AddressUtil.getCharPosZ() != lastZ;

            lastX = AddressUtil.getCharPosX();
            lastY = AddressUtil.getCharPosY();
            lastZ = AddressUtil.getCharPosZ();

            return moved;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
