using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPv4.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private RadioButton getChecked()
        {
            return grpExercices.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            switch (getChecked().Name)
            {
                case "rbtnDecode":
                    IP frmIP = new IP(this);
                    frmIP.Show();
                    break;
                case "rbtnPropose":
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
