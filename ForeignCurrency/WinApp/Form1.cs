using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer();
            BLL.updateExchangeRateInfo();

            List<Currency> currencyList = BLL.currencyListTypeList();
            List<ExchangeRate> exchangeRateList = BLL.exchangeRateListTypeList();

            ExchangeRate Dolar = exchangeRateList.FirstOrDefault(I => I.CurrencyID == currencyList.FirstOrDefault(x => x.Name == "Dolar").ID);
            lbl_dollar_buying.Text = Dolar.Buyying.ToString("N2");
            lbl_dollar_selling.Text = Dolar.Selling.ToString("N2");

            ExchangeRate Euro = exchangeRateList.FirstOrDefault(I => I.CurrencyID == currencyList.FirstOrDefault(x => x.Name == "Euro").ID);
            lbl_euro_buying.Text = Euro.Buyying.ToString("N2");
            lbl_euro_selling.Text = Euro.Selling.ToString("N2");

            ExchangeRate Sterlin = exchangeRateList.FirstOrDefault(I => I.CurrencyID == currencyList.FirstOrDefault(x => x.Name == "İngiliz Sterlini").ID);
            lbl_sterling_buying.Text = Sterlin.Buyying.ToString("N2");
            lbl_sterling_selling.Text = Sterlin.Selling.ToString("N2");

            grd_ExchangeRatePast.DataSource = BLL.showExchangeRatePast();


        }
    }
}
