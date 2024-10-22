using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace FitKitWebApp.Controllers
{
    public class UserDetailsController : Controller
    {
        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;

        public UserDetailsController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var accessToken = HttpContext.Session.GetString("AccessToken");
            if (accessToken != null)
            {
                return View();
            }

            TempData["AccessDenied"] = "You need to be authenticated.";
            return RedirectToAction("Index", "Signup");
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserDetails userDetails)
        {
            try
            {
                userDetails.CreatedAt = DateTime.Now;
                userDetails.ModifiedDate = DateTime.Now;

                var accessToken = HttpContext.Session.GetString("AccessToken");

                if (string.IsNullOrEmpty(accessToken))
                {
                    return RedirectToAction("Index", "Signup");
                }

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var json = JsonConvert.SerializeObject(userDetails);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/UserDetails", data);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

            return View();
        }
    }
}
