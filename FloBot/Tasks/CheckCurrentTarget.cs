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


            if ((int)AddressUtil.getTargetCurrentHP() == 0 || !checkIfInRange(main_form))
            {
                if(!AddressUtil.getTargetName().Contains("NoTarget")&& AddressUtil.getTargetName().Length > 1)
                    mc.sendKeystroke(Keys.Escape);
                return false;
            }
                
             
            return true;
        }


        private bool checkIfInRange(mainForm main_form)
        {
            int range;
            int ownLevel = Int32.Parse(main_form.lblCharLvL.Text);
            int monsterLevel;
            if (!Int32.TryParse(AddressUtil.getTargetLevel(),out monsterLevel))
                return false;
            if (!Int32.TryParse(main_form.tbLvLRange.Text, out range)) return false;

            if (monsterLevel > (ownLevel + range) 
                || monsterLevel < ownLevel - range)
                return false;

            return true;
        }
    }
}
