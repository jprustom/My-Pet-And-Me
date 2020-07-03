using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static My_Pet_And_Me__.PongGameForm;

namespace My_Pet_And_Me__
{
    public class Ball
    {
        #region Properties

        public IManageBallFaçade ManageBallFaçade { get; set; }  //Façade ! 
        public PictureBox BallPictureBox { get; set; }
        private Coordinates BallCoordinatesPerTick { get; set; }

        List<Image> BallsImagesList => new List<Image>() {
            Image.FromFile(Paths.BallsImagesPath+"ball1.png"),
            Image.FromFile(Paths.BallsImagesPath+"ball2.png")
        };

        #endregion

        #region Constructor Overloads

        #region Constructor For Pong Game

        public Ball(PongGameForm pongForm)
        {
            #region Setting BallCoordinatesPerTick

            BallCoordinatesPerTick = new Coordinates(-PongGameMode.PongBallSpeed, -PongGameMode.PongBallSpeed);
            //Negative Coordinates For The Ball To Fly Towards Player Rather Than Bot

            #endregion

            #region Setting Ball PictureBox & Adding It To Passed Form

            Random rand = new Random();
            int randomBallImageIndex = rand.Next(BallsImagesList.Count);
            BallPictureBox = new PictureBox
            {
                Image = BallsImagesList[randomBallImageIndex],
                Size = new Size(50, 50),
                Visible = true,
                SizeMode = PictureBoxSizeMode.Zoom,
                Left = pongForm.ClientSize.Width / 2,
                Top = rand.Next(pongForm.ClientSize.Height),
                BackColor = Color.Transparent,
            };

            pongForm.Controls.Add(BallPictureBox);

            #endregion

            ManageBallFaçade = new ManagePongBallFaçade(pongForm);
        }

        #endregion

        #region Constructor For Brick Breaker Game

        public Ball(BrickBreakerGameForm brickBreakerForm, List<Brick> Bricks)
        {
            /*TotalBalls++;*/
            BallCoordinatesPerTick = new Coordinates(BrickBreakerGameMode.BrickBreakerBallSpeed, BrickBreakerGameMode.BrickBreakerBallSpeed);

            Random rand = new Random();
            int randomBallImageIndex = rand.Next(BallsImagesList.Count);

            BallPictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                Image = BallsImagesList[randomBallImageIndex],
                Width = 15,
                Height = 15,
                Top = rand.Next(brickBreakerForm.ClientSize.Height / 4, brickBreakerForm.ClientSize.Height / 2),
                Left = brickBreakerForm.Width / 2,
                Visible = true
            };

            brickBreakerForm.Controls.Add(BallPictureBox);

            ManageBallFaçade = new ManageBrickBreakerBallFaçade(brickBreakerForm,Bricks);
        }

        #endregion

        #endregion

        #region Methods

        public void MoveTBalloRight()
        {
            BallCoordinatesPerTick.x = +Math.Abs(BallCoordinatesPerTick.x);
        }
        public void MoveBallToLeft()
        {
            BallCoordinatesPerTick.x = -Math.Abs(BallCoordinatesPerTick.x);
        }
        public void MoveBallOnYAxis()
        {
           
            BallPictureBox.Top += BallCoordinatesPerTick.y;
        }
        public void MoveBallOnXAxis()
        {

            BallPictureBox.Left += BallCoordinatesPerTick.x;
        }
        public void ReverseBallOnXAxis()
        {
            BallCoordinatesPerTick.x *= -1;
        }
        public void ReverseBallOnYAxis()
        {
            BallCoordinatesPerTick.y *= -1;
        }

        #endregion

    }
}