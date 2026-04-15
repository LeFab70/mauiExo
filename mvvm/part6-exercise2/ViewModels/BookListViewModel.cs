using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookCatalog.ViewModels;

public class BookListViewModel: ObservableObject
{
    private BookViewModel? _selectedBook;

    public BookViewModel? SelectedBook
    {
        get => _selectedBook;
        set => SetProperty(ref _selectedBook, value);
    }

    public ObservableCollection<BookViewModel> Books { get; set; }

    public ICommand DeleteBookCommand { get; private set; }

    public BookListViewModel()
    {
        Books = [];
        DeleteBookCommand = new Command<BookViewModel>(DeleteBook);
    }

    public async Task RefreshBooks()
    {
        IEnumerable<Models.Book> booksData = await Models.BooksDatabase.GetBooks();

        foreach (Models.Book book in booksData)
            Books.Add(new BookViewModel(book));
    }

    public void DeleteBook(BookViewModel book) =>
        Books.Remove(book);
}
