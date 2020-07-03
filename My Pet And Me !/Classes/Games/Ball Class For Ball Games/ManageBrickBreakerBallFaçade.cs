using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    class ManageBrickBreakerBallFaçade : IManageBallFaçade
    {
        #region Properties

        private BrickBreakerGameForm CurrentBrickBreakerForm { get; set; }
        public List<Brick> Bricks { get; set; }

        #endregion

        #region Constructor

        public ManageBrickBreakerBallFaçade(BrickBreakerGameForm brickBreakerForm,List<Brick> Bricks)
        {
            CurrentBrickBreakerForm = brickBreakerForm;
            this.Bricks = Bricks;
        }

        #endregion

        #region Implemented Methods

        public void MoveBall(Ball ball)
        {
            ball.MoveBallOnXAxis();
            ball.MoveBallOnYAxis();
        }

        public void IfBallHitEdges(Ball ball)
        {
            PictureBox ballPicBox = ball.BallPictureBox;
            var ballPicBoxRight = ballPicBox.Left + ball.BallPictureBox.Width;


            if (ballPicBox.Left <= 0 || ballPicBoxRight >= CurrentBrickBreakerForm.ClientSize.Width)
                ball.ReverseBallOnXAxis();

            if (ballPicBox.Top <= 0)
                ball.ReverseBallOnYAxis();

            if (ballPicBox.Bottom >= CurrentBrickBreakerForm.ClientSize.Height)
            {
                CurrentBrickBreakerForm.Balls.Remove(ball);
                CurrentBrickBreakerForm.Controls.Remove(ballPicBox);
             

            }
        }

        public void IfBallHitPetPaddle(Ball ball)
        {
            PictureBox PetBrickBreakerPaddlePictureBox = CurrentBrickBreakerForm.CurrentPetBrickBreakerPaddle.PetBrickBreakerPaddlePictureBox;
            if (!ball.BallPictureBox.Bounds.IntersectsWith(PetBrickBreakerPaddlePictureBox.Bounds))
                return;

            ball.ReverseBallOnYAxis();

            var petPaddleCenter = PetBrickBreakerPaddlePictureBox.Left + PetBrickBreakerPaddlePictureBox.Width / 2;
            var ballCenter = ball.BallPictureBox.Left + ball.BallPictureBox.Width / 2;

            if (ballCenter > petPaddleCenter)
            {
                ball.MoveTBalloRight();
                return;
            }

            else
                ball.MoveBallToLeft() ;
            

        }

        #endregion
    }
}
