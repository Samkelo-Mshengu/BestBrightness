using DataLogic.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Product;

namespace BestBrightness.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ILogger<ProductsModel> _logger;
        private readonly IProductLogic _productLogic;
        public List<ProductView> products;
        //[BindProperty(SupportsGet = true)]
        [BindProperty(SupportsGet = true)]
        public string Searchterm { get; set; } = string.Empty;
        public ProductsModel(ILogger<ProductsModel> logger, IProductLogic productLogic)
        {
            _logger = logger;
            _productLogic = productLogic;
            products = new List<ProductView>();
        }
        public async Task OnGetAsync()
        {
            products = await _productLogic.GetAllProductsAsync();
            Page();
        }
    }
}
