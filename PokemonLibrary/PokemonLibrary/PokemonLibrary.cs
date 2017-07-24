using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonLibrary
{
    public class Pokemon

    {
        public int NationalNumber;

        public string Name;

        public int CurrentHp;

        public int Hp;

        public float Weight;

        public string[] Type;

        public float Height;

        public int PowerUpStardust;

        public int PowerUpCandy;

        public int EvolveCandy;

        public void PowerUp()
        {
            EasyRandom random = new EasyRandom();
            if (NationalNumber == 1)
            {
                double deltaHp = (int)(random.NextDouble(5.0, 15.0) / 100.0);
                Hp += (int)deltaHp;
                CurrentHp += (int)deltaHp;
            }
        }
    }
}