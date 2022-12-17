using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    [Serializable]
    public class CustomNumber
    {
        private int Number;

        public CustomNumber()
        {
            Number = 0;
        }

        public void Set(int value)
        {
            Number = value;
        }
        public int Get()
        {
            return Number;
        }
    }
}
