
namespace Reto.Payment.BL.Interfaces
{
    public interface ICreateServiceBL<T> where T : class
    {
        T Create(T entity);
    }
}
