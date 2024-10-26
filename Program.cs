namespace class_structOop
{
    public class Character
    {
        public string name;
        public int xp = 0;

        public Character(string name)
        {
            this.name = name;
            //Reset();
        }
        public Character()
        {
            name = "Not assigned";
        }
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.xp + " EXP");
        }
        private void Reset()
        {
            this.name = "Not assigned";
            this.xp = 0;
        }
    }
    //Inheriting from Charcter(base) class
    public class Paladin: Character
    {
        public Weapon weapon;
        public Paladin(string name, Weapon weapon): base(name)
        {
            this.weapon = weapon;
        }
        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
        }

    }
    public struct Weapon
    {
        public string name;
        public int damage;
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Marcy");
            heroine.PrintStatsInfo();

            Weapon trifoldLance = new Weapon("Trifold Lance", 125);
            trifoldLance.PrintWeaponStats();

            //Testing reference types
            Character villian = hero;

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "Sir Kane the Brave";

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            //Testing value types
            //note: Trifold Lance is declared above
            Weapon warBow = trifoldLance;

            trifoldLance.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            trifoldLance.PrintWeaponStats();
            warBow.PrintWeaponStats();

            // hero.Reset();

            //Experimenting with Inheritance
            Paladin knight = new Paladin("Sir Arthur", trifoldLance);
            knight.PrintStatsInfo();

            //Testing external files
            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            Duuuude dave = new Duuuude("Dave");
            dave.PrintStatsInfo();
        }
    }
}
