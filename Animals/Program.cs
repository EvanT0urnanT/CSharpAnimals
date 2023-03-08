using CSharpAnimal.Models.Animals;

class Program
{    
    static void Main(string[] args)
    {
        Animal animal = new Dragon();
        animal.Sleep();
        animal.Moove();

        Animal animal2 = new Griffin();
        animal2.Sleep();
        animal2.Moove();

        Console.ReadLine();
    }
}
