using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Age;

namespace BusinesssLogic.LogicInterface
{
    public interface IAgeGroupsLogic
    {
        Task<List<AgeGroupView>> GetAllAgeGroupsAsync();

    }
}
