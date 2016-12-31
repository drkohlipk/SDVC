using sdvcWebapp.Models;
using System.Collections.Generic;
public interface IKeywordRepository : IBaseRepository<Keyword>
{
    Keyword FindByText();
}