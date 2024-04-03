using Microsoft.EntityFrameworkCore;
using UserRegistration.Data.Map;
using UserRegistration.Models;

namespace UserRegistration.Data
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options) : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<AdressModel> Adress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuramos as MAPs
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new AdressMap());
        }



    }
}

