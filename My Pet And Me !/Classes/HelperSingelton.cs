using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public class HelperSingelton
    {
     
        private static HelperSingelton instance { get; set; }
        static private Dictionary<string, Image> HelpersDictionary => new Dictionary<string, Image>()
        {
            { "Sarah",Image.FromFile(Paths.HelpersPath+"sarah.png")},
            {"Jean-Paul",Image.FromFile(Paths.HelpersPath+"JP.png") }
        };
        private HelperSingelton(HelperForm helperForm) {
            DisplayHelper(helperForm);
        }

       static void DisplayHelper(HelperForm helperForm) {
            Random rand = new Random();
            KeyValuePair<string, Image> randomHelper = HelpersDictionary.ElementAt(rand.Next(HelpersDictionary.Count));
            PictureBox helperPicBox = new PictureBox
            {
                Visible = true,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(320, 620),
                Image = randomHelper.Value,
                Left = 5,
                Top = 5
            };
            Label helperLabel = new Label
            {
                Visible = true,
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(480, 550),
                Left = helperPicBox.Left + helperPicBox.Width + 5,
                Top = 15,
                ForeColor = Color.Blue,
                Font = new Font("Microsoft Sans Serif", (float)15.75, FontStyle.Bold),
                Text = $"Hey {helperForm.PlayerName}! My name is {randomHelper.Key} And I shall tell you how the game works.\n" +
                    "First start by clicking on any pet you'd like to pick and he will be your companion!\n" +
                     "A pet companion is a friend that will be with you throughout the game, he will just be there and you will basically move him.\n" +
                     "Then, you will have to make a choice between three games:  Snake, Pong And Brick Breaker!\n" +
                     "Snake: Your pet will take the form of a hungry snake and you will have to feed him. Beware Of Collisions!\n" +
                     "Pong: You will play versus another player with another pet companion, both of you will shoot balls and try to score a goal,\n" +
                     "Brick Breaker: You have some bricks that you gotta smash. " +
                     "That's it, your're ready: Let your journey begin !"

            };
            helperForm.Text = $"Meet {randomHelper.Key} !";
            helperForm.Controls.Add(helperPicBox);
            helperForm.Controls.Add(helperLabel);
        }

        public static HelperSingelton LoadHelper(HelperForm helperForm)
        {
            if (instance == null)
            {
                instance = new HelperSingelton(helperForm);
                return instance;
            }

            DisplayHelper(helperForm);
            return instance;        
        }

   
    }
}
