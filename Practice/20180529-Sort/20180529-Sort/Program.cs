using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180529_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1[] b = new Class1[5];
            b[0] = new Class1("asda", "asd", 1);
            b[1] = new Class1("asd", "das", 211);
            b[2] = new Class1("fgd", "qwe", 3);
            b[3] = new Class1("zxwe", "qwf", 45);
            b[4] = new Class1("werw", "fgsdff", 5);

            foreach(var item in b)
            {
                Console.WriteLine("{0}  --  {1}", item.id, item.name);

            }
            Array.Sort(b);

            Console.WriteLine("----------------------------");

            foreach (var item in b)
            {
                Console.WriteLine("{0}  --  {1}", item.id, item.name);

            }
            Console.ReadLine();
        }
    }
}
