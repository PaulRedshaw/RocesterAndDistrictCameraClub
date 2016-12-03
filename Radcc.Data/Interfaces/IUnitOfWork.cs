namespace Radcc.Data.Persistence
{
    public interface IUnitOfWork
    {
        IUsefulLinkRepository UsefulLinks { get; }
        INewsArticleRepository NewsArticles { get; }
        IProgrammeRepository Programmes { get; }

        void Commit();
    }
}
