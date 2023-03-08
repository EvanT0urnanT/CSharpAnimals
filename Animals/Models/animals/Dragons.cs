namespace Project.Animal.dragon;
using Project.Animal.animal;

class Dragon : Animal{
    public new string name;
    public Dragon(string name = "dragon") : base(name)
    {
        this.name = name;
    }
    public override void Moove()
    {
        Console.WriteLine(name + " the mooving dragon");
    }
    public new void Sleep()
    {
        Console.WriteLine(this.name + " the sleeping dragon");
    }

}