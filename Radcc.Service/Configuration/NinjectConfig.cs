using Ninject;
using Radcc.Data;
using Radcc.Data.Infrastructure;
using Radcc.Data.Interfaces;

namespace Radcc.Service.Configuration
{
    public class NinjectConfig
    {
        public static void Config(IKernel kernel)
        {
            //kernel.Bind<IDbFactory>().To<DbFactory>();
            //kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            //kernel.Bind<IProgrammeRepository>().To<ProgrammeRepository>();
            //kernel.Bind<IUsefulLinkRepository>().To<UsefulLinkRepository>();
            //kernel.Bind<INewsArticleRepository>().To<NewsArticleRepository>();
        }
    }
}
