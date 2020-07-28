using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class PetWolf : Wolf
    {

        //Data
        public string nameOfPack;
        public string name;
        public string favoriteFood;

        //functionallty
        public PetWolf(string nameOfPack, string name, string favoriteFood) : base(name, favoriteFood,nameOfPack)
        {
            _nameOfPack = nameOfPack;
            _name = name;
            _favoriteDogFood = favoriteFood;
        }
        public override void Bark()
        {
            Console.WriteLine("");
        }
        public override string ToString()
        {

            return base.ToString();
        }
    }
   
}
