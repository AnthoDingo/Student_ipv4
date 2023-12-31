﻿using IPv4.Class;
using IPv4.Converter;
using IPv4.Services;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using static System.Environment;

namespace IPv4.Forms
{
    public partial class Main : Form
    {
        private Converter _frmConverter;
        private Setting _setting;
        private SettingsManager _settingsManager = new SettingsManager();
        private string _appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private string _settingFileName = "settings_v2.dat";
        
        // Key you can change if needed
        private string _settingKey = "k4o47#DB3@SD#orX";
        private string _settingIV = "K9Z3HfmSBE%G*FH2";

        public Main()
        {
            InitializeComponent();

            LoadSetting();

            _frmConverter = new Converter();

            if (IsAdministrator())
                btnSettings.Visible = true;

            (new Updater("IPv4", "AnthoDingo", "Student_ipv4")).CheckAsync();
        }

        private void LoadSetting()
        {
            if (!File.Exists($"{_appPath}\\{_settingFileName}"))
            {
                if (IsAdministrator())
                {
                    Settings = new Setting();
                    MessageBox.Show("Paramètres par défaut créés.\r\nPensez à changer le mot de passe Devoir.", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
#if DEBUG
                    Settings = new Setting();
                    MessageBox.Show("Paramètres par défaut créés.\r\nPensez à changer le mot de passe Devoir.", "Paramètres", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
                    MessageBox.Show("Fichier de paramètre manquant.\r\nRelancer l'application en mode Administrateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
#endif
                }
            }
        }

        internal Setting Settings
        {
            get
            {
                return _settingsManager.ReadSettings($"{_appPath}\\{_settingFileName}", Encoding.UTF8.GetBytes(_settingKey), Encoding.UTF8.GetBytes(_settingIV));
            }
            set
            {
                _settingsManager.WriteSettings($"{_appPath}\\{_settingFileName}", value, Encoding.UTF8.GetBytes(_settingKey), Encoding.UTF8.GetBytes(_settingIV));
            }
        }

        internal void ShowMain()
        {
            this.Show();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
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
            Mode targetMode;
            switch (exercice.Name)
            {
                case "rbtnDecode":
                    targetMode = Mode.Decode;
                    break;
                case "rbtnPropose":
                    targetMode = Mode.Propose;
                    break;
                default:
                    return;
            }

            IP frmPropose = new IP(this, targetMode, true);
            _frmConverter.Hide();
            frmPropose.Show();
            this.Hide();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            _frmConverter.Show();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/AnthoDingo/Student_ipv4") { UseShellExecute = true });
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            (new Settings(this)).ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }
    }
}
