using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex.pokemons
{
    internal class Munchlax : Pokemon
    {
        public Munchlax() 
        {
            Random random = new Random();
            this.name = "Munchlax";
            //random number between >= 380 and < 475
            this.HP = random.Next(380, 475);
            this._image = Properties.Resources._447;
            this.Attack = random.Next(157, 296);
            this.Defense = random.Next(76, 197);
        }

    }
}
