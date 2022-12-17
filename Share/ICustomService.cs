using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public interface ICustomService 
    {
        int sum(int a, int b);
        List<int> GetNumList(List<int> func);
        CustomNumber GetCustomNumber(int number);
    }
}
