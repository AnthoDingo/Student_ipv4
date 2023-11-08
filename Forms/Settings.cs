using IPv4.Class;
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
    public partial class Settings : Form
    {
        private Main _frmMain;
        private Setting _setting;

        public Settings(Main main)
        {
            InitializeComponent();
            _frmMain = main;
            _setting = main.Settings;

            tbxPassword.Text = _setting.Password;
            numExercices.Value = _setting.Number;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _setting.Password = tbxPassword.Text;
            _setting.Number = Convert.ToInt32(numExercices.Value);
            _frmMain.Settings = _setting;
            this.Close();
        }
    }
}
