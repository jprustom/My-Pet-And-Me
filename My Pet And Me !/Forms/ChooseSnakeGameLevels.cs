using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public partial class ChooseSnakeGameLevels : Form
    {
        IPetSnake CurrentPetPaddleSnake { get; set; }
        public ChooseSnakeGameLevels(IPetSnake currentPetSnake)
        {
            CurrentPetPaddleSnake = currentPetSnake ;
            InitializeComponent();
        }

        private void snakeGameLevelsPictureBoxes_Click(object sender, EventArgs e)
        {
            PictureBox snakeGameLevelSnapshotPictureBox = sender as PictureBox;
            string snakeGameLevelSnapshotPictureBoxName = snakeGameLevelSnapshotPictureBox.Name;
        
            SnakeGameForm snakeGameForm = new SnakeGameForm(snakeGameLevelSnapshotPictureBoxName,CurrentPetPaddleSnake);
            snakeGameForm.ShowDialog();
        }
    }
}
