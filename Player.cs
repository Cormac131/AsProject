using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    class Player
    {
        public string Username;
        public string Password;
        public int Age;
        public int Highscore;
        public int Score;
        public string Avatar;
    }

    class SessionPlayer
    {
        public static string Username;
        public static string Password;
        public static int Age;
        public static int Highscore;
        public static int Score;
        public static int PreviousScore;
        public static string Avatar;
    }

    class PlayersOnSystem 
    {
        public static string[,] PlayersOnSystemArray = new string[Program.UserCount, 6];

        public static int CurrentPlayerArrayValue;
    }
}
