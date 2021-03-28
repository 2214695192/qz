using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AddString:Calculator
    {
        string str1;

        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }
        string str2;

        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        public void addStr()
        {
            System.Text.StringBuilder st = new StringBuilder();
            string str = str1 + str2;
            Console.WriteLine("str1+str1:"+str);
        }
    }
}
