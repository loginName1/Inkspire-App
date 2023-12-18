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
            Book newBook = new Book();
            newBook.genre = "testing genre";
            newBook.content = "content for a book meant for post testing";
            newBook.status = "complete";
            newBook.description = "testing purposes";
            newBook.name = "Test";
            newBook.author = "657c86e89cd64c8f07daf73f";

            Task<HttpResponseMessage> bookInsert = WebAPI.PostCall(API_URIs.books, newBook);

            Debug.WriteLine(bookInsert.Result.Content.ReadAsStringAsync().Result);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
