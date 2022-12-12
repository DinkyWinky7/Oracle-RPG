using System;
using System.Collections;
using System.Linq;

namespace MainSpace
{
    #region Actor Data
    #region Monsters + Base
    public class cMonster
    {
        public string name { get; set; }
        public int power { get; set; }
        public int maxHealth { get; set; }
    }
    
    public class cSlime : cMonster
    {
        public cSlime()
        {
            name = "Slime";
            power = 3;
            maxHealth = 10;
        }
    }
    
    public class cWerewolf : cMonster
    {
        public cWerewolf()
        {
            name = "Wolf";
            power = 6;
            maxHealth = 15;
        }
    }
    
    public class cBat : cMonster
    {
        public cBat()
        {
            name = "Bat";
            power = 3;
            maxHealth = 8;
        }
    }
    
    public class cUnicorn : cMonster
    {
        public cUnicorn()
        {
            name = "Unicorn";
            power = 9;
            maxHealth = 18;
        }
    }
    #endregion
    
    public class cPlayer
    {
        public string name { get; set; }
        public int power = 5;
        public int maxHealth = 10;
    }
    #endregion
    
    #region Combat
    public class cCombatManager
    {
        public void TutorialCombat()
        {
            cTutorialCombat tutorialCombat = new cTutorialCombat();
            tutorialCombat.TutorialCombat();
        }
    }
    
    public class cTutorialCombat
    {
        cPlayer player = new cPlayer();
        cSlime slime = new cSlime();
        
        public void TutorialCombat()
        {
            int playerHealth = player.maxHealth;
            int enemyHealth = slime.maxHealth;
            
            Console.WriteLine($"A {slime.name} has appeared!\n");
            
            while (enemyHealth > 0)
            {
                Console.WriteLine($"Player HP: {playerHealth}");
                Console.WriteLine($"Enemy HP: {enemyHealth}\n");
                
                Console.WriteLine("What will you do:");
                Console.WriteLine("(A)ttack\n");
                
                char playerInput = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                
                if (playerInput == 'A' || playerInput == 'a')
                {
                    Console.WriteLine($"\n{player.name} attacked and dealt {player.power} damage!");
                    Console.WriteLine($"{slime.name} attacked and dealt {slime.power} damage!");
                    
                    enemyHealth -= player.power;
                    playerHealth -= slime.power;
                }
                
                else
                {
                    Console.WriteLine("Incorrect action, try again\n");
                }
            }
            
            Console.WriteLine($"Congratulations! You beat {slime.name}!");
        }
    }
    
    public class cCombat
    {
        
    }
    #endregion
    
    #region Main Manager
    public class cMainManager
    {
        public void Manage()
        {
            cCombatManager combatManager = new cCombatManager();
            combatManager.TutorialCombat();
        }
    }
    #endregion
    
    public class Program
    {
        public static void Main()
        {
            cMainManager mainManager = new cMainManager();
            mainManager.Manage();
            
            Console.WriteLine("Congratulations, you beat the game!");
            
            Console.ReadKey();
        }
    }
}
