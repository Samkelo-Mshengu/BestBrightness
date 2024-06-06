using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Await;
using DataLogic.Members;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Await;
using ViewLogic.Members;
using ViewLogic.Statuses;

namespace BusinesssLogic.AwaitingsLogic
{
    public class AwaitingLogic : IAwaitingLogic
    {
        private readonly iAwaiting _iAwaiting;

        public AwaitingLogic(iAwaiting iAwaiting)
        {
            _iAwaiting = iAwaiting;
        }
        public async Task<List<AwaitingViewModel>> GetAwaitingListAsync()
        {
            var awaiting = await _iAwaiting.GetAwaitingList();
            return ObjectMapper.Mapper.Map<List<AwaitingModel>, List<AwaitingViewModel>>(awaiting.ToList());
        }

        public async Task AwaitingStatusChangeAsync(AwaitingViewModel awaiting)
        {
            var Model = ObjectMapper.Mapper.Map<AwaitingViewModel, AwaitingModel>(awaiting);
            await _iAwaiting.AwaitingStatusChange(Model);

        }
    }
}
