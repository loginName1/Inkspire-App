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

namespace Bookies_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomePage homePage = null;
        BooksPage booksPage = null;
        AboutPage aboutPage = null;
        LoginPage loginPage = null;
        RegisterPage registerPage = null;
        WorkshopPage workshopPage = null;
        BookInfoPage bookInfoPage = null;


        public MainWindow()
        {
            InitializeComponent();
            if (homePage == null)
            {
                homePage = new HomePage();
            }

            Main.Content = homePage;
        }

        private void HomeRedirectClick(object sender, RoutedEventArgs e)
        {
            if (homePage == null) {
                homePage = new HomePage();
            }

            Main.Content = homePage;
        }
        private void AboutRedirectClick(object sender, RoutedEventArgs e)
        {
            if (aboutPage == null)
            {
                aboutPage = new AboutPage();
            }

            Main.Content = aboutPage;
        }

        private void WorkshopRedirectClick(object sender, RoutedEventArgs e)
        {
            if (workshopPage == null)
            {
                workshopPage = new WorkshopPage();
            }

            Main.Content = workshopPage;
        }
        private void BooksRedirectClick(object sender, RoutedEventArgs e)
        {
            if (booksPage == null)
            {
                booksPage = new BooksPage();
            }

            Main.Content = booksPage;
        }

        public void BooksInfoRedirectClick(object sender, RoutedEventArgs e)
        {
            if (booksPage == null)
            {
                booksPage = new BooksPage();
            }

            Main.Content = booksPage;
        }
        private void LoginRedirectClick(object sender, RoutedEventArgs e)
        {
            if (loginPage == null)
            {
                loginPage = new LoginPage();
            }

            Main.Content = loginPage;
        }
        private void RegisterRedirectClick(object sender, RoutedEventArgs e)
        {
            if (registerPage == null)
            {
                registerPage = new RegisterPage();
            }

            Main.Content = registerPage;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}