using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex.pokemons
{
    internal class Snorlax : Pokemon
    {
        public Snorlax()
        {
            Random random = new Random();
            this.name = "Snorlax";
            //random number between >= 430 and < 525
            this.HP = random.Next(430, 525);
            this._image = Properties.Resources._144;
            this.Attack = random.Next(202, 351);
            this.Defense = random.Next(121, 252);
        }
    }
}
