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
        private static int oldHP = -1;
        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            
            //Check if in combat yes -> return false (not resting) incase you were resting, stand up and set resting to false
            if (player.inCombat)
                if (player.Resting)
                {
                    mc.sendKeystroke(Keys.Z);
                    player.Resting = false;
                    oldHP = -1;
                    return false;
                }
                else
                    return false;

            if(player.Resting && oldHP > player.PlayerCurrentHP)
            {
                mc.sendKeystroke(Keys.Tab);
                return true;
            }

            //Check if player is not resting but needs to rest
            if(!player.Resting && (getRestHP(main_form,player) || getRestMP(main_form, player)))
            {
                
                if (player.inCombat)
                    return false;
                //Try to avoid not being able to sit down when you killed an enemy with a cast time spell
                //Bot notices that an enemy died even befor shown in the client
                do
                {
                    Thread.Sleep(200);
                } while (player.Pos.moved());
                Thread.Sleep(2000);
                oldHP = player.PlayerCurrentHP;
                player.Resting = true;
                mc.sendKeystroke(Keys.Z);
                
                return true;
            }
            //Check if player has finished resting
            if(player.Resting)
            {
                if (player.PlayerMaxHP == player.PlayerCurrentHP && player.PlayerMaxMP == player.PlayerCurrentMP)
                {
                    oldHP = -1;
                    mc.sendKeystroke(Keys.Z);
                    player.Resting = false;
                    Thread.Sleep(1500);
                    return false;
                }
                else
                {
                    if (oldHP < player.PlayerCurrentHP)
                        oldHP = player.PlayerCurrentHP;
                    Thread.Sleep(200);
                    return true;
                }
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
