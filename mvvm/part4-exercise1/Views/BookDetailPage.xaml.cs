namespace BookCatalog.Views;

public partial class BookDetailPage : ContentPage
{
	public BookDetailPage(ViewModels.BookViewModel book)
	{
		BindingContext = book;
		InitializeComponent();
	}
}