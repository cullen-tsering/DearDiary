using System.Web.Http;
using DearDiary.WebApi.App_Start;

namespace DearDiary.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
