using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_17
{
    class PR { 
        public void Pr(object x)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("아", "이유");
            Person per2 = new Person("김", "연아");
            Employee emp1 = new Employee(2020155, "류", "현진");



            Employee emp2 = new Employee(2020200, "손", "흥민");
            emp2.VirtualPrint();



            emp1 = (Employee)per;   //실행됨
            emp2 = (Employee)per2;  //실행안됨          //태생에 대하여 결정
            ((Employee)per).Print();
            emp1.VirtualPrint();
            emp1 = per2 as Employee;
            if (emp1 != null)
                emp1.VirtualPrint();

            if(per2 is Employee)
            {
                emp1 = (Employee)per2;
            }
            else Console.WriteLine("형변환불가 ");
            
        }
    }
}
