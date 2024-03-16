namespace AnimalStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <string> animals = new Stack<string>();
            //adding animals
            animals.Push ("Penguin");
            animals.Push ("Giraffe");
            animals.Push("Elephant");
            animals.Push("Panda");
            animals.Push("Lion");

            //counts animals in the Stack
            Console.WriteLine($"Here are your {animals.Count()} animals");
            //display the Stack contents
            foreach (var a in animals) 
            { 
                Console.WriteLine(a);
            }

            Console.WriteLine("****************************************************");

            if (animals.Contains("snake"))
            {
                Console.WriteLine("That animal is part of the group");
            }
            else
            {
                Console.WriteLine("Snake is not part of the group");
            }
            
            string firstAnimal = animals.Peek();
            Console.WriteLine((firstAnimal) + " has been removed from the group");
            animals.Pop();

            Console.WriteLine("****************************************************");

            Console.WriteLine($"Here are your {animals.Count()} animals");
            foreach (var a in animals)
            {
                Console.WriteLine (a);
            }
        }
    }
}