using AutoMapper.Internal.Mappers;
using BestBrightness.StaticMappings;
using DataLogic.LogicInterfaces;
using DataLogic.Product;
using Repository.RepositoryInterfaces;

using ViewLogic.Product;

namespace BestBrightness.Logic
{
    public class ProductLogic: IProductLogic
    {
        private readonly iProducts _iProducts;

        public ProductLogic(iProducts iProducts)
        {
            _iProducts = iProducts;
        }
        public async Task<List<ProductView>> GetAllProductsAsync()
        {
            var products = await _iProducts.GetAllProducts();
            return ObjectMappings.Mapper.Map<List<ProductModel>, List<ProductView>>(products.ToList());
        }
    }
}
