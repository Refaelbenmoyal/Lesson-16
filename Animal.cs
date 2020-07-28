using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    abstract class Animal
    {
        //Data
        public string _name;
        //functonallty
        public Animal(string name)
        {
            _name = name;
        }
        public abstract void MakeSound();

        public override string ToString()
        {
            return "$ Animal: name:{_name}";
        }
    }
}
