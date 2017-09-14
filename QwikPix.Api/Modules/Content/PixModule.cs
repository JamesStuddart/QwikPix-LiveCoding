using System;
using Nancy;
using QwikPix.Business.Services;

namespace QwikPix.Api.Modules.Content
{
    public class PixModule : NancyModule
    {
        private readonly IServiceManager _serviceManager;
        public PixModule(IServiceManager serviceManager) : base("pix")
        {
            _serviceManager = serviceManager;

            Get("/{userId}", args => GetUser(args.userId));
        }

        private dynamic GetUser(Guid userId)
        {
            if (userId.Equals(Guid.Empty) || _serviceManager.QwikUsers.GetById(userId) == null)
            {
                return HttpStatusCode.NotFound;
            }

            var pix = _serviceManager.Pix.GetByUserId(userId);
            
            return Response.AsJson(pix);
        }
    }
}
