using FloBot.MemoryClass;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FloBot.Model
{
    class Player
    {
        private Position _pos = new Position();
        private Target _target = new Target();
        private  ArrayList _buffArray = new ArrayList();
        private  ArrayList _attArray = new ArrayList();
        private int _MobToLootCount = 0;
        private bool _Resting = false;
        private bool _buffed = false;
        private Single oldPercentage=-1;
        private int level;
        private Single highestPercent = -1;
        private int oldExp =-1;
        private int oldMobExp =-1;
        private bool _playerEngaged = false;

        public  ArrayList BuffArray
        {
            get
            {
                return _buffArray;
            }

        }
        
        public  ArrayList AttArray
        {
            get
            {
                return _attArray;
            }
        }
        
        public Position Pos
        {
            get
            {
                return _pos;
            }
        }

        public Target Target
        {
            get
            {
                return _target;
            }
        }

        public bool inCombat
        {
            get
            {
                return Target.isCurrentTargetAlive() && !Target.isTargetFriendly() && !Target.targetName.Contains("NoTarget") && !targetingMyself() && PlayerCurrentHP > 0;
            }
        }

        public int MobToLootCount
        {
            get
            {
                return _MobToLootCount;
            }

            set
            {
                _MobToLootCount = value;
            }
        }

        public bool Resting
        {
            get
            {
                return _Resting;
            }

            set
            {
                _Resting = value;
            }
        }

        public String PlayerName
        {
            get
            {
                String name = AddressUtil.getCharName();
               // int playerNameEnd = -1 ;
               // while ((playerNameEnd = AddressUtil.getCharName().IndexOf('\0')) < 0) Thread.Sleep(50);

                return name.Substring(0, name.IndexOf('\0' ));
            }
        }

        public int PlayerLevel
        {
            get
            {
                return AddressUtil.getCharLevel();
            }
        }

        public int PlayerMaxHP
        {
            get
            {
                return AddressUtil.getCharMaxHP();
            }
        }

        public int PlayerCurrentHP
        {
            get
            {
                return AddressUtil.getCharCurrentHP();
            }
        }
        public int PlayerMaxMP
        {
            get
            {
                return AddressUtil.getCharMaxMP();
            }
        }

        public int PlayerCurrentMP
        {
            get
            {
                return AddressUtil.getCharCurrentMP();
            }
        }

        public bool Buffed
        {
            get
            {
                return _buffed;
            }

            set
            {
                _buffed = value;
            }
        }

        public bool PlayerEngaged { get => _playerEngaged; set => _playerEngaged = value; }

        public bool targetingMyself()
        {

            if (PlayerName.Length <= 0)
                return false;
   
            return Target.targetName.Contains(PlayerName) && Target.isTargetFriendly();
        }

        public void updateReviveBlock()
        {
            if(highestPercent == -1)
            {
                highestPercent = AddressUtil.getCharExpPercent();
                level = PlayerLevel;
                return;
            }
            if(highestPercent < AddressUtil.getCharExpPercent())
            {
                highestPercent = AddressUtil.getCharExpPercent();
                return;
            }

            if (PlayerLevel > level)
            {
                highestPercent = AddressUtil.getCharExpPercent();
                level = PlayerLevel;
                return;
            }

        }

        public bool allowedToRevive(mainForm main_form)
        {
            int maxAllowedExpLos = 0;
            Int32.TryParse(main_form.tbNotRevivePercent.Text,out maxAllowedExpLos);

            return (highestPercent - Math.Abs(AddressUtil.getCharExpPercent()) < maxAllowedExpLos);
            

        }

        public void addElement(ArrayList al, Skill skill)
        {
            al.Add(skill);
            al.Sort();
        }

        public void removeElement(ArrayList al, Skill skill)
        {
            Skill skillToRemove = null;
            foreach (Skill skill2 in al)
            {
                if (skill2.Equals(skill))
                {
                    skillToRemove = skill2;
                }
            }
            if (skillToRemove != null)
                al.Remove(skillToRemove);

        }





        public void updateCharInfo(mainForm main_form)
        {
            main_form.lblCharName.Text = AddressUtil.getCharName();

            main_form.lblCharLvL.Text = "" + AddressUtil.getCharLevel();

            main_form.lblCharHP.Text = AddressUtil.getCharCurrentHP() + "/" + AddressUtil.getCharMaxHP();

            main_form.lblCharMP.Text = AddressUtil.getCharCurrentMP() + "/" + AddressUtil.getCharMaxMP();

            if (oldPercentage == -1)
            {
                oldPercentage = AddressUtil.getCharExpPercent();
                oldExp = AddressUtil.getCharCurrentExp();
                return;
            }

            if (oldPercentage != AddressUtil.getCharExpPercent())
            {
               
                main_form.lblExpMax.Text = "" + calculateMaxExp();


                main_form.lblExpCurrent.Text =
                  calculateCurrentExp()
                    + "(" + AddressUtil.getCharExpPercent() + "%)";
                if (((AddressUtil.getCharCurrentExp() - oldExp + oldMobExp) / 2) != 0)
                    main_form.lblMobsTillUp.Text = "" + ((calculateMaxExp() - calculateCurrentExp()) / ((AddressUtil.getCharCurrentExp() - oldExp + oldMobExp) / 2));
                oldMobExp = (AddressUtil.getCharCurrentExp() - oldExp);
                oldPercentage = AddressUtil.getCharExpPercent();
                oldExp = AddressUtil.getCharCurrentExp();

            }

        }

        private int calculateMaxExp()
        {
            return (int)(((AddressUtil.getCharCurrentExp() - oldExp) / (AddressUtil.getCharExpPercent() - oldPercentage)) * 100F);
        }

        private int calculateCurrentExp()
        {
            return (int)(((AddressUtil.getCharCurrentExp() - oldExp) / (AddressUtil.getCharExpPercent() - oldPercentage)) * AddressUtil.getCharExpPercent());
        }

    }
}
