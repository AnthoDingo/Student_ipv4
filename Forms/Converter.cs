using IPv4.Converter;
using System.Net;
using System.Numerics;
using System.Text.RegularExpressions;

namespace IPv4.Forms
{
    public partial class Converter : Form
    {
        private IPAddress _ipAddress;

        public Converter()
        {
            InitializeComponent();
        }

        private void btnIP2Int_Click(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(tbxIPv4.Text, @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$"))
            {
                MessageBox.Show("Adresse IP invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string[] ipBlocks = tbxIPv4.Text.Split(".");

            tbxBlockInt0.Text = ipBlocks[0];
            tbxBlockInt1.Text = ipBlocks[1];
            tbxBlockInt2.Text = ipBlocks[2];
            tbxBlockInt3.Text = ipBlocks[3];

            int block0 = Convert.ToInt32(ipBlocks[0]);
            int block1 = Convert.ToInt32(ipBlocks[1]);
            int block2 = Convert.ToInt32(ipBlocks[2]);
            int block3 = Convert.ToInt32(ipBlocks[3]);

            tbxBlockBin0.Text = Convert.ToString(block0, 2).PadLeft(8, '0');
            tbxBlockBin1.Text = Convert.ToString(block1, 2).PadLeft(8, '0');
            tbxBlockBin2.Text = Convert.ToString(block2, 2).PadLeft(8, '0');
            tbxBlockBin3.Text = Convert.ToString(block3, 2).PadLeft(8, '0');

            tbxBin.Text = $"{tbxBlockBin0.Text}{tbxBlockBin1.Text}{tbxBlockBin2.Text}{tbxBlockBin3.Text}";
            BigInteger value = Convert.ToInt64(tbxBin.Text, 2);
            tbxResult.Text = value.ToString();
            tbxDec.Text = value.ToString();
            finalResult();
        }

        private void btnInt2IP_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxDec.Text;
            int source = (int)Convert.ToInt64(tbxDec.Text);
            tbxBin.Text = Convert.ToString(source, 2).PadLeft(32, '0');
            tbxBlockBin0.Text = tbxBin.Text.Substring(0, 8);
            tbxBlockBin1.Text = tbxBin.Text.Substring(8, 8);
            tbxBlockBin2.Text = tbxBin.Text.Substring(16, 8);
            tbxBlockBin3.Text = tbxBin.Text.Substring(24, 8);

            tbxBlockInt0.Text = Convert.ToInt32(tbxBlockBin0.Text, 2).ToString();
            tbxBlockInt1.Text = Convert.ToInt32(tbxBlockBin1.Text, 2).ToString();
            tbxBlockInt2.Text = Convert.ToInt32(tbxBlockBin2.Text, 2).ToString();
            tbxBlockInt3.Text = Convert.ToInt32(tbxBlockBin3.Text, 2).ToString();

            tbxIPv4.Text = $"{tbxBlockInt0.Text}.{tbxBlockInt1.Text}.{tbxBlockInt2.Text}.{tbxBlockInt3.Text}";
            finalResult();
        }

        private void finalResult()
        {
            rtbxResult.Text = "";
            rtbxResult.AppendText($"Adresse ipv4 :  {tbxIPv4.Text}\r\n");
            rtbxResult.AppendText($"Octet ipv4   :  {tbxBlockInt0.Text}-{tbxBlockInt1.Text}-{tbxBlockInt2.Text}-{tbxBlockInt3.Text}\r\n");
            rtbxResult.AppendText($"Bin ipv4     :  {tbxBlockBin0.Text}-{tbxBlockBin1.Text}-{tbxBlockBin2.Text}-{tbxBlockBin3.Text}\r\n");
            rtbxResult.AppendText($"Binaire ipv4 :  {tbxBin.Text}\r\n");
            rtbxResult.AppendText($"Décimal ipv4 :  {tbxDec.Text}\r\n");
        }
    }
}
