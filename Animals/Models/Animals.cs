namespace Project.Animal.animal;

class Animal
{
    public string name;
    public Animal(string name = "Tigre") {
        this.name = name;
    }

    public void moove() {
        Console.WriteLine(this.name + " Moove");
    }
    public void sleep()
    {
        Console.WriteLine(this.name + " Sleep");
    }
}