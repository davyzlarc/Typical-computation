using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class HeadOfCathedra : Professor
    {
        public int NumberOfPublications { get; set; }
        public HeadOfCathedra(string fName, string mName, string lName, int exp, string cath,  string subj, int numOfPubl)
            : base(fName, mName, lName, exp, cath, subj)
        {
            NumberOfPublications = numOfPubl;
            this.CalculateSalary();
        }
        public override string GetInfo()
        {
            bool isExperience = (Experience > 0);
            bool wasPublished = (NumberOfPublications > 0);
            string info = GetFullName() + " - заведующий кафедрой \"" + Cathedra + "\"" + ", преподающий предмет \"" + Subject + "\"";
            if (isExperience)
                info += " со стажем " + Experience + " лет и с зарплатой " + Salary.ToString("F2") + " рублей";
            else
                info += " без стажа и с зарплатой " + Salary.ToString("F2") + " рублей";
            if (wasPublished)
                info += ", имеет " + NumberOfPublications + " публикаций";
            else
                info += ", не имеет публикаций";
            return info;
        }
        public override void CalculateSalary()
        {
            Salary = Globals.basicSalary + Experience * 500 + NumberOfPublications * 1000;
        }
    }
}
