using System.Collections.Generic;

namespace Reto.Payment.BL.Interfaces
{
    public interface IGetServiceBL<T> where T:class
    {
       T Get(int Id);
        List<T> Get();
    }
}
