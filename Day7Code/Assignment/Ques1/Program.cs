class Program
{
    static void Main()
    {
        
        Console.Write("Enter number of animals: ");
        int number = Convert.ToInt32(Console.ReadLine());
        while (number <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the type of animals: ");
        Animal[] animals = new Animal[number]; //array of animal refernce, storing objects initially null
        for(int i = 0; i < number; i++)
        {
            while (true)
            {
                string input = (Console.ReadLine() ?? "").ToLower();
                if (input == "animal")
                {
                    animals[i] = new Animal();//creating object and storing at index
                    break;
                }
                else if (input == "cat")
                {
                    animals[i] = new Cat();
                    break;
                }
                else if (input == "dog")
                {
                    animals[i] = new Dog();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid animal type. Please enter animal, dog, or cat.");
                }
            }
           
        }
        

        Console.WriteLine("Sounds of the animals in the array:");
        foreach (Animal animal in animals)
        {
            animal.MakeSound(); 
        }


    }
}