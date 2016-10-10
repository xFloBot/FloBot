using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using FloBot.Model;
using System.Threading;
using System.Windows.Forms;

namespace FloBot.Tasks
{
    class BuffMyselfTask : ITask
    {
        private int castDelay = 0;
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {

            while (player.Pos.moved()) Thread.Sleep(100);
            int counter = 0;

            try
            {
                foreach (Skill buff in player.BuffArray)
                {

                    Console.WriteLine();
                    if (buff.skillCanBeUsed())
                    {
                        mc.sendKeystroke(buff.Hotkey);
                        buff.LastTimeUsed = DateTime.Now;
                    }
                    while (counter++ <= 10)
                        if (player.inCombat)
                            return false;
                        else
                            Thread.Sleep(200);

                }
            }catch(InvalidOperationException e)
            {

            }
           finally
            {
                while (player.targetingMyself())
                {
                    mc.sendKeystroke(Keys.Escape);
                    Thread.Sleep(100);
                }
               
            }
            return true;

        }
    }
}
