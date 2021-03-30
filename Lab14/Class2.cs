using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class class2 : TEmploeer
    {
        static int count;
        string department;
        int numOfWorkers = 0;
        public class2(int workStartYear, int workStartMonth, int PostStartYear, int PostStartMonth, string passport, string post , string department) : base(workStartYear, workStartMonth, PostStartYear, PostStartMonth, passport, post) {
            this.department = department;
            count++;
}       
      public double salaryPerYear()
        {
            if (experience() >= 5)
                return Tsalary * 1.1; 
            else if (experience() >= 10)
                return Tsalary* 1.25;
            else return Tsalary;
        }
    public string compareSalary()
        {
            if (salaryPerYear() >= 1800 || salaryPerYear() >= 2500 || salaryPerYear() >= 3000)
                return Passport;
            else return "Зарплата є нижчя, ніж середня";
        }


        

    }
}
