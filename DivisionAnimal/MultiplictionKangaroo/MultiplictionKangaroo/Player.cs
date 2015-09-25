using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplictionKangaroo
{
    class Player
    {

        int lives;

        public Player()
        {
            setLives(3);
        }


        public void setLives(int setLife)
        {
            lives = setLife;
        }

        public void lifeLoss()
        {
            lives--;
        }

        public void lifeGain()
        {
            lives++;
        }

        public int returnLives()
        {
            return lives;
        }
    }
}
