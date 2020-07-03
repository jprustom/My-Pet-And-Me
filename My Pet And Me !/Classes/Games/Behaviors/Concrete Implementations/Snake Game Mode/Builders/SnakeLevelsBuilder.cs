using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace My_Pet_And_Me__
{
    public abstract class SnakeLevelsBuilder
    {
        #region Properties

        #region Properties That Will Not Be Influenced By The Builder Adapted & GameBoardFields enum

        #region Initialized In Constructor
        public Random rand { get; set; }
        public IPetSnake CurrentPetSnake { get; set; }
        public SnakeGameForm CurrentForm { get; set; }

        #endregion

        #region These Properties Will Also Be Used By SnakeGameMode But They Should Be Initialized Here

        public GameBoardFields[,] GameBoardField { get; set; }
        public List<Coordinates> SnakeCoordinatesList { get; set; }

        #endregion

        public static Coordinates InitialSnakeHeadPosition { get => new Coordinates(5, 5); }//Common To All Builders 

        public enum GameBoardFields
        {
            Free,
            Snake,
            Wall,
            Bonus
        };

        #endregion

        #region Properties That Depends On Builder Chosen

        #region Properties To Be Overriden In SubClasses & Obviously Influenced By Builders

        public abstract int InitialSnakeLength { get; }
        public abstract int NumberOfBricksPerSide { get; set; }
        public abstract Image BrickImage { get; }
        public abstract Color BackgroundColor { get; }
        public abstract Brush MainBrush { get; } //Will Be Used While Removing Snake Body Part / Brick In SnakeGameMode.cs
        public abstract int NumberOfBonusesAtStartup { get; }

        #endregion

        #region Wall Coordinates On Sides: Will Be Initialized In SnakeGameForm

        public Coordinates TopWallRightMostCoordinate { get; set; }
        public Coordinates BottomWallLeftMostCoordinate { get; set; }
        public Coordinates BottomWallRightMostCoordinate { get; set; }

        #endregion

        #endregion

        #endregion


        #region Constructor 

        public SnakeLevelsBuilder(IPetSnake currentPetSnake, SnakeGameForm snakeGameForm)
        {
            CurrentForm = snakeGameForm;
            CurrentPetSnake = currentPetSnake;
            CurrentPetSnake.SnakeDirection = SnakeGameMode.SnakeDirection.Up;
            rand = new Random();
            //Initializes 2D GameBoardFields GameBoard Array 
            GameBoardField = new GameBoardFields[SnakeGameMode.MaxNumOfWallBricksPerSide, SnakeGameMode.MaxNumOfWallBricksPerSide];
        }

        #endregion

        #region Methods That Will Be Called By All Subclasses But With Overridden Properties (Will Specify On Which SubClass Properties They Depend)

        #region 0-InitializeNumOfBlocksPerSideAndSideCoordinates Will Be Called In Each Builder Constructor (Depends On NumOfBricksPerSide)

        public void InitializeNumOfBlocksPerSideAndSideCoordinates(int numOfBricksPerSide)
        {
            NumberOfBricksPerSide = numOfBricksPerSide;
            TopWallRightMostCoordinate = new Coordinates(NumberOfBricksPerSide - 1, 0);
            BottomWallLeftMostCoordinate = new Coordinates(0, NumberOfBricksPerSide - 1);
            BottomWallRightMostCoordinate = new Coordinates(NumberOfBricksPerSide - 1,NumberOfBricksPerSide - 1);
        }

        #endregion

        #region 1-InitializeBackground (Depends On BackgroundColor)

        public void InitializeBackground(SnakeGameForm currentForm)
        {
            //We Will Prepare The Field To Allocate The Max Number Of Bricks Possible
            var EachBackgroundImageSidePixels = SnakeGameMode.MaxNumOfWallBricksPerSide * SnakeGameMode.PixelsPerImage;
            CurrentForm = currentForm;
            CurrentForm.GetBackgroundPictureBox().Image = new Bitmap(EachBackgroundImageSidePixels, EachBackgroundImageSidePixels);

            CurrentForm.SnakeGameFormGraphics = Graphics.FromImage(CurrentForm.GetBackgroundPictureBox().Image);
            CurrentForm.SnakeGameFormGraphics.Clear(BackgroundColor);

        }

        #endregion

        #region 2-DrawWalls (Depends On NumberOfWallBricksPerSide & On BrickImage)

        public void DrawWalls()
        {
            #region Top & Bottom Walls

            for (int xCoordinate = 1; xCoordinate <= NumberOfBricksPerSide - 2; xCoordinate++)
            {
                //Top Side
                DrawWall(new Coordinates(xCoordinate, 0));

                //Bottom Side
                int numberOfImagesBetweenTopAndDown = NumberOfBricksPerSide - 1;
                DrawWall(new Coordinates(xCoordinate, numberOfImagesBetweenTopAndDown));
            }

            #endregion

            #region Left & Right Walls

            for (int yCoordinate = 0; yCoordinate < NumberOfBricksPerSide; yCoordinate++)
            {
                //Left Side
                DrawWall(new Coordinates(0, yCoordinate));

                //Right Side
                int numberOfImagesBetweenLeftAndRight = NumberOfBricksPerSide - 1;
                DrawWall(new Coordinates(numberOfImagesBetweenLeftAndRight, yCoordinate));
            }

            #endregion
        }

        #endregion

        #region 3-DrawSnake (Depends On InitialSnakeLength)

        public void DrawSnake()
        {
            SnakeCoordinatesList = new List<Coordinates>();

            DrawSnakePixelImage(CurrentForm.SnakeGameFormGraphics, CurrentPetSnake.PetSnakeHeadImage, InitialSnakeHeadPosition,GameBoardField);
            SnakeCoordinatesList.Add(InitialSnakeHeadPosition);

            for (int i = 1; i <= InitialSnakeLength - 1; i++)
            {
                var snakeCoordinatesToAdd = new Coordinates(InitialSnakeHeadPosition.x, InitialSnakeHeadPosition.y + i);

                DrawSnakePixelImage(CurrentForm.SnakeGameFormGraphics, CurrentPetSnake.PetSnakeBodyPartImage, snakeCoordinatesToAdd,GameBoardField);
                GameBoardField[snakeCoordinatesToAdd.x, snakeCoordinatesToAdd.y] = GameBoardFields.Snake;
                SnakeCoordinatesList.Add(snakeCoordinatesToAdd);
            }

        }

        #endregion

        #region 4- AddBonuses (Depends On NumberOfBricksPerSide & NumberOfBonusesAtStartup)

        public void AddBonuses()
        {
            for (int i = 1; i <= NumberOfBonusesAtStartup; i++)
                Bonus(CurrentPetSnake);
        }

        public void Bonus(IPetSnake CurrentPetSnake)
        {
            #region Choose Random Collectible

            var randomBonusIndex = rand.Next(CurrentPetSnake.PetSnakeCollectiblesList.Count);
            Image bonusImage = CurrentPetSnake.PetSnakeCollectiblesList[randomBonusIndex];
            CurrentPetSnake.AssociatedPlayer.Score++;

            #endregion

            #region Display This Collectible On Screen 

            int gameBoardFielXCoordinate, gameBoardFieldYCoordinate;

            do
            {
                gameBoardFielXCoordinate = rand.Next(1, NumberOfBricksPerSide - 1);
                gameBoardFieldYCoordinate = rand.Next(1, NumberOfBricksPerSide - 1);
            }
            while (GameBoardField[gameBoardFielXCoordinate, gameBoardFieldYCoordinate]
                    != GameBoardFields.Free);

            GameBoardField[gameBoardFielXCoordinate, gameBoardFieldYCoordinate]= GameBoardFields.Bonus;
           
            CurrentForm.SnakeGameFormGraphics.DrawImage(bonusImage,
                gameBoardFielXCoordinate * SnakeGameMode.PixelsPerImage, gameBoardFieldYCoordinate * SnakeGameMode.PixelsPerImage);


            #endregion
        }


        #endregion

        #region 5- ExtendField, Will Be Called In CheckForPetCollisions (Depends On NumberOfBricksPerSide)

        public void ExtendField()
        {
            NumberOfBricksPerSide++;

            #region "Erasing" Bottom Wall

            for (int lowestXAxis = 1; lowestXAxis <= BottomWallRightMostCoordinate.x; lowestXAxis++)
            {
                Debug.WriteLine("REMOVING " + $"{lowestXAxis},{BottomWallRightMostCoordinate.y}");
                RemovePixelImage(new Coordinates(lowestXAxis, BottomWallRightMostCoordinate.y));
                GameBoardField[lowestXAxis, BottomWallRightMostCoordinate.y] = GameBoardFields.Free;
            }

            #endregion

            #region "Erasing" RightMost Wall

            for (int rightMostYAxis = 1; rightMostYAxis < BottomWallRightMostCoordinate.y; rightMostYAxis++)
            {

                RemovePixelImage(new Coordinates(BottomWallRightMostCoordinate.x, rightMostYAxis));

                GameBoardField[BottomWallRightMostCoordinate.x, rightMostYAxis] = GameBoardFields.Free;
            }

            #endregion

            #region Building New RightMost Wall

            //BOTTOM WALL RIGHTMOST
            ++BottomWallRightMostCoordinate.x;
            ++BottomWallRightMostCoordinate.y;
            DrawWall(BottomWallRightMostCoordinate);

            //TOP WALL RIGHTMOST
            ++TopWallRightMostCoordinate.x;
            DrawWall(TopWallRightMostCoordinate);

            for (int rightMostYAxis = 1; rightMostYAxis <= BottomWallRightMostCoordinate.y; rightMostYAxis++)
                DrawWall(new Coordinates(TopWallRightMostCoordinate.x, rightMostYAxis));

            #endregion

            #region Building New Bottom Wall

            ++BottomWallLeftMostCoordinate.y;

            for (int lowestXAxis = BottomWallLeftMostCoordinate.x; lowestXAxis < NumberOfBricksPerSide; lowestXAxis++)
                DrawWall(new Coordinates(lowestXAxis, BottomWallLeftMostCoordinate.y));

            #endregion

            CurrentForm.GetBackgroundPictureBox().Refresh();
        }

        #endregion

        #endregion

        #region DrawSnakePixelImage 

        public void DrawSnakePixelImage(Graphics g, Image pixelImageToDraw, Coordinates coordinates, GameBoardFields[,] GameBoardField)
        {
            g.DrawImage(pixelImageToDraw, coordinates.x * SnakeGameMode.PixelsPerImage,
               coordinates.y * SnakeGameMode.PixelsPerImage);

            GameBoardField[coordinates.x, coordinates.y] = GameBoardFields.Snake;
        }

        #endregion

        #region Helpers

        void DrawWall(Coordinates coordinatesWhereToDrawWall)
        {
            CurrentForm.SnakeGameFormGraphics.DrawImage(BrickImage,
                coordinatesWhereToDrawWall.x * SnakeGameMode.PixelsPerImage,
              coordinatesWhereToDrawWall.y * SnakeGameMode.PixelsPerImage);

            GameBoardField[coordinatesWhereToDrawWall.x, coordinatesWhereToDrawWall.y] = GameBoardFields.Wall;

        }

        public void RemovePixelImage(Coordinates imageToRemoveCoordinates)
        {
            CurrentForm.SnakeGameFormGraphics.FillRectangle(MainBrush,
                imageToRemoveCoordinates.x * SnakeGameMode.PixelsPerImage,
                    imageToRemoveCoordinates.y * SnakeGameMode.PixelsPerImage,
                    SnakeGameMode.PixelsPerImage, SnakeGameMode.PixelsPerImage);
          
        }

        #endregion

    }
}
