using BlogEntityFramework.Data;
using BlogEntityFramework.Models;

namespace BlogEntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                var tag = new Tag { Id = 0, Name = "teste", Slug = "test" };
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }
    }
}