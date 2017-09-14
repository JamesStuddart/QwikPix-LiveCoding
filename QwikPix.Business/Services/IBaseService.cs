using System;
using System.Collections.Generic;
using System.Text;
using Debonair.Data;

namespace QwikPix.Business.Services
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : class, new()
    {
        IDataRepository<TEntity> Repository { get; }

        void Initialize(IDataRepository<TEntity> repository);
    }
}
