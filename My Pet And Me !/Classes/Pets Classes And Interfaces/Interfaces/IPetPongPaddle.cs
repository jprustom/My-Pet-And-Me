using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static My_Pet_And_Me__.PongGameMode;

namespace My_Pet_And_Me__
{
    public interface IPetPongPaddle : IPet
    {
        int PetPongPaddleSpeed { get; }
        PetPongPaddleDirection PetPongPaddleDirection { get; set; }
        PictureBox PetPongPaddlePictureBox { get; set; }
    }
}
