using Chloe.Server.Services.Contracts;
using System.Web.Http;

namespace Chloe.Server.Controllers.v1
{
    [RoutePrefix("api/v1/product")]
    public class v1_ProductController : ApiController
    {
        public v1_ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("v1");
        }

        protected readonly IProductService productService;
    }
}