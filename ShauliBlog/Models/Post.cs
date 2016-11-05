using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShauliBlog.Models
{
    public class Post
    {
        public int PostID { get; set; }


        [Display(Name = "TitleTest")]
        public string headline { get; set; }
        [Display(Name = "Author")]
        public string author { get; set; }
        [Display(Name = "Website")]
        public string authorurl { get; set; }

        public DateTime postdate { get; set; }
        [Display(Name = "Post")]
        public string postcontent { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        [Display(Name = "Video")]
        public string video { get; set; }
        public virtual ICollection<Comment> postComments { get; set; }
    }

}