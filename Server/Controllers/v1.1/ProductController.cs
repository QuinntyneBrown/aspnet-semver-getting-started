using Chloe.Server.Services.Contracts;
using System.Web.Http;

namespace Chloe.Server.Controllers.v1._1
{
    [RoutePrefix("api/v1.1/product")]
    public class ProductController : ApiController
    {
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("v1.1");
        }

        protected readonly IProductService productService;
    }
}