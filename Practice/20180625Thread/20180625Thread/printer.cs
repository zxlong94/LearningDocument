using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _20180625Thread
{
    public class printer
    {
        private object thlo = new object();

        public void printNumber()
        {
            lock(thlo)
            {
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000);
                    //Thread.Sleep(3000);
                    //Console.Write("线程{0}:{1} || ", Thread.CurrentThread.ManagedThreadId,i);

                    Console.Write("{0} || ", i);
                }
                Console.WriteLine();
            }
            
        }

        public async void numberAsync()
        {
            var text = await Task.Run( () =>
            {
                string bn= "线程:" + Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine(bn);
                printNumber();
                return bn;
            });
        }
    }
}
