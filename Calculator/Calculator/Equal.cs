using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Equal
    {
        public int Equals(int x, int y)
        {
            int flag;
            if (x == y)
            {
                flag = 1;
                Console.WriteLine(" Equal! ");
            }
            else
            {
                flag = 0;
                Console.WriteLine(" Unequal! ");
            }
            return flag;
        }
    }
}
