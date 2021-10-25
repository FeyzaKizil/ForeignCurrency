using Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static Entities.JsonDataType;

namespace Core
{
    public class BusinessLogicLayer
    {
        DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new DatabaseLogicLayer();
        }


        public List<Currency> currencyListTypeList()
        {
            List<Currency> theCurrencyList = new List<Currency>();
            SqlDataReader reader = DLL.currencyList();
            while (reader.Read())
            {
                theCurrencyList.Add(new Currency()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    LimitAlert = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2)
                });
            }
            reader.Close();
            DLL.connectionSet();
            return theCurrencyList;
        }

        public void updateExchangeRateInfo()
        {
            //api
            var client = new RestClient("https://api.collectapi.com/economy/allCurrency");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 46MImu5LqyKeBGbyIZKJWp:0fHSwUFQJsZFztvQ0tDSQK");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            JsonDataType exchangeRateInfo = JsonConvert.DeserializeObject<JsonDataType>(response.Content);

            List<Currency> theCurrencyList = currencyListTypeList();
            for (int i = 0; i< theCurrencyList.Count; i++)
            {
                Result foundExchangeRate = exchangeRateInfo.result.FirstOrDefault(I => I.name == theCurrencyList[i].Name);
                exchangeRateAddRecordforBLL(Guid.NewGuid(), theCurrencyList[i].ID, decimal.Parse(foundExchangeRate.buying), 
                    decimal.Parse(foundExchangeRate.selling), DateTime.Now);

            }


        }

        public void exchangeRateAddRecordforBLL(Guid ID, Guid CurrencyID, decimal Buyying, decimal Selling, DateTime CreationDate)
        {
            if (ID != Guid.Empty && CurrencyID != Guid.Empty && Buyying != 0 && Selling != 0 && CreationDate > DateTime.MinValue)
            {
                DLL.exchangeRateAddRecord(new ExchangeRate()
                {
                    ID = ID,
                    CurrencyID = CurrencyID,
                    Buyying = Buyying,
                    Selling = Selling,
                    CreationDate = CreationDate
                });
            }
           
        }

        public List<ExchangeRatePast> exchangeRatePastListTypeList()
        {
            List<ExchangeRatePast> theExchangeRatePastListTypeList = new List<ExchangeRatePast>();
            SqlDataReader reader = DLL.exchangeRatePastList();
            while (reader.Read())
            {
                theExchangeRatePastListTypeList.Add(new ExchangeRatePast()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ExchangeRateID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    CurrencyID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    Buyying = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Selling = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    CreationDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5)
                });
            }
            reader.Close();
            DLL.connectionSet();
            return theExchangeRatePastListTypeList;
        }

        public List<ExchangeRatePast> exchangeRatePastListTypeList(Guid CurrencyID)
        {
            List<ExchangeRatePast> theExchangeRatePastListTypeList = new List<ExchangeRatePast>();
            SqlDataReader reader = DLL.exchangeRatePastList(CurrencyID);
            while (reader.Read())
            {
                theExchangeRatePastListTypeList.Add(new ExchangeRatePast()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ExchangeRateID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    CurrencyID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    Buyying = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Selling = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    CreationDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5)
                });
            }
            reader.Close();
            DLL.connectionSet();
            return theExchangeRatePastListTypeList;
        }

        public List<ExchangeRate> exchangeRateListTypeList()
        {
            List<ExchangeRate> theExchangeRateListTypeList = new List<ExchangeRate>();
            SqlDataReader reader = DLL.exchangeRateList();
            while (reader.Read())
            {
                theExchangeRateListTypeList.Add(new ExchangeRate()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    CurrencyID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Buyying = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Selling = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    CreationDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                });
            }
            reader.Close();
            DLL.connectionSet();
            return theExchangeRateListTypeList;

        }

        public List<ExchangeRate> exchangeRateListTypeList(Guid currencyID)
        {
            List<ExchangeRate> theExchangeRateListTypeList = new List<ExchangeRate>();
            SqlDataReader reader = DLL.exchangeRateList(currencyID);
            while (reader.Read())
            {
                theExchangeRateListTypeList.Add(new ExchangeRate()
                {
                    ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    CurrencyID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    Buyying = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Selling = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    CreationDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                });
            }
            reader.Close();
            DLL.connectionSet();
            return theExchangeRateListTypeList;

        }
        public DataTable showExchangeRatePast()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ExchangeRate", typeof(string));
            dt.Columns.Add("Buyying", typeof(string));
            dt.Columns.Add("Selling", typeof(string));
            dt.Columns.Add("Time", typeof(string));

            List<ExchangeRatePast> exchangeRatePastsList = exchangeRatePastListTypeList();
            List<Currency> currencyList = currencyListTypeList();

            for (int i = 0; i<exchangeRatePastsList.Count; i++)
            {
                dt.Rows.Add(
                    currencyList.FirstOrDefault(I => I.ID == exchangeRatePastsList[i].CurrencyID).Name,
                    exchangeRatePastsList[i].Buyying.ToString(),
                    exchangeRatePastsList[i].Selling.ToString(),
                    exchangeRatePastsList[i].CreationDate.ToString("dd.MM.yyyy hh:mm")
                    );
            }
            return dt;
        }

    }
}
