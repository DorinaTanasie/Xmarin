using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsArray
{
    class Program
    {
        
        
        
        public void Add(Dictionary<string, string> Animals)
        {
            Animals.Add("Pisica", "Miau");
            Animals.Add("Caine", "Ham");
            Animals.Add("Leu", "Raww");

        }

        public void Afisare(Dictionary<string, string> Animals)
        {

            foreach(var animal in Animals )
            {
                Console.WriteLine(animal.Key + " " + animal.Value);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> AnimalArray = new Dictionary<string, string>();
            Program anim = new Program();
            anim.Add(AnimalArray);
            anim.Afisare(AnimalArray);
        }
    }
}
