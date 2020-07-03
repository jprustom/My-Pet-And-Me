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
using static My_Pet_And_Me__.SnakeLevelsBuilder;
using System.Windows.Media;

namespace My_Pet_And_Me__
{
    public partial class SnakeGameForm : Form
    {
        #region Properties

        public IPetSnake CurrentPetSnake { get; set; }

        Game SnakeGameInstance { get; set; }

        public Graphics SnakeGameFormGraphics { get; set; }

        #endregion

        #region Controls To Be Accessed By The Outside Snake-Related Classes


        public List<Timer> GetTimers() => new List<Timer>()
        {
            timer,
            playPetSound
        };

        public PictureBox GetBackgroundPictureBox()
        {
            return backgroundPictureBox;
        }

        #endregion

        #region Constructor

        public SnakeGameForm(string snakeGameLevelSnapshotPictureBoxName,IPetSnake currentPetPaddleSnake)
        {
            InitializeComponent();
            
            CurrentPetSnake = currentPetPaddleSnake;
           
            #region Load Level (Choosing Right Builder)

            //The SnakeGameMode Class, Implements A IGameMode Interface Having The Role Of A Behavior Interface
            //The SnakeGameMode Class Itself, Has Also A SnakeLevelsBuilder Class
            //The SnakeGameMode, is basically part of a builder pattern and a strategy/behavior pattern

            SnakeLevelsBuilder currentSnakeLevelBuilder;

            if (snakeGameLevelSnapshotPictureBoxName.Contains("1"))
            
                currentSnakeLevelBuilder = new SnakeLevel1Builder(CurrentPetSnake,this);
            
            else if (snakeGameLevelSnapshotPictureBoxName.Contains("2"))
            
                currentSnakeLevelBuilder = new SnakeLevel2Builder(CurrentPetSnake, this);
            
            else if (snakeGameLevelSnapshotPictureBoxName.Contains("3"))
            
                currentSnakeLevelBuilder = new SnakeLevel3Builder(CurrentPetSnake, this);
            
            else if (snakeGameLevelSnapshotPictureBoxName.Contains("4"))
            
                currentSnakeLevelBuilder = new SnakeLevel4Builder(CurrentPetSnake, this);
            
            else if (snakeGameLevelSnapshotPictureBoxName.Contains("5"))
            
                currentSnakeLevelBuilder = new SnakeLevel5Builder(CurrentPetSnake, this);
            
            else if (snakeGameLevelSnapshotPictureBoxName.Contains("6"))
            
                currentSnakeLevelBuilder = new SnakeLevel6Builder(CurrentPetSnake, this);
            
            else 
                currentSnakeLevelBuilder = new SnakeLevel7Builder(CurrentPetSnake, this);


            SnakeGameMode snakeGameMode = new SnakeGameMode(currentSnakeLevelBuilder, this);
            SnakeGameInstance = new Game(snakeGameMode); //snakeGameMode Is The Behavior We Want To Adapt
            SnakeGameInstance.Build(); //Always At Form's Constructor, We Build!

            #endregion

        }

        #endregion

        #region Events

        #region Timer Tick Event
        private void playPetSound_Tick(object sender, EventArgs e)
        {
            CurrentPetSnake.PlaySound();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            SnakeGameInstance.MovePet();
   
        }

        #endregion

        #region KeyDown Event

        private void SnakeGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (CurrentPetSnake.SnakeDirection ==SnakeGameMode.SnakeDirection.Down) break;
                    CurrentPetSnake.SnakeDirection = SnakeGameMode.SnakeDirection.Up;
                    break;
                case Keys.S:
                case Keys.Down:
                    if (CurrentPetSnake.SnakeDirection == SnakeGameMode.SnakeDirection.Up) break;
                    CurrentPetSnake.SnakeDirection = SnakeGameMode.SnakeDirection.Down;
                    break;
                case Keys.A:
                case Keys.Left:
                    if (CurrentPetSnake.SnakeDirection == SnakeGameMode.SnakeDirection.Right) break;
                    CurrentPetSnake.SnakeDirection = SnakeGameMode.SnakeDirection.Left;
                    break;
                case Keys.D:
                case Keys.Right:
                    if (CurrentPetSnake.SnakeDirection == SnakeGameMode.SnakeDirection.Left) break;
                    CurrentPetSnake.SnakeDirection = SnakeGameMode.SnakeDirection.Right;
                    break;

            }
        }


        #endregion

        #region Close Form Event

        private void SnakeGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentPetSnake.AssociatedPlayer.Score = 0;
            timer.Enabled = false;
            playPetSound.Enabled = false;
        }

        #endregion

        #endregion

      
    }
}
