using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Product;

namespace DataLogic.LogicInterfaces
{
    public interface IProductLogic
    {

        Task<List<ProductView>> GetAllProductsAsync();
    }
}
