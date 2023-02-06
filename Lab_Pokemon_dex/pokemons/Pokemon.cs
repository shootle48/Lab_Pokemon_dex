﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex.pokemons
{
    public class Pokemon
    {
        protected string name { get; set; }
        protected int HP { get; set; }
        protected int Attack { get; set; }
        protected int Defense { get; set; }
        protected int Speed { get; set; }

        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return this.name; }
        public int getHP() { return this.HP; }
        public int getAttack() { return this.Attack; }
        public int getDefense() { return this.Defense; }
        public void takeDamage(int damage)
        {
            this.HP -= damage;
        }
    }
}
