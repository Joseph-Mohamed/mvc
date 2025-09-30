using Demo.DataAccessesLayer.Models.EmpolyeeModule;
using Demo.DataAccessesLayer.Models.Shared;

namespace Demo.DataAccessesLayer.Data.Configrations
{
    internal class EmpolyeeConfegrations : BaseEntityConfigrations<Empolyee>, IEntityTypeConfiguration<Empolyee>
    {
        public new void Configure(EntityTypeBuilder<Empolyee> builder)
        {
            builder.Property(a => a.Address).HasColumnType("varchar(50)");
            builder.Property(n => n.Name).HasColumnType("varchar(50)");
            builder.Property(s => s.Salary).HasColumnType("decimal(10,2)");
            builder.Property(g => g.gender).HasConversion((EmpGender) => EmpGender.ToString() , 
                (gender) =>(Gender) Enum.Parse(typeof(Gender),gender));

            builder.Property(e => e.EmpolyeeType).HasConversion((empType) => empType.ToString(),
               (empolyeeType) => (EmpolyeeType)Enum.Parse(typeof(EmpolyeeType), empolyeeType));

            base.Configure(builder);
        }
    }
}
