using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static My_Pet_And_Me__.SnakeGameMode;

namespace My_Pet_And_Me__
{
   public interface IPetSnake:IPet
    {
        SnakeDirection SnakeDirection { get; set; }
        Image PetSnakeHeadImage { get;  }
        Image PetSnakeBodyPartImage { get; }
        List<Image> PetSnakeCollectiblesList { get;  }
       
    }
}
