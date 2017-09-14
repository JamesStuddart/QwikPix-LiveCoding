using System;
using Nancy;
using Nancy.ModelBinding;
using QwikPix.Business.Services;
using QwikPix.Entities.Accounts;

namespace QwikPix.Api.Modules.Accounts
{
    public class QwikUserModule : NancyModule
    {
        private readonly IServiceManager _serviceManager;

        public QwikUserModule(IServiceManager serviceManager) : base("users")
        {
            _serviceManager = serviceManager;

            Get("/", args => GetUsers());
            Get("/{userId}", args => GetUser(args.userId));

            Post("/", args =>  UpdateUser());
        }

        private dynamic UpdateUser()
        {
            var user = this.Bind<QwikUser>();

            if (user == null || _serviceManager.QwikUsers.GetById(user.Id) == null)
            {
                return Response.AsJson("The user was not found", HttpStatusCode.NotFound);
            }

            _serviceManager.QwikUsers.Update(user);

            return Response.AsJson(user);
        }

        private dynamic GetUser(Guid userId)
        {
            if (userId.Equals(Guid.Empty))
            {
                return HttpStatusCode.NotFound;
            }

            var user = _serviceManager.QwikUsers.GetById(userId);

            if (user == null)
            {
                return HttpStatusCode.NotFound;
            }

            return Response.AsJson(user);
        }

        private dynamic GetUsers()
        {
            var users = _serviceManager.QwikUsers.GetAll();

            return Response.AsJson(users);

        }
    }
}
