using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class SnakeLevel7Builder : SnakeLevelsBuilder
    {
        public override Image BrickImage => Image.FromFile(Paths.LevelsResourcesPaths + "LVL7\\lava.png");
        public override Color BackgroundColor => Color.LightYellow;
        public override Brush MainBrush => Brushes.LightYellow;
        public override int InitialSnakeLength => 8;
        public override int NumberOfBricksPerSide { get; set; }
        public override int NumberOfBonusesAtStartup => 8;

        public SnakeLevel7Builder(IPetSnake currentPet, SnakeGameForm snakeGameForm) : base(currentPet, snakeGameForm) {
            InitializeNumOfBlocksPerSideAndSideCoordinates(17);
        }


    }
}
