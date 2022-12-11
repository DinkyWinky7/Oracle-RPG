using System;
using System.Collections;
using System.Linq;

namespace MainSpace
{
    //All Monsters
    #region Monsters + Base
    public class cMonster
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
    }

    public class cSlime : cMonster
    {
        public cSlime()
        {
            name = "Slime";
            attack = 3;
            health = 10;
        }
    }
    #endregion

    //Player Info
    public class cPlayer
    {
        public string name;
        public int attack;
        public int health;
    }

    //To Be Deleted
    public class cOutput
    {
        public void Output()
        {
            cSlime objSlime = new cSlime()

            Console.WriteLine(objSlime.name);
        }
    }

    //<Main>
    public class Program
    {
        public static void Main()
        {
            cOutput objOutput = new cOutput();
            objOutput.Output();

            Console.ReadKey();
        }
    }
}