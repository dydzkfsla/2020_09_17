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

        public Person()
        {

        }

        public Person(string Fname, string Lname)
        {
            FName = Fname;
            this.Lname = Lname;
        }

        public virtual void VirtualPrint()
        {
            Console.WriteLine("============ Main =============");
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public virtual void VirtualPrint(Person rpyee)
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

        public override void VirtualPrint()
        {
            Console.WriteLine("============ Employee =============");
            Console.WriteLine("employeeID : {0}", employeeID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public override void VirtualPrint(Person rpyee)
        {
            rpyee = new Employee();
            Console.WriteLine("============ Employee =============");
            Console.WriteLine("employeeID : {0}", employeeID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public Employee()
        {

        }

        public Employee(int ID) : base()
        {
            employeeID = ID;
        }

        public Employee(int ID, string Fname, string Lname) : base(Fname, Lname)
        {
            employeeID = ID;
        }

        public override string ToString()
        {
            return $"{fName}  {lname}";
        }
    }

    public class Rpyee : Person
    {

        int ID;
        public Rpyee()
        {
                
        }
        public Rpyee(int ID, string Fname, string Lname) : base(Fname, Lname)
        {
            this.ID = ID;
        }
        public override void VirtualPrint()
        {
            Console.WriteLine("============ Rpyee =============");
            Console.WriteLine("employeeID : {0}", ID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public override void VirtualPrint(Person rpyee)
        {
            Console.WriteLine("============ Rpyee =============");
            Console.WriteLine("employeeID : {0}", ID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
    }
}
