using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewages_Day3
{
    public class empwage
    {
        public static void Employeewages()
        {
            int Full_Time = 1;
            int emp_rate_per_hour = 20;
            int emphrs = 0;
            int emp_wage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == Full_Time)
            {
                Console.WriteLine("employee is Present");
                emphrs = 8;

            }
            else
            {
                Console.WriteLine("Employee is absent");
                emphrs = 0;
            }

            emp_wage = emphrs * emp_rate_per_hour;
            Console.WriteLine("Emp wage :" + emp_wage);
        }
        

        
    }

    
}
