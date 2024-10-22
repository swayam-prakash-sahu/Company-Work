using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("Search")]
    public class SearchController : Controller
    {

        [Route("SearchResult")]
        public IActionResult SearchResult()
        {
            return View();
        }

        [Route("HandleQuery")]
        public IActionResult HandleQuery()
        {
            return RedirectToAction("SearchResult");
        }

    }
}
