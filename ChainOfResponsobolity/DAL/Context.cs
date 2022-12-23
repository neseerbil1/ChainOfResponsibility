using ChainOfResponsobolity.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsobolity.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-T0I7RRL;initial catalog=ChainOfRespDb;integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
