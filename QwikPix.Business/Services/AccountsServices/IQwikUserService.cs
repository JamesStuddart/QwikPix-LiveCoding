using System;
using System.Collections.Generic;
using QwikPix.Entities.Accounts;

namespace QwikPix.Business.Services.AccountServices
{
    public interface IQwikUserService : IQwikSave<QwikUser>, IQwikDelete<QwikUser>
    {
        IEnumerable<QwikUser> GetAll();
        QwikUser GetById(Guid id);
    }
}
