using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Horse : Animal
    {
        //Data
        public bool _racingHorse;
        //functonallty
        public Horse(string name, bool racingHorse): base(name)
        {
            _name = name;
            _racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            this.Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("The Horse is neigh");
        }

        public override string ToString()
        {
            return "$ Horse: racingHorse:{_racingHorse} + base.ToString()";
        }
    }
}
