using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Manager());
            list.Add(new CEO());
            foreach (var e in list)
            {
                e.Draw();
            }

            CEO o = new CEO();
            o.Draw();

            Console.ReadLine();
        }

        public abstract class Employee
        {
            //protected string name = "Employee";
            protected string name ;
            //public abstract void Draw()
            //{
            //    Console.WriteLine("{0}", name);
            //}
            public abstract void Draw(); 

        }

        public class Manager : Employee
        {
            private string name;
            public  Manager()
            {
                this.name = "Manager";
            }
            
            public override void Draw()
            {
                Console.WriteLine("{0}", name);
            }
        }

        public class CEO : Manager
        {
            private string name = "CEO";
            public new void Draw()
            {
                Console.WriteLine("{0}", name);
            }

        }

    }
}
