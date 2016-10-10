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
        public bool doTask(MemoryRW mc)
        {
            foreach (Skill skill in DataNeededCrossTaskUtil.BuffArray)
            {
                Thread.Sleep(2000);
                if (AddressUtil.getTargetCurrentHP() > 0 && !AddressUtil.getTargetName().Contains(AddressUtil.getCharName().Substring(16)))
                {
                    break;
                }
                   
                if (skill.skillCanBeUsed())
                {
                    Console.WriteLine("Should buff");
                    mc.sendKeystroke(skill.Hotkey);
                    skill.LastTimeUsed = DateTime.Now;
                    //DataNeededCrossTaskUtil.Buffed = true;
                    Thread.Sleep(1500);
                }

            }
            int indexOfStringEnd = AddressUtil.getCharName().IndexOf('\0') - 1;
            Console.WriteLine(indexOfStringEnd);
            String charName = AddressUtil.getCharName();
            if (indexOfStringEnd >= 0)
                charName = AddressUtil.getCharName().Substring(0, indexOfStringEnd);//.Replace( ((char)0x00).ToString(),string.Empty);
   
            while (AddressUtil.getTargetName().Contains(charName))           
            {

                mc.sendKeystroke(Keys.Escape);
                Thread.Sleep(500);
            }
           
            return true;
        }

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            throw new NotImplementedException();
        }
    }
}
