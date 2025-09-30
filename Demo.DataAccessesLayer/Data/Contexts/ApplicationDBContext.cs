using Demo.DataAccessesLayer.Models.DepartementModule;
using Demo.DataAccessesLayer.Models.EmpolyeeModule;

namespace Demo.DataAccessesLayer.Data.Contexts
{
    //depancy injection
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Connection string");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Departement>(new DepartementsConfigrations);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);


        }


        public DbSet<Departement> departements { get; set; }
        public DbSet<Empolyee> empolyees { get; set; }
    }
}
