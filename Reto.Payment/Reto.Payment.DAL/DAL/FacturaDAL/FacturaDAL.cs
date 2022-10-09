using Reto.Payment.DAL.Context;
using Reto.Payment.DAL.Generic;
using Reto.Payment.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Payment.DAL.DAL.FacturaDAL
{
    public class FacturaDAL : GenericRepositoryDAL<Factura>, IFacturaDAL
    {
        public FacturaDAL(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}




