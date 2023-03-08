using CSharpAnimal.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    class Griffin : Animal, IPilotage
    {
        public Griffin()
        {
            griffinName = "Griffin";
        }
        public string griffinName { get; private set; }

        public override void Moove()
        {
            Console.WriteLine($"{griffinName} moove");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{griffinName} sleep");
        }
    }
}