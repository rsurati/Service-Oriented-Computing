using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog_project
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Create_user_Service" in both code and config file together.
    public class Create_user_Service : ICreate_user_Service
    {
        BlogContext db = new BlogContext();

       
        public int addBlog(Blog_detail b)
        {
            int x = 0;

            if (b != null)
            {
                Blog_detail bg = db.Blog_Details.Add(b);
                db.SaveChanges();
                x = 1;

            }
            else {
                x = 0;
            }
            return x;
        }

        public User addUser(User u)
        {
            if(u!=null)
            { 
                User ua = db.Users.Add(u);
                db.SaveChanges();
                return ua;
            }
            else
            {
                return null;
            }
        }

        public User checkUser(User u)
        {
           
           
                User ua = db.Users
                                .Where(s => s.email == u.email && s.password==u.password)
                                .FirstOrDefault<User>();
            if (u != null)
            {
                return ua;
            }
            else
            {
                return null;
            }


        }

        public int deleteBlog(User u, int blog_id)
        {
            Blog_detail bd  = db.Blog_Details.Where(s => s.UserId == u.UserId && s.Blog_detailId==blog_id)
                                .FirstOrDefault<Blog_detail>();
            db.Blog_Details.Remove(bd);

            return db.SaveChanges();
            
        }

        public List<Blog_detail> displayBlog()
        {
            List<Blog_detail> ll = null;

            ll = db.Blog_Details.OrderBy(s => s.Blog_detailId).ToList();

            if (ll != null)
            {
                return ll;
            }
            else {
                return null;
            }
        }

        public List<Blog_detail> displayBlogbyUser(User u)
        {

            List<Blog_detail> ll = null;

            ll = db.Blog_Details.Where(s => s.UserId==u.UserId).ToList();

            if (ll != null)
            {
                return ll;
            }
            else
            {
                return null;
            }

        }

        public Blog_detail updateBlog(User u, string topic)
        {
            Blog_detail bd = null;

            bd = db.Blog_Details.Where(s => s.UserId == u.UserId && s.topic == topic)
                                .FirstOrDefault<Blog_detail>();
            if (bd != null)
            {
                return bd;
            }
            else
            {
                return null;
            }

        }

        public int updateBlogbyclick(Blog_detail b)
        {
            Blog_detail bd = db.Blog_Details.Where(s => s.Blog_detailId == b.Blog_detailId).
                FirstOrDefault<Blog_detail>();
            bd.description = b.description;
            return db.SaveChanges();
        }
    }
}
