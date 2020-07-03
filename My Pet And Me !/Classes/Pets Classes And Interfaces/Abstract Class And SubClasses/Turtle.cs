using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Turtle :Pet
    {
        protected override string animalStringToAddToPaths => "turtle";


        public override string PetName=> "Gix";

        public override List<Image> PetSnakeCollectiblesList => new List<Image> {

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"carrot.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"lettuce.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"strawberry.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"apple.png"),

        };




        public Turtle(Player player) : base(player) { }

        public override string ToString()
        {
            return "Take a walk with a turtle. And behold the world in pause.\n" +
            base.ToString();
        }

    }
}
