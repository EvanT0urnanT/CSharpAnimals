using Project.Animal.animal;

class Program
{    
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.sleep();
        animal.moove();

        Animal animal2 = new Animal("Lion");
        animal.sleep();
        animal.moove();

        Console.ReadLine();
    }
}
