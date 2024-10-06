using Microsoft.EntityFrameworkCore;
using SempaSocial.DAL.DB;
using SempaSocial.DAL.Entities;
using SempaSocial.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SempaSocial.DAL.Repo.Impelementation
{
    public class PostRepo : IPostRepo
    {
        private readonly SempaSocialDbContext db;

        public PostRepo(SempaSocialDbContext Db)
        {
            db=Db;
        }
        public List<Post> GetAllPosts(Expression<Func<Post,bool>>? filter)
        {
            var Result = db.Posts.Where(filter).Include(a=>a.User).ToList();
            return Result;
        }
      
        public bool Create(Post post)
        {
            try
            {
                var Result = db.Posts.Add(post);
                db.SaveChanges();
                if(Result != null)
                    return true;
                return false;
            
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
