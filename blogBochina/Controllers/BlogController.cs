using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogBochina.Domain.DB;
using blogBochina.Model.Common;
using blogBochina.ViewModels.Account;
using BlogForStudents.Security.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace blogBochina.Controllers
{
    /// <summary>
    /// Класс для работы со страницами блога
    /// </summary>
    public class BlogController : Controller
    {

        private readonly BlogDbContext _blogDbContext;

        public BlogController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext ?? throw new ArgumentNullException(nameof(blogDbContext));
        }

        /// <summary>
        /// Метод возращающий страницу блога
        /// </summary>
        public IActionResult Index()
        {
            IQueryable<BlogPostItemViewModel> posts = _blogDbContext.BlogPosts.Select(x => new BlogPostItemViewModel
            {
                Author = x.Owner.FullName,
                Created = x.Created.ToString(),
                Data = x.Data,
                Title = x.Title
            }).OrderByDescending(x => x.Created);
            List<string> postings = new List<string>();
            foreach (BlogPostItemViewModel post in posts) {
                postings.Add(post.Author);
                postings.Add(post.Created);
                postings.Add(post.Title);
                postings.Add(post.Data);
            }                    
            return View(postings);
        }

        /// <summary>
        /// Метод открывает страницу с добавлением поста
        /// </summary>
        /// <returns>Возврпщает страницу для добавления поста</returns>
       // [Authorize]
       // [HttpPost]
       // [ValidateAntiForgeryToken]
        public IActionResult AddPost(NewPostViewModel model)
        //public IActionResult AddPost()
        {
            
            
            if (!ModelState.IsValid) return View(model);
            //if (!ModelState.IsValid) return View();

            var user = this.GetAuthorizedUser();
            
            var post = new BlogPost
            {
                Created = DateTime.Now,
                Data = model.Data,
                Title = model.Title,
               //Data = "qwreqwe" ,
                //Title = "gdfhfdgjhfdg",
                Owner = user.Employee
            };

            _blogDbContext.BlogPosts.Add(post);

            _blogDbContext.SaveChanges();
            
            return View();
        }
    }
}
