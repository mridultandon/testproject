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

        }

    }
}