using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserRegistration.Models;

namespace UserRegistration.Data.Map
{
    public class AdressMap : IEntityTypeConfiguration<AdressModel>
    {
        public void Configure(EntityTypeBuilder<AdressModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.City).IsRequired();
        }
    }
}
