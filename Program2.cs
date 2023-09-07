using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public  class Program2
    {
        private int privateFieldA;

        public Program2(int value)
        {
            privateFieldA = value;
        }

        public int GetPrivateFieldA()
        {
            return privateFieldA;
        }
    }
}
