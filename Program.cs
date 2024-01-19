using BlogEntityFramework.Data;
using BlogEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new BlogDataContext();
            //var user = new User
            //{
            //    Name = "Luis Felipe Janes",
            //    Slug = "luis-felipe-janes",
            //    Email = "luisfelipe@gmail.om",
            //    Bio = "Esta é a bio do Luis Felipe",
            //    Image = "EstaéaimagemdoLuisFelipe",
            //    PasswordHash = "EstaéoHashdoLuisFelipe",
            //};
            //var category = new Category
            //{
            //    Name = "Backend",
            //    Slug = "backend"
            //};

            //var post = new Post
            //{
            //    Author = user,
            //    Category = category,
            //    Body = "<p>Hello world<p>",
            //    Slug = "luis-felipe",
            //    Summary = "Aprendendo EF core com o balta",
            //    Title = "Primeira vez com EF Core",
            //    CreateDate = DateTime.Now,
            //    LastUpdateDate = DateTime.Now,
            //};

            //context.Posts.Add(post);
            //context.SaveChanges();

            //var posts = context
            //    .Posts
            //    .AsNoTracking()
            //    .Include(x=>x.Author)
            //    .Include(x=>x.Category)
            //    .OrderBy(x=>x.LastUpdateDate)
            //    .ToList();

            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            //    Console.WriteLine($"{post.Body}");
            //    Console.WriteLine($"{post.CreateDate} - {post.Category.Name}");
            //}

            var posts = context
                .Posts
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderBy(x => x.LastUpdateDate)
                .Where(x=>x.AuthorId==9)
                .FirstOrDefault();
            posts.Author.Name = "Luis Felipe Janes";

            context.Update(posts);
            context.SaveChanges();
        }
    }
}