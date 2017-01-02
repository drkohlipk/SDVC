using sdvcWebapp.Models;

namespace sdvcWebapp.Repository
{
    public interface IKeywordRepository : IBaseRepository<Keyword>
    {
        Keyword FindByText();
    }
}