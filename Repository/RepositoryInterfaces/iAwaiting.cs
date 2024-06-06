using DataLogic.Await;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iAwaiting:iGenericRepository<Awaiting>
    {
        Task<List<AwaitingModel>> GetAwaitingList(CancellationToken token = default);

        Task AwaitingStatusChange(AwaitingModel awaiting);
    }
}
