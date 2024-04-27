using DataLogic;
using DataLogic.Product;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ProductRepository
{
    public class ProductRepo: GenericRepository<ProductModel>, iProducts
    {
        private readonly DefaultContext _context;

        public ProductRepo(DefaultContext context): base(context)
        {
            _context = context;
        }

        public async Task<List<ProductModel>> GetAllProducts(CancellationToken token = default)
        {
            const string query = "EXEC [GetAllProducts] ";
            return await _context.Set<ProductModel>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }
    }
}
