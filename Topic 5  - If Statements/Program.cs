﻿namespace Topic_5____If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        { //Andre
            int people = 20;
            int cats = 20;
            int dogs = 15;
            string dinosaur;
            string please, name;
            int age;
            double temp;
            Console.WriteLine("People: " + people + " Cats: " + cats + " Dogs: " + dogs);
            if (people < cats)
            {
                Console.WriteLine("Too many Cats, THE WORLD IS DOOMED!");
            }
            if (people > cats)
            {
                Console.WriteLine("The world is drooled on!");
            }
            if(people > dogs)
            {
                Console.WriteLine("The world is dry!");
            }
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs.");
            }
            if (people <= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs.");
            }
            if (people == dogs)
            {
                Console.WriteLine("People are dogs.");
            }
            // If's are peices of code that if put in can run some code if their are certin conditions met.
            // The curley braces are used to put the code that the "if" would need to run
            Console.WriteLine("What famous dinosaur has three large horns?");
            dinosaur = Console.ReadLine();
            if (dinosaur.ToLower () == "yes")
            {
                Console.WriteLine("You are corrct");
            }
            Console.WriteLine("What is the magic word? ");
            please = Console.ReadLine();
            if (please.ToLower () == "please")
            {
                Console.WriteLine("You're welcome ");
            }
            Console.WriteLine("Hey man what's your name?");
            name= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How old are you " + name + "?");
            Console.WriteLine();
            int.TryParse(Console.ReadLine(), out age);
            if (age < 16)
            {
                Console.WriteLine("You can't drive yet!");
                Console.WriteLine();
            }
            if (age < 18)
            {
                Console.WriteLine("You can't vote yet bozo");
                Console.WriteLine();
            }
            if (age < 25)
            {
                Console.WriteLine("You can't rent a car yet");
                Console.WriteLine();
            }
            if (age > 25)
            {
                Console.WriteLine("You can do anyhing that's legal");
            }
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey " + name + " what's the temp that freezes water?");
            double.TryParse(Console.ReadLine(), out temp);
            if (temp <= 0)
            {
                Console.WriteLine("Wowza man it's prolly freezing temp.");
            }



        }   
    }
}
