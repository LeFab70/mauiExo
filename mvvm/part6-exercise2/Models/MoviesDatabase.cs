namespace BookCatalog.Models;

internal static class BooksDatabase
{
    public async static Task<IEnumerable<Book>> GetBooks()
    {
        using Stream stream = await FileSystem.OpenAppPackageFileAsync("data.json");

        System.Text.Json.JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
        };

        IEnumerable<Book>? books = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Book>>(stream, options);

        return books ?? [];
    }
}
