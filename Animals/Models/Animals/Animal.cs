namespace CSharpAnimal.Models.Animals
{
    abstract public class Animal
    {
        public Animal()
        {
            this.name = "Cat";
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public string name { get; private set; }
        public virtual void Moove()
        {
            Console.WriteLine("Moove !");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Sleep !");
        }

    }
}