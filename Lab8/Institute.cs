using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Institute
    {
        private SortedList<Person, Person> persons = new SortedList<Person, Person>();
        public int Count
        {
            get
            {
                return persons.Count;
            }
        }
        public void Add(Person person)
        {
            if (person != null)
            {
                persons.Add(person, person);
            }
        }
        public void Remove(int index)
        {
            if (index >= 0 && index < persons.Count)
                persons.RemoveAt(index);
        }
        public Person GetPerson(int index)
        {
            if (index >= 0 && index < persons.Count)
                return persons.Values.ElementAt(index);
            else
                return null;
        }

        internal void Add(Professor professor, string text)
        {
            throw new NotImplementedException();
        }
    }
}
