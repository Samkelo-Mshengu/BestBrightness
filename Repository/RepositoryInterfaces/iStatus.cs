using DataLogic.Statuses;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iStatus:iGenericRepository<Status>
    {
        Task<List<Status>> GetAllStatuses(CancellationToken token = default);
    }
}
