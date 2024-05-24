using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using System.Web.WebPages.Html;
using ViewLogic.Branch;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace BestBrightness.Controllers
{

    public class BranchController : Controller
    {
        public readonly IProvinceLogic _provinceLogic;

        public readonly ICountriesLogic _countryLogic;

        [BindProperty]
        public List<ProvinceView> GetAllProvince { get; set; }
        [BindProperty]
        public List<CountryView> GetAllCountries { get; set; }
        [BindProperty]
        public AddBranchView AddBranchView { get; set; }
        [BindProperty]
        public string SelectedProvince { get; set; }
        [BindProperty]
        public string SelectedCountry { get; set; }

        public List<SelectListItem> CountryList { get; set; }

        public BranchController(IProvinceLogic provinceLogic, ICountriesLogic countryLogic)
        {
            _provinceLogic = provinceLogic;
            _countryLogic = countryLogic;
            GetAllProvince = new List<ProvinceView>();
            GetAllCountries = new List<CountryView>();
            AddBranchView = new AddBranchView();

        }
        public async Task<IActionResult> AddNewBranch()
        {
            GetAllCountries = await _countryLogic.GetCountriesAsync();
            return View(GetAllCountries);
        }

        public async Task<IActionResult> OnGetProvincesAsync(string selectedCountry)
        {
            if (string.IsNullOrEmpty(selectedCountry))
            {
                return new JsonResult(new List<SelectListItem>());
            }

            var provinces = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
            var provinceList = provinces.Select(p => new SelectListItem
            {
                Value = p.ProvinceName,
                Text = p.ProvinceName + " " + p.City
            }).ToList();

            return new JsonResult( provinceList );
        }


        [HttpGet]
        public async Task<JsonResult> GetProvinces(string selectedCountry)
        {
            var provinces = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
            return Json(provinces);
        }
    }
}
