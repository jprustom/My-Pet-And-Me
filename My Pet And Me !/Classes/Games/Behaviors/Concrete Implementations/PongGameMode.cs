using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public class PongGameMode : IBallGameMode
    {
        #region Properties

        #region Constants

        private static int ScoreLimit => 15;
        private static int MaxNumberOfBalls => 2;
        public static int PongBallSpeed => 15; //Will Be Passed To Ball Constructor

        #endregion

        private bool HasPlayerWon { get; set; }
        string gameOverMessage => HasPlayerWon
                ? $"Hooray! {CurrentPetPongPaddle.PetName} & {CurrentPetPongPaddle.AssociatedPlayer.PlayerName} Won !"
                : $"You've lost to {BotPongPaddle.PetName} & {BotPongPaddle.AssociatedPlayer.PlayerName} :(";
        private IPetPongPaddle CurrentPetPongPaddle { get; set; }
        private IPetPongPaddle BotPongPaddle { get; set; }
        private PictureBox PlayerPaddlePicBox => CurrentPetPongPaddle.PetPongPaddlePictureBox;//Quick Reference To Player's PicBox
        private PictureBox BotRacketPictureBox => BotPongPaddle.PetPongPaddlePictureBox;//Quick Reference To Bot's PicBox
        private int BotPongPaddleDirectionCoefficient { get; set; }
        private PongGameForm CurrentPongBallGameForm { get; set; }

        public List<Ball> Balls { get; set; } //Implementing IBallGame Interface

        #endregion

        #region PongPaddleDirections Enum

        public enum PetPongPaddleDirection
        {
            Up,
            Idle,
            Down
        }

        #endregion

        #region Constructor

        public PongGameMode(PongGameForm pongFameForm)
        {
            CurrentPetPongPaddle = pongFameForm.CurrentPetPaddle;
            Balls = new List<Ball>();
            CurrentPongBallGameForm = pongFameForm;
            CurrentPongBallGameForm.Balls = Balls;
            CurrentPongBallGameForm.Controls.Add(CurrentPetPongPaddle.PetPongPaddlePictureBox);
        }

        #endregion

        #region Behaviors Implemented

        #region Original Game Behivors (Common To All Games)

        #region 1-Build

        public void Build()
        {
            PositionPaddles();

            PositionDivider();

            CreateBallInstance(); //Behavior (To Ball Games Only)

        }

        #region Helpers

        private void PositionPaddles()
        {
            PositionPlayerPaddle();

            PositionBotPaddle();
        }
        private void PositionPlayerPaddle()
        {
            PlayerPaddlePicBox.Left = 0;
            PlayerPaddlePicBox.Top = (CurrentPongBallGameForm.ClientSize.Height - PlayerPaddlePicBox.Height) / 2;
        }
        private void PositionBotPaddle()
        {
            #region Create Random Bot Paddle

            CreateRandomBot();

            #endregion

            #region Place Bot Paddle On Screen

            BotRacketPictureBox.Top = (CurrentPongBallGameForm.ClientSize.Height - BotRacketPictureBox.Height) / 2;
            BotRacketPictureBox.Left = (CurrentPongBallGameForm.ClientSize.Width - BotRacketPictureBox.Width);

            CurrentPongBallGameForm.Controls.Add(BotRacketPictureBox);

            #endregion
        }
        private void CreateRandomBot()
        {

            Random rand = new Random();

            switch (rand.Next(1,8))
            {
                case 1:
                    BotPongPaddle = new Bird(RandomPlayer());
                    break;
                case 2:
                    BotPongPaddle = new Dog(RandomPlayer());
                    break;
                case 3:
                    BotPongPaddle = new Fox(RandomPlayer());
                    break;
                case 4:
                    BotPongPaddle = new Cat(RandomPlayer());
                    break;
                case 5:
                    BotPongPaddle = new Snake(RandomPlayer());
                    break;
                case 6:
                    BotPongPaddle = new Rabbit(RandomPlayer());
                    break;
                case 7:
                    BotPongPaddle = new Turtle(RandomPlayer());
                    break;

            }

            CurrentPongBallGameForm.BotPetPaddle = BotPongPaddle;
            BotPongPaddleDirectionCoefficient = 1; 
            //I Did Not Directly Reference The PetPongPaddleSpeed Property Because It Is Read-Only & I Wanna Change It
            //I Want To Keep It Read-Only Because I Never Need To Change It Unless I Want To Move A Bot In This Particular Game

        }
        private static Player RandomPlayer() => new Player(RandomName(), RandomAge());
        private static string RandomName()
        {
            Random rand = new Random();
            string[] possibleNames = { "Sebastien",  "Simon", "Antoine", "Angelo", "Clara", "Maria", "Antoinette", "Pierre", "Paul", "Trump",
                "Obama", "Bruce Lee", "Goku", "Rhea", "Rebecca", "Geovanna", "Zeina", "Marina", "Anthony", "Jonas", "Jim" };
            int randomIndex = rand.Next(possibleNames.Length);
            string randomName = possibleNames[randomIndex];
            return randomName;
        }
        private static int RandomAge()
        {
            Random rand = new Random();

            int[] possibleAges = { 4, 5, 6, 7, 8, 9, 10, 11 };
            int randomIndex = rand.Next(possibleAges.Length);

            return possibleAges[randomIndex];
        }
        private void PositionDivider()
        {
            PictureBox dividerPictureBox = new PictureBox
            {
                Size = new Size(10, 100),
                Visible = true,
                Top = 0,
                Height = CurrentPongBallGameForm.ClientSize.Height,
                Left = (CurrentPongBallGameForm.ClientSize.Width - 100) / 2
            };

            CurrentPongBallGameForm.Controls.Add(dividerPictureBox);
        }

        #endregion

        #endregion

        #region 2-Move Pet

        public void MovePet()
        {
            MovePaddleUp();
            MovePaddleDown();
        }

        #region Helpers (Directions Are Set By Pong Game Form's Timer Tick Event

        private void MovePaddleDown()
        {
            var playerRacketPictureBoxBottom = PlayerPaddlePicBox.Top + PlayerPaddlePicBox.Height;
            if (playerRacketPictureBoxBottom < CurrentPongBallGameForm.ClientSize.Height 
                && CurrentPetPongPaddle.PetPongPaddleDirection == PetPongPaddleDirection.Down)
                 PlayerPaddlePicBox.Top += CurrentPetPongPaddle.PetPongPaddleSpeed ;

        }

        private void MovePaddleUp()
        {
            if (PlayerPaddlePicBox.Top > 0 && CurrentPetPongPaddle.PetPongPaddleDirection == PetPongPaddleDirection.Up)
                PlayerPaddlePicBox.Top -=CurrentPetPongPaddle.PetPongPaddleSpeed;
        }

        #endregion

        #endregion

        #region 3-Display Score

        public void DisplayScore()
        {

            CurrentPongBallGameForm.Text = ShowPlayerScore(CurrentPetPongPaddle) +" | "+ ShowPlayerScore(BotPongPaddle);

            if (CurrentPetPongPaddle.AssociatedPlayer.Score >= ScoreLimit)
            {
                Game.DisableTimers(CurrentPongBallGameForm.GetTimers);
                HasPlayerWon = true;
                GameOver();
            }
            else if (BotPongPaddle.AssociatedPlayer.Score >= ScoreLimit)
            {
                Game.DisableTimers(CurrentPongBallGameForm.GetTimers);
                HasPlayerWon = false;
                GameOver();
            }
        }

        #region Mini-Helper

        static string ShowPlayerScore(IPetPongPaddle Pet) => $"{Pet.PetName} & {Pet.AssociatedPlayer.PlayerName}: {Pet.AssociatedPlayer.Score}";

        #endregion

        #endregion

        #region 4-Game Over

        public void GameOver()
        {
            Game.PlaySound(Paths.GamesSoundEffectsPath + "gameover.wav");
            Game.DisableTimers(CurrentPongBallGameForm.GetTimers);
            MessageBox.Show(gameOverMessage);
            CurrentPongBallGameForm.Close();
        }


        #endregion

        #endregion

        #region Ball Games Exclusive Behaviors

        #region ManageBalls: The Main Method That Will Take Place At Each Timer Tick

        //Will Be Called At Each Timer Tick Event
        public void ManageBalls()
        {
            for (int i = 0; i < Balls.Count; i++)
                PongBallFaçade(Balls[i]); //Façade Pattern: One Class Will Be Responsible For Multiple Consecutive Actions !

            BotFollowBall();
        }

        #region Helpers

        private void PongBallFaçade(Ball ballOnWhichToCallFaçade)
        {
            ManagePongBallFaçade managePongBallFaçade = ballOnWhichToCallFaçade.ManageBallFaçade as ManagePongBallFaçade;

            managePongBallFaçade.MoveBall(ballOnWhichToCallFaçade);
            managePongBallFaçade.IfBallHitEdges(ballOnWhichToCallFaçade);
            managePongBallFaçade.IfBallHitPetPaddle(ballOnWhichToCallFaçade);
        }

       
        private void BotFollowBall()
        {
            if (Balls.Count == 0)
            {
                Debug.WriteLine("NO BALLS!!!!!!, SHOULD NEVER GET HERE!");
                return;
            }

            MoveBotUpDown();

        }

        private void MoveBotUpDown()
        {

            BotRacketPictureBox.Top +=BotPongPaddle.PetPongPaddleSpeed*BotPongPaddleDirectionCoefficient;

            int botRacketPictureBoxBottom = BotRacketPictureBox.Top + BotRacketPictureBox.Height;

            if (BotRacketPictureBox.Top <= 0 || botRacketPictureBoxBottom >= CurrentPongBallGameForm.ClientSize.Height)
                  BotPongPaddleDirectionCoefficient *= -1;

        }

        #endregion


        #endregion

        #region CreateBallInstance Will Be Called Once At Build, Then At Each CreateBallTimer Tick Event 

        public void CreateBallInstance()
        {
            if (Balls.Count < MaxNumberOfBalls || Balls.Count == 0)
                Balls.Add(new Ball(CurrentPongBallGameForm));

        }

        #endregion

        #endregion

        #endregion

    }
}
