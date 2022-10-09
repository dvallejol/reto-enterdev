using Reto.Payment.DAL.Context;
using Reto.Payment.DAL.Generic;
using Reto.Payment.Models;

namespace Reto.Payment.DAL.InvoiceDAL
{
    public class InvoiceDAL : GenericRepositoryDAL<Invoice>, IInvoiceDAL
    {
        public InvoiceDAL(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}
