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
            this.pictureBox2.Image - this.monster.getImage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.monster.getDefense() - this.selectedPokemon.getAttack();
            this.monster.takeDamage(damage);
            //display data
        }
    }
}