using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _20180625Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("当前main线程:{0}", Thread.CurrentThread.ManagedThreadId);
            printer p = new printer();
            
            //使用CLR的线程池
            for(int i = 0; i< 10; i++)
            {
                //ThreadPool.QueueUserWorkItem(new WaitCallback(number), p);

                //使用Asnyc和Await
                p.numberAsync();
            }
            Console.ReadLine();
        }
        
        static void number(object model)
        {
            printer pmodel = (printer)model;
            pmodel.printNumber();
        }

    }
}
