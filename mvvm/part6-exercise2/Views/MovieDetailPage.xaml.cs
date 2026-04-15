namespace BookCatalog.Views;

public partial class MovieDetailPage : ContentPage
{
    public MovieDetailPage()
    {
        BindingContext = App.MainViewModel?.SelectedBook;
        InitializeComponent();
    }
}