using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpAssing3
{
    internal class Programhelp
    {
        internal String name;

        internal Programhelp(String name)
        {
            this.name = name;

        }
        internal void Getnames()
        {
            Console.WriteLine(name);
        }

        static void Main(String[] args)
        {

        }
    }
}
