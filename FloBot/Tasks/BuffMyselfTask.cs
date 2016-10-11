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

        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
  

            while (player.Pos.moved()) Thread.Sleep(100);
            if (player.inCombat || player.Resting)
                return false;

            try
            {
               
                foreach (Skill buff in player.BuffArray)
                {
                     int counter = 0;
                    

                    if (buff.skillCanBeUsed())
                    {
                        mc.sendKeystroke(buff.Hotkey);
                        buff.LastTimeUsed = DateTime.Now;
                    }
                    while (counter++ <= 5)
                        if (player.inCombat)
                            return false;
                        else
                            Thread.Sleep(200);

                }
            }catch(InvalidOperationException )
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
