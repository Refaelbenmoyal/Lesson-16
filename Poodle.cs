using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Poodle : Dog
    {
        //Data
        public string _numberOfPonyTails;
        //functonallty
        public Poodle(string numberOfPonyTails,string name, string favoriteFood):base(name,favoriteFood)
        {
            _numberOfPonyTails = numberOfPonyTails;
            _favoriteDogFood = favoriteFood;
            _name = name;
        }
        public override void Bark()
        {
            Console.WriteLine("The Poodle is bark poodle barking");
        }

        public override string ToString()
        {
            return "$ Poodle: numberOfPonyTails:{_numberOfPonyTails} + base.ToString()";
        }
    }
}
