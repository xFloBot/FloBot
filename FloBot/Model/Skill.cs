﻿using System;
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

        public Skill (int delay,int castTime,Keys hotkey)
        {
            _delay = delay+castTime;
            _castTime = castTime;
            _hotkey = hotkey;
        }
        public bool skillCanBeUsed()
        {
            return ( DateTime.Now - LastTimeUsed ).TotalSeconds >= Delay;
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
