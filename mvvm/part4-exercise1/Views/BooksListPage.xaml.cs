namespace BookCatalog.Views;

public partial class BooksListPage : ContentPage
{
	public BooksListPage()
	{
		InitializeComponent();
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
            return;

        await Navigation.PushAsync(new Views.BookDetailPage());

        // Deselect
        ((CollectionView)sender).SelectedItem = null;
    }
}