using System;

namespace human
{
    class Human
    {
        // Fields
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // Public "getter" property to access health 
        public int Health
        {
            get {return health; }
            set {health = value;}
        }
        // Alternatively, public int Health {get;set;}

        // Constructor: takes str to set Name, sets remaining fields to default values
        public Human(string givenName)
        {
            Name = givenName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Constructor: takes custom values
        public Human(string givenName, int givenStrength, int givenIntelligence, int givenDexterity, int givenHealth)
        {
            Name = givenName;
            Strength = givenStrength;
            Intelligence = givenIntelligence;
            Dexterity = givenDexterity;
            health = givenHealth;
        }

        // Reduces target human's health by this human's strength x 5
        public int Attack(Human target)
        {
            int damage = Strength * 5;
            target.Health = target.Health - damage;
            return target.Health;
        }
    }
}
