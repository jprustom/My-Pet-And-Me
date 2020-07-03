using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Media;
using System.Diagnostics;

namespace My_Pet_And_Me__
{
    public partial class MenuForm : Form
    {
        Random rand => new Random();
        string RandomBackgroundMusicPathToPlay { get; set; }
        public Player CurrentPlayer { get; set; }
        HistoryForm HistoryForm { get; set; }
        bool isNotMuted => muteToolStripMenuItem.Text == "Mute";

        public MenuForm(Player player, bool isNewGame, HistoryForm historyForm)
        {
            InitializeComponent();

            PlayBackgroundMusic();
           
            HistoryForm = historyForm;
            CurrentPlayer = player;
            minimizeHistoryFormTimer.Enabled = !isNewGame;

            if (isNewGame)
            {
                MinimizeHistoryForm();
                HelperForm helperForm = new HelperForm(CurrentPlayer);
                helperForm.ShowDialog();
            }

            CloseLoginForm();

        }

        private void PlayBackgroundMusic()
        {
            mediaPlayer.settings.setMode("loop", true);
            int randomIndex = rand.Next(Paths.ListOfBackgroundMusic.Count);
            RandomBackgroundMusicPathToPlay = Paths.ListOfBackgroundMusic[randomIndex];
            mediaPlayer.URL = RandomBackgroundMusicPathToPlay;
            mediaPlayer.Ctlcontrols.play();

        }

        private void changeMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string newRandomMusicPath = RandomBackgroundMusicPathToPlay;
            do
            {
                int randomIndex = rand.Next(Paths.ListOfBackgroundMusic.Count);
                newRandomMusicPath = Paths.ListOfBackgroundMusic[randomIndex];
            }
             while (newRandomMusicPath == RandomBackgroundMusicPathToPlay);

            RandomBackgroundMusicPathToPlay = newRandomMusicPath;
            mediaPlayer.URL = RandomBackgroundMusicPathToPlay;
           
        }
        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isNotMuted)
                Mute();
            
            else
                Unmute();
        }

        private void Unmute()
        {
            muteToolStripMenuItem.Text = "Mute";
            mediaPlayer.Ctlcontrols.play();
        }

        private void Mute()
        {
            muteToolStripMenuItem.Text = "Unmute";
            mediaPlayer.Ctlcontrols.pause();
        }

        private static void CloseLoginForm()
        {
            LoginForm loginForm = (LoginForm)Application.OpenForms["LoginForm"];
            if (loginForm != null)
                loginForm.Close();
        }

        private void petPicBox_Click(object sender, EventArgs e)
        {
            PictureBox currentPetClickedPictureBox = sender as PictureBox;

            Pet chosenPet;

            if (currentPetClickedPictureBox.Name.Contains("rabbit"))
                chosenPet = new Rabbit(CurrentPlayer);

            else if (currentPetClickedPictureBox.Name.Contains("snake"))
                chosenPet = new Snake(CurrentPlayer);

            else if (currentPetClickedPictureBox.Name.Contains("turtle"))
                chosenPet = new Turtle(CurrentPlayer);

            else if (currentPetClickedPictureBox.Name.Contains("fox"))
                chosenPet = new Fox(CurrentPlayer);

            else if (currentPetClickedPictureBox.Name.Contains("bird"))
            {

                chosenPet = new Bird(CurrentPlayer);
            }

            else if (currentPetClickedPictureBox.Name.Contains("cat"))
                chosenPet = new Cat(CurrentPlayer);

            else
                chosenPet = new Dog(CurrentPlayer);

            CurrentPlayer.PetCompanion = chosenPet;

            MessageBox.Show(chosenPet.ToString(),$"Hey {CurrentPlayer.PlayerName} !");

            ChooseGameForm chooseGameForm = new ChooseGameForm(chosenPet);
            chooseGameForm.ShowDialog();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HistoryForm.WindowState = FormWindowState.Normal;
        }

        private void minimizeHistoryFormTimer_Tick(object sender, EventArgs e)
        {
            MinimizeHistoryForm();
        }

        private static void MinimizeHistoryForm()
        {
            HistoryForm openHistoryForm = (HistoryForm)Application.OpenForms["HistoryForm"];
            if (openHistoryForm != null)
                openHistoryForm.WindowState = FormWindowState.Minimized;
        }

        private void closeCurrentGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
