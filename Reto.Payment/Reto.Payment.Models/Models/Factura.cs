using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Payment.Models.Models
{
    public class Factura
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }

        public List<Products> Productos { get; set; }
    }
}
