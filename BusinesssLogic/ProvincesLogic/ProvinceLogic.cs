using AutoMapper.Internal.Mappers;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Cities;
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
using ViewLogic.City;
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

        public async Task<List<CityView>> GetAllCityAsync(Guid province)
        {
            var city = await _iProvince.GetAllCityAsync(province);
            return ObjectMapper.Mapper.Map<List<City>, List<CityView>>(city.ToList());
        }

        public async Task<List<ProvinceView>> GetAllProvinceAsync(string countryName)
        {
            var province = await _iProvince.GetAllProvines(countryName);
            return ObjectMapper.Mapper.Map<List<Province>, List<ProvinceView>>(province.ToList());
        }


           
    }
}
