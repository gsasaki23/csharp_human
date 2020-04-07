using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myHuman = new Human("Gaku");
            Human enemy = new Human("Neil",10,10,10,84);

            Console.WriteLine($"My human's name is {myHuman.Name} with {myHuman.Health} HP");
            Console.WriteLine($"Enemy's name is {enemy.Name} with {enemy.Health} HP");

            Console.WriteLine("Attack!");
            int enemyNewHealth = myHuman.Attack(enemy);
            Console.WriteLine($"Enemy's health: {enemyNewHealth} HP");
        }
    }
}
