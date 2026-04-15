using CommunityToolkit.Mvvm.ComponentModel;

namespace BookCatalog.ViewModels;

public class BookViewModel: ObservableObject
{
    private string _title;
    private string _author;
    private string _publisher;
    private DateOnly _year;

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public string Author
    {
        get => _author;
        set => SetProperty(ref _author, value);
    }

    public string Publisher
    {
        get => _publisher;
        set => SetProperty(ref _publisher, value);
    }

    public DateOnly Year
    {
        get => _year;
        set => SetProperty(ref _year, value);
    }

    public BookViewModel(Models.Book book)
    {
        _title = book.Title;
        _author = book.Author;
        _publisher = book.Publisher;
        _year = new DateOnly(book.Year, 1, 1);
    }
}
