using Autofac;
using System.Web.Http;
using TerryberrySample.Sample.Abstract;

namespace TerryberrySample.Sample.API.Controllers
{
    public class HelloWorldController : ApiController
    {
        public IHttpActionResult GetMessage()
        {
            using (var scope = AutofacConfig.Container.BeginLifetimeScope())
            {
                var message = scope.Resolve<IHelloWorldRepository>();

                var result = message.GetAll();

                return Json(result);
            }
        }
    }
}
