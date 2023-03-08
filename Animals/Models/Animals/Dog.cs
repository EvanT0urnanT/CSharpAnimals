using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAnimal.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    internal class Dog : Animal
    {
        public string dogName { get; private set; }
        public Dog(string name) {
            this.dogName = name;
        }
    }
}
