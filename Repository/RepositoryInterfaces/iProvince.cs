using DataLogic.Provinces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iProvince:iGenericRepository<Province>
    {
        Task<List<Province>> GetAllProvines(CancellationToken token = default);
    }
}
