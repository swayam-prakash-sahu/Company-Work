using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace FitKitWebApp.Controllers
{
    public class LoginController : Controller
    {

        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;


        public LoginController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginDetails user)
        {
            try
            {
                var json = JsonConvert.SerializeObject(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("api/login", data);

                if (response.IsSuccessStatusCode)
                {
                    var tokenResponse = await response.Content.ReadAsStringAsync();
                    var token = JsonConvert.DeserializeObject<TokenModel>(tokenResponse);

                    HttpContext.Session.SetString("AccessToken", token.Token);

                    return RedirectToAction("Index", "Home");
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    TempData["Login failed"] = "The account you provided does not exist. Please signup or check your credentials and try again.";
                    return RedirectToAction("Index", "Signup");
                }
                else
                {
                    TempData["Login failed"] = "An error occured during login. Please try again later.";
                    return RedirectToAction("Index", "Signup");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Error", "Home");
            }

        }
    }
}
