using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public interface IPet
    {
        //The Properties Below Are Common To All Pets, Regardless Of The Game Played
        string PetName { get; }
        Player AssociatedPlayer { get; set; }
        void PlaySound();
    }
}
