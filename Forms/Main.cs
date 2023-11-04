using IPv4.Class;
using IPv4.Converter;

namespace IPv4.Forms
{
    public partial class Main : Form
    {
        private Converter _frmConverter;

        public Main()
        {
            InitializeComponent();
            _frmConverter = new Converter();
        }
        internal void ShowMain()
        {
            this.Show();
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

        private void btnExam_Click(object sender, EventArgs e)
        {
            RadioButton exercice = GroupBoxCheckedRadioButton.GetChecked(grpExercices);
            switch (exercice.Name)
            {
                case "rbtnDecode":
                    IP frmDecode = new IP(this, Mode.Decode, true);
                    frmDecode.Show();
                    break;
                case "rbtnPropose":
                    IP frmPropose = new IP(this, Mode.Propose, true);
                    frmPropose.Show();
                    break;
            }

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _frmConverter.Show();
        }
    }
}
