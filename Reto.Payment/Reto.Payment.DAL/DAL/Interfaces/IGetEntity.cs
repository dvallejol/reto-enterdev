using System.Collections.Generic;

namespace Reto.Payment.DAL.Interfaces
{
    public interface IGetEntity<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        List<TEntity> Get();
    }
}
