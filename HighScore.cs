using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    class HighScore
    {
        const string hsFilePath = "HighScores.txt";

        public void getHighScore()
        {
            char[] delimiterChars = { '/', '_' };

            StreamReader hsFile = new StreamReader(hsFilePath);
            string hsData = hsFile.ReadToEnd();

            string[] records = hsData.Split(delimiterChars[1]);

            string[,] hsTable = new string[10, 2];

            for (int i = 0; i < 10; i++)
            {
                string[] fields = records[i].Split(delimiterChars[0]);
            }
            

        }

        public void newHighScore(int highscore)
        {

        }
    }
}
