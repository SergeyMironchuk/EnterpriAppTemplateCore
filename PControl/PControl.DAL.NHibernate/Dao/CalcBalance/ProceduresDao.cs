﻿using BIZ.PControl.DAL.NHibernate.Dao;
using PControl.DomainModel.Dao.CalcBalance;
using Spring.Transaction.Interceptor;

namespace PControl.DAL.NHibernate.Dao.CalcBalance
{
    public class ProceduresDao: HibernateDao, IProceduresDao
    {
        [Transaction]
        public void RecalcBalancesOnDocument(long documentId)
        {
            CurrentSession.CreateSQLQuery("exec UpdateBalances ?")
                .SetParameter(0, documentId)
                .ExecuteUpdate();
        }
    }
}