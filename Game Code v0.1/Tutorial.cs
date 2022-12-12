using System;
using System.Collections;
using System.Linq;

namespace Tutorial
{
    public class cTutorialCombat
    {
        #region Stats
        public string enemyName = "Slime";
        public int enemyPower = 3;
        public int enemyHealth = 10;

        public int playerPower = 2;
        public int playerHealth = 20;
        #endregion

        public void TutorialFight()
        {
            Console.WriteLine("");
        }
    }

    public class Program
    {
        public static void Main()
        {
            cTutorialCombat tutorialCombat = new cTutorialCombat();
            tutorialCombat.TutorialFight();
        }
    }
}