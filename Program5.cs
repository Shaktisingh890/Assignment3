using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpAssing3
{
    public class Program5
    {
        protected internal String name;
        protected internal String city;
        protected int age = 18;
        protected int account = 123344;

        protected Program5(String name, String city)
        {
            this.name = name;
            this.city = city;
        }
        protected internal void GetUserInfo()
        {
            Console.WriteLine($"Student name is{name} and city is {city}");

        }
    }
}
