using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using W11D1Assignment11._1.Data;

namespace W11D1Assignment11._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private readonly BookContext _context;
        private Book newBook = new Book();

        public MainWindow(BookContext context) {
            InitializeComponent();
            _context = context;
            DataContext = newBook;
            LoadBooks();
        }

        private void LoadBooks() {
            BooksDataGrid.ItemsSource = _context.Books.ToList();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e) {
            _context.Books.Add(newBook);
            _context.SaveChanges();
            newBook = new Book();
            DataContext = newBook;
            LoadBooks();
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e) {
            var book = (sender as FrameworkElement).DataContext as Book;
            _context.Books.Remove(book);
            _context.SaveChanges();
            LoadBooks();
        }
    }
}