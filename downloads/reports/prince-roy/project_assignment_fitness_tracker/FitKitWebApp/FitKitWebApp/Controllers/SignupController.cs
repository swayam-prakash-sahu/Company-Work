using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace FitKitWebApp.Controllers
{
    public class SignupController : Controller
    {

        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;

        public SignupController()
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
        public async Task<IActionResult> Index(UserCredential user)
        {
            try
            {
                user.CreatedDate = DateTime.Now;
                user.ModifiedDate = DateTime.Now;
                user.Active = true;

                var json = JsonConvert.SerializeObject(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/UserCredentials", data);

                if (response.IsSuccessStatusCode)
                {
                    json = JsonConvert.SerializeObject(new { UserName = user.UserName, Password = user.Password });
                    data = new StringContent(json, Encoding.UTF8, "application/json");
                    response = await _httpClient.PostAsync("api/login", data);

                    if (response.IsSuccessStatusCode)
                    {
                        try
                        {
                            var tokenResponse = await response.Content.ReadAsStringAsync();
                            var token = JsonConvert.DeserializeObject<TokenModel>(tokenResponse);

                            HttpContext.Session.SetString("AccessToken", token.Token);

                            TempData["Name"] = $"{user.FirstName} {user.LastName}";
                            var accessToken = HttpContext.Session.GetString("AccessToken");

                            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                            var userDetailsResponse = await _httpClient.GetAsync("api/UserDetails");

                            if (userDetailsResponse.IsSuccessStatusCode)
                            {
                                return RedirectToAction("Index", "UserDetails");
                            }
                        }
                        catch (Exception ex)
                        {
                            return View(ex.Message);
                        }
                    }
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();

                    return View(errorMessage);
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

            return View();
        }

        private static string TitleCase(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
        }
    }
}
