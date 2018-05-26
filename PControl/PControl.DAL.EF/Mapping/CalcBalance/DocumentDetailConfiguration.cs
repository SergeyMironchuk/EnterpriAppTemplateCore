using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PControl.DomainModel.CalcBalance;

namespace PControl.DAL.EF.Mapping.CalcBalance
{
    public class DocumentDetailConfiguration: IEntityTypeConfiguration<DocumentDetail>
    {
        public void Configure(EntityTypeBuilder<DocumentDetail> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}