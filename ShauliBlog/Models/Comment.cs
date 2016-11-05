using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShauliBlog.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public DateTime commentdate { get; set; }
        public string commentheadline { get; set; }
        public string commentauthor { get; set; }
        public string commentauthorurl { get; set; }
        public string commentcontent { get; set; }
        public Post post { get; set; }

    }
}