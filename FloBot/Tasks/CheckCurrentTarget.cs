using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FloBot.Tasks
{
    class CheckCurrentTarget : ITask
    {
        public static int mobsToLoot = 0;
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form,MemoryRW mc)
        {
            main_form.lblTarget.Text = AddressUtil.getTargetName();
            main_form.lblHP.Text = AddressUtil.getTargetCurrentHP() + "/" + AddressUtil.getTargetMaxHP();

            main_form.lblLvL.Text = AddressUtil.getTargetLevel();


            //I dont like this part 
            if(!AddressUtil.getTargetName().Contains("NoTarget")&& AddressUtil.getTargetName().Length > 1&& (int)AddressUtil.getTargetCurrentHP() == 0)
            {
                mobsToLoot++;
                mc.sendKeystroke(Keys.Escape);
                return false;
            }
            else if ((int)AddressUtil.getTargetCurrentHP() == 0)
                return false;


            return true;
        }


       
    }
}
