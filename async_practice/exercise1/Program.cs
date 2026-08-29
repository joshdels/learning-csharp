using System.Net.Http;
using System.Net.Http.Json;

using HttpClient client = new();

HttpResponseMessage response =
    await client.GetAsync(
        "https://jsonplaceholder.typicode.com/todos/1"
    );

Todo? todo =
    await response.Content.ReadFromJsonAsync<Todo>();

Console.WriteLine($"ID: {todo?.Id}");
Console.WriteLine($"User ID: {todo?.UserId}");
Console.WriteLine($"Title: {todo?.Title}");
Console.WriteLine($"Completed: {todo?.Completed}");