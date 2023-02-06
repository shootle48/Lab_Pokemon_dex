using Lab_Pokemon_dex.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex
{
    internal class Diglett : Pokemon
    {
        public Diglett()
        {
            Random random = new Random();
            this.name = "Diglett";
            //random number between >= 430 and < 525
            this.HP = random.Next(130, 225);
            this._image = Properties.Resources._050;
        }
    }
}
