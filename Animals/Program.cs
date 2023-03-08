
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






        Dog dog1 = new Dog("Loup");
        Dog dog2 = new Dog("Enzo");
        Dog dog3 = new Dog("Antoine");
        Dog dog4 = new Dog("Raphaël");
        Dog dog5 = new Dog("snow");
        Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };
        IEnumerable<Dog> differentThanSnow =
            from dog in dogs
            where dog.dogName != "snow"
            select dog;


        Console.WriteLine("\nLes dogs sont : ");


        foreach (Dog dog in differentThanSnow)
        {
            Console.WriteLine(dog.dogName);
        }


        Console.ReadLine();
    }
}
