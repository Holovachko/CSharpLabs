using System;
using System.Collections.Generic;
using System.Text;

namespace ex2
{
    class TEmploeer
    {
        string post;
        string passport;
        double tsalary;
        public DateTime WorkStart;
        public DateTime PostStart;

        public string Post{
            get {return post;}
            set {post = value;}
}
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        public double Tsalary
        {
            get { return tsalary; }
            set { tsalary = value; }
        }

        public TEmploeer(int workStartYear, int workStartMonth, int PostStartYear, int PostStartMonth , string passport , string post)
        {
            this.post = post;
            this.passport = passport;
            WorkStart = new DateTime(workStartYear, workStartMonth , 1);
            PostStart = new DateTime(PostStartYear, PostStartMonth, 1);
        }
        public int experience()
        {
            DateTime Today = new DateTime(2021, 03, 29);
            return Today.Year - WorkStart.Year;
        }
        public double salary()
        {
            Random rnd = new Random();
            tsalary = rnd.Next(5000);
            return tsalary;
        }

    }
}
