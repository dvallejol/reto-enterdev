using Reto.Payment.DAL.Context;
using Reto.Payment.DAL.Generic;
using Reto.Payment.Models;

namespace Reto.Payment.DAL.ProductsDAL
{
    public class ProductsDAL: GenericRepositoryDAL<Products>, IProductsDAL
    {
        public ProductsDAL(ApplicationContext applicationContext): base(applicationContext)
        {
        }
    }
}
