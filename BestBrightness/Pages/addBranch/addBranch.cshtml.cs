using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewLogic.Provinces;

namespace BestBrightness.Pages.AddBranch
{
    public class AddBranchModel : PageModel
    {

        [BindProperty]
        public List<ProvinceView> GetAllProvince {  get; set; }

        public readonly IProvinceLogic _provinceLogic;

       
        public string SelectedProvince { get; set; }

        public SelectList AllProvinces { get; set; }

        public AddBranchModel(IProvinceLogic provinceLogic)
        {
            _provinceLogic = provinceLogic;

            GetAllProvince=new List<ProvinceView>();
        }
        public async Task OnGet()
        {
            GetAllProvince=await _provinceLogic.GetAllProvinceAsync();
            Page();
        }
    }
}
