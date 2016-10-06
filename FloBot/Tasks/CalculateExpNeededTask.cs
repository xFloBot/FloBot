using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;

namespace FloBot.Tasks
{
    class CalculateExpNeededTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }
        private static Single currentExpPercent = -1F;
        private static int currentExp = -1;
        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            int newExp = AddressUtil.getCharCurrentExp();
            
            if (currentExpPercent == -1)
            {
                currentExpPercent = AddressUtil.getCharExpPercent();
                currentExp = newExp;
                return true;
            }

            int maxExp;
            if (currentExpPercent != AddressUtil.getCharExpPercent())
            {
                maxExp = (int)((newExp-currentExp)/(AddressUtil.getCharExpPercent() - currentExpPercent)*100);
                main_form.lblExpMax.Text = ""+ maxExp;


                main_form.lblExpCurrent.Text = 
                  (int)  ((newExp - currentExp) / (AddressUtil.getCharExpPercent() - currentExpPercent) * AddressUtil.getCharExpPercent() )
                    +"("+ AddressUtil.getCharExpPercent()+"%)";

                currentExpPercent = AddressUtil.getCharExpPercent();
                currentExp = newExp;

            }

         

            return true;
        }
    }
}
