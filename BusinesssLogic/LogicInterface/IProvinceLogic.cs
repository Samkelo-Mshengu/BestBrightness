using ViewLogic.City;
using ViewLogic.Provinces;

namespace BusinesssLogic.LogicInterface
{
    public interface IProvinceLogic
    {
        Task<List<ProvinceView>> GetAllProvinceAsync(string countryName);
        Task<List<CityView>> GetAllCityAsync(Guid province);
    }
}
