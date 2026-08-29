using System.Net.Http;

HttpClient client = new();

HttpResponseMessage response =
    await client.GetAsync(
        "https://my-json-server.typicode.com/typicode/demo/posts"
    );

string data =
    await response.Content.ReadAsStringAsync();

Console.WriteLine(data);