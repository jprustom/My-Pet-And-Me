using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class SnakeLevel5Builder : SnakeLevelsBuilder
    {
        public override Image BrickImage => Image.FromFile(Paths.LevelsResourcesPaths + "LVL5\\tree.png");
        public override Color BackgroundColor => Color.BurlyWood;
        public override Brush MainBrush => Brushes.BurlyWood;
        public override int InitialSnakeLength => 6;
        public override int NumberOfBricksPerSide { get; set; }
        public override int NumberOfBonusesAtStartup => 6;
        public SnakeLevel5Builder(IPetSnake currentPet, SnakeGameForm snakeGameForm) : base(currentPet, snakeGameForm) {
            InitializeNumOfBlocksPerSideAndSideCoordinates(16);
        }


    }
}
