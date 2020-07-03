using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_And_Me__
{
    public static class Paths
    {
        public static string GamesSoundEffectsPath => @"Resources\Audio\Games\";
        private static string BackgroundMusicPath => @"Resources\Audio\Background Music\";
        public static List<string> ListOfBackgroundMusic => new List<string>()
        {
            BackgroundMusicPath+"backgroundMusic1.wav",
            BackgroundMusicPath+"backgroundMusic2.wav",
            BackgroundMusicPath+"backgroundMusic3.wav",
            BackgroundMusicPath+"backgroundMusic4.wav",
            BackgroundMusicPath+"backgroundMusic5.wav",
        };
        public static string AudioPath => "Resources\\Audio\\";
        public static string HelpersPath => @"Resources\Helpers\";
        public static string PlayerProfilesPath => @"Saved Data\PlayersProfiles.xml";
        public static string BallsImagesPath => "Resources\\Games\\Ball Games\\Balls\\";
        public static string LevelsResourcesPaths { get { return "Resources\\Games\\Snake\\Levels\\"; } }
        public static string IPetImagePath { get { return "Resources\\Main Animals Images\\"; } }
        public static string IPetPaddle180DegreesImagesPath { get { return "Resources\\Games\\Ball Games\\Bricks Breaker Animals\\"; } }
        public static string IPetPaddle90DegreesImagesPath { get { return "Resources\\Games\\Ball Games\\Pong Animals\\"; } }
        public static string IPetSnakePathImages => "Resources\\Games\\Snake\\Animals Bodies\\";
        public static string IPetCollectiblesImagesPath { get { return "Resources\\Games\\Snake\\Collectibles\\";  } }
        public static string Extension { get { return ".png"; } }
    }
}
