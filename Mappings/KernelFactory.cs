using DataStoring;
using DataStoring.InMemory;
using Ninject;
using PersonManagement;

namespace Mappings
{
    public class KernelFactory
    {
        public IKernel Create()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();

            return kernel;
        }
    }
}