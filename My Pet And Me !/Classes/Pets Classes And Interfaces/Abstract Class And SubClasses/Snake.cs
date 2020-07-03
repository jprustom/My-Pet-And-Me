using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Snake : Pet
    {
        protected override string animalStringToAddToPaths => "snake";


       public override string PetName=>"Sebastien";



        public override List<Image> PetSnakeCollectiblesList => new List<Image> {

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"fish.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"bird.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"mouse.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"worm.png"),

        };



        public Snake(Player player) : base(player) { }

        public override string ToString()
        {
            return "If A Snake Is Not Poisonous, It Should Pretend To Be Venomous!\n" +
                base.ToString();
        }

    }
}
