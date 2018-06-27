using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180531observableCollection
{
    public class Class1 : IComparer<Class1>
    {
        public int age { get; set; }

        public string name { get; set; }
        
        public int Compare(Class1 a, Class1 b)
        {
            if (a.age > b.age)
                return 1;
            if (a.age < b.age)
                return -1;
            return 0;
        }
    }
}
