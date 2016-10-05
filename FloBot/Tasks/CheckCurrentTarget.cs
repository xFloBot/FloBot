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
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }

        public bool doTask(mainForm main_form,MemoryRW mc)
        {
            main_form.lblTarget.Text = AddressUtil.getTargetName();
            main_form.lblHP.Text = AddressUtil.getTargetCurrentHP() + "/" + AddressUtil.getTargetMaxHP();

            main_form.lblLvL.Text = AddressUtil.getTargetLevel();


            if ((int)AddressUtil.getTargetCurrentHP() == 0  )
            {
                if(!AddressUtil.getTargetName().Contains("NoTarget")&& AddressUtil.getTargetName().Length > 1)
                    mc.sendKeystroke(Keys.Escape);
                return false;
            }
                

            return true;
        }


       
    }
}
