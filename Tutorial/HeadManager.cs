using System;
using System.Collections;
using System.Linq;

namespace HeadManager
{
    public class cManager
    {
        #region Tutorial
        public void Manage_Tutorial()
        {
            Tutorial.TutorialProgram tutorialProgram = new Tutorial.TutorialProgram();
            tutorialProgram.Manager();

            TutorialBoss.TutorialBossProgram tutorialBossProgram = new TutorialBoss.TutorialBossProgram();
            tutorialBossProgram.Manager();
        }
        #endregion

        
    }

    public class Program
    {
        public static void Main()
        {
            Console.Clear();

            Console.WriteLine("Skip the tutorial?");
            Console.WriteLine("(N)o     (Y)es");

            string playerInput = Convert.ToString(Console.ReadLine());

            if (playerInput != Y)
            {
                cManager manager = new cManager();
                manager.Manage_Tutorial();
            }

            Console.WriteLine("Congratulations, you beat the game! (What it is so far)");
        }
    }
}