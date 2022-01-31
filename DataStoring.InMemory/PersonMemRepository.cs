using DataClasses;

namespace DataStoring.InMemory
{
    public class PersonMemRepository : IPersonRepository
    {
        public IQueryable<Person> Query => new List<Person>
        {
            new Person(1, "TDavid", 38),
            new Person(2, "TLena", 34),
            new Person(3, "TMaximilian", 9),
        }.AsQueryable();

        public void Insert(Person person)
        {
            throw new NotImplementedException();
        }
    }
}