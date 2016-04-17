using Chloe.Server.Services.Contracts;
using System.Web.Http;

namespace Chloe.Server.Controllers.v2
{
    //Can not have two controllers with the same name (ProductControllers) in the Application
    [RoutePrefix("api/v2/product")]
    public class v2_ProductController : ApiController
    {
        public v2_ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("v2");
        }

        protected readonly IProductService productService;
    }
}