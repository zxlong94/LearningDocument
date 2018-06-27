using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _20180531observableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Class1> a = new ObservableCollection<Class1>()
            {
                new Class1{ age = 22, name ="nb"},
                new Class1{ age = 33, name ="gb"}
            };

            a.CollectionChanged += cc;
            a.Remove(a.Last());
            a.Add(new Class1 { age = 44, name = "di"});
            Console.ReadLine();
        }

        public static void cc(object a, System.Collections.Specialized.NotifyCollectionChangedEventArgs b)
        {
            Console.WriteLine(b.Action);
            if (b.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("move-----old");
                foreach(Class1 item in b.OldItems)
                {

                    Console.WriteLine("{0},{1}",item.age,item.name);
                }
            }
            if (b.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("add-----new");
                foreach (Class1 item in b.NewItems)
                {
                    Console.WriteLine("{0},{1}", item.age, item.name);
                }
            }
        }
    }
}
