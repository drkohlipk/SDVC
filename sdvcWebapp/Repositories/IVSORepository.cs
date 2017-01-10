using System.Collections.Generic;
using sdvcWebapp.Models;

namespace sdvcWebapp.Repository
{
    public interface IVSORepository : IBaseRepository<VSO>
    {
        List<VSO> GetVSOsByKeyword(string keyword);
    }
}