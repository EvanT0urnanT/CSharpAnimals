using CSharpAnimal.Models.Animals;
namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal,IPilotage
    {
        public Dragon()
        {
            dragonName = "Dragon";
        }
        public string dragonName { get; private set; }

        public override void Moove()
        {
            Console.WriteLine($"{dragonName} moove");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{dragonName} sleep");
        }
    }
}