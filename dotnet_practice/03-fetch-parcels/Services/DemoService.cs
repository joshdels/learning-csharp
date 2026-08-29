using System.Net.Http.Json;

public class DemoApiService
{
  private readonly HttpClient _httpClient;
  public DemoApiService(HttpClient httpClient)
  {
    _httpClient = httpClient;
  }
}