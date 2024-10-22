using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;

namespace FitKitWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var accessToken = HttpContext.Session.GetString("AccessToken");
                if (accessToken == null)
                {
                    TempData["AccessDenied"] = "You need to be authenticated.";
                    return RedirectToAction("Index", "Signup");
                }

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var currentUserResponse = await _httpClient.GetAsync("api/UserClaims");

                if (!currentUserResponse.IsSuccessStatusCode)
                {
                    if (currentUserResponse.StatusCode == HttpStatusCode.NotFound)
                    {
                        return View("Error", "Current user not found.");
                    }
                    else if (currentUserResponse.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        TempData["AccessDenied"] = "You are not authorize to access this resource.";
                        return RedirectToAction("Index", "Signup");
                    }
                    else
                    {
                        return View("Error", $"Error: {currentUserResponse.StatusCode}");
                    }
                }

                var currentUserJson = await currentUserResponse.Content.ReadAsStringAsync();
                var currentUser = JsonConvert.DeserializeObject<UserDetails>(currentUserJson);
                if (currentUser == null)
                {
                    return View("Error", "Failed to deserialize the user details object.");
                }

                return View(currentUser);

            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
