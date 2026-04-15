namespace BookCatalog.Views;

public partial class BookDetailPage : ContentPage
{
    public BookDetailPage()
    {
        BindingContext = App.MainViewModel?.SelectedBook;
        InitializeComponent();
    }
}