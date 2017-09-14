using System;
using System.Linq;
using Debonair.Data;
using QwikPix.Entities.Accounts;

namespace QwikPix.Business.Services.AccountServices
{
    public class QwikUserService : BaseService<QwikUser>, IQwikUserService
    {
        public QwikUserService(IDataRepository<QwikUser> repository)
        {
            Initialize(repository);
        }

        public QwikUser GetById(Guid id)
        {
            return Repository.Select(x => x.Id == id).FirstOrDefault();
        }

        public bool Delete(QwikUser entity, bool forceDelete = false)
        {
            return Repository.Delete(entity, forceDelete);
        }

        public bool Insert(QwikUser entity)
        {
            return Repository.Insert(entity);
        }

        public bool Update(QwikUser entity)
        {
            return Repository.Update(entity);
        }

    }
}
