using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class SnakeLevel4Builder : SnakeLevelsBuilder
    {
        public override Image BrickImage => Image.FromFile(Paths.LevelsResourcesPaths + "LVL4\\star.png");
        public override Color BackgroundColor => Color.Black;
        public override Brush MainBrush => Brushes.Black;
        public override int InitialSnakeLength => 5;
        public override int NumberOfBricksPerSide { get; set; }
        public override int NumberOfBonusesAtStartup => 5;
        public SnakeLevel4Builder(IPetSnake currentPet, SnakeGameForm snakeGameForm) : base(currentPet, snakeGameForm) {
            InitializeNumOfBlocksPerSideAndSideCoordinates(15);
        }

    }
}
