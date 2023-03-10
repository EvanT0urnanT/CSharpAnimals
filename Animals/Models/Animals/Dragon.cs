using CSharpAnimal.Models.Animals;
namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal,IPilotage
    {
        public Dragon()
        {
            name = "Dragon";
        }

        public Dragon(string name, string type, int ID, int age)
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
    }
}