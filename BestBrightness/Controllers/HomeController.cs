using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewLogic.Branch;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace BestBrightness.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvinceLogic _provinceLogic;
        private readonly ICountriesLogic _countryLogic;

        public HomeController(IProvinceLogic provinceLogic, ICountriesLogic countryLogic)
        {
            _provinceLogic = provinceLogic;
            _countryLogic = countryLogic;
        }

        public async Task<IActionResult> Index()
        {
            var countries = await _countryLogic.GetCountriesAsync();
            return View(countries);
        }

        [HttpGet]
        public async Task<JsonResult> GetProvinces(string selectedCountry)
        {
            var provinces = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
            return Json(provinces);
        }
    }
}
