namespace BookCatalog.Views;

public partial class BooksListPage : ContentPage
{
	public BooksListPage()
	{
		InitializeComponent();
	}

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		ViewModels.BookViewModel book = (ViewModels.BookViewModel)e.Item;
		await Navigation.PushAsync(new Views.BookDetailPage(book));
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        MenuItem menuItem = (MenuItem)sender;
        ViewModels.BookViewModel book = (ViewModels.BookViewModel)menuItem.BindingContext;
        App.MainViewModel?.DeleteBook(book);
    }
}