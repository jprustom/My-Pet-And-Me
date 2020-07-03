using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static My_Pet_And_Me__.SnakeLevelsBuilder;

namespace My_Pet_And_Me__
{
    //The SnakeGameMode Class Itself Adapts A Builder Pattern To Build Its Various Levels
    public class SnakeGameMode : IGameMode
    {

        #region Properties & Directions enum

        #region Common To All Snake Games

        public static int SnakeSpeed => 30;
        public static int PixelsPerImage { get => 35; }
        public static int MaxNumOfWallBricksPerSide { get => 24; }

        #endregion

        #region BUILDER PATTERN TO BUILD LEVELS

        private SnakeLevelsBuilder CurrentSnakeLevelBuilder { get; set; }

        #endregion

        public SnakeGameForm CurrentSnakeForm { get; set; }

        Coordinates snakeHead { get; set; }
        Coordinates snakeTail { get; set; }
     

        public enum SnakeDirection
        {
            Up,
            Down,
            Left,
            Right
        }

        #endregion

        #region SnakeGameMode Constructor, Takes As Parameters Behavior & Form Of The Snake Game

        public SnakeGameMode(SnakeLevelsBuilder snakeGameBuilder, SnakeGameForm currentForm)
        {
            
            CurrentSnakeForm = currentForm;
            CurrentSnakeLevelBuilder = snakeGameBuilder; //Will Tell Which Level To Load

            Build(); //Will Call A SnakeLevelsBuilder Subclass 4 Times 

        }

        #endregion

        #region Implemented Behaviors

        #region Build Behavior: Each Game Will Build Itself Differently ! (This Behavior Itself Adopts A Builder Pattern)

        public void Build()
        {
            CurrentSnakeLevelBuilder.InitializeBackground(CurrentSnakeForm);
            CurrentSnakeLevelBuilder.DrawWalls();
            CurrentSnakeLevelBuilder.DrawSnake();
            CurrentSnakeLevelBuilder.AddBonuses();
        }

      
        #endregion

        #region Move Behavior: Each Game Will Move Its Pet Differently !

        //After Many Trials & Errors, Here's How It Worked:
        //1- We Remove Snake Tail
        //2- We Update Snake's Coordinates
        //3- We Erase The Head Then Draw A Body Part On Top Of It
        //4- We Draw The Head's New Position After Checking Direction
        //5- We Refresh Form's PictureBox For The Changes To Be Visualized
        public void MovePet()
        {
            IPetSnake PetSnake = CurrentSnakeForm.CurrentPetSnake;

            #region snakeHead & snakeTail Initialization

            snakeTail =CurrentSnakeLevelBuilder.SnakeCoordinatesList[CurrentSnakeLevelBuilder.SnakeCoordinatesList.Count - 1];
            snakeHead = CurrentSnakeLevelBuilder.SnakeCoordinatesList[0];

            #endregion

            #region "Remove" Snake Tail (Draw A Rectange Of The Same Dimensions & Same Color On Top Of It)

            CurrentSnakeLevelBuilder.RemovePixelImage(snakeTail);

            //The Builder Class Will Initialize The GameBoardField Property First, That's Why It Has It
            CurrentSnakeLevelBuilder.GameBoardField[snakeTail.x, snakeTail.y] = GameBoardFields.Free;

            #endregion

            #region Move Snake Along

            for (int i = CurrentSnakeLevelBuilder.SnakeCoordinatesList.Count - 1; i >= 1; i--)
            {
                CurrentSnakeLevelBuilder.SnakeCoordinatesList[i].x = CurrentSnakeLevelBuilder.SnakeCoordinatesList[i - 1].x;
                CurrentSnakeLevelBuilder.SnakeCoordinatesList[i].y = CurrentSnakeLevelBuilder.SnakeCoordinatesList[i - 1].y;
            }

            #endregion

            #region Draw Body Part In The Place Of The Head

            CurrentSnakeLevelBuilder.RemovePixelImage(snakeHead);

            CurrentSnakeForm.SnakeGameFormGraphics.DrawImage(PetSnake.PetSnakeBodyPartImage, 
                snakeHead.x * PixelsPerImage,
                snakeHead.y * PixelsPerImage);

            #endregion

            #region Handle Directions (Will Be Updated By CurrentForm's Timer Event

            switch (PetSnake.SnakeDirection)
            {
                case SnakeDirection.Up:
                    snakeHead.y--;
                    break;

                case SnakeDirection.Down:
                    snakeHead.y++;
                    break;

                case SnakeDirection.Left:
                    snakeHead.x--;
                    break;

                case SnakeDirection.Right:
                    snakeHead.x++;
                    break;

            }

            #endregion

            CheckForPetCollisions(PetSnake);

            #region Draw Head & Refresh

            CurrentSnakeLevelBuilder.DrawSnakePixelImage(CurrentSnakeForm.SnakeGameFormGraphics,
                PetSnake.PetSnakeHeadImage, snakeHead, CurrentSnakeLevelBuilder.GameBoardField);

            CurrentSnakeForm.GetBackgroundPictureBox().Refresh();

            #endregion
        }

