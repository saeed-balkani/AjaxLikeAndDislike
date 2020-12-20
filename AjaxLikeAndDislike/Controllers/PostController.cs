using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxLikeAndDislike.Models;

namespace AjaxLikeAndDislike.Controllers
{
    public class PostController : Controller
    {
        List<Posts> db = new List<Posts>()
        {
            new Posts
            {
                PostsId =1,
                UserName = "saeed.balkani@",
                PostText = "شما فقط موفقیت را می بینید اما پشت سر هر موفقیتی گورستانی از شکست ها پنهان شده است.در هنگام شکست تسلیم نشوید.",
                LikeCount = 0,
                DislikeCount = 0
            }
        };
        public ActionResult Index()
        {
            return View(db);
        }

        public int LikeCount(int id)
        {
            List<Posts> post = new List<Posts>();
            if (Session["Like"] != null)
            {
                post = Session["Like"] as List<Posts>;
            }
            if (post.Any(a => a.PostsId == id))
            {
                int index = post.FindIndex(a => a.PostsId == id);
                post[index].LikeCount++;
            }
            else
            {
                post.Add(new Posts()
                {
                    PostsId = id,
                    LikeCount = 1
                });
            }
            Session["Like"] = post;
            return post.Sum(a => a.LikeCount);
        }
        public int DisikeCount(int id)
        {
            List<Posts> post = new List<Posts>();
            if (Session["Disike"] != null)
            {
                post = Session["Disike"] as List<Posts>;
            }
            if (post.Any(a => a.PostsId == id))
            {
                int index = post.FindIndex(a => a.PostsId == id);
                post[index].DislikeCount++;
            }
            else
            {
                post.Add(new Posts()
                {
                    PostsId = id,
                    DislikeCount = 1
                });
            }
            Session["Disike"] = post;
            return post.Sum(a => a.DislikeCount);
        }
    }
}