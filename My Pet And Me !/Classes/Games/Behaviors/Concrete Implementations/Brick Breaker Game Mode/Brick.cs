using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public class Brick
    {
        #region Properties

        public PictureBox brickPicBox { get; set; }
        private BrickBreakerGameForm CurrentBrickBreakerForm { get; set; }
        private List<PictureBox> AllCurrentBricks { get; set; }

        #endregion

        #region Constructor: Build A Brick

        public Brick(BrickBreakerGameForm brickBreakerForm, Random rand)
        {

            CurrentBrickBreakerForm = brickBreakerForm;
            AllCurrentBricks = new List<PictureBox>();
            brickPicBox = new PictureBox
            {
                BackColor = GetColor(rand.Next(1, 7)),
                Width = rand.Next(50, 101),
                Height = rand.Next(10, 26),
                Tag = "Brick",
                Visible = true
            };

            //To Draw A Brick We Have To First Get All Current Bricks In The BrickBreaker Form
            //Then We Draw A Brick Only And Only If It Does Not Intersect With Any Brick
            DrawBrickOnBrickBreakerForm();

        }

        #region GetColor Helper

        private Color GetColor(int c)
        {

            Color color;

            switch (c)
            {
                case 1:
                    color = Color.Blue;
                    break;
                case 2:
                    color = Color.Red;
                    break;
                case 3:
                    color = Color.Purple;
                    break;
                case 4:
                    color = Color.Yellow;
                    break;
                case 5:
                    color = Color.Green;
                    break;
                default:
                    color = Color.Black;
                    break;
            }
            return color;
        }

        #endregion

        #endregion

        #region Methods & Helpers

        private void DrawBrickOnBrickBreakerForm()
        {
            GetAllBricks();
            DisplayBrickOnScreen(new Random());
        }
        private void GetAllBricks()
        {
            foreach (var item in
                CurrentBrickBreakerForm.Controls.OfType<PictureBox>().Where(t => t.Tag == "Brick"))
                AllCurrentBricks.Add(item);
        }
        private void DisplayBrickOnScreen(Random rand)
        {
            do
            {
                brickPicBox.Left = rand.Next(0, (CurrentBrickBreakerForm.ClientSize.Width - brickPicBox.Width));
                brickPicBox.Top = rand.Next(0, CurrentBrickBreakerForm.ClientSize.Height / 2);
            }
            while (!CheckIntersect());
            
            AddBrick();
        }
        private bool CheckIntersect()
        {
            for (int i = 0; i < AllCurrentBricks.Count; i++)
                if (brickPicBox.Bounds.IntersectsWith(AllCurrentBricks[i].Bounds))
                    return false;
            return true;

        }
        private void AddBrick()
        {
            AllCurrentBricks.Add(brickPicBox);
            CurrentBrickBreakerForm.Controls.Add(brickPicBox);
        }

        #endregion
    }
}
