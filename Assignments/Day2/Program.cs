using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Employee e2 = new Employee("Sandesh");
            Employee e3 = new Employee("Sandesh",45000);
            Employee e4 = new Employee("",45000,08);


            Console.WriteLine(e2.EmpNumber);
            Console.WriteLine(e3.EmpNumber);
            Console.WriteLine(e4.EmpNumber);

            Console.ReadLine();

            e2.GetSalary();

        }
    }

    class Employee
    {

        #region Data Members
        string Name;
        static int EmpNo = 1;
        decimal Basic;
        public decimal DA, HRA, Gross_Salary;
        short DeptNo;
        #endregion


        #region SetterGetters
        public string EmpName
        {
            set
            {
                if (value != null)
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("Incorrect name");
                }
            }

            get
            {
                return Name;
            }
        }


        public int EmpNumber
        {
            set
            {
                if (value >= 0)
                {
                    EmpNo = value;

                }
            }
            get
            {
                return EmpNo++;
            }

        }

        public decimal BasicSalary
        {
            set
            {
                if ((50000 <= value) && (100000 >= value))
                {
                    Basic = value;
                }
            }
            get
            {
                return Basic;
            }

        }

       
        public short DeptNumber
        {
            set
            {
                if (value > 10)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine(" wrong dept no");
                }
            }
            get
            {
                return DeptNo;

            }
        }


        #endregion






        #region construc
        public Employee()
        {

        }
        public Employee(string Name, decimal Basic, short DeptNo)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public Employee(string Name, decimal Basic)
        {

            this.Name = Name;
            this.Basic = Basic;
        }

        public Employee(string Name)
        {

            this.Name = Name;

        }
        #endregion


        #region Methods
        public void GetSalary()
        {

            DA = ((Basic * 40) / 100);
            HRA = ((Basic * 20) / 100);
            Gross_Salary = Basic + DA + HRA;

            Console.WriteLine("Gross Salary : " + Gross_Salary);

        }
        #endregion


    }
}