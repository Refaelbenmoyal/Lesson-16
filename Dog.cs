using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Dog : Animal
    {
        //Data
        public string _favoriteDogFood;
        //functonallty
        public Dog(string favoriteDogFood, string name) : base(name)
        {
            _favoriteDogFood = favoriteDogFood;
            _name = name;
        }

        public override void MakeSound()
        {
            this.Bark();
        }
        public virtual void Bark()
        {
            Console.WriteLine("The Dog is bark"); 
        }

        public override string ToString()
        {
            return "$ Dog:  favoriteDogFood:{ _favoriteDogFood} + base.ToString()";
        }
    } 

}
