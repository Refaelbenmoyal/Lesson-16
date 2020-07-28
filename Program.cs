using NPoco.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    { 
        static void AnimalSing(Animal[] Animals)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                Console.WriteLine(i);
                MakeSound();
            }
        }

        private static void MakeSound()
        {
            throw new NotImplementedException();
        }

        private static Wolf wo;

        static void Main(string[] args)
        {
            
            Horse ho = new Horse("ho", true);
            Wolf wo = new Wolf("wo10", "wo", "met");
            Poodle po = new Poodle("10", "po", "dogly");
            PetWolf pe = new PetWolf("pe10", "pe", "met");
            
        }
    }
}
