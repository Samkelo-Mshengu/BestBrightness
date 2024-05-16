using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Provinces;

namespace BusinesssLogic.LogicInterface
{
    public interface IProvinceLogic
    {
        Task<List<ProvinceView>> GetAllProvinceAsync();
    }
}
