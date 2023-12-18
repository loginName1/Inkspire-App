using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookies_App.Utilities
{
    public class Comment
    {
        public string userId { get; set; }
        public string content { get; set; }
        public string bookId { get; set; }
        public string time { get; set; }
    }

    public class CommentList
    {
        public List<Comment> comments { get; set; }
        public int count { get; set; }
    }
}
