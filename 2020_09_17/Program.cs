using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("아", "이유");
            Employee emp1 = new Employee(2020155, "류", "현진");



            Employee emp2 = new Employee(2020200, "손", "흥민");
            emp2.VirtualPrint();

            Rpyee rpy1 = new Rpyee(114114, "임", "디기");



            per.VirtualPrint();

        }
    }
}
