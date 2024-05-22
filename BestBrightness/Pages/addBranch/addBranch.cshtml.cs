using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web.Helpers;
using ViewLogic.Branch;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace BestBrightness.Pages.AddBranch
{

    public class AddBranchModel : PageModel
    {

        [BindProperty(SupportsGet =true)]
        public string SelectedCountry { get; set; }
        //public ILogger<AddBranchModel> Logger { get; set; }

        [BindProperty]
        public List<ProvinceView> GetAllProvince {  get; set; }
        [BindProperty]
        public List<CountryView> GetAllCountries { get; set; }
        [BindProperty]
        public AddBranchView AddBranchView { get; set; }

        public readonly IProvinceLogic _provinceLogic;

        public readonly ICountriesLogic _countryLogic;

        public readonly IBranchLogic _branchLogic;
        [BindProperty]
        public string SelectedProvince { get; set; }
        [BindProperty]
    

        public List<SelectListItem> ProvinceList { get; set; }    
        public AddBranchModel(IProvinceLogic provinceLogic, ICountriesLogic countryLogic, IBranchLogic branchLogic)
        {
            _provinceLogic = provinceLogic;
            _countryLogic = countryLogic;
            _branchLogic = branchLogic;
            GetAllProvince =new List<ProvinceView>();
            GetAllCountries =new List<CountryView>();
            ProvinceList = new List<SelectListItem>();
            AddBranchView = new AddBranchView();

        }
        public async Task OnGet(string selectedCountry)
        {

            GetAllCountries = await _countryLogic.GetCountriesAsync();

            if (!string.IsNullOrEmpty(selectedCountry))
            {
                SelectedCountry = selectedCountry;
                GetAllProvince = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
            }
           Page();


        }



        //public async Task<IActionResult> OnPostGetProvinceAsync(string selectedCountry)
        //{
        //    if (!string.IsNullOrEmpty(selectedCountry))
        //    {
        //        SelectedCountry = selectedCountry;
        //        var provinces = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
        //        ProvinceList = provinces.Select(p => new SelectListItem
        //        {
        //            Value = p.ProvinceID.ToString(),
        //            Text = p.ProvinceName + " " + p.City
        //        }).ToList();
        //    }

        //    // Repopulate countries for the dropdown


        //    return Page();
        //}
        [HttpGet]
        public async Task<JsonResult> OnGetProvincesAsync(string selectedCountry)
        {
            var provinces = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
            var provinceList = provinces.Select(p => new SelectListItem
            {
                Value = p.ProvinceName,
                Text = $"{p.ProvinceName} {p.City}"
            }).ToList();
            return new JsonResult(provinceList);
        }
        public async Task<IActionResult> OnPostAsync(string actions, AddBranchView addBranchView)
        {

            if (actions == "addBranch")
            {
                var model = ObjectMapper.Mapper.Map<AddBranchView>(addBranchView);
                await _branchLogic.AddNewBranchAsync(model);
            }

            return Page();
        }
    }
}
