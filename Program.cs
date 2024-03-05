using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }


    class Ferret : Animal
    {
        public string breed;
        public int age;
        public string color;

        public Ferret()
        {
            breed = "";
            age = 0;
            color = "";
        }

        public Ferret(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }
        public void DisplayPet()
        {
            Console.WriteLine($"Your pet's name is {name}");
            Console.WriteLine($"Your pet is a {breed} breed");
            Console.WriteLine($"Your pet is {age} years old");
            Console.WriteLine($"Your pet is {color} in color");
        }
    }
    class Cat : Animal
    {
        public string breed;
        public int age;
        public string color;

        public Cat()
        {
            breed = "";
            age = 0;
            color = "";
        }

        public Cat(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public void DisplayPet()
        {
            Console.WriteLine($"Your pet's name is {name}");
            Console.WriteLine($"Your pet is a {breed} breed");
            Console.WriteLine($"Your pet is {age} years old");
            Console.WriteLine($"Your pet is {color} in color");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Console.WriteLine("Your first cat's information!");
            Console.WriteLine();

            cat1.name = "Caesar";
            cat1.breed = "Toyger";
            cat1.age = 17;
            cat1.color = "brownish with black stripes";
            cat1.DisplayPet();
            Console.WriteLine();

            Console.WriteLine("Your second cat's information!");
            Cat cat2 = new Cat("Zelda", "Maine Coon", 16, "fluffy brown with some stripes");
            cat2.DisplayPet();

            Ferret ferret1 = new Ferret();
            Console.WriteLine("Your first ferret's information!");
            ferret1.name = "Conan";
            ferret1.breed = "Sable";
            ferret1.age = 8;
            ferret1.color = "black with a white mask";
            ferret1.DisplayPet();
            Console.WriteLine();

            Console.WriteLine("Your second ferret's information!");
            Ferret ferret2 = new Ferret("Franklin", "Roan", 3, "black with a white undercoat");
            ferret2.DisplayPet();


        }

    }
}