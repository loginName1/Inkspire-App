using System.ComponentModel;
using System.Configuration;
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
        AccountPage accountPage = null;


        private void SettingsChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
            if (Properties.Settings.Default.loggedIn != "")
            {
                header_logged_in.Visibility = Visibility.Visible;
                header_logged_out.Visibility = Visibility.Hidden;

            }
            else
            {
                header_logged_in.Visibility = Visibility.Hidden;
                header_logged_out.Visibility = Visibility.Visible;
            }

            if (homePage == null)
            {
                homePage = new HomePage();
            }

            Main.Content = homePage;
        }

        public MainWindow()
        {
            InitializeComponent();

            Properties.Settings.Default.SettingChanging += SettingsChangingEventHandler;


            if (homePage == null)
            {
                homePage = new HomePage();
            }

            Main.Content = homePage;

            if (Properties.Settings.Default.loggedIn != "")
            {
                header_logged_in.Visibility = Visibility.Visible;
                header_logged_out.Visibility = Visibility.Hidden;
                
            }
            else
            {
                header_logged_in.Visibility = Visibility.Hidden;
                header_logged_out.Visibility = Visibility.Visible;
            }
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

        private void AccountRedirectClick(object sender, RoutedEventArgs e)
        {
            if (accountPage == null)
            {
                accountPage = new AccountPage();
            }

            Main.Content = accountPage;
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            if (homePage == null)
            {
                homePage = new HomePage();
            }

            Main.Content = homePage;

            Properties.Settings.Default.Reset();

            if (Properties.Settings.Default.loggedIn != "")
            {
                header_logged_in.Visibility = Visibility.Visible;
                header_logged_out.Visibility = Visibility.Hidden;
            }
            else
            {
                header_logged_in.Visibility = Visibility.Hidden;
                header_logged_out.Visibility = Visibility.Visible;
            }
        }
    }
}