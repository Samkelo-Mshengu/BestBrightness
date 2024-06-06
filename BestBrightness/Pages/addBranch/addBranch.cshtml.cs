using BusinesssLogic.BranchLogic;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewLogic.Branch;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace BestBrightness.Pages.AddBranch
{
    public class AddBranchModel : PageModel
    {
        private readonly ICountriesLogic _countriesLogic;
        private readonly IProvinceLogic _provinceLogic;

        public List<CountryView> GetAllCountries { get; set; }
        public string SelectedCountry { get; set; }
        public readonly IBranchLogic _branchLogic;
        public List<ProvinceView> GetAllProvinces { get; set; }
        [BindProperty]
        public AddBranchView AddBranchView { get; set; }
        [BindProperty]
        public Guid? SelectedProvince { get; set; }
        [BindProperty]
        public Guid? SelectedCity { get; set; }
        public AddBranchModel(ICountriesLogic countriesLogic, IProvinceLogic provinceLogic, IBranchLogic branchLogic)
        {
            _countriesLogic = countriesLogic;
            _provinceLogic = provinceLogic; 
            _branchLogic = branchLogic;
            AddBranchView = new AddBranchView();
        }

        public async Task OnGet()
        {
            GetAllCountries = await _countriesLogic.GetCountriesAsync();
        }

        public async Task<IActionResult> OnGetGetProvincesAsync(string selectedCountry)
        {
            GetAllProvinces = await _provinceLogic.GetAllProvinceAsync(selectedCountry);
            return new JsonResult(GetAllProvinces);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var province = SelectedProvince;
            var city = SelectedCity;
            if (province!=null && city !=null) {
                AddBranchView.branch.ProvinceID = (Guid)province;
                AddBranchView.branch.CityID = (Guid)city;
                if (!string.IsNullOrEmpty(AddBranchView.branch.BranchName) && !string.IsNullOrEmpty(AddBranchView.branch.BranchLocation))
                {
                    var model = ObjectMapper.Mapper.Map<AddBranchView>(AddBranchView);
                    await _branchLogic.AddNewBranchAsync(model);
                 return RedirectToPage("/AddBranch/UpdateBranch");
                }
               
            }
             await OnGet();
            return RedirectToPage("/AddBranch/UpdateBranch");
        }
    }
}
