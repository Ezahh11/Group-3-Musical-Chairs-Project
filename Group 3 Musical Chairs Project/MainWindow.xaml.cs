
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group_3_Musical_Chairs_Project
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheGameBoard();
        }

        private void MakeTheGameBoard()
        {
            PlayerCharacters[] menuItems = new PlayerCharacters[5];
            string guacamolePrice;

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new PlayerCharacters();
                if (i >= 3)
                {
                    menuItems[i].Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };
                }
                menuItems[i].Generate();
            }

            player1.Text = menuItems[0].Description;
            chair1.Text = menuItems[0].Price;
            player2.Text = menuItems[1].Description;
            chair2.Text = menuItems[1].Price;
            player3.Text = menuItems[2].Description;
            chair3.Text = menuItems[2].Price;
            player4.Text = menuItems[3].Description;
            MusicPlayer.Text = menuItems[3].Price;
            StartGame.Text = menuItems[4].Description;
            MovePlayer.Text = menuItems[4].Price;

            PlayerCharacters specialMenuItem = new PlayerCharacters()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };
            specialMenuItem.Generate();

            Empty1.Text = specialMenuItem.Description;
            Empty2.Text = specialMenuItem.Price;

            PlayerCharacters guacamoleMenuItem = new PlayerCharacters();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;

            Empty3.Text = "Add guacamole for " + guacamolePrice;
        }
    }

    class PlayerCharacters
    {
        public static Random Randomizer = new Random();

        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
        }
    }
}
