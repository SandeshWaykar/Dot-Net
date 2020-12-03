using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo2
{

    public abstract class Employee
    {

         public Employee()
        {
            Empno = lastempNo++;

            Console.WriteLine("Employee contructor");
        }
        public abstract decimal Basic
        {
            get;
            set;
        }
        public static int lastempNo = 0;
        public string name;

          public string EmpName
        {

            set
            {
                if(value!=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                }

            }

            get
            {

                return name;

            }

        }

        public int empno;
        public  int Empno
        {
            set
            {
                empno = value;

            }
            get
            {
                return empno;
            }
        }

        public short deptno;

         public short DeptNumber
        {
            set
            {
                 if(value>=0)
                {
                    deptno = value;
                }

                 else
                {
                    Console.WriteLine("you entered wrong number");
                }

            }

            get
            {
                return deptno;
            }
        }
        public abstract decimal CalcNetSalary(decimal basic);

    }


    public class Manager : Employee
    {

        public Manager()
            {
			 
             Empno = lastempNo++;
             Console.WriteLine("Manager class");

            }

        public string design;

        public string Designation
        {
            set
            {
                 if(value!=null)
                {
                    design = value;
                }
                 else
                {
                    Console.WriteLine("Invalid");

                }

            }

            get
            {
                return design;
            }
        }

         public override decimal Basic
        {
            set
            {
                 
                if(value > 1500 && value < 10000)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return Basic;
            }
        }
         
        public override decimal CalcNetSalary(decimal basic)
        {

            decimal DA = ((basic * 40) / 100);
            decimal HRA = ((basic * 20) / 100);
            decimal Gross_Salary = basic + DA + HRA;

            return Gross_Salary;

        }
    }

    public class GeneralManager : Manager
    {
        public GeneralManager()
        {
            Empno = lastempNo++;
            Console.WriteLine("Genral Manager constructer");
        }

        public string perks;

        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

    }

     public class CEO : Employee
    {
        public CEO()
        {
            Console.WriteLine("CEO class  constructor");
        }

        public override decimal Basic
        {
            set
            {

                if (value > 1500 && value < 10000)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return Basic;
            }
        }

        public override sealed decimal CalcNetSalary(decimal basic)
        {

            decimal DA = ((basic * 40) / 100);
            decimal HRA = ((basic * 20) / 100);
            decimal Gross_Salary = basic + DA + HRA;

            return Gross_Salary;

        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();

        }
    }
}