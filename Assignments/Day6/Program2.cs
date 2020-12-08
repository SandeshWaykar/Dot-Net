using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo05
{

    public class Employee
    {
        int empno;
        string name;
        string designation;
        int age;

        public Employee(int empno,string empname,string designation,int age)
        {
            this.empno = empno;
            this.name = empname;
            this.designation = designation;
            this.age = age;
        }

        public override string ToString()
        {
            return empno + " " + name + " " + designation + " " + age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1,"sandesh","manager",24);
            Employee e2 = new Employee(2,"sandy","genral manager",22);
            List<Employee> list = new List<Employee>();

            list.Add(e1);
            list.Add(e2);

            Employee[] emp = list.ToArray();

            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}