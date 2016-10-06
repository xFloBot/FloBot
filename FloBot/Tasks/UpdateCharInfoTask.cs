using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloBot.MemoryClass;

namespace FloBot.Tasks
{
    class UpdateCharInfoTask : ITask
    {
        public bool doTask(MemoryRW mc)
        {
            throw new NotImplementedException();
        }
        private static Single currentExpPercent = -1F;
        private static int currentExp = -1;
        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            main_form.lblCharName.Text = AddressUtil.getCharName();

            main_form.lblCharLvL.Text = "" + AddressUtil.getCharLevel();

            main_form.lblCharHP.Text = AddressUtil.getCurrentCharHP() + "/" + AddressUtil.getCharMaxHP();

            main_form.lblCharMP.Text = AddressUtil.getCharCurrentMP() + "/" + AddressUtil.getCharMaxMP();

            if (currentExpPercent == -1)
            {
                currentExpPercent = AddressUtil.getCharExpPercent();
                currentExp = AddressUtil.getCharCurrentExp();
                return true;
            }

            if (currentExpPercent != AddressUtil.getCharExpPercent())
            {
               
                main_form.lblExpMax.Text = "" + calculateMaxExp();


                main_form.lblExpCurrent.Text =
                  calculateCurrentExp()
                    + "(" + AddressUtil.getCharExpPercent() + "%)";

                currentExpPercent = AddressUtil.getCharExpPercent();
                currentExp = AddressUtil.getCharCurrentExp();

            }

            return true;
        }

        private int calculateMaxExp()
        {
            return (int)((AddressUtil.getCharCurrentExp() - currentExp) / (AddressUtil.getCharExpPercent() - currentExpPercent) * 100);
        }
        
        private int calculateCurrentExp()
        {
            return (int)((AddressUtil.getCharCurrentExp() - currentExp) / (AddressUtil.getCharExpPercent() - currentExpPercent) * AddressUtil.getCharExpPercent());
        }

       
    }
}
