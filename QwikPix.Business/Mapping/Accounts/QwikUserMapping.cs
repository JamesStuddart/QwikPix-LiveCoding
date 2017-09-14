using Debonair.FluentApi;
using QwikPix.Entities.Accounts;

namespace QwikPix.Business.Mapping.Accounts
{
    public class QwikUserMapping : EntityMapping<QwikUser>
    {
        public QwikUserMapping()
        {
            SetTableName("Users");
            SetColumnName(x => x.EmailAddress, "Email");
            SetPrimaryKey(x => x.Id);
        }
    }
}
