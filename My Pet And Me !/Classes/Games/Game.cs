using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public class Game
    {
       
        #region Behavior/Strategy Pattern !

        //Normally While Applying Behavior Pattern, Can Have More Than One Behavior But In This Case I Want One Behavior/Game
        //And That Is Because At Once A Game Can Be A Snake Game, Or Either Brick Breaker Or Pong
        //I Will Have The Corresponding Behavior Passed On In Constructor
        private IGameMode GameMode { get; set; }

        #endregion

        #region Constructor: Initializes Behavior Adapted

        public Game(IGameMode gameMode)=>GameMode = gameMode;

        #endregion

        #region Methods That Will Execute Depending On The Behavior Adapted

        public void Build()
        {
            GameMode.Build();
        }
        public void MovePet()
        {
            GameMode.MovePet();
        }

        public void DisplayScore()
        {
            GameMode.DisplayScore();
        }
        public void GameOver()
        {
            GameMode.GameOver();
        }

        #endregion

        #region Methods That Will Have A Common Implementation Regardless Of The Behavior Adapted

        public static void PlaySound(string soundPath)
        {
            SoundPlayer sPlayer = new SoundPlayer(soundPath);
            sPlayer.Play();
        }
        public static void DisableTimers(List<System.Windows.Forms.Timer> timers)
        {
            foreach (System.Windows.Forms.Timer timer in timers)
                timer.Enabled = false;
        }

        #endregion
    }
}
