namespace Project.Animal.griffin;
using Project.Animal.animal;


class Griffin : Animal
{
    public new string name;
    public Griffin(string name = "griffin") : base(name)
    {
        this.name = name;
    }
    public override void Moove()
    {
        Console.WriteLine(name + " the mooving Griffin");
    }
    public new void Sleep()
    {
        Console.WriteLine(name + " the sleeping griffin");
    }

}