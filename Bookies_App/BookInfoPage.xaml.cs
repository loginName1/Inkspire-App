using Bookies_App.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
    /// Interaction logic for BookInfoPage.xaml
    /// </summary>
    public partial class BookInfoPage : Page
    {
        public BookInfoPage()
        {
            InitializeComponent();

            //get certain book id through click

            // GET CALL FOR BOOK
            string bookId = "65547acb333a7fcb8200c8de";
            string bookUrl = "/" + bookId;
            var bookDetails = WebAPI.GetCall(API_URIs.books + bookUrl);

            Debug.WriteLine(bookDetails.Result.Content.ReadAsStringAsync().Result);

            // GET CALL FOR COMMENTS 
            // USING THE SAME ID AS THE BOOK CALL
            Task<HttpResponseMessage> comments = WebAPI.GetCall(API_URIs.comments + bookUrl);
            string jsonedComments = comments.Result.Content.ReadAsStringAsync().Result;
            CommentList listComments = JsonSerializer.Deserialize<CommentList>(jsonedComments);
            Debug.WriteLine(jsonedComments);
            //// WHEN DISPLAYING COMMENTS IS DONE UNCOMMENT
            //CommentList.ItemsSource = listComments.comments;
        }
    }
}
