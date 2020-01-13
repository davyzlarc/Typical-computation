using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Student : Person
    {
        public int Course { get; private set; }
        public double AverageMark { get; set; }
        public double Stipend { get; private set; }
        public string Debt { get; set; }
        public string DebtProfessor { get; set; }


        public Student(string fName, string mName, string lName, int course, double mark) : base(fName, mName, lName)
        {
            Course = course;
            AverageMark = mark;
            this.CalculateStipend();
        }
        public override string GetInfo()
        {
            bool isStipend = (Stipend > 0);
            string info = GetFullName() + " - студент " + Course + "-го курса со средним баллом " + AverageMark.ToString("F2");
            if (isStipend)
                info += " и со стипендией " + Stipend.ToString("F2") + " рублей";
            else
                info += ", не получает стипендии";
            if (Debt != null)
                info += "; имеется задолженность по предмету \"" + Debt+"\"";
            if (DebtProfessor != null)
                info += ", преподователь принимающий пересдачу - " + DebtProfessor;
            return info;
        }
        public void CalculateStipend()
        {
            if (AverageMark >= 4.0)
                Stipend = Globals.basicStipend * AverageMark;
            else
                Stipend = 0;
        }
    }
}
