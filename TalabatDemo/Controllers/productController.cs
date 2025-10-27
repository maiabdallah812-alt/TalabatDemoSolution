using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalabatDemo.Models;

namespace TalabatDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase //BaseUrl/api/product
    {


        [HttpGet("{id}")] //GET :BaseUrl/api/product/id=6
        public ActionResult<Product> Get(int id)
        {


            return new Product() { Id = id };

        }



        [HttpGet]//GET: BaseUrl/api/prodect
        public ActionResult<Product> GetAll()
        {


            return new Product() { Id = 20 };
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {

            return new Product();
        }

        [HttpPut]
        public ActionResult<Product> UpdateProduct(Product product)
        {

            return new Product();

        }
    }

        }
