using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Rabbit : Pet
    {
        protected override string animalStringToAddToPaths => "rabbit";
    
        public override string PetName=> "John";

    
        

        public override List<Image> PetSnakeCollectiblesList => new List<Image> { 

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"carrot.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"strawberry.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"lettuce.png"),

        };

       

        public Rabbit(Player player) : base(player) { }
        
        public override string ToString()
        {
            return "Ideas are like rabbits. You get a couple and learn how to handle them, and pretty soon you have a dozen.\n" +
                base.ToString();
        }

    }
}
