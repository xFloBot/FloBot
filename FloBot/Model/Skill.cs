using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloBot.Model
{
    class Skill : IComparable
    {
        private float _delay;
        private float _castTime;
        private DateTime _lastTimeUsed;
        private Keys _hotkey;
        private int _maxHPM;
        private int _minHPM;
        private int _maxHPP;
        private int _minHPP;
        private int _prio;

        public float Delay
        {
            get
            {
                return _delay;
            }
            
        }
        public int Prio
        {
            get
            {
                return _prio;
            }
            
        }

        public float CastTime
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

        public int MaxHPM
        {
            get
            {
                return _maxHPM;
            }
        }

        public int MinHPM
        {
            get
            {
                return _minHPM;
            }
        }

        public int MaxHPP
        {
            get
            {
                return _maxHPP;
            }
        }

        public int MinHPP
        {
            get
            {
                return _minHPP;
            }
        }

        public Skill (String delay,String castTime,Keys hotkey,int maxHPM,int minHPM,int maxHPP,int minHPP,int prio)
        {

            float.TryParse(delay, NumberStyles.Float , CultureInfo.InvariantCulture, out _delay);
            float.TryParse(castTime, NumberStyles.Float, CultureInfo.InvariantCulture, out _castTime);
         
            _hotkey = hotkey;
            _maxHPM = maxHPM;
            _minHPM = minHPM;
            _maxHPP = maxHPP;
            _minHPP = minHPP;
            _prio = prio;
        }
        public bool skillCanBeUsed()
        {
            return ( DateTime.Now - LastTimeUsed ).TotalSeconds >= Delay;
        }
        public bool attackCanBeUsed(Target target,Player player)
        {
            return skillCanBeUsed()
                && ((double)target.targetMaxHP / 100 * MaxHPM)+1 >= target.targetCurrentHP
                && ((double)target.targetMaxHP / 100 * MinHPM) <= target.targetCurrentHP

                && ((double)player.PlayerMaxHP / 100 * MaxHPP)+1 >= player.PlayerCurrentHP
                && ((double)player.PlayerMaxHP / 100 * MinHPP) <= player.PlayerCurrentHP
                ;
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Hotkey == ((Skill) obj).Hotkey;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            return Prio.CompareTo(((Skill)obj).Prio);
        }
    }
}
