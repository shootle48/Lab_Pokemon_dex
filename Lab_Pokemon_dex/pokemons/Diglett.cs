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
            this.HP = random.Next(30, 32);
            this._image = Properties.Resources._051;
            this.Attack = random.Next(103, 230);
            this.Defense = random.Next(49, 164);
        }
    }
}
