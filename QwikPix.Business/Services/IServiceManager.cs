using System;
using System.Collections.Generic;
using System.Text;
using QwikPix.Business.Services.AccountServices;
using QwikPix.Business.Services.ContentServices;

namespace QwikPix.Business.Services
{
    public interface IServiceManager : IDisposable
    {
        IQwikUserService QwikUsers { get; }
        IPixService Pix { get; }
    }
}
