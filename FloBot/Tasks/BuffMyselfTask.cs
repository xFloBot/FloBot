using System;
using System.Collections;
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

            if (player.inCombat || player.Resting)
                return false;
           
            Skill[] copy = new Skill[player.BuffArray.Count];
            player.BuffArray.CopyTo(copy);

            foreach (Skill buff in copy)
            {
                
               
                int counter = 0;
                if (buff.skillCanBeUsed()||!player.Buffed)
                {
                    counter = (int)buff.CastTime * 4;
                    mc.sendKeystroke(buff.Hotkey);
                    buff.LastTimeUsed = DateTime.Now;
                }

                do
                {

                    if (player.inCombat)
                        return false;
                    Thread.Sleep(250);
                } while (counter-- >= 0);
            }
           
                while (player.targetingMyself())
                {
                    mc.sendKeystroke(Keys.Escape);
                    Thread.Sleep(100);
                }
            player.Buffed = true;
            return true;

        }
    }
}
