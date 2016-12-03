using Radcc.Data.Context;
using Radcc.Data.Persistence;

namespace Radcc.Data.Persitence
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;


        public IProgrammeRepository Programmes { get; }
        public IUsefulLinkRepository UsefulLinks { get; }
        public INewsArticleRepository NewsArticles { get; }
        public IGalleryRepository Gallerys { get; }


        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            Programmes = new ProgrammeRepository(context);
            UsefulLinks = new UsefulLinkRepository(context);
            NewsArticles = new NewsArticleRepository(context);
            Gallerys = new GalleryRepository(context);

        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
