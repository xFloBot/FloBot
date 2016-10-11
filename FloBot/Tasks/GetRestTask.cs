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
    class GetRestTask : ITask
    {
        
        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }
        private int oldHP = -1;
        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            if (player.PlayerCurrentHP == 0)
                return false;
            //Check if in combat yes -> return false (not resting) incase you were resting, stand up and set resting to false
            if (player.inCombat)
                if (player.Resting)
                {
                    mc.sendKeystroke(Keys.Z);
                    player.Resting = false;
                    return false;
                }
                else
                    return false;
            if(player.Resting && oldHP > player.PlayerCurrentHP)
            {
                player.Resting = false;
                mc.sendKeystroke(Keys.Z);
                oldHP = -1;
                return false;
            }

            //Check if player is not resting but needs to rest
            if(!player.Resting && (getRestHP(main_form,player) || getRestMP(main_form, player)))
            {
                while (player.Pos.moved())
                    Thread.Sleep(100);
                if (player.inCombat)
                    return false;
                int counter = 0;
                while ((oldHP = player.PlayerCurrentHP) == 0 && counter++ < 10) Thread.Sleep(100);

                player.Resting = true;
                mc.sendKeystroke(Keys.Z);
                return true;
            }
            //Check if player has finished resting
            if(player.Resting)
            {
                if (player.PlayerMaxHP == player.PlayerCurrentHP && player.PlayerMaxMP == player.PlayerCurrentMP)
                {
                    Console.WriteLine("Player max HP: {0} \nPlayer current HP:{1}", player.PlayerMaxHP, player.PlayerCurrentHP);
                    mc.sendKeystroke(Keys.Z);
                    player.Resting = false;
                    return false;
                }
                else
                    return true;
            }
            return false;

                  
        }

        private bool getRestHP(mainForm main_form, Player player)
        {
           return ( (player.PlayerMaxHP) / 100 * main_form.tbRestHP.Value) > player.PlayerCurrentHP;
        }
        private bool getRestMP(mainForm main_form, Player player)
        {
            return ((player.PlayerMaxMP) / 100 * main_form.tbRestMP.Value) > player.PlayerCurrentMP;
        }

    }
}
