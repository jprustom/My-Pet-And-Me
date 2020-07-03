using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class SnakeLevel1Builder : SnakeLevelsBuilder
    {
        public override Image BrickImage  => Image.FromFile(Paths.LevelsResourcesPaths + "LVL1\\wall.png") ; 
        public override Color BackgroundColor => Color.White;
        public override Brush MainBrush => Brushes.White;
        public override int InitialSnakeLength => 2;
        public override int NumberOfBricksPerSide { get; set; }
        public override int NumberOfBonusesAtStartup => 2;

        public SnakeLevel1Builder(IPetSnake currentPet, SnakeGameForm snakeGameForm) : base(currentPet, snakeGameForm) {
            InitializeNumOfBlocksPerSideAndSideCoordinates(12);
        }
      
       
    }
}
