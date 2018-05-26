using PControl.DomainModel.CalcBalance;

namespace PControl.DomainModel.Dao.CalcBalance
{
    public interface IDocumentDao : IDao<Document, long>, ISupportsDeleteDao<Document>, ISupportsSave<Document, long>
    {
    }
}