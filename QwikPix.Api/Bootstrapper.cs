using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Debonair.Data;
using Debonair.Provider.MsSql;
using Debonair.Provider.MsSql.Data.Context;
using Microsoft.Extensions.Configuration;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using QwikPix.Business.Services;
using QwikPix.Business.Services.AccountServices;
using QwikPix.Business.Services.ContentServices;
using QwikPix.Entities.Accounts;
using QwikPix.Entities.Content;

namespace QwikPix.Api
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private const string ConnectionStringName = "QwikPixConn";

        private IConfigurationRoot _configuration;
        protected void GetConfiguration()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines piplines)
        {
            GetConfiguration();

            var connection = new SqlConnection(_configuration.GetConnectionString(ConnectionStringName));

            container.Register<IDbConnection>(connection);

            var pixProvider = new MsSqlDataRepository<Pix>(new MsSqlProvider<Pix>(connection));
            container.Register<IDataRepository<Pix>>(pixProvider);

            var qwikUserProvider = new MsSqlDataRepository<QwikUser>(new MsSqlProvider<QwikUser>(connection));
            container.Register<IDataRepository<QwikUser>>(qwikUserProvider);

            container.Register<IServiceManager, ServiceManager>();
            container.Register<IQwikUserService, QwikUserService>();
            container.Register<IPixService, PixService>();
        }

    }
}
