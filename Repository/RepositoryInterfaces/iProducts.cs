using DataLogic.Product;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unipluss.Sign.ExternalContract.Entities;

namespace Repository.RepositoryInterfaces
{
    public interface iProducts: iGenericRepository<ProductModel>
    {
        Task<List<ProductModel>> GetAllProducts(CancellationToken token = default);
    }
}
