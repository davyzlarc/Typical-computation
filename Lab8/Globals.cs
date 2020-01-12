using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    abstract class Globals
    {
        public const string lastNamePattern =           "^(([А-Я]|Ё)([а-я]|ё){1,19}(-([А-Я]|Ё)([а-я]|ё){1,19})?)$";
        public const string firstAndMiddleNamePattern = "^(([А-Я]|Ё)([а-я]|ё){1,19})$";
        public const string subjectPattern = "^(([а-я]|ё){1,19}(-([а-я]|ё){1,19})?)$";
        public const string cathedraPattern = "^(([А-Я]|Ё)([а-я]|ё){1,19}(([а-я]|ё|\\s|-){1,100})?)$";

        public const int basicStipend = 1000;
        public const double maxAverageMark = 5.0;
        public const double minAverageMark = 2.0;

        public const int maxExperience = 50;
        public const double basicSalary = 50000;
        public const int maxPublications = 1000;
    }
}
