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
using static My_Pet_And_Me__.PongGameMode;

namespace My_Pet_And_Me__
{

    public partial class PongGameForm : Form
    {

        #region Getter To Timer

        public List<Timer> GetTimers => new List<Timer>()
        {
            timer,
            playPetSound,
            createBallInstance
        };

        #endregion

        #region Properties & Constants
   
        BallGame CurrentBallGameInstance { get; set; }
        public IPetPongPaddle CurrentPetPaddle { get; set; }
        public IPetPongPaddle BotPetPaddle { get; set; }
        public List<Ball> Balls { get; set; }

        #endregion

        #region Constructor

        public PongGameForm(IPetPongPaddle curentPetPaddle)
        {
            InitializeComponent();

            CurrentPetPaddle = curentPetPaddle;

            CurrentBallGameInstance = new BallGame(new PongGameMode(this));
            CurrentBallGameInstance.Build();

        }

        #endregion

        #region Events

        #region Key Press Events

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    CurrentPetPaddle.PetPongPaddleDirection = PetPongPaddleDirection.Up;
                    break;
                case Keys.S:
                case Keys.Down:
                    CurrentPetPaddle.PetPongPaddleDirection = PetPongPaddleDirection.Down;
                    break;

            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                case Keys.S:
                case Keys.Down:
                    CurrentPetPaddle.PetPongPaddleDirection = PetPongPaddleDirection.Idle;
                    break;

            }
        }



        #endregion

        #region Timers Ticks Events
        private void playPetSound_Tick(object sender, EventArgs e)
        {
            CurrentPetPaddle.PlaySound();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CurrentBallGameInstance.ManageBalls();
            CurrentBallGameInstance.DisplayScore();
          
            CurrentBallGameInstance.MovePet();



        }
        private void createBallInstance_Tick(object sender, EventArgs e)
        {
            CurrentBallGameInstance.CreateBallInstance();
        }

        #endregion

        private void PongGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Enabled = false;
            playPetSound.Enabled = false;
            CurrentPetPaddle.AssociatedPlayer.Score = 0;
        }

        #endregion

        
    }
}
