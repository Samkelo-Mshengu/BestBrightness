using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Statuses;

namespace BusinesssLogic.LogicInterface
{
    public interface IStatusesLogic
    {
        Task<List<StatusView>> GetStatusAsync();
    }
}
