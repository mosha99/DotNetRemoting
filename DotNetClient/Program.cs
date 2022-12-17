using Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var obj = (ICustomService)Activator.GetObject(typeof(ICustomService), "tcp://localhost:8085/rahul");

            //object [] vs = new object [1];
            //vs [0] = 1;
            //Activator.CreateInstance(obj,vs);
            try
            {

                //test exeption
                //var x1 = obj.GetCustomNumber(2);
                //Console.WriteLine(x1.Get());
                //var x2 = obj.GetCustomNumber(4);
                //Console.WriteLine(x2.Get());
                //var x3 = obj.GetCustomNumber(5);
                //Console.WriteLine(x3.Get());


                // List<int> vs = new List<int>();
                // for (int i = 0; i < 100; i++)
                //     if (i % 3 == 0)
                //         vs.Add(i);
                // var list = obj.GetNumList(vs);
                // list.ForEach(x =>
                // {
                //     Console.WriteLine(x);
                // });
                // Console.ReadLine();

                // while (true)
                // {
                //     Console.Write("A : ");
                //     int a = int.Parse(Console.ReadLine());
                //     Console.WriteLine();
                //     Console.Write("B : ");
                //     int b = int.Parse(Console.ReadLine());
                //     var Result = (obj.sum(a, b)).ToString();
                //     Console.WriteLine($"A + B = {Result}");
                //     Console.WriteLine("-------");
                // }

            }
            catch (Exception ex)
            {

            }

            Console.ReadLine();

        }
    }
}
