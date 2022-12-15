using System;
using System.Collections;
using System.Linq;

namespace GameManager
{
    public class cGetName
    {
        public void GetName()
        {
            bool isNaming = true;

            Console.WriteLine("Hello, um, what is your name?");

            while (isNaming)
            {
                Player.cPlayer.name = Convert.ToString(Console.ReadLine());

                Console.WriteLine($"Hmm, {Player.cPlayer.name}?");
                Console.WriteLine("(Y)es        (N)o");

                string playerInput = Convert.ToString(Console.ReadLine());

                if (playerInput.ToUpperInvariant() == "Y")
                {
                    isNaming = false;
                }
            }
        }
    }

    public class GameManagerProgram
    {
        public static void Main()
        {
            Console.Clear();
          
            cGetName getName = new cGetName();
            getName.GetName();

            Console.WriteLine(Player.cPlayer.name);
        }
    }
}