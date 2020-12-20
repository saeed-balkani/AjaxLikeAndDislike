using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLikeAndDislike.Models
{
    public class Posts
    {
        public int PostsId { get; set; }
        public string UserName { get; set; }
        public string PostText { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }

    }
}