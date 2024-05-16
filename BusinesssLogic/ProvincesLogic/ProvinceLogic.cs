using AutoMapper.Internal.Mappers;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.LogicInterfaces;
using DataLogic.Product;
using DataLogic.Provinces;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Unipluss.Sign.ExternalContract.Entities;
using ViewLogic.Product;
using ViewLogic.Provinces;

namespace BusinesssLogic.ProvincesLogic
{
    public class ProvinceLogic:IProvinceLogic
    {
        private readonly iProvince _iProvince;

        public ProvinceLogic(iProvince iProvince)
        {
           _iProvince = iProvince;
        }

        public async Task<List<ProvinceView>> GetAllProvinceAsync()
        {
            var province = await _iProvince.GetAllProvines();
            return ObjectMapper.Mapper.Map<List<Province>, List<ProvinceView>>(province.ToList());
        }


           
    }
}
