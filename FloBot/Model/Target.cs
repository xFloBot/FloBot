using FloBot.MemoryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FloBot.Model
{
    class Target
    {

        public String targetName
        {
            get
            {
                int targetNameEnd = -1;
                while ((targetNameEnd = AddressUtil.getTargetName().IndexOf('\0')) < 0) Thread.Sleep(50);

                return AddressUtil.getTargetName().Substring(0, targetNameEnd);       
            }
        }

        public String targetLevel
        {
            get
            {
                int targetLevelEnd = -1;
                while ((targetLevelEnd = AddressUtil.getTargetLevel().IndexOf('\0')) < 0) Thread.Sleep(50);

                return AddressUtil.getTargetLevel().Substring(0, targetLevelEnd);
            }
        }

        public Single targetMaxHP
        {
            get
            {
                return AddressUtil.getTargetMaxHP();
            }
        }

        public Single targetCurrentHP
        {
            get
            {
             
                return AddressUtil.getTargetCurrentHP();
            }
        }

        public bool isCurrentTargetAlive()
        {
            return targetCurrentHP > 0;
        }

        public void updateTargetInfo(mainForm main_form)
        {
            main_form.lblTarget.Text = targetName;
            main_form.lblHP.Text = targetCurrentHP + "/" + targetMaxHP;

            main_form.lblLvL.Text = targetLevel;
        }

        public bool isValidTarget(mainForm main_form)
        {
            return targetCurrentHP == targetMaxHP && checkIfInRange(main_form) && !targetName.Contains("NoTarget") && !(main_form.cbUseWhitelist.Checked && !main_form.lbWhitelist.Items.Contains(targetName)); 
        }
        public bool isTargetFriendly()
        {
            return AddressUtil.getTargetType() == 0;
        }

        private bool checkIfInRange(mainForm main_form)
        {
            int range;
            int ownLevel = Int32.Parse(main_form.lblCharLvL.Text);
            int monsterLevel = 1;
            Console.WriteLine("Player level:" + ownLevel);
            Console.WriteLine("Target level:" + targetLevel);
            //TryParse Target level(It's stored as String in the address dunno why)
            if (!Int32.TryParse(targetLevel, out monsterLevel))
                return false ;
            //Try parse range
            if (!Int32.TryParse(main_form.tbLvLRange.Text, out range)) return false;
            //check if monster level is bigger than ownLevel+ range || smaller than ownLevel-range
            if (monsterLevel > (ownLevel + range)
                || monsterLevel < ownLevel - range)
                return false;

            return true;
        }
    }
}
