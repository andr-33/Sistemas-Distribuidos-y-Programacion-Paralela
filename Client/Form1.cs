using Client.ServiceExchangeCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceExchangeCurrency.ExchangeCurrencyClient client = new 
                ServiceExchangeCurrency.ExchangeCurrencyClient();

            ConvertRequest request = new ConvertRequest();
            ConvertResponse response = new ConvertResponse();
           
            String fromCurrency = cbFromCurrency.SelectedItem.ToString();
            String toCurrency = cbToCurrency.SelectedItem.ToString();

            try
            {
                Currency from = (Currency)Enum.Parse(typeof(Currency), fromCurrency);
                Currency to = (Currency)Enum.Parse(typeof(Currency), toCurrency);
                double amount = Convert.ToDouble(tbAmount.Text);

                request.From = from;
                request.To = to;
                request.Amount = amount;

                response = client.exchange(request);

                String currencySimbol = response.To.ToString() == "EUR" ? "€" : "$";
                lbNewAmount.Text = $"{currencySimbol}{response.Amount}";
            }
            catch (ArgumentException) {
                MessageBox.Show("Error: Invalid currency was selected");
            }
        }
    }
}
