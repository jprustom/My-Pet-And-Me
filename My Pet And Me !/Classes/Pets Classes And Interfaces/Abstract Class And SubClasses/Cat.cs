using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Cat : Pet
    {
        protected override string animalStringToAddToPaths=> "cat";

        public override string PetName=> "Nancy";

 
        public override List<Image> PetSnakeCollectiblesList => new List<Image> {

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"fish.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"snake.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"chicken.png"),

        };


        public Cat(Player player) : base(player) { }

        public override string ToString()
        {
            return "Meoooooooooooow!\n" +
                base.ToString();
        }

    }
}
