using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PControl.DomainModel.CalcBalance;

namespace PControl.DAL.EF.Mapping.CalcBalance
{
    public class DocumentConfiguration: IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}