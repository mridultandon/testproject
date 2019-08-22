using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject
{
    public class TestContext : DbContext
    {


        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }
        DbSet<LoginModel> LoginModels { get; set; }
        DbSet<RequestModel> RequestModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginModel>().HasData(new {UserId = 1, UserName = "Mridul", Password = "123456", UserType = 1 },
                new { UserId = 2, UserName = "Test", Password = "123456", UserType = 1 },
                new { UserId = 3, UserName = "Admin", Password = "admin@12345", UserType = 2 });

        }

    }
}