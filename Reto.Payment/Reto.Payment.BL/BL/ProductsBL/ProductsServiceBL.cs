using Reto.Payment.BL.Generic;
using Reto.Payment.DAL.Interfaces;
using Reto.Payment.Models;

namespace Reto.Payment.BL.ProductsBL
{
    public class ProductsServiceBL : GenericServiceBL<Products>, IProductsServiceBL
    {
        public ProductsServiceBL(IUnitOfWork<Products> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
