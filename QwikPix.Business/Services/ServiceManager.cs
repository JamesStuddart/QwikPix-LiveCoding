using System;
using QwikPix.Business.Services.AccountServices;
using QwikPix.Business.Services.ContentServices;

namespace QwikPix.Business.Services
{
    public class ServiceManager : IServiceManager
    {
        public IQwikUserService QwikUsers { get; }
        public IPixService Pix { get; }

        public ServiceManager(IQwikUserService qwikUserService, IPixService pixService)
        {
            QwikUsers = qwikUserService;
            Pix = pixService;
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
