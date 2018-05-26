using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PControl.DomainModel.CalcBalance;

namespace PControl.DAL.EF.Mapping.CalcBalance
{
    public class BalanceConfiguration: IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.HasKey(b => new {b.Date, b.Product});
        }
    }
}