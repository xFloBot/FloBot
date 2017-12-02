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
        public Single posX = 0;
        public Single posY = 0;
        public Single posZ = 0;

        public Position() { }
        public Position(Single[] pos)
        {
            updatePos(pos);
        }

        public void updatePos(Single[] pos)
        {
            posX = pos[0];
            posY = pos[1];
            posZ = pos[2];
        }
        public bool moved()
        {
            bool moved = AddressUtil.getCharPosX() != posX
           || AddressUtil.getCharPosY() != posY
           || AddressUtil.getCharPosZ() != posZ;

            posX = AddressUtil.getCharPosX();
            posY = AddressUtil.getCharPosY();
            posZ = AddressUtil.getCharPosZ();

            return moved;
        }

        public Single distance(Position pos)
        {
            Console.WriteLine("X: "+(pos.posX));

            Console.WriteLine(pos.posY - posY);
            return (Single) (Math.Sqrt( Math.Pow(pos.posX-posX, 2)+ Math.Pow(pos.posY-posY, 2)))/100;
        }
    }
}
