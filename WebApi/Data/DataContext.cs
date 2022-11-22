namespace WebApi.Data
{
    using Microsoft.EntityFrameworkCore;
    using WebApi.Models;

    public class DataContext:DbContext
    {   
        //private readonly IConfiguration _configuration;
        //public DataContext()
        //{

        //}
        //public DataContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =LAPTOP-S330TI63\SQLEXPRESS; Initial Catalog = DatingAppDB; Integrated Security = true;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString(""))
        }
    }
}
