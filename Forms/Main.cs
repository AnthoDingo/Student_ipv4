using IPv4.Class;
using IPv4.Converter;

namespace IPv4.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            RadioButton exercice = GroupBoxCheckedRadioButton.GetChecked(grpExercices);
            switch (exercice.Name)
            {
                case "rbtnDecode":
                    IP frmDecode = new IP(this, Mode.Decode);
                    frmDecode.Show();
                    break;
                case "rbtnPropose":
                    IP frmPropose = new IP(this, Mode.Propose);
                    frmPropose.Show();
                    break;
                case "rbtnNetworkDecode":
                    break;
                case "rbtnNetworkPropose":
                    break;
                case "rbtnTable":
                    break;
            }

            this.Hide();
        }

        internal void ShowMain()
        {
            this.Show();
        }
    }
}
