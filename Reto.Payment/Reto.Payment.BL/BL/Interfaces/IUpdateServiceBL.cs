namespace Reto.Payment.BL.Interfaces
{
    public interface IUpdateServiceBL<T> where T :class
    {
        void Update(T entity);
    }
}
