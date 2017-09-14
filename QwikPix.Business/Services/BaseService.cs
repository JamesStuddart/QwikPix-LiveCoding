using System;
using System.Collections.Generic;
using System.Text;
using Debonair.Data;

namespace QwikPix.Business.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        public IDataRepository<TEntity> Repository { get; set; }

        public void Initialize(IDataRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Repository.Select();
        }

        #region IDisposable

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    //do something here if you like :)
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }


        #endregion IDisposable

    }
}
