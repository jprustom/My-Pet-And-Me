using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public class ManagePongBallFaçade : IManageBallFaçade
    {

        PongGameForm CurrentPongForm { get; set; }

        public ManagePongBallFaçade(PongGameForm currentPongForm)
        {

            CurrentPongForm = currentPongForm;

        }

        #region 1-MoveBall

        public void MoveBall(Ball ball)
        {

            ball.MoveBallOnYAxis();
            ball.MoveBallOnXAxis();
        }

        #endregion

        #region 2-IfBallHitEdges

        public void IfBallHitEdges(Ball ball)
        {
            IfBallHitLeftOrRightEdge(ball);

            IfBallHitTopOrBottomEdge(ball);
        }

        #region Helpers

        private void RemoveBall(Ball ball, Player player)
        {
            CurrentPongForm.Balls.Remove(ball);
            AddBallIfNoBalls();
            player.Score++;
        }

        private void AddBallIfNoBalls()
        {
            if (CurrentPongForm.Balls.Count == 0)
                CurrentPongForm.Balls.Add(new Ball(CurrentPongForm));
        }

        private void IfBallHitLeftOrRightEdge(Ball ball)
        {
            var ballPictureBoxRight = ball.BallPictureBox.Left + ball.BallPictureBox.Width;

            if (ball.BallPictureBox.Left <= 0)
            {
                ball.BallPictureBox.Visible = false;
                Game.PlaySound(Paths.GamesSoundEffectsPath + "pongbotscore.wav");
                RemoveBall(ball, CurrentPongForm.BotPetPaddle.AssociatedPlayer);
            }

            else if (ballPictureBoxRight >= CurrentPongForm.ClientSize.Width)
            {
                ball.BallPictureBox.Visible = false;
                Game.PlaySound(Paths.GamesSoundEffectsPath + "pongbrickbreakerscore.wav");
                RemoveBall(ball, CurrentPongForm.CurrentPetPaddle.AssociatedPlayer);
            }

            
        }

        private void IfBallHitTopOrBottomEdge(Ball ball)
        {
            var ballBottom = ball.BallPictureBox.Top + ball.BallPictureBox.Height;

            if (ball.BallPictureBox.Top <= 0 || ballBottom >= CurrentPongForm.ClientSize.Height)
                ball.ReverseBallOnYAxis();

        }

        #endregion

        #endregion

        #region 3-IfBallHitPaddle

        public void IfBallHitPetPaddle(Ball ball)
        {

            if (ball.BallPictureBox.Bounds.IntersectsWith(CurrentPongForm.BotPetPaddle.PetPongPaddlePictureBox.Bounds) ||
                            ball.BallPictureBox.Bounds.IntersectsWith(CurrentPongForm.CurrentPetPaddle.PetPongPaddlePictureBox.Bounds))
                ball.ReverseBallOnXAxis();
        }

        #endregion






    }
}
