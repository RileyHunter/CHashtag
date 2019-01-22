using System;

namespace CHashtag
{
    // Tasks:
    // Run the current program and read the output.

    // Identify what's wrong, find the errant code, and fix it.

    // Then, add a method "Punch" to the Person class which sets their mood to "Ooch".
    // Un-comment the lines in Main to make sure it works.

    // Bonus points:
    // Try and instantiate a Person. It doesn't work. Why? Don't fix this, it's deliberate.

    // Implement a new class Master extending Person (the same way Student does) and
    // have it set the mood in the constructor to "Contemplative", and their Dollaz to -1.

    // Override Master.GiveDollaz() so that it prints "No thanks b0ss" instead and does not
    // add to their Dollaz.
    class Program
    {
        static void Main(string[] args)
        {
            var em = new Student("Em");

            em.GiveDollaz(100);
            em.HowMuchDollaz();
            em.GiveDollaz(100);
            em.HowMuchDollaz();

            em.WhatMood();
            //em.Punch();
            //em.WhatMood();

            Console.ReadKey();
        }
    }

    abstract class Person
    {
        private string Name;
        private double Dollaz;
        protected string Mood;

        public Person(string name, double dollaz)
        {
            Name = name;
            Dollaz = dollaz;
        }
        public void GiveDollaz(double amount)
        {
            Console.WriteLine($"Giving {amount} to {Name}");
            Dollaz = amount;
        }

        public double TakeDollaz(double amount)
        {
            Dollaz -= Math.Min(Dollaz, amount);
            Console.WriteLine($"Taking {amount} from {Name}");
            return Math.Min(Dollaz, amount);
        }

        public double HowMuchDollaz()
        {
            Console.WriteLine($"{Name} has {Dollaz} dollaz");
            return Dollaz;
        }

        public string WhatMood()
        {
            Console.WriteLine($"{Name} is feeling {Mood}");
            return Mood;
        }
    }

    class Student : Person
    {
        public Student(string name) : base(name, 0)
        {
            Mood = "Feisty";
        }
    }
}
