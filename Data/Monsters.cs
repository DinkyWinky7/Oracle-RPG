namespace Monsters
{
    //Base class for monsters
    public class cMonsters
    {
        string name { get; set; }
        int power { get; set; }
        int maxHealth { get; set; }
    }

    public class Slime : cMonsters
    {
        public Slime()
        {
            name = "Slime";
            power = 3;
            maxHealth = 10;
        }
    }

    public class Werewolf : cMonsters
    {
        public Werewolf()
        {
            name = "Werewolf";
            power = 5;
            maxHealth = 15;
        }
    }
}