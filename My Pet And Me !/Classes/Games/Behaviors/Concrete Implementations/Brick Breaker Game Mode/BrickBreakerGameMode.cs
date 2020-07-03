using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public class BrickBreakerGameMode : IBallGameMode
    {
        #region Properties

        #region Static Properties & PetPaddleBrickBreakerDirection enum

        public static int BrickBreakerBallSpeed => 20;
        public static int MaxNumberOfBalls => 2;
        private static int MinimumNumberOfBricks => 10;
        private static int MaximumNumberOfBricks => 35;
        public static int NumberOfBricks { 
            get { Random rand = new Random();
                    return rand.Next(MinimumNumberOfBricks, MaximumNumberOfBricks + 1); } }

        public enum PetBrickBreakerPaddleDirection
        {
            Right,
            Idle,
            Left
        }

        #endregion

        public List<Brick> Bricks { get; set; }
        public List<Ball> Balls { get; set; }
        public PictureBox PlayerPaddlePicBox => CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddlePictureBox;
        public IPetBrickBreakerPaddle CurrentPetBrickBreakerPaddle { get; set; }
        Player CurrentPlayer => CurrentBrickBreakerGameForm.CurrentPetBrickBreakerPaddle.AssociatedPlayer;
        public BrickBreakerGameForm CurrentBrickBreakerGameForm { get; set; }

        #endregion

        #region Constructor

        public BrickBreakerGameMode(BrickBreakerGameForm brickBreakerForm)
        {
            Bricks = new List<Brick>();
            CurrentBrickBreakerGameForm = brickBreakerForm;
            CurrentPetBrickBreakerPaddle = CurrentBrickBreakerGameForm.CurrentPetBrickBreakerPaddle;
            CurrentBrickBreakerGameForm.Controls.Add(PlayerPaddlePicBox);
        }

        #endregion

        #region Behaviors

        #region Basic Behaviors Inherited From Game SuperClass

        #region 1- Build

        //AFTER INITIALIZE COMPONENT
        public void Build()
        {
            //Reset Score In Case We Are Re-Building Level
            CurrentPlayer.Score = 0;

            CreateBallInstance();//This Method Is Itself A Behavior Implemented

            PositionPlayerPaddle();

            AddBricks();
        }

        #region Helpers

        #region Position Player Paddle

        private void PositionPlayerPaddle()
        {
            PlayerPaddlePicBox.Top = CurrentBrickBreakerGameForm.ClientSize.Height - PlayerPaddlePicBox.Height;
            PlayerPaddlePicBox.Left = CurrentBrickBreakerGameForm.ClientSize.Width / 2 - PlayerPaddlePicBox.Width / 2;
        }

        #endregion

        #region Add Bricks

        private void AddBricks()
        {
            Random rand = new Random();
            
            for (int i = 0; i < NumberOfBricks; i++)
            {
                Bricks.Add(new Brick(CurrentBrickBreakerGameForm, rand));
            }
        }

#endregion

        #endregion

        #endregion

        #region 2- Move Pet

        public void MovePet()
        {
            #region Move Right

            var paddleRight = PlayerPaddlePicBox.Left + PlayerPaddlePicBox.Width;

            if (CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection == PetBrickBreakerPaddleDirection.Right
             && paddleRight < CurrentBrickBreakerGameForm.ClientSize.Width)
                PlayerPaddlePicBox.Left += CurrentPetBrickBreakerPaddle.PetPaddleBrickBreakerSpeed;

            #endregion

            #region Move Left

            else if (CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection==PetBrickBreakerPaddleDirection.Left 
                && PlayerPaddlePicBox.Left > 0)
                PlayerPaddlePicBox.Left -= CurrentPetBrickBreakerPaddle.PetPaddleBrickBreakerSpeed;

            #endregion

        }

        #endregion

        #region 3- Display Score

        public void DisplayScore()
        {
            foreach (Ball ball in Balls)
                for (int brickIndex=Bricks.Count-1;brickIndex>=0;brickIndex--)
                    if (Bricks[brickIndex].brickPicBox.Bounds.IntersectsWith(ball.BallPictureBox.Bounds))
                        HandleBrickCollision(Bricks[brickIndex],ball);   
        }

        #region Helpers

        void HandleBrickCollision(Brick brick, Ball ballToReverseOnYAxis)
        {
            Game.PlaySound(Paths.GamesSoundEffectsPath + "pongbrickbreakerscore.wav");

            CheckBrickColor(brick);

            RemoveBrick(brick);

            CurrentBrickBreakerGameForm.Text = "Score: " + CurrentPlayer.Score;

            ballToReverseOnYAxis.ReverseBallOnYAxis();
        }

        private void RemoveBrick(Brick brick)
        {
            CurrentBrickBreakerGameForm.Controls.Remove(brick.brickPicBox);
            Bricks.Remove(brick);
        }

        private void CheckBrickColor(Brick brick)
        {
            PictureBox brickPictureBox = brick.brickPicBox;

            if (brickPictureBox.BackColor == Color.Blue)
                CurrentPlayer.Score++;

            else if (brickPictureBox.BackColor == Color.Red)
                CurrentPlayer.Score += 2;
            else if (brickPictureBox.BackColor == Color.Purple)
                CurrentPlayer.Score += 3;
            else if (brickPictureBox.BackColor == Color.Yellow)
                CurrentPlayer.Score += 4;
            else
                CurrentPlayer.Score += 6;
        }

        #endregion

        #endregion

        #region 4-Game Over

        public void GameOver()
        {
            if (Won())
                return;

            if (CurrentBrickBreakerGameForm.Balls.Count > 0)
                return;

            DisplayGameOverMessage();
        }

        #region Helpers 
       
        private bool Won()
        {
            if (Bricks.Count == 0)
            {
                Game.DisableTimers(CurrentBrickBreakerGameForm.GetTimers);

                var dialogResultToShow = MessageBox.Show("Proceed To Next Level?", $"Wow! You Broke All Bricks!\n" +
                    $"Your Score Was {CurrentPlayer.Score}", MessageBoxButtons.YesNo);

                if (dialogResultToShow == DialogResult.Yes)
                    RemoveBallsAndRebuildLevel();

                else if (dialogResultToShow == DialogResult.No)
                    CurrentBrickBreakerGameForm.Close();

                return true;
            }

            return false;
        }

       

        private void RemoveBallsAndRebuildLevel()
        {
            for (int ballIndex = Balls.Count - 1; ballIndex >= 0; ballIndex--)
                RemoveBall(Balls[ballIndex]);
            
            
            Build();
            CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection = PetBrickBreakerPaddleDirection.Idle;
            foreach (Timer timer in CurrentBrickBreakerGameForm.GetTimers)
                timer.Enabled = true;
        }

        private void RemoveBall(Ball ballToRemove)
        {
            CurrentBrickBreakerGameForm.Controls.Remove(ballToRemove.BallPictureBox);
            Balls.Remove(ballToRemove);
        }

        private void DisplayGameOverMessage()
        {
            Game.PlaySound(Paths.GamesSoundEffectsPath + "gameover.wav");
            Game.DisableTimers(CurrentBrickBreakerGameForm.GetTimers);
            var possibleMessagesToAppear = new List<string>()
            {
                "Game Over. You Can't Break Bricks Anymore !",
                "Game Over. You Lost.",
                $"{CurrentPetBrickBreakerPaddle.PetName}:\n" +
                    $"Wow, {CurrentPlayer.PlayerName}, We Scored {CurrentPlayer.Score}!",
                $"{CurrentPetBrickBreakerPaddle.PetName}:\n" +
                    $"We'll Score Better Next Time!"
            };
            Random ran = new Random();
            var randomIndex = ran.Next(possibleMessagesToAppear.Count);
            MessageBox.Show(possibleMessagesToAppear[randomIndex]);

            CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection = PetBrickBreakerPaddleDirection.Idle;
            CurrentBrickBreakerGameForm.Close();
        }

        #endregion

        #endregion

        #endregion

        #region Ball Game Behaviors, Inherited From BallGame, Which Itself Inherits From Game

        #region Create Ball Instance Behavior

        public void CreateBallInstance()
        {
            if (Balls == null) 
            {
                Balls = new List<Ball>();
                Balls.Add(new Ball(CurrentBrickBreakerGameForm, Bricks));
                CurrentBrickBreakerGameForm.Balls = Balls;
                return;
            }

            if (Balls.Count < MaxNumberOfBalls)
                Balls.Add(new Ball(CurrentBrickBreakerGameForm, Bricks));
        }

        #endregion

        #region Manage Balls Behavior

        public void ManageBalls()
        {
            DisplayScore(); //Display Score Itself Is A Behavior

            for (int index = Balls.Count - 1; index >= 0; index--)
            {
                Ball ballToManage = Balls[index];
            
                ballToManage.ManageBallFaçade.IfBallHitPetPaddle(ballToManage);
                ballToManage.ManageBallFaçade.MoveBall(ballToManage);
                ballToManage.ManageBallFaçade.IfBallHitEdges(ballToManage);

               GameOver();

            }
            
        }

        #endregion

        #endregion

        #endregion
        
    }
}
