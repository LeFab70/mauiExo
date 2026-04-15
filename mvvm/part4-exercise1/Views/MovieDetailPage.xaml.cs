namespace MovieCatalog.Views;

public partial class MovieDetailPage : ContentPage
{
	public MovieDetailPage(ViewModels.BookViewModel book)
	{
		BindingContext = book;
		InitializeComponent();
	}
}