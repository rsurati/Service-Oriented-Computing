namespace Blog_project
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogContext : DbContext
    {
        // Your context has been configured to use a 'BlogContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Blog_project.BlogContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BlogContext' 
        // connection string in the application configuration file.
        public BlogContext()
            : base("name=BlogContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Create_user_Service.Migrations.Configuration>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Blog_project.Migrations.Configuration>());
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Blog_project.User> Users { get; set; }

        public virtual DbSet<Blog_project.Blog_detail> Blog_Details { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}