using CSharpAnimal.Models.Animals;
namespace CSharpAnimal.Models.Animals
{
    class Bird : Animal, IPilotage, IFly
    {
        public Bird()
        {
            name = "Bird";
        }

        public Bird(string name, string type, int ID, int age)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
            this.age = age;
        }
        public override void Moove()
        {
            Console.WriteLine($"{name} moove");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{name} sleep");
        }
        public void Fly()
        {
            Console.WriteLine("I Believe i can fly !");
        }
    }
}