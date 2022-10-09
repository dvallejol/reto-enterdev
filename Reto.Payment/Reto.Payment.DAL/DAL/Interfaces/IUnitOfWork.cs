using Reto.Payment.DAL.Context;
using Reto.Payment.DAL.Generic;
using System;

namespace Reto.Payment.DAL.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        ApplicationContext context { get; }

        GenericRepositoryDAL<T> GenericRepositoryDAL { get; }

        void Save();
    }
}
