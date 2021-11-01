using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DatabaseLogicLayer : BaseClass
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DatabaseLogicLayer()
        {
            con = new SqlConnection("data source= ; initial catalog=ForeignCurrency; user Id=sa; password=1234");
        }
        public void connectionSet()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

       public SqlDataReader currencyList()
        {            
            myTryCatch(() =>
            {
                cmd = new SqlCommand("select * from Currency", con);
                connectionSet();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader exchangeRateList()
        {
            myTryCatch(() =>
            {
                cmd = new SqlCommand("select * from ExchangeRate", con);
                connectionSet();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader exchangeRateList(Guid CurrencyID)
        {
            myTryCatch(() =>
            {
                cmd = new SqlCommand("select * from ExchangeRate where CurrencyID = @CurrencyID", con);
                cmd.Parameters.Add("@CurrencyID", System.Data.SqlDbType.UniqueIdentifier).Value = CurrencyID;
                connectionSet();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader exchangeRatePastList()
        {
            myTryCatch(() =>
            {
                cmd = new SqlCommand("select * from ExchangeRatePast", con);
                connectionSet();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader exchangeRatePastList(Guid CurrencyID)
        {
            myTryCatch(() =>
            {
                cmd = new SqlCommand("select * from ExchangeRatePast where CurrencyID = @CurrencyID", con);
                cmd.Parameters.Add("@CurrencyID", System.Data.SqlDbType.UniqueIdentifier).Value = CurrencyID;
                connectionSet();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
        
        public void exchangeRateAddRecord(ExchangeRate rate)
        {
            myTryCatch(() =>
            {
                cmd = new SqlCommand("ExchangeRateAddRecord", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = rate.ID;
                cmd.Parameters.Add("@CurrencyID", System.Data.SqlDbType.UniqueIdentifier).Value = rate.CurrencyID;
                cmd.Parameters.Add("@Buyying", System.Data.SqlDbType.Decimal).Value = rate.Buyying;
                cmd.Parameters.Add("@Selling", System.Data.SqlDbType.Decimal).Value = rate.Selling;
                cmd.Parameters.Add("@CreationDate", System.Data.SqlDbType.DateTime).Value = rate.CreationDate;
                connectionSet();
                cmd.ExecuteNonQuery(); //for executing queries that does not return any data
            });
            connectionSet();
        }


    }
}
