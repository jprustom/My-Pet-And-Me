using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Dog : Pet
    {
        protected override string animalStringToAddToPaths => "dog";


        public override string PetName=>"Jacob";

      

        public override List<Image> PetSnakeCollectiblesList => new List<Image> {

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"meat.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"bone.png"),

        };


        public Dog(Player player) : base(player) { }

        public override string ToString()
        {
            return "A dog is the only thing on earth that loves you more than you love yourself.\n" +
                base.ToString();
        }

    }
}
