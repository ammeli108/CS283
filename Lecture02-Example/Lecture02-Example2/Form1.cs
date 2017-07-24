using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Lecture02_Example2
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;
        public int UserCandy;
        public int UserStardust;

        public Form1()
        {
            InitializeComponent();
            pokemon = new Pokemon()
            {
                Name = "妙娃種子",
                CurrentHp = 60,
                Hp = 60,
                Height = 0.67f,
                Type = new string[] { "草", "毒" },
                Weight = 5.94f,
                PowerUpCandy = 5,
                PowerUpStardust = 3000,
                EvolveCandy = 25
            };

            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.CurrentHp.ToString() + "/" + pokemon.Hp + "HP";
            WeightLabel.Text = pokemon.Weight.ToString() + "KG";
            TypeLabel.Text = pokemon.Type[0] + "/" + pokemon.Type[1];
            HeighLabel.Text = pokemon.Height.ToString() + "M";
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            EvolveLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStardust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserCandy >= pokemon.PowerUpCandy && UserStardust >= pokemon.PowerUpStardust)

                UserCandy = UserCandy - pokemon.PowerUpCandy;
            UserStardust = UserStardust - pokemon.PowerUpStardust;
            pokemon.Hp = pokemon.Hp + 10;
            pokemon.CurrentHp = pokemon.CurrentHp + 10;
            HpLabel.Text = pokemon.CurrentHp.ToString() + "/" + pokemon.Hp + "HP";
            UserStardustLabel.Text = UserStardust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - pokemon.EvolveCandy;
            pokemon = new Pokemon()
            {
                Name = "妙娃草",
                CurrentHp = 325,
                Hp = 325,
                Height = 1.89f,
                Type = new string[] { "草", "毒" },
                Weight = 352.19f,
                PowerUpCandy = 5,
                PowerUpStardust = 3000,
                EvolveCandy = 100
            };

            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.CurrentHp.ToString() + "/" + pokemon.Hp + "HP";
            WeightLabel.Text = pokemon.Weight.ToString() + "KG";
            TypeLabel.Text = pokemon.Type[0] + "/" + pokemon.Type[1];
            HeighLabel.Text = pokemon.Height.ToString() + "M";
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            EvolveLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStardust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }
    }
}