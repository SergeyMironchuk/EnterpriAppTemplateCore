using PControl.DomainModel.CalcBalance;

namespace PControl.DomainModel.Dao.CalcBalance
{
    public interface IProductDao : IDao<Product, int>, ISupportsDeleteDao<Product>, ISupportsSave<Product, int>
    {
    }
}