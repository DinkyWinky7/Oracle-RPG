using System;
using System.Collections;
using System.Linq;

namespace HeadManager
{
    public class Manager
    {
        #region Tutorial
        public void Manage_Tutorial()
        {
            Tutorial.TutorialProgram tutorialProgram = new Tutorial.TutorialProgram();
            tutorialProgram.Manager();
        }
        #endregion
    }

    public class Program
    {
        public static void Main()
        {
            Manager manager = new Manager();
            manager.Manage_Tutorial();

            Console.WriteLine("Congratulations, you beat the game!");
        }
    }
}
