using Lab_Pokemon_dex.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex
{
    internal class Beedrill : Pokemon
    {
        public Beedrill() 
        {
            Random random = new Random();
            this.name = "Beedrill";
            //random number between >= 430 and < 525
            this.HP = random.Next(2400, 3350);
            this._image = Properties.Resources._016;
            this.Attack = random.Next(166, 307);
            this.Defense = random.Next(76,197);
        }
    }
}
