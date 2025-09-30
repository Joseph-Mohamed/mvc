using Demo.DataAccessesLayer.Models.DepartementModule;

namespace Demo.DataAccessesLayer.Data.Configrations
{
    internal class DepartementsConfigrations : BaseEntityConfigrations<Departement>, IEntityTypeConfiguration<Departement>
    {
        public new void Configure(EntityTypeBuilder<Departement> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("varchar(20)");
            builder.Property(d => d.Code).HasColumnType("varchar(20)");
            base.Configure(builder);
        }
    }
}
