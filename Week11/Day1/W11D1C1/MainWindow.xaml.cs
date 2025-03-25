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
using W11D1C1.Data;

namespace W11D1C1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ProductContext dbContext;
        Product newProduct = new Product();
        Product selectedProduct = new Product();

        public MainWindow(ProductContext _dbContext) // dependency injection in constructor
        {
            this.dbContext = _dbContext;
            InitializeComponent();
            GetProducts();
            AddProductGrid.DataContext = newProduct;
        }
        
        private void GetProducts() {
            ProductDg.ItemsSource = this.dbContext.Products.ToList();
        }

        private void UpdateProductForEdit(object sender, RoutedEventArgs e) {
            selectedProduct = (sender as FrameworkElement).DataContext as Product;
            UpdateProductGrid.DataContext = selectedProduct;
        }
        private void UpdateProduct(object sender, RoutedEventArgs e) {
            this.dbContext.Update(selectedProduct);
            this.dbContext.SaveChanges();
            GetProducts();
        }

        private void AddProduct(object sender, RoutedEventArgs e) {
            this.dbContext.Products.Add(newProduct);
            this.dbContext.SaveChanges();
            GetProducts();
            newProduct = new Product();
            AddProductGrid.DataContext = newProduct;
        }

        private void DeleteProduct(object sender, RoutedEventArgs e) {
            var product = (sender as FrameworkElement).DataContext as Product;
            this.dbContext.Products.Remove(product);
            this.dbContext.SaveChanges();
            GetProducts();
        }
    }
}