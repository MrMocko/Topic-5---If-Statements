namespace Topic_5____If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        { //Andre
            int people = 20;
            int cats = 20;
            int dogs = 15;
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
            if (condition)
            {
                // Code here will only be run if 
            }
        }   
    }
}
