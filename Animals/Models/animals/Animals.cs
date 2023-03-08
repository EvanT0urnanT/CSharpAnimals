namespace Project.Animal.animal;

abstract public class Animal
{
    public string name { get; private set; }
    public Animal(string name) {
        this.name = name;
    }

    public abstract void Moove();
    public virtual void Sleep()
    {
        Console.WriteLine(this.name + " Sleep");
    }
}