using System.Net.Http;
using System.Net.Http.Json;

using HttpClient client = new();

HttpResponseMessage response =
    await client.GetAsync(
        "https://jsonplaceholder.typicode.com/todos"
    );

List<Todo>? todos =
    await response.Content.ReadFromJsonAsync<List<Todo>>();

var completedTodos =
    from todo in todos
    where todo.Completed == false
    select todo;

foreach (Todo todo in completedTodos)
{
    Console.WriteLine(todo.Id);
}