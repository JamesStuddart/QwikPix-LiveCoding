using System;
using System.Collections.Generic;
using System.Linq;
using Debonair.Data;
using QwikPix.Entities.Content;

namespace QwikPix.Business.Services.ContentServices
{
    public class PixService : BaseService<Pix>, IPixService
    {
        public PixService(IDataRepository<Pix> repository)
        {
            Initialize(repository);
        }

        public Pix GetById(Guid id)
        {
            return Repository.Select(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Pix> GetByUserId(Guid userId)
        {
            return Repository.Select(x => x.UserId == userId);
        }

        public bool Delete(Pix entity, bool forceDelete = false)
        {
            return Repository.Delete(entity, forceDelete);
        }

        public bool Insert(Pix entity)
        {
            return Repository.Insert(entity);
        }

        public bool Update(Pix entity)
        {
            return Repository.Update(entity);
        }

    }
}
