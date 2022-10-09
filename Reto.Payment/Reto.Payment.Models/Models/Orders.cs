using System.Collections.Generic;

namespace Reto.Payment.Models
{
    public class Orders
    {
        public List<Products> Products { get; set; } = new List<Products>();

        public Client Client { get; set; }
    }
}
