using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using My_Pet_And_Me__;
using static My_Pet_And_Me__.PongGameMode;
using static My_Pet_And_Me__.SnakeGameMode;
using static My_Pet_And_Me__.BrickBreakerGameMode;
using System.Media;

namespace My_Pet_And_Me__
{
    //INTERFACE SEGREGATION: THIS SEGREGATION WILL LATER, WHILE CHOOSING A GAME, SHOW GREAT BENEFIT !
    //AT CREATION, THE PET IS STILL NOT SEGREGATED INTO A PETPSNAKE, A PETPONGPADDLE OR A PETBRICKBREAKERPADDLE!

    public abstract class Pet : IPetSnake, IPetBrickBreakerPaddle, IPetPongPaddle
    {

        #region Paddles Speed Properties That Will Be The Same Regardless Of The Animal Type

        public int PetPongPaddleSpeed => PongBallSpeed;

        public int PetPaddleBrickBreakerSpeed =>BrickBreakerBallSpeed;

        #endregion

        #region Will Be Initialized Using SuperClass's Constructor

        public SnakeDirection SnakeDirection { get; set; } //ONLY WHEN PLAYING SNAKE
        public PetPongPaddleDirection PetPongPaddleDirection { get; set; } //ONLY WHEN PLAYING PONG
        public PictureBox PetPongPaddlePictureBox { get; set; } //ONLY WHEN PLAYING PONG
        public PetBrickBreakerPaddleDirection PetBrickBreakerPaddleDirection { get; set; } //ONLY WHEN PLAYING BRICK BREAKER
        public PictureBox PetBrickBreakerPaddlePictureBox { get; set; } // ONLY WHEN PLAYING BRICK BREAKER
        public abstract string PetName { get; } //COMMON TO ALL
        public Player AssociatedPlayer { get; set; } //COMMON TO ALL

        #endregion

        #region Will Be Initialized In SubClasses' Constructor

        protected abstract string animalStringToAddToPaths { get; }
        public abstract List<Image> PetSnakeCollectiblesList { get; } //ONLY WHEN PLAYING SNAKE


        #endregion

        #region Depends On SubClass

        public void PlaySound()
        {
            SoundPlayer sPlayer = new SoundPlayer(Paths.AudioPath+animalStringToAddToPaths+".wav");
            sPlayer.Play();
        }

        public Image PetFullImage => Image.FromFile(Paths.IPetImagePath + animalStringToAddToPaths + ".png");  //Added To This Abstract Class, It Will Be Used Only When Prompting User To Choose A Game
        public Image PetSnakeHeadImage => Image.FromFile(Paths.IPetSnakePathImages + animalStringToAddToPaths + "_head.png"); //ONLY WHEN PLAYING SNAKE
        public Image PetSnakeBodyPartImage => Image.FromFile(Paths.IPetSnakePathImages + animalStringToAddToPaths + "_body.png"); //ONLY WHEN PLAYING SNAKE
        public Image PetBrickBreakerPaddleImage => Image.FromFile(Paths.IPetPaddle180DegreesImagesPath + animalStringToAddToPaths + "_whole.png"); //ONLY WHEN PLAYING BRICK BREAKER
        public Image PetPongPaddleImage => Image.FromFile(Paths.IPetPaddle90DegreesImagesPath + animalStringToAddToPaths + "_whole.png"); //ONLY WHEN PLAYING PONG
    
        #endregion

        #region Constructor

        public Pet(Player player)
        {

            #region Initializing Default Values

            #region Snake

            SnakeDirection = SnakeDirection.Up;

            #endregion

            #region Pong

            PetPongPaddleDirection = PetPongPaddleDirection.Idle;

            PetPongPaddlePictureBox = new PictureBox
            {
                Visible = true,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = PetPongPaddleImage,
                Size = new Size(20, 160),
            };

            #endregion

            #region Brick Breaker

            PetBrickBreakerPaddleDirection = PetBrickBreakerPaddleDirection.Idle;
            

            PetBrickBreakerPaddlePictureBox = new PictureBox
            {
                Visible = true,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = PetBrickBreakerPaddleImage,
                Size = new Size(135, 16),
            };

            #endregion

            #endregion

            PlaySound();

            AssociatedPlayer = player;
        }

        #endregion

        #region Overriden ToString Method: Will Be Called After Being Called By SubClass's Own ToString

        public override string ToString()
        {
            return $"My Name Is {PetName}.\nI Am Pleased To Play With You, {AssociatedPlayer.PlayerName} !\nLet's Be Friends :)";
        }//Only To Pet, Not Upper Interfaces, It Will Be Used Only Once At Creation When Clicking A Pet

        #endregion

        
    }
}
