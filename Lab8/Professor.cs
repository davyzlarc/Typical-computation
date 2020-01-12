using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Professor : Person, ISalaryCalculator
    {
        public string Cathedra { get; }
        public int Experience { get; set; }
        public double Salary { get; protected set; }
        public string Subject { get; set; }


        public Professor(string fName, string mName, string lName, int exp, string cath, string subj)
            : base(fName, mName, lName)
        {
            Subject = subj;
            Cathedra = cath;
            Experience = exp;
            this.CalculateSalary();
        }
        public override string GetInfo()
        {
            bool isExperience = (Experience > 0);
            string info = GetFullName() + " - преподаватель по предмету \"" + Subject + "\" на кафедре \"" + Cathedra + "\"" ;
            if (isExperience)
                info += " со стажем " + Experience + " лет и с зарплатой " + Salary.ToString("F2") + " рублей";
            else
                info += " без стажа и с зарплатой " + Salary.ToString("F2") + " рублей";
            return info;
        }
        public virtual void CalculateSalary()
        {
            Salary = Globals.basicSalary + Experience * 1000;
        }
    }
}
