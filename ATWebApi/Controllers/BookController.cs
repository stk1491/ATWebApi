using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace ATWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<string> listbook = new List<string>() {"Harry Potter","Notebook" };
        [HttpGet]
        public 
    }
}
