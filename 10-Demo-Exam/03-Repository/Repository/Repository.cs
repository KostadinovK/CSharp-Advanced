using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private int id = 0;
        private Dictionary<int, Person> data;

        public int Count => data.Count;

        public Repository()
        {
            data = new Dictionary<int, Person>();
        }

        public void Add(Person person)
        {
            data.Add(id,person);
            id++;
        }

        public Person Get(int id)
        {
            return data[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (!data.ContainsKey(id))
            {
                return false;
            }

            data[id] = newPerson;
            return true;
        }

        public bool Delete(int id)
        {
            if (!data.ContainsKey(id))
            {
                return false;
            }

            data.Remove(id);
            return true;
        }

    }
}
