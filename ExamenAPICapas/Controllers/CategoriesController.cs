using Domain;
using ExamenAPICapas.Request;
using ExamenAPICapas.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ExamenAPICapas.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpPost]
        public void Insert(CategoryRequestInsert request)
        {

            CategoryService service = new CategoryService();

            //Transformas el request =>domian
            //Esto lo hace libreria con autompper
            Category domain = new Category
            {
                CategoryName = request.Name,
                CategoryDescription = request.Description
            };

            service.Insert(domain);

        }


        [HttpGet]
        public List<CategoryResponseGet> Get()
        {
            CategoryService service = new CategoryService();

            var categories= service.Get();

            //Convertir del domain=>Response
            var response = categories.Select(x => new CategoryResponseGet
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription
            }).ToList();

            return response;


        }

    }
}
