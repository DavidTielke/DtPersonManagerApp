
using DataStoring;
using PersonManagement;

namespace ConsoleClient
{
    public class Program
    {
        public static void Main()
        {
            IPersonRepository repository = new PersonRepository();
            IPersonManager manager = new PersonManager(repository);

            var adults = manager.GetAllAdults();
            var children = manager.GetAllChildren();

            Console.WriteLine("### Erwachsene (" + adults.Count() + ") ###");
            adults.ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.WriteLine("### Kinder (" + children.Count() + ") ###");
            children.ToList().ForEach(c => Console.WriteLine(c.Name));

        }
    }
}