        #endregion

        #region AddScore Behavior: Each Game Will Have A Different Mechanism To Do So

        public void DisplayScore()
        {
            CurrentSnakeForm.Text = "Snake - Score: " + CurrentSnakeLevelBuilder.CurrentPetSnake.AssociatedPlayer.Score;
        }

        #endregion

        #region GameOver Behavior

        public void GameOver()
        {
            Game.PlaySound(Paths.GamesSoundEffectsPath + "gameover.wav");

            Game.DisableTimers(CurrentSnakeForm.GetTimers());

            var possibleMessagesToShow = new List<string>()
            {
                "Oh No, You Killed Your Snake!",
                "Your Snake Has Died.",
                "Game Over, Better Luck Next Time!",
                "You Crushed Your Snake's Skull.",
                "Better Luck Next Time."
            };
            Random ran = new Random();
            int randomIndex = ran.Next(possibleMessagesToShow.Count);
            MessageBox.Show(possibleMessagesToShow[randomIndex]);

            CurrentSnakeForm.Close();
       
        }

        #endregion

        #endregion

        #region Check For Pet Collisions - Snake Game Exclusive

        public void CheckForPetCollisions(IPetSnake PetSnake)
        {

            #region snakeTail & snakeHead Updated Values

            snakeTail = CurrentSnakeLevelBuilder.SnakeCoordinatesList[CurrentSnakeLevelBuilder.SnakeCoordinatesList.Count - 1];
            snakeHead = CurrentSnakeLevelBuilder.SnakeCoordinatesList[0];

            #endregion

            #region Check Wether Snake Hit Wall Or Itself, If So, Call GameOver() Behavior

            if (CurrentSnakeLevelBuilder.GameBoardField[snakeHead.x, snakeHead.y] == GameBoardFields.Wall ||
                CurrentSnakeLevelBuilder.GameBoardField[snakeHead.x, snakeHead.y] == GameBoardFields.Snake)
            {
                GameOver(); //Will Call GameOver Behavior
                return;
            }

            #endregion

            #region Check If Snake Ate A Bonus

            if (CurrentSnakeLevelBuilder.GameBoardField[snakeHead.x, snakeHead.y] == GameBoardFields.Bonus)
            {
                Game.PlaySound(Paths.GamesSoundEffectsPath + "snakescore.wav");

                #region Add New Body Part

                CurrentSnakeLevelBuilder.SnakeCoordinatesList.Add(new Coordinates(snakeTail.x, snakeTail.y));
                DrawSnakePixelImage(CurrentSnakeForm.SnakeGameFormGraphics, PetSnake.PetSnakeBodyPartImage, snakeTail);

                #endregion

                #region Generate Another Bonus, Check For Field Extension & Update Score Text

                CurrentSnakeLevelBuilder.Bonus(PetSnake);

                CheckForFieldExtension();

                DisplayScore(); //Add Score Behavior

                #endregion

            }

            #endregion
        }



        #endregion

        #region Helpers

        void DrawSnakePixelImage(Graphics g, Image pixelImageToDraw, Coordinates coordinates)
        {
            g.DrawImage(pixelImageToDraw, coordinates.x * PixelsPerImage,
               coordinates.y * PixelsPerImage);

            CurrentSnakeLevelBuilder.GameBoardField[coordinates.x, coordinates.y] = SnakeLevelsBuilder.GameBoardFields.Snake;
        }

        private void CheckForFieldExtension()
        {
            //Field Will Extend When Snake Is Two Times And A Half Bigger Than The Number Of Bricks Per Side
            if (CurrentSnakeLevelBuilder.NumberOfBricksPerSide < MaxNumOfWallBricksPerSide
                                && CurrentSnakeLevelBuilder.SnakeCoordinatesList.Count > CurrentSnakeLevelBuilder.NumberOfBricksPerSide * 2.5)
                CurrentSnakeLevelBuilder.ExtendField();
        }

        #endregion

    }
}
