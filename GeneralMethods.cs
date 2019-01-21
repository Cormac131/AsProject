using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    class GeneralMethods
    {
        public static void SaveGame()
        {
            if (SessionPlayer.Highscore <= SessionPlayer.Score)
            {
                SessionPlayer.Highscore = SessionPlayer.Score;

                PlayersOnSystem.PlayersOnSystemArray[PlayersOnSystem.CurrentPlayerArrayValue, 3] = SessionPlayer.Highscore.ToString();
                PlayersOnSystem.PlayersOnSystemArray[PlayersOnSystem.CurrentPlayerArrayValue, 4] = SessionPlayer.Score.ToString(); 
            }

            BinaryWriter ClearFile = new BinaryWriter(File.Open(FrmRegister.binaryFileName, FileMode.Create));
            ClearFile.Write("");
            ClearFile.Close();

            for (int i = 0; i < Program.UserCount; i++)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(FrmRegister.binaryFileName, FileMode.Append)))
                {
                    writer.Write("_" + PlayersOnSystem.PlayersOnSystemArray[i, 0] + "/" + PlayersOnSystem.PlayersOnSystemArray[i, 1]
                        + "/" + PlayersOnSystem.PlayersOnSystemArray[i, 2].ToString() + "/" + PlayersOnSystem.PlayersOnSystemArray[i, 3]
                        + "/" + PlayersOnSystem.PlayersOnSystemArray[i, 4] + "/" + PlayersOnSystem.PlayersOnSystemArray[i, 5]);

                    writer.Close();
                }
            }
        }
    }
}
