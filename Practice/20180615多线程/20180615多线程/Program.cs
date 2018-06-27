using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20180615多线程
{

    public delegate int add(int a, int b);

    class Program
    {
        private static bool state = false;

        static void Main(string[] args)
        {
            Console.WriteLine("主线程:{0}", Thread.CurrentThread.ManagedThreadId);
            add diao = new add(nb);
            IAsyncResult re = diao.BeginInvoke(1, 2, new AsyncCallback(appcomplete), "fuck you");
            int i = 1;
            while(!state)
            {
                Console.WriteLine("wait{0}",i);
                Thread.Sleep(1000);
                i++;
            }
            var rt = diao.EndInvoke(re);
            Console.WriteLine("jieguo {0}", rt);
            Console.ReadLine();
        }

        public static int nb(int a, int b)
        {
            Console.WriteLine("新的线程{0}",Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return a + b;
        }

        static void appcomplete (IAsyncResult a)
        {
            Console.WriteLine("chufal:{0}", a.AsyncState);
            state = a.IsCompleted;
        }
    }

   
}
