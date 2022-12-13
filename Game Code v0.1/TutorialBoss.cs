using System;
using System.Collections;
using System.Linq;

namespace TutorialBoss
{
    //Gets, adds, and returns critical power
    public class cCritical
    {
        public int Critical(int power)
        {
            Random random = new Random();
            int ran = random.Next(10);

            if (ran >= 7)
            {
                return (power + (power / 2));
            }

            else 
            {
                return power;
            }
        }
    }

    public class cBossFight
    {
        #region Stats
        public int bossPower = 3;
        public int bossHealth = 25;

        public int playerPower = 4;
        public int playerHealth = 20;
        #endregion

        cCritical critical = new cCritical();

        public void BossFight()
        {
            Console.WriteLine("Use what you've learned to beat Pepper, a tall green monster!");

            char playerInput;

            while (bossHealth > 0)
            {
                Console.WriteLine($"Player HP: {playerHealth}\nPepper HP: {bossHealth}\n");
                Console.WriteLine("(A)ttack");
                playerInput = Convert.ToChar(Console.ReadLine());

                Console.Clear();

                int playerCrit = critical.Critical(playerPower), 
                    bossCrit   = critical.Critical(bossPower);

                string hasCrit = ((playerCrit >= 7 || bossCrit >= 7) ? " critical" : "");

                if (char.ToUpperInvariant(playerInput) == 'A')
                {
                    Console.WriteLine($"\nYou striked Pepper and dealt {playerCrit}{hasCrit} damage!");
                    playerHealth -= bossPower;

                    if (bossHealth > 0)
                    {
                        Console.WriteLine($"Pepper punches you in the face dealing {bossCrit}{hasCrit} damage!");
                        bossHealth -= playerPower;
                    }
                }

                else 
                {
                    Console.WriteLine("Try again.");
                }
            }

            if (bossHealth > 0)
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

    public class TutorialBossProgram
    {
        public void Manager()
        {
            cBossFight bossFight = new cBossFight();
            bossFight.BossFight();

            Console.WriteLine("Congratulations, you beat Pepper!");
        }
    }
}