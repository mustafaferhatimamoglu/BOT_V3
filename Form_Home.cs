using BOT_V3.Operations;

namespace BOT_V3
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
        GetDataFromBinance getDataFromBinance = new GetDataFromBinance();
        private void Button_CreateAndUpdate_Table_Click(object sender, EventArgs e)
        {
            getDataFromBinance.Create_Coin("BTCUSDT");
            MessageBox.Show("DONE");
        }

        private void Button_ShowGraph_Click(object sender, EventArgs e)
        {
            var f = new Grapher.Form_Graph("BTCUSDT");
            f.Show();
        }
    }
}
