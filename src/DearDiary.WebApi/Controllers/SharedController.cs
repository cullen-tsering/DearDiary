using System.Web.Http;

namespace DearDiary.WebApi.Controllers
{
    /// <summary>
    /// this controller will be shared by all the other API controller 
    /// so code can be shared by all child controllers
    /// </summary>
    public class SharedController : ApiController
    {
    }
}
