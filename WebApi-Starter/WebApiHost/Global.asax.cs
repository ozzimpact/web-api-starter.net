using System.Web;

namespace WebApiHost
{
    public class WebApiApplication:HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.Start();
        }
    }
}
