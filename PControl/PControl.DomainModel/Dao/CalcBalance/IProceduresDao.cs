namespace PControl.DomainModel.Dao.CalcBalance
{
    public interface IProceduresDao
    {
        void RecalcBalancesOnDocument(long documentId);
    }
}