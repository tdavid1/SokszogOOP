using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Program
    {
        private List<Teglalap> list = new List<Teglalap>();
        static void Main(string[] args)
        {
            Haromszog h1 = new Haromszog();
            Haromszog h2 = new Haromszog(3,4,5);
            Teglalap t1 = new Teglalap(4, 3);
            Teglalap t2 = new Teglalap(5, 2);
            Console.WriteLine(h1 + "\n" + h2 + "\n"+ t1 + "\n"+t2);
            Console.ReadKey();
        }
    }
}
