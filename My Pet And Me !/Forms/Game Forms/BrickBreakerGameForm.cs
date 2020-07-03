using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static My_Pet_And_Me__.BrickBreakerGameMode;

namespace My_Pet_And_Me__
{
    public partial class BrickBreakerGameForm : Form
    {
        #region Timer Control Getter

        public List<Timer> GetTimers => new List<Timer>() { 
            timer,
            createBallInstanceTimer,
            playPetSound};

        #endregion

        #region Properties

        public List<Ball> Balls { get; set; }
        public List<Brick> Bricks { get; set; }
        BallGame CurrentGameInstance { get; set; }
        public IPetBrickBreakerPaddle CurrentPetBrickBreakerPaddle { get; set; }

        #endregion

        #region Constructor

        public BrickBreakerGameForm(IPetBrickBreakerPaddle currentPetBrickBreakerPaddle)
        {

            #region Initializing Form, CurrentPetBrickBreakerPaddle Property & Assigning Image To Our Paddle PictureBox

            InitializeComponent();

            CurrentPetBrickBreakerPaddle = currentPetBrickBreakerPaddle;

            #endregion

            #region Loading Game

            BrickBreakerGameMode brickBreakerMode = new BrickBreakerGameMode(this);
            CurrentGameInstance = new BallGame(brickBreakerMode);
            Bricks = brickBreakerMode.Bricks;
            Balls = brickBreakerMode.Balls;
            CurrentGameInstance.Build();

            #endregion

        }

        #endregion

        #region Events

        #region Key Events

        private void BrickBreakerGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.Left:
                    CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection = PetBrickBreakerPaddleDirection.Left;
                    break;

                case Keys.D:
                case Keys.Right:
                    CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection = PetBrickBreakerPaddleDirection.Right;
                    break;
            }
        }

        private void BrickBreakerGameForm_KeyUp(object sender, KeyEventArgs e)
        {
                switch (e.KeyCode)
                {
                    case Keys.A:
                    case Keys.Left:
                    case Keys.D:
                    case Keys.Right:
                    CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection = PetBrickBreakerPaddleDirection.Idle;
                        break;
                }
            }

        #endregion

        #region Timer Tick Events
        private void playPetSound_Tick(object sender, EventArgs e)
        {
            CurrentPetBrickBreakerPaddle.PlaySound();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CurrentGameInstance.MovePet();

            CurrentGameInstance.ManageBalls();
        }

        private void createBallInstanceTimer_Tick(object sender, EventArgs e)
        {
            CurrentGameInstance.CreateBallInstance();
        }


        #endregion

        private void BrickBreakerGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Enabled = false;
            playPetSound.Enabled = false;
            CurrentPetBrickBreakerPaddle.AssociatedPlayer.Score = 0;
        }

        #endregion




    }
}
