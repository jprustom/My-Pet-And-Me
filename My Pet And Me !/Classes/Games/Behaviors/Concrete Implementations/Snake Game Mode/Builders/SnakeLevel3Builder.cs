using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class SnakeLevel3Builder : SnakeLevelsBuilder
    {
        public override Image BrickImage => Image.FromFile(Paths.LevelsResourcesPaths + "LVL3\\patrick.png");
        public override Color BackgroundColor => Color.LightBlue;
        public override Brush MainBrush => Brushes.LightBlue;
        public override int InitialSnakeLength =>4;
        public override int NumberOfBricksPerSide { get; set; }
        public override int NumberOfBonusesAtStartup => 4;
        public SnakeLevel3Builder(IPetSnake currentPet, SnakeGameForm snakeGameForm) : base(currentPet, snakeGameForm) {
            InitializeNumOfBlocksPerSideAndSideCoordinates(14);
        }

    }
}
