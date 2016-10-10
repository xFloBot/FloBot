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
        private static DateTime castDelay;
        private static int delayTime = 0;
        public bool doTask(MemoryRW mc)
        {
           // Console.WriteLine((DateTime.Now - castDelay).TotalSeconds);
            mc.sendKeystroke(Keys.Space);
            if (delayTime > 0)
                if ((DateTime.Now - castDelay).TotalSeconds <= delayTime)
                    return true;
                else
                    delayTime = 0;

            Thread.Sleep(500);
           // Console.WriteLine(DataNeededCrossTaskUtil.AttArray.Count);
            foreach(Skill skill in DataNeededCrossTaskUtil.AttArray)
            {
                if (skill.skillCanBeUsed())
                {

                    DataNeededCrossTaskUtil.LastX = AddressUtil.getCharPosX();
                    DataNeededCrossTaskUtil.LastY = AddressUtil.getCharPosY();
                    DataNeededCrossTaskUtil.LastZ = AddressUtil.getCharPosZ();
                    mc.sendKeystroke(skill.Hotkey);
                    Thread.Sleep(150);
                    while (DataNeededCrossTaskUtil.hasMoved())
                        Thread.Sleep(150);
                    skill.LastTimeUsed = DateTime.Now;
                    castDelay = DateTime.Now;
                    delayTime = skill.CastTime;
                    Thread.Sleep(1500);
                    return true;
                }
                    
            }
           
            return true;
        }

        public bool doTask(mainForm main_form, Player player)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form, MemoryRW mc, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
