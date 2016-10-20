using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloBot.Model
{
    class Skill
    {
        private int _delay;
        private int _castTime;
        private DateTime _lastTimeUsed;
        private Keys _hotkey;
        private int _maxHP;
        private int _minHP;

        public int Delay
        {
            get
            {
                return _delay;
            }

         
        }

        public int CastTime
        {
            get
            {
                return _castTime;
            }

            
        }

        public Keys Hotkey
        {
            get
            {
                return _hotkey;
            }

          
        }

        public DateTime LastTimeUsed
        {
            get
            {
                return _lastTimeUsed;
            }

            set
            {
                _lastTimeUsed = value;
            }
        }

        public int MaxHP
        {
            get
            {
                return _maxHP;
            }
        }

        public int MinHP
        {
            get
            {
                return _minHP;
            }
        }

        public Skill (int delay,int castTime,Keys hotkey,int maxHP,int minHP)
        {
            _delay = delay+castTime;
            _castTime = castTime;
            _hotkey = hotkey;
            _maxHP = maxHP;
            _minHP = minHP;
        }
        public bool skillCanBeUsed()
        {
            return ( DateTime.Now - LastTimeUsed ).TotalSeconds >= Delay;
        }
        public bool attackCanBeUsed(Target target)
        {
            if(Keys.NumPad3 == Hotkey)
            {
                Console.WriteLine("3DelayTime:{0}", (DateTime.Now - LastTimeUsed).TotalSeconds);
                Console.WriteLine("3HP in range?{0}", (target.targetMaxHP / 100 * MaxHP) >= target.targetCurrentHP);
                Console.WriteLine("3HP in range2?{0}", (target.targetMaxHP / 100 * MinHP) <= target.targetCurrentHP);
            }
            if (Keys.NumPad1 == Hotkey)
            {
                Console.WriteLine("1DelayTime:{0}", (DateTime.Now - LastTimeUsed).TotalSeconds);
                Console.WriteLine("1HP in range?{0}", (target.targetMaxHP / 100 * MaxHP) >= target.targetCurrentHP);
                Console.WriteLine("1HP in range2?{0}", (target.targetMaxHP / 100 * MinHP) <= target.targetCurrentHP);
            }
            return (DateTime.Now - LastTimeUsed).TotalSeconds >= Delay 
                && (target.targetMaxHP/100*MaxHP)>=target.targetCurrentHP
                && (target.targetMaxHP / 100 * MinHP) <= target.targetCurrentHP
                ;
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Hotkey == ((Skill) obj).Hotkey;
        }

    }
}
