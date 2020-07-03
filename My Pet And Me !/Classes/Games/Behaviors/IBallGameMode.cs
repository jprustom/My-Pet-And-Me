using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public interface IBallGameMode : IGameMode
    {
        List<Ball> Balls { get; set; }
        void CreateBallInstance();
        void ManageBalls();
    }
}
