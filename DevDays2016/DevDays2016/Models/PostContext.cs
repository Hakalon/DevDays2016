using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DevDays2016.Models
{
    public class PostContext : DbContext
    {
        public PostContext() : base("PostContext")
        {
            Database.SetInitializer(new CustomInitializer());
            Database.Initialize(true);
        }

        DbSet<User> Users { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
