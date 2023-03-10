using System.Globalization;

namespace CSharpAnimal.Models.Animals
{
    abstract public class Animal
    {
        public Animal()
        {
            this.name = "Cat";
            this.age = 12;
            this.Type = "commun";
            this.Id = 1;
        }
        public Animal(string name, string type, int id, int age)
        {
            this.name = name;
            this.Type = type;
            this.Id = id;
            this.age = age;

        }
        public string name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public int age { get; set; }
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