using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    //BallGame Is A Special Case Of A Regular Game
    //Its Behavior Is Of Type IBallGameMode, Which Itself Is A Special Case Of IGameMode
    public class BallGame : Game
    {
        #region The Constructor Will Take An IBallGameMode Instance, Which Inherits From IGameMode, As A Parameter.

        IBallGameMode BallGameMode { get; set; }

        public BallGame(IBallGameMode BallGameMode) : base(BallGameMode) {
            Balls = new List<Ball>();
            this.BallGameMode = BallGameMode;
        }

        #endregion

        #region Additional Balls Property & Methods 

        public List<Ball> Balls { get; set; }

        public void ManageBalls()
        {
            BallGameMode.ManageBalls();
        }

        public void CreateBallInstance()
        {
            BallGameMode.CreateBallInstance();
        }

        #endregion
    }
}
