using PublisherLib;
using System.Linq;
using System.Windows;


namespace BookSellerWpf {
	/// <summary>
	/// Interaction logic for BookListWindow.xaml
	/// </summary>
	public partial class BookListWindow : Window
	{
		public BookListWindow()
		{
			InitializeComponent();

			var dataSource = new PublisherLib.Data.BookDataSource();
			var books = dataSource.GetAllBooks().OrderBy(x => x.Title);
			this.DataContext = books;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var book = BooksListBox.SelectedItem as Book;
			book.UpdatePrice(22.50M);
		}
	}
}
