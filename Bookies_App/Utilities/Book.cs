using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookies_App.Utilities
{
    public class Book
    {
        public string id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string image { get; set; }
        public string content { get; set; }
        public List<string> comments { get; set; }
    }

    public class BookList
    {
        public List<Book> books { get; set; }
        public int count { get; set; }
    }
}
