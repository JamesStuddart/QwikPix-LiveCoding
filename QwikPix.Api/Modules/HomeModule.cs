using Nancy;

namespace QwikPix.Api.Modules
{
    public class HomeModule : NancyModule
    {

        public HomeModule() 
        {
            Get("/", args => GetHome());
        }

        private dynamic GetHome()
        {
            return Response.AsJson(new {page = "This is my new website"});
        }
    }
}
