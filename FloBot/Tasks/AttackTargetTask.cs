using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Threading;
using FloBot.Model;

namespace FloBot.Tasks
{
    class AttackTargetTask : ITask
    {
        private static DateTime lastTimeUsedSpell;
        private static int delayTime = 0;

        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            mc.sendKeystroke(Keys.Space);
            if (delayTime > 0)
                if ((DateTime.Now - lastTimeUsedSpell).TotalSeconds <= delayTime)
                    return true;
                else
                    delayTime = 0;
            Console.WriteLine("__________\nArrayCount:{0}\n_____________", player.AttArray.Count);

            Skill[] copy = new Skill[player.AttArray.Count];
            player.AttArray.CopyTo(copy);
            foreach (Skill attk in copy)
                {
              

                    if (attk.attackCanBeUsed(player.Target))
                    {
                        if (!player.inCombat)
                            return false;
                    
                        mc.sendKeystroke(attk.Hotkey);

                        while (player.Pos.moved())
                            Thread.Sleep(200);

                        attk.LastTimeUsed = DateTime.Now;
                        lastTimeUsedSpell = attk.LastTimeUsed;
                        delayTime = attk.CastTime;
                        Thread.Sleep(2000);

                        return true;

                    }

                }
           
            

            return true;
        }
    }
}
