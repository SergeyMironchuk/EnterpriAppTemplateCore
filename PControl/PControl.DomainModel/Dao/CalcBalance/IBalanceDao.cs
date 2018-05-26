using System;
using System.Collections.Generic;
using PControl.DomainModel.CalcBalance;

namespace PControl.DomainModel.Dao.CalcBalance
{
    public interface IBalanceDao : IDao<Balance, object>, ISupportsDeleteDao<Balance>, ISupportsSave<Balance, Balance>
    {
        IEnumerable<Balance> GetBalancesOnDate(DateTime onDate, int[] productIds);
        void UpdateBalancesFromDate(DateTime fromDate, int productId, double addedQuantity);
    }
}