using Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetServer
{
    public class CustomService : MarshalByRefObject, ICustomService
    {
        private List<int> Numlist = new List<int>();
        public CustomService()
        {
            if (!Numlist.Any())
            {
                for (int i = 0; i < 100; i++)
                    if (i % 2 == 0)
                        Numlist.Add(i);
            }
        }
        public CustomService(int RootNumber)
        {
            if (!Numlist.Any())
            {
                for (int i = 0; i < 100; i++)
                    if (i % RootNumber == 0)
                        Numlist.Add(i);
            }
        }
        public List<int> GetNumList(List<int> func)
        {
            return Numlist.Where(x => func.Contains(x)).ToList();
        }

        public int sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }

        public CustomNumber GetCustomNumber(int number)
        {
            if (Numlist.Contains(number))
            {
                CustomNumber customNumber = new CustomNumber();
                customNumber.Set(number);
                return customNumber;
            }
            else throw new Exception("Number Not Find");
        }
    }
}
