using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
        }
    }
    public class Human
    {

        private int strength, intelligence, stealth, health;
        private string name;
        
        public Human()
        {
            initialize();
        }

        public Human(string name)
        {
            initialize();
            this.name = name;
        }

        public Human(int strength, int intelligence, int stealth, int health, string name)
        {
            this.strength = strength;
            this.intelligence = intelligence;
            this.stealth = stealth;
            this.health = health;
            this.name = name;
        }

        private void initialize()
        {
            strength = intelligence = stealth = 3;
            health = 100;
        }
        
        public int getHealth()
        {
            return health;
        }
        
        public void attack(Object h)
        {
            if(h is Human)
            {
                (h as Human).health -= 5 * strength;
            }
        }

    }   
}
