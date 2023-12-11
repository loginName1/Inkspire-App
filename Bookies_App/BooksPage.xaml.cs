using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {
            InitializeComponent();
            List<Book> test = new List<Book>();
            test.Add(new Book() { Title="Adamova knjiga", Author="Author: Adam"});
            test.Add(new Book() { Title="Book of Lorem", Author = "Author: Adam" });
            test.Add(new Book() { Title="knjiga", Author = "Author: Tim" });
            test.Add(new Book() { Title="In a galaxy far away", Author = "Adam"});
            test.Add(new Book() { Title="Book of Lorem", Author = "Author: Adam" });
            test.Add(new Book() { Title="knjiga", Author = "Author: Tim" });
            test.Add(new Book() { Title="In a galaxy far away", Author = "Author: Marija" });

            BookList.ItemsSource = test;
        }


    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
