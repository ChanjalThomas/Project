using BusinesLogic;
using BusinesLogic.Interface;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using System.Collections;
using System.Net.Http;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatalogController : ControllerBase
    {
        ProductDbContext _Context;
        IProductCatalog _Catalog;
        public ProductCatalogController(ProductDbContext Context)
        {
            _Context = Context;
            _Catalog = new ProductCatalog(_Context);
        }
        [HttpGet]
        public IEnumerable GetAll()
        {
            return _Catalog.GetAll();
        }
        [HttpPost]
        public HttpResponseMessage Post([FromBody]Product product )
        {
            _Catalog.Add(product);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
        [HttpPut]
        public HttpResponseMessage Put([FromBody]Product product)
        {
            _Catalog.Update(product);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
        [HttpDelete]
        public HttpResponseMessage Delete(int Id)
        {
            Product  product=new Product();
            product=_Catalog.GetById(Id);

            _Catalog.Delete(product);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            
        }
    }
}
