using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static My_Pet_And_Me__.BrickBreakerGameMode;

namespace My_Pet_And_Me__
{
    public interface IPetBrickBreakerPaddle:IPet
    {
        PetBrickBreakerPaddleDirection PetBrickBreakerPaddleDirection { get; set; }
        int PetPaddleBrickBreakerSpeed { get; }
        PictureBox PetBrickBreakerPaddlePictureBox { get; set; }
       
    }
}
