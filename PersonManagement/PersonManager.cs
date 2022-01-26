using DataClasses;
using DataStoring;

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
    }
}