using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180529_Sort
{
    public class Class1 : IComparable
    {
        public int id { get; set; }

        public string name { get; set; }

        public string mesg { get; set; }

        public Class1(string name, string mesg, int id)
        {
            this.id = id;
            this.name = name;
            this.mesg = mesg;
        }
        int IComparable.CompareTo(object obj)
        {
            Class1 a = obj as Class1;
            if(a != null )
            {
                //if (this.id > a.id)
                //    return 1;
                //if (this.id < a.id)
                //    return -1;
                //else
                //    return 0;
                return this.id.CompareTo(a.id);
            }
            else
            {
                throw new Exception("no class!");
            }
        }
    }
}
