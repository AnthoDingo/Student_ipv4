using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IPv4.Forms
{
    public enum Mode
    {
        Decode,
        Propose
    }

    public partial class IP : Form
    {
        private Main _frmMain;
        public IP(Main frmMain, Mode mode = Mode.Decode)
        {
            InitializeComponent();
            _frmMain = frmMain;
            switch (mode)
            {
                case Mode.Decode:
                    initDecode();
                    break;
                case Mode.Propose:
                    break;
            }
        }

        #region Global
        private void Decode_Load(object sender, EventArgs e)
        {
            setExercice(0);
            setError(0);
        }

        private void formClose()
        {
            _frmMain.ShowMain();
        }

        private void setExercice(int number)
        {
            lblExercice.Text = $"Nombre d'exercice(s) : {number.ToString()}";
        }

        private void setError(int number)
        {
            lblError.Text = $"Nombre d'erreur(s) : {number.ToString()}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formClose();
            this.Close();
        }

        private void Decode_FormClosed(object sender, FormClosedEventArgs e)
        {
            formClose();
        }
        #endregion

        #region Mode Decode

        private bool RunningDecode = true;
        private Thread[] Decodes = new Thread[4];
        private void initDecode()
        {
            btnStop.Click += DecodeStop;
            startDecodeThreads();
        }

        private void startDecodeThreads()
        {
            startDecodeThread(Decodes[0], $"lblBlock0", 223);
            for (int i = 1; i < Decodes.Length; i++)
            {
                startDecodeThread(Decodes[i], $"lblBlock{i}", 255);
            }
        }

        private void startDecodeThread(Thread thread, string name, int max)
        {
            thread = new Thread(UpdateTextBox);
            Label lbl = grpAddress.Controls.OfType<Label>().FirstOrDefault(l => l.Name == name);
            thread.Start(new Tuple<Label, int>(lbl, max));
        }

        private void DecodeStop(object sender, EventArgs e)
        {
            RunningDecode = !RunningDecode;
            switch (btnStop.Text)
            {
                case "&Arrêter":
                    btnStop.Text = "&Générer";
                    break;
                case "&Générer":
                    btnStop.Text = "&Arrêter";
                    startDecodeThreads();
                    break;
            }
        }

        private void UpdateTextBox(object obj)
        {
            var data = obj as Tuple<Label, int>;
            Label label = data.Item1;
            int maxRandom = data.Item2;
            Random random = new Random();

            while (RunningDecode)
            {
                int randomNumber = random.Next(maxRandom);

                if (label.InvokeRequired)
                {
                    label.Invoke(new Action(() => label.Text = randomNumber.ToString()));
                }
                else
                {
                    label.Text = randomNumber.ToString();
                }

                Thread.Sleep(50);
            }
        }

        #endregion

        #region Mode Propose

        #endregion
    }
}
