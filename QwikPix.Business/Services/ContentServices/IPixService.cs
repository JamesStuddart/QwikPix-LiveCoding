using System;
using System.Collections.Generic;
using QwikPix.Entities.Content;

namespace QwikPix.Business.Services.ContentServices
{
    public interface IPixService : IQwikDelete<Pix>, IQwikSave<Pix>
    {
        IEnumerable<Pix> GetByUserId(Guid userId);
        Pix GetById(Guid id);
    }
}
