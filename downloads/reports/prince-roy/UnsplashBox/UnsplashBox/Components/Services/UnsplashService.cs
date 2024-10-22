public class UnsplashService
{

    private readonly HttpClient _httpClient;
    private const string ApiBaseUrl = "https://api.unsplash.com/";
    private const string AccessKey = "YhJWWrRNK7V9vuBXgIInys7y4uFbbg9v-LdGw8TY8po";

    public UnsplashService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Photo>?> SearchPhotosAsync(string query)
    {
        var url = $"{ApiBaseUrl}search/photos?page=1&query={query}&client_id={AccessKey}";
        var response = await _httpClient.GetFromJsonAsync<SearchResponse>(url);
        return response?.Results.Select(r => new Photo
        {
            Id = r.Id,
            Urls = r.Urls,
            RegularUrl = r.Urls.Regular,
            SmallUrl = r.Urls.Small,
            Description = r.Description
        }).ToList();
    }

}

public class Photo
{
    public string Id { get; set; }

    public Urls Urls { get; set; }

    public string RegularUrl { get; set; }

    public string SmallUrl { get; set; }

    public string Description { get; set; }
}

public class Urls
{
    public string Raw { get; set; }
    public string Full { get; set; }
    public string Regular { get; set; }
    public string Small { get; set; }
    public string Thumb { get; set; }
}

public class SearchResponse
{
    public List<Photo> Results { get; set; }
}
