using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HelpAssing3;

namespace Assignment3
{
    public class Program
        
    {
        private String My_name;
        public void Setvalue(String name1)
        {
            My_name=name1;
        }
        public String Getvalue()
        {
            return My_name;
        }
        static void Main(string[] args)
        {
            /*Program p1 = new Program();
            p1.Setvalue("Shakti Singh");
            String name=p1.Getvalue();
            Console.WriteLine(name);
            Console.ReadLine();*/
            /* Program2 p2 = new Program2(22);
             int value=p2.GetPrivateFieldA();
             Console.WriteLine(value);*/
            //// Programhelp p2 = new Programhelp("Shakti");
            // p2.Getnames();
            // Child.Main(new String[] { });


            //Dev d1 = new Dev();
            //  Console.WriteLine(d1.city);
            // d1.print2();
            // d1.GetUserInfo();

            // Child.Main(new String[] { });

            //Class7.Main(new string[] { });

            //Class8 c8=new Class8("india",455145);
            //c8.Getinfo2();

          //  Dev1 d1=new Dev1();
          //  d1.Print3();

            Class10 c=new Class10(10);
            c.print();
            

            

        
            
                


            Console.ReadLine();
        }
        internal class Dev :Program5
        {
            public Dev() : base("Pranav", "Delhi") { }

            internal void print2()
            {
                Console.WriteLine($"the Derived user name is {name} and city is {city} and is age  {age} and ac num is {account}");
            }
        }
    
    }
}
