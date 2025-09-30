
using Demo.DataAccessesLayer.Models.DepartementModule;
using Demo.DataAccessesLayer.Models.Shared;

namespace Demo.DataAccessesLayer.Data.Configrations
{
    internal class BaseEntityConfigrations<T> : IEntityTypeConfiguration<T> where T:BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(d => d.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(d => d.ModifiedOn).HasComputedColumnSql("GETDATE()");
        }
    }
}
