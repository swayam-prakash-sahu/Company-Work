using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace FitKitWebApp.Controllers
{
    public class ExerciseController : Controller
    {
        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;

        public ExerciseController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

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

                var exercisesResponse = await _httpClient.GetAsync("api/Exercises");

                if (!exercisesResponse.IsSuccessStatusCode)
                {
                    if (exercisesResponse.StatusCode == HttpStatusCode.NotFound)
                    {
                        return View("Error", "Exercise database not found.");
                    }
                    else if (exercisesResponse.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        TempData["AccessDenied"] = "You are not authorize to access this resource.";
                        return RedirectToAction("Index", "Signup");
                    }
                    else
                    {
                        return View("Error", $"Error: {exercisesResponse.StatusCode}");
                    }
                }

                var exercisesJson = await exercisesResponse.Content.ReadAsStringAsync();
                var exercises = JsonConvert.DeserializeObject<List<Exercise>>(exercisesJson);
                if (exercises == null)
                {
                    return View("Error", "Failed to deserialize the exercises object.");
                }

                return View(exercises);

            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }
    }
}
