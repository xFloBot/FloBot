using FloBot.MemoryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBot.Model
{
    class Position
    {
        private Single posX = 0;
        private Single posY = 0;
        private Single posZ = 0;

        public bool moved()
        {
            bool moved = !AddressUtil.getCharPosX().Equals(posX) 
           || !AddressUtil.getCharPosY().Equals(posY)
           || !AddressUtil.getCharPosZ().Equals(posZ);

            posX = AddressUtil.getCharPosX();
            posY = AddressUtil.getCharPosY();
            posZ = AddressUtil.getCharPosZ();

            return moved;
        }


    }
}
