using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MovieCatalog.ViewModels;

public class BookListViewModel: ObservableObject
{
    public ObservableCollection<BookViewModel> Books { get; set; }

    public BookListViewModel() =>
        Books = [];

    public async Task RefreshBooks()
    {
        IEnumerable<Models.Book> booksData = await Models.BooksDatabase.GetBooks();

        foreach (Models.Book book in booksData)
            Books.Add(new BookViewModel(book));
    }

    public void DeleteBook(BookViewModel book) =>
        Books.Remove(book);
}
