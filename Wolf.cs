using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Wolf : Dog
    {
        //Data
        public string _nameOfPack;
        private string name;
        private string favoriteFood;

        //functionallty
        public Wolf(string nameOfPack,string name, string favoriteFood) : base (name, favoriteFood)
        {
            _nameOfPack = nameOfPack;
            _name = name;
            _favoriteDogFood = favoriteFood;
        }
        public override string ToString()
        {
           
            return "$ Wolf: nameOfPack:{_nameOfPack} + base.ToString()";
        }

    }
}
