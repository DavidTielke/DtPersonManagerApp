using DataClasses;

namespace DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<Person> Query => new List<Person>
        {
            new Person(1, "David", 38),
            new Person(2, "Lena", 34),
            new Person(3, "Maximilian", 9),
        }.AsQueryable();
    }
}