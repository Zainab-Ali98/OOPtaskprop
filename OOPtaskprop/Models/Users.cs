using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtaskprop.Models
{
    public class Users
    {   
        string name;
        public string UserName
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please enter user name");
                   
                }
                else
                {
                    name = value;
                }

            }
        }
        double Salary;
        public double salary
        { 
            get
            {
                return Salary;
            }
            set
            {
                if(value >=350 && value <= 900)
                {
                    Salary = value;

                    Console.WriteLine($"Salary is : {salary}");


                }
                else
                {
                    Console.WriteLine("salary is our of range");
                }
            }

        }

        public void GetUserName()
        {
            Console.WriteLine("User name is :" + name);
        }

    }
}