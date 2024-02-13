using Microsoft.EntityFrameworkCore;
using static Emmcnorb.Models.ChronicleElysianBonds;

namespace Emmcnorb.Models
{
    //Models are typically responsible for retrieving and storing data
    //from and to a data store, such as a database
    public class ChronicleElysianBonds
    {
        // Models/BlogPost.cs
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public List<Comment> Comments { get; set; }
        

        // Models/Comment.cs
        public class Comment
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Content { get; set; }
            public int ChronicleElysianBondsId { get; set; }
            public ChronicleElysianBonds ChronicleElysianBonds { get; set; }
        }


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ChronicleElysianBonds> ChronicleElysianBonds { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

}
}
