using System;
using System.Collections;
using System.Linq;

namespace Tutorial
{
    public class cTutorialCombat
    {
        #region Stats
        public string enemyName;

        public string GetEnemyName()
        {
            string[] enemyNames = new string[] 
            {  
                "Slime",
                "Blob",
                "Goo",
                "Muk",
            };

            Random random = new Random();
            int ran = random.Next(4);

            return enemyNames[ran];
        }

        public int enemyPower = 3;
        public int enemyHealth = 10;

        public int playerPower = 2;
        public int playerHealth = 20;
        #endregion

        public void TutorialFight(string enemyName)
        {
            Console.WriteLine($"A {enemyName} has appeared! (Don't worry though, this is the tutorial.)\n");
            Console.WriteLine("To do stuff, enter a command by pressing one of the provided buttons:");

            char playerInput;

            while (enemyHealth > 0)
            {
                Console.WriteLine($"Player HP: {playerHealth}\nEnemy HP: {enemyHealth}");
                Console.WriteLine("(A)ttack");
                playerInput = Convert.ToChar(Console.ReadLine());

                if (char.ToUpperInvariant(playerInput) == 'A')
                {
                    Console.WriteLine($"You striked {enemyName} and dealt {playerPower}");

                    playerHealth -= enemyPower;
                    enemyHealth -= playerPower;
                }

                else 
                {
                    Console.WriteLine("Try again.");
                }
            }
        }
    }

    public class TutorialProgram
    {
        public void Manager()
        {
            {
                cTutorialCombat tutorialCombat = new cTutorialCombat();

                string enemyName = tutorialCombat.GetEnemyName();
                tutorialCombat.TutorialFight(enemyName);

                Console.WriteLine("Congratulations, you beat the tutorial!");
            }
        }
    }
}