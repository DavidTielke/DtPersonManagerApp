using System.Data.SqlTypes;
using DataClasses;
using DataStoring.Contract.Exceptions;

namespace DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        private static List<Person> _items;

        static PersonRepository()
        {
            _items = new List<Person>
            {
                new Person(1, "David", 38),
                new Person(2, "Lena", 34),
                new Person(3, "Maximilian", 9),
            };
        }

        public IQueryable<Person> Query => _items.AsQueryable();

        public void Insert(Person person)
        {
            try
            {

                if (person.Id != 0)
                {
                    throw new SqlTypeException("Can't add Entity with an id unequal 0, because its not new!");
                }

                person.Id = _items.Max(p => p.Id) + 1;
                _items.Add(person);
            }
            catch (SqlTypeException exc)
            {
                throw new DataStoringInsertException($"Person with id {person.Id} can't be inserte dinto the database, because just ids with 0 accepted", exc);
            }
        }
    }
}