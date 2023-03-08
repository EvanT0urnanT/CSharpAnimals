using Project.Animal.animal;
using Project.Animal.dragon;
using Project.Animal.griffin;

class Program
{    
    static void Main(string[] args)
    {
        Animal animal = new Dragon("Dragon2");
        animal.Sleep();
        animal.Moove();

        Animal animal2 = new Griffin("Griffon2");
        animal2.Sleep();
        animal2.Moove();

        Console.ReadLine();
    }
}
