using System;

namespace UML_RPG
{
    class Weapon {
        public int damage;
        public string name;
        public Weapon(int damage, string name) {
            this.damage = damage;
            this.name = name;
        }
    }

    class Character {
        public int hp;
        public int lvl;
        public int strength;
        public int agility;
        public int endurance;
        public Weapon weapon;
        public int[] damage;

        public int[] calculateDamage(Weapon w, int s)
        {
            return null;
        }
    
    }
    class Player : Character {
        public Player()
        {
            this.hp = 200;
            this.lvl = 1;
            this.strength = 5;
            this.agility = 5;
            this.endurance = 5;
            this.weapon = new Weapon(50, "Fakard");
            this.damage = calculateDamage(weapon, strength);
        }
    }
    class Enemy : Character {
        public string name;

        public void fight(Player p) {
        // TODO
        }
    }
    class Ogre : Enemy
    {
        public Ogre() {
            this.name = "Shrek";
            this.hp = 500;
            this.lvl = 2;
            this.strength = 10;
            this.agility = 1;
            this.endurance = 3;
            this.weapon = new Weapon(10, "Szájszag");
            this.damage = calculateDamage(weapon, strength);
        }
    }
    class Goblin : Enemy { }
    class Ork : Enemy { }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
