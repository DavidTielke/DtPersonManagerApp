using DataClasses;

namespace DataStoring;

public interface IPersonRepository
{
    IQueryable<Person> Query { get; }
}