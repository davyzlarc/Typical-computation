using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Person : IComparable<Person>
    {
        private static int staticKey = 0;
        private int uniqueKey;
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public Person(string fName, string mName, string lName)
        {
            FirstName = fName;
            MiddleName = mName;
            LastName = lName;
            uniqueKey = staticKey++;
        }
        abstract public string GetInfo();
        public string GetFullName()
        {
            return LastName + ' ' + FirstName + ' ' + MiddleName;
        }
        public int CompareTo(Person person)
        {
            if (person == null)
                return 1;
            return (GetFullName() + uniqueKey).CompareTo(person.GetFullName() + person.uniqueKey);
        }
    }
}
