using Lab_Pokemon_dex.pokemons;

namespace Lab_Pokemon_dex
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Munchlax());
            pokemons.Add(new Snorlax());
            pokemons.Add(new Jigglypuff());
            pokemons.Add(new Diglett());

            this.monster = new Beedrill();
            this.pictureBox2.Image = this.monster.getImage();
            this.textBox3.Text = this.monster.getName();
            this.textBox4.Text = this.monster.getHP().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0) 
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.selectedPokemon.getAttack() - this.monster.getDefense();
            int reflectDamage = this.monster.getAttack() - this.selectedPokemon.getDefense();
            if (damage >= 0 && reflectDamage >= 0)
            {
                this.textBox2.Text = this.selectedPokemon.takeDamage(damage).ToString();
                this.textBox4.Text = this.monster.takeDamage(reflectDamage).ToString();
            }
            if (this.monster.getHP() <= 0)
            {
                this.labelResult.Text = "Yon Won!";
                this.pictureBox2.Image = null;
            }
            else if(this.selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image= null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
            }
            //display data
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.selectedPokemon.getHP() > 0) 
            {
                int getHeal = this.selectedPokemon.getHP() + 50;
                this.textBox2.Text = getHeal.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int getDefense = this.selectedPokemon.getDefense() + 50;
        }
    }
}