using Bookies_App.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for WorkshopPage.xaml
    /// </summary>
    public partial class WorkshopPage : Page
    {
        public WorkshopPage()
        {
            InitializeComponent();

            // fill out information and get it to the backend
            //// TESTING DATA, COMMENT OUT WHEN WORKSHOP IS DONE


            labelAuthor.Text = "Author: " + Properties.Settings.Default.user.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Upload_Clicked(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book();
            newBook.genre = txtBox_text.Text;
            newBook.content = txtBox_content.Text;
            newBook.status = txtBox_content.Text;
            newBook.description = txtBox_description.Text;
            newBook.name = txtBox_title.Text;

            //get this from logged user id
            newBook.author = Properties.Settings.Default.loggedIn;

            Task<HttpResponseMessage> bookInsert = WebAPI.PostCall(API_URIs.books, newBook);

            Debug.WriteLine(bookInsert.Result.Content.ReadAsStringAsync().Result);
        }
    }
}
