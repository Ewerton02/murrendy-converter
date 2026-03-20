using Newtonsoft.Json.Linq;

namespace MurrendyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadCoins();
        }

        private async Task LoadCoins()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string url = "https://api.frankfurter.app/currencies";
                    var response = await client.GetStringAsync(url);
                    var json = JObject.Parse(response);

                    var coins = new List<KeyValuePair<string, string>>();
                    foreach (var coin in json)
                    {
                        coins.Add(new KeyValuePair<string, string>(coin.Key, coin.Key + " - " + coin.Value));
                    }

                    cbDe.DataSource = new List<KeyValuePair<string, string>>(coins);
                    cbDe.DisplayMember = "Value";
                    cbDe.ValueMember = "Key";
                    cbDe.SelectedValue = "USD";

                    cbPara.DataSource = new List<KeyValuePair<string, string>>(coins);
                    cbPara.DisplayMember = "Value";
                    cbPara.ValueMember = "Key";
                    cbPara.SelectedValue = "BRL";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading coins: " + ex.Message);
                }
            }
        }

        private async void btnConverter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Please enter a value to convert.");
                return;
            }

            try
            {
                string de = cbDe.SelectedValue.ToString();
                string para = cbPara.SelectedValue.ToString();

                if (de == para)
                {
                    lblResultado.Text = $"{decimal.Parse(txtValor.Text):N2} {de} = {decimal.Parse(txtValor.Text):N2} {para}";
                    return;
                }

                decimal value = decimal.Parse(txtValor.Text);

                decimal converter = await ConvertCurrency(de, para, value);
                lblResultado.Text = $"{value:N2} {de} = {converter:N2} {para}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting currency: " + ex.Message);
            }
        }

        private async Task<decimal> ConvertCurrency(string de, string para, decimal value)
        {
            using(var client = new HttpClient())
            {
                string url = $"https://api.frankfurter.app/latest?from={de}&to={para}";
                var response = await client.GetStringAsync(url);
                var json = JObject.Parse(response); 
                decimal taxa = json["rates"][para].Value<decimal>();
                return value * taxa;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            var temp = cbDe.SelectedIndex;
            cbDe.SelectedIndex = cbPara.SelectedIndex;
            cbPara.SelectedIndex = temp;
        }
    }
}
