using Microsoft.EntityFrameworkCore;

namespace WebAppRazorPagesTechCrew.Models
{
    public class AppDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=HDC3-L-94S8B54;database=db_razorapptechcrew;Integrated security=true;TrustServerCertificate=true");
            // connection string my db name my table 

            //server --> db --> table


        }

        public DbSet<RegisterModelProp> Mytable { get; set; }  // table to ef core
    }
}
