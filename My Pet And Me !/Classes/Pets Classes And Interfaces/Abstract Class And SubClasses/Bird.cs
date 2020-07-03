using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Bird : Pet
    {
        protected override string animalStringToAddToPaths => "bird";

        public override string PetName=> "Gabriel";


        public override List<Image> PetSnakeCollectiblesList => new List<Image> {

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"worm.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"apple.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"strawberry.png"),

        };

        public Bird(Player player) : base( player) { }

        public override string ToString()
        {
            return "Let's Fly Together To The Farthest Heavens!\n" +
                base.ToString();
        }

    }
}
