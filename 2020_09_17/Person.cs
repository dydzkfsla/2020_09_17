using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_17
{
    public class Person
    {
        protected string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        protected string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public Person() : this("김", "아무게")
        {
            Console.WriteLine("Person 생성");
        }

        ~Person()
        {
            Console.WriteLine("Person삭제");
        }

        public Person(string Fname, string Lname)
        {
            FName = Fname;
            this.Lname = Lname;
        }

        public void Print()
        {
            Console.WriteLine("============ Main =============");
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }

        public virtual void VirtualPrint()
        {
            Console.WriteLine("============ Main =============");
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public override string ToString()
        {
            return $"{fName}  {lname}";
        }
    }

    public class Employee : Person
    {
        int employeeID;

        public int EmployeeID { get => employeeID; set => employeeID = value; }

        public new void Print()
        {
            Console.WriteLine("============ Employee =============");
            Console.WriteLine("employeeID : {0}", EmployeeID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public override void VirtualPrint()
        {
            Console.WriteLine("============ Employee =============");
            Console.WriteLine("employeeID : {0}", EmployeeID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public Employee()
        {
            Console.WriteLine("Employee 생성");
        }

        public Employee(int ID) : base()
        {
            EmployeeID = ID;
        }

        public Employee(int ID, string Fname, string Lname) : base(Fname, Lname)
        {
            EmployeeID = ID;
        }

        ~Employee()
        {
            Console.WriteLine("Employee 삭제");
        }

        public override string ToString()
        {
            return $"{fName}  {lname}";
        }
    }

    public class SalesMan : Employee
    {

        int Bou = 100;

        #region 생성자
        public SalesMan() : base()
        {
            Console.WriteLine("SalesMan 생성");
            base.EmployeeID = 1;
        }
        public SalesMan(int ID, string Fname, string Lname) : base(ID,Fname, Lname)
        {
            base.EmployeeID = 1;
        }
        #endregion
    }
}
