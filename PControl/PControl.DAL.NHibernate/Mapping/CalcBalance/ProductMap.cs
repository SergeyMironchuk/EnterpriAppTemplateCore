using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PControl.DomainModel.CalcBalance;

namespace PControl.DAL.NHibernate.Mapping.CalcBalance
{
    public class ProductMap: ClassMapping<Product>
    {
        public ProductMap()
        {
            Table("Products");
            Id(product => product.Id, mapper =>
            {
                mapper.Generator(Generators.Identity);
                mapper.Column("Id");
            });
            Property(product => product.Name, mapper => mapper.Column(c =>
            {
                c.Name("Name");
                c.Length(256);
            }));
        }
    }
}