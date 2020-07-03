using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public class Fox : Pet
    {
        protected override string animalStringToAddToPaths => "fox";


       public override string PetName=> "Ricardo";


        public override List<Image> PetSnakeCollectiblesList => new List<Image> {

            Image.FromFile(Paths.IPetCollectiblesImagesPath+"fish.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"strawberry.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"apple.png"),
            Image.FromFile(Paths.IPetCollectiblesImagesPath+"chicken.png"),

        };

  

        public Fox(Player player) : base( player) { }

        public override string ToString()
        {
            return "The Fox Said The Following To The Little Prince:\n"+
                "If You Tame Me, Then We Shall Need Each Other.\n"+
                "To Me, You Will Be Unique In All The World\n"+
                "To You, I Shall Be Unique In All The World.\n"+
                base.ToString();
        }

    }
}
