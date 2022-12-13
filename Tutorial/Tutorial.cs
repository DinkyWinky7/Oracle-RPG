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
            Console.WriteLine("To do stuff, enter a command by pressing one of the provided buttons:\n");

            char playerInput;

            while (enemyHealth > 0)
            {
                Console.WriteLine($"Player HP: {playerHealth}\nEnemy HP: {enemyHealth}");
                Console.WriteLine("(A)ttack");
                playerInput = Convert.ToChar(Console.ReadLine());

                Console.Clear();

                if (char.ToUpperInvariant(playerInput) == 'A')
                {
                    Console.WriteLine($"\nYou striked {enemyName} and dealt {playerPower} damage!");
                    playerHealth -= enemyPower;

                    if (enemyHealth > 0)
                    {
                        Console.WriteLine($"{enemyName} striked you and dealt {enemyPower} damage!\n");
                        enemyHealth -= playerPower;
                    }
                }

                else 
                {
                    Console.WriteLine("Try again.");
                }
            }

            if (enemyHealth > 0)
            {
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You Died.");
                    Console.WriteLine("Please Restart the Game.");

                    while (1 > 0)
                    {
                        Console.ReadKey();
                    }
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

                Console.WriteLine("Congratulations, you beat the tutorial!\n");
                Console.WriteLine("Press Enter to Continue:\n");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}