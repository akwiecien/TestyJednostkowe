using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            vocabularies vocs = new vocabularies();
            var lista = vocs.GetItems();
            lista.ForEach(x => Console.WriteLine("{0} {1} {2}", x.pol, x.eng, x.nextRepeat.ToString("yyyy-MM-dd")));
            Console.ReadLine();
        }
    }
}
