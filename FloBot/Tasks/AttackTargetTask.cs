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
        private static float delayTime = 0;
      
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            int counter = 400;
            if (!player.PlayerEngaged)
            {  //Attack
                mc.sendKeystroke(Keys.Space);
                // Stop Moving
                //mc.sendKeystroke(Keys.S);
                player.PlayerEngaged = true;
                do
                    Thread.Sleep(50);
                while (player.Pos.moved() && counter-- > 0);
                counter = 400;
            }
           

            Console.WriteLine((DateTime.Now - lastTimeUsedSpell).TotalSeconds);
            Console.WriteLine("DelayTime: " + delayTime);
            if (delayTime > 0)
                if ((DateTime.Now - lastTimeUsedSpell).TotalSeconds <= delayTime)
                    return true;
                else
                    delayTime = 0;
          
            Skill[] copy = new Skill[player.AttArray.Count];
            player.AttArray.CopyTo(copy);
            foreach (Skill attk in copy)
            {
                Console.WriteLine(attk.Hotkey);
                if (attk.attackCanBeUsed(player.Target, player))
                {
                    if (!player.inCombat)
                        return false;

                    mc.sendKeystroke(attk.Hotkey);
                    
                    do
                        Thread.Sleep(50);
                    while (player.Pos.moved() && counter-- >0);
                    Console.WriteLine("Set Time Used");
                    attk.LastTimeUsed = DateTime.Now;
                    lastTimeUsedSpell = attk.LastTimeUsed;
                    Console.WriteLine(attk.CastTime);
                    delayTime = attk.CastTime;
                    //Thread.Sleep(2000);

                    return true;

                }

            }

            //Attack
            mc.sendKeystroke(Keys.Space);
            do
                Thread.Sleep(50);
            while (player.Pos.moved() && counter-- > 0);

            return true;
        }
    }
}
