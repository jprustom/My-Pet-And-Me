using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace My_Pet_And_Me__
{
    public partial class ChooseGameForm : Form
    {
        Pet CurrentPet { get; set; }
        public ChooseGameForm(Pet currentPet)
        {
            InitializeComponent();
            CurrentPet = currentPet;
            chosenPetPictureBox.Image = CurrentPet.PetFullImage;
        }

        private void snakeSnapshotPicBox_Click(object sender, EventArgs e)
        {
            IPetSnake CurrentPetSnake = CurrentPet ;
            ChooseSnakeGameLevels chooseSnakeGameLevels = new ChooseSnakeGameLevels(CurrentPetSnake);
            chooseSnakeGameLevels.ShowDialog();
        }

        private void pongSnapshot_Click(object sender, EventArgs e)
        {
            IPetPongPaddle CurrentPetPongPaddle = CurrentPet;
            PongGameForm pongGameForm = new PongGameForm(CurrentPetPongPaddle);
            pongGameForm.ShowDialog();
        }

        private void brickBreakerGame_Click(object sender, EventArgs e)
        {
            IPetBrickBreakerPaddle CurrentPetBrickBreakerPaddle = CurrentPet;
            BrickBreakerGameForm brickBreakerGameForm = new BrickBreakerGameForm(CurrentPetBrickBreakerPaddle);
            brickBreakerGameForm.ShowDialog();
        }
    }
}
