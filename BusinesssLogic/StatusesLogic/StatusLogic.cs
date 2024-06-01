using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Countries;
using DataLogic.Statuses;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Countries;
using ViewLogic.Statuses;

namespace BusinesssLogic.StatusesLogic
{
    public class StatusLogic: IStatusesLogic
    {
        private readonly iStatus _iStatus;

        public StatusLogic(iStatus iStatus)
        {
            _iStatus = iStatus;
        }
        public async Task<List<StatusView>> GetStatusAsync()
        {
            var status = await _iStatus.GetAllStatuses();
            return ObjectMapper.Mapper.Map<List<Status>, List<StatusView>>(status.ToList());
        }

    }
}
