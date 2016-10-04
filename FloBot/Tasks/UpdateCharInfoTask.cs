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

        public bool doTask(mainForm main_form, MemoryRW mc)
        {
            main_form.lblCharName.Text = AddressUtil.getCharName();

            main_form.lblCharLvL.Text = "" + AddressUtil.getCharLevel();

            main_form.lblCharHP.Text = AddressUtil.getCurrentCharHP() + "/" + AddressUtil.getMaxCharHP();

            main_form.lblCharMP.Text = AddressUtil.getCharCurrentMP() + "/" + AddressUtil.getCharMaxMP();
            return true;
        }
    }
}
