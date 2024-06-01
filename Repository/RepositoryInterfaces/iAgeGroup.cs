using DataLogic.Age;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iAgeGroup:iGenericRepository<AgeGroup>
    {
        Task<List<AgeGroup>> GetAllAgeGroups(CancellationToken token = default);
    }
}
