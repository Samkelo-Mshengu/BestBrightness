using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Product
{
    public class ProductView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = default!;
        public decimal Price { get; set; }

        public int RatingLevel { get; set; }
        public string imageUrl { get; set; } = default!;
        public string ProductDescription { get; set; } = default!;
    }
}
