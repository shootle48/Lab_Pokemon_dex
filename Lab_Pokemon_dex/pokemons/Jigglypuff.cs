using Lab_Pokemon_dex.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex
{
    internal class Jigglypuff : Pokemon
    {
        public Jigglypuff()
        {
            Random random = new Random();
            this.name = "Jigglypuff";
            //random number between >= 430 and < 525
            this.HP = random.Next(340, 435);
            this._image = Properties.Resources._040;
            this.Attack = random.Next(85,208);
            this.Defense = random.Next(40, 153);
        }
    }
}
