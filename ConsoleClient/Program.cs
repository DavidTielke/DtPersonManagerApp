
using DataStoring;
using Ninject;
using PersonManagement;

namespace ConsoleClient
{
    public class Program
    {
        public static void Main()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();

            var manager = kernel.Get<IPersonManager>();

            var adults = manager.GetAllAdults();
            var children = manager.GetAllChildren();

            Console.WriteLine("### Erwachsene (" + adults.Count() + ") ###");
            adults.ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.WriteLine("### Kinder (" + children.Count() + ") ###");
            children.ToList().ForEach(c => Console.WriteLine(c.Name));

        }
    }
}
