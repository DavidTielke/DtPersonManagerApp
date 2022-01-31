using DataClasses;
using DataStoring;
using DataStoring.Contract.Exceptions;
using PersonManagement.Contract.Exceptions;

namespace PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;
        
        public PersonManager(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Person> GetAllAdults() => _repository.Query.Where(p => p.Age >= 18);
        public IQueryable<Person> GetAllChildren() => _repository.Query.Where(p => p.Age < 18);
        public void Add(Person person)
        {
            Console.WriteLine("+++ Enter Add(person)+++");
            try
            {
                _repository.Insert(person);
                Console.WriteLine("+++ SUCCEEED Add(Person) +++");
            }
            catch (DataStoringInsertException exc)
            {
                Console.WriteLine("!!! WARNING Add(person) !!!");
                throw new PersonAddException("Can't add person to the local storange", exc);
            }
            finally
            {
                Console.WriteLine("xxx Exit Add(person)");
            }
        }
    }
}