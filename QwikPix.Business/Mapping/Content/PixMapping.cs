using Debonair.FluentApi;
using QwikPix.Entities.Content;

namespace QwikPix.Business.Mapping.Content
{
    public class PixMapping : EntityMapping<Pix> 
    {
        public PixMapping()
        {
            SetIgnore(x => x.ShortDescription);
        }
    }
}
