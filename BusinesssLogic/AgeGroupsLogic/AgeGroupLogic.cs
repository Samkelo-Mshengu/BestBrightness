using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Age;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Age;
using ViewLogic.Statuses;

namespace BusinesssLogic.AgeGroupsLogic
{
    public class AgeGroupLogic:IAgeGroupsLogic
    {
        private readonly iAgeGroup _iAgeGroup;

        public AgeGroupLogic(iAgeGroup iAgeGroup)
        {
            _iAgeGroup = iAgeGroup;
        }
        public async Task<List<AgeGroupView>> GetAllAgeGroupsAsync()
        {
            var age = await _iAgeGroup.GetAllAgeGroups();
           var model=ObjectMapper.Mapper.Map<List<AgeGroup>, List<AgeGroupView>>(age.ToList());
            return model;
        }

    }
}
