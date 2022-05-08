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
        private string[] music;
        int tenthsOfSecondsElapsed;
        int matchesFound;
        public MainWindow()
        {
            InitializeComponent();
            MakeTheGameBoard();
        }

        
        private void MakeTheGameBoard() // This method is designed to generate the game board before starting the game
        {
            
            PlayerCharacters[] PlayerCharacters = new PlayerCharacters[5];

            for (int i = 0; i < 5; i++) // This generates the appropriate number of characters for the game
            {
                PlayerCharacters[i] = new PlayerCharacters();
                if (i >= 3)
                {
                    PlayerCharacters[i].players = new string[] { "boy", "girl", "girl2", "boy2" };
                }
                PlayerCharacters[i].Generate();
            }

            { // This loads in the music files prepared for the game
                music = new string[] { "Jeopardy", "Flashdance", "18 Survivor" };
            }

            foreach (TextBlock ChairSlot in mainGrid.Children.OfType<TextBlock>()) // This block generates the chair tokens for the game
            {
                Chair chair1 = new Chair();
                Chair chair2 = new Chair();
                Chair chair3 = new Chair();
                Chair chair4 = new Chair();
                Chair chair5 = new Chair();
            }

            foreach (TextBlock AutoPlayerSlot in mainGrid.Children.OfType<TextBlock>()) //This block generates the player tokens for the game
            {
                PlayerCharacters npc1 = new PlayerCharacters();
                PlayerCharacters npc2 = new PlayerCharacters();
                PlayerCharacters npc3 = new PlayerCharacters();
                PlayerCharacters npc4 = new PlayerCharacters();
                PlayerCharacters npc5 = new PlayerCharacters();
                Player player = new Player();

                while (true)
                {
                    
                }
            }

        }

        private void GameOverScreen() // This method is intended to run if the player character loses the game
        {
            // If the player token touches the middle button, go to GameOverScreen
            // Say "You lose!" and wait for user input to terminate program and/or restart game
        }

        private void PlayMusic(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void RotateTransformSample() // This method is intended to translate the player tokens around the chairs and simulate movement

        {

            Player player = new Player();

            Player rotatedPlayer = new Player();

            rotatedPlayer = player;
            RotateTransform rotateTransform1 = new RotateTransform(45, -50, 50);

            //rotatedPlayer.RenderTransform = rotateTransform1;
        }
    }
}

class PlayerCharacters  // This class has the automatic player tokens characteristics
{
    public static Random Randomizer = new Random();

    public virtual void Generate() // This block randomly generates the speed at which the automatic player tokens move while running around the chairs, moving towards the chairs, and how fast they react when the music stops                
    {
        decimal randomRotationSpeed = Randomizer.Next(1, 5);
        decimal randomStraightlineSpeed = Randomizer.Next(3, 7);
        double reactionTime = Randomizer.Next(1, 2);
    }
    internal string[] players;

}

class Player : PlayerCharacters
{
    public string PlayerName;

    public override void Generate() // This section overrides the PlayerCharacters characteristics and makes player faster on average
    {
        decimal randomRotationSpeed = Randomizer.Next(1, 5);
        decimal randomStraightlineSpeed = Randomizer.Next(5, 10);
    }
}

class Chair // This class creates the chair tokens that the player tokens are attempting to reach
{
    internal string[] chairs;
    public string chairNumber;

}

class Addmusic2Form1 : Form1 // This class is intended to create the music player that plays during the game
{
    WindowsMediaPlayer player = new WindowsMediaPlayer();

    Addmusic2Form1(WindowsMediaPlayer player)
    {
        this.player = player;
    }

    private class WindowsMediaPlayer
    {
        public WindowsMediaPlayer()
        {
        }
    }
}


class Form1 // This class is intended to read in music from .mp3 files to be played during the game
{
    private void Form1_Load(object sender, EventArgs e)
    {

    }

}

