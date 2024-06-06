using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Await;

namespace BusinesssLogic.LogicInterface
{
    public interface IAwaitingLogic
    {
        Task<List<AwaitingViewModel>> GetAwaitingListAsync();

        Task AwaitingStatusChangeAsync(AwaitingViewModel awaiting);
    }
}
