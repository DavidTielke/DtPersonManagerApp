
using System.Text;
using DataClasses;
using DataStoring;
using Mappings;
using Ninject;
using PersonManagement;

namespace ConsoleClient
{
    public class Program
    {
        public static void Main()
        {
            var kernel = new KernelFactory().Create();

            var manager = kernel.Get<IPersonManager>();

            var adults = manager.GetAllAdults();
            var children = manager.GetAllChildren();

            Console.WriteLine("### Erwachsene (" + adults.Count() + ") ###");
            adults.ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.WriteLine("### Kinder (" + children.Count() + ") ###");
            children.ToList().ForEach(c => Console.WriteLine(c.Name));

            var hasi = new Person(4, "Hasi", 9);
            try
            {
                manager.Add(hasi);
            }
            catch (Exception e)
            {
                var message = new StringBuilder();
                Exception current = e;
                do
                {
                    message.AppendLine(current.Message);
                    current = current.InnerException;
                } while (current != null);

               File.WriteAllText("log.txt", e.Message);
               Console.WriteLine(message.ToString());
            }


        }
    }
}
