using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace My_Pet_And_Me__
{

    public class Player
    {
     
        #region Properties

        public int Score { get; set; }
        public string PlayerName { get; set; }

        public Pet PetCompanion { get; set; }
        public int PlayerAge { get; set; }
        public DateTime LastLoggedDate { get; set; }

        #endregion

        #region Constructor

        public Player(string playerName,int playerAge)
        {
            PlayerName = playerName;
            PlayerAge = playerAge;
            LastLoggedDate = DateTime.Now;
            Score = 0;
        }


        #endregion

        #region ToString

        public override string ToString()
        {
            return $"{PlayerName}, {PlayerAge} Years Old.\n"
                + $" Last Played On {LastLoggedDate.ToShortDateString()}.";
        }

        #endregion
    }
}
