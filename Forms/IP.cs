using System.Linq;
using IPv4.Class;
using IPv4.Converter;
using System.Diagnostics;
using Type = IPv4.Class.Type;
using Microsoft.VisualBasic;

namespace IPv4.Forms
{
    internal partial class IP : Form
    {
        private Main _frmMain;
        private bool _isExam;
        private int _exercices = 0;
        private int _errors = 0;
        private Mode _mode;
        private Setting _setting;

        private List<RadioButton> _btnsClass;
        private List<RadioButton> _btnsType;
        private List<RadioButton> _btnsMasque;

        private bool RunningThreads = true;

        public IP(Main frmMain, Mode mode = Mode.Decode, bool IsExam = false)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _mode = mode;
            switch (mode)
            {
                case Mode.Decode:
                    initDecode();
                    break;
                case Mode.Propose:
                    initPropose();
                    break;
            }
            _isExam = IsExam;

            _btnsClass = grpClasse.Controls.OfType<RadioButton>().OrderBy(r => r.TabIndex).ToList();
            _btnsType = grpType.Controls.OfType<RadioButton>().OrderBy(r => r.TabIndex).ToList();
            _btnsMasque = grpMasque.Controls.OfType<RadioButton>().OrderBy(r => r.TabIndex).ToList();

            if (_isExam)
            {
                btnBack.Enabled = false;
                btnBack.Visible = false;
                this.ControlBox = false;
                _setting = _frmMain.Settings;
            }
        }

        #region Global
        private void Decode_Load(object sender, EventArgs e)
        {
            Exercices = 0;
            Errors = 0;
            switch (_mode)
            {
                case Mode.Decode:
                    startDecodeThreads();
                    break;
                case Mode.Propose:
                    startProposeThreads();
                    break;
            }
        }

        private void formClose()
        {
            _frmMain.ShowMain();
        }

        private int Exercices
        {
            get
            {
                return _exercices;
            }
            set
            {
                if (_exercices != value)
                {
                    _exercices = value;
                    lblExercice.Text = $"Nombre d'exercice(s) : {_exercices.ToString()}";
                }

            }
        }

        private int Errors
        {
            get { return _errors; }
            set
            {
                if (_errors != value)
                {
                    _errors = value;
                    lblError.Text = $"Nombre d'erreur(s) : {_errors.ToString()}";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formClose();
            this.Close();
        }

        private void resetLabelSolution(Label lbl)
        {
            lbl.Text = "";
            lbl.BackColor = SystemColors.Control;
        }

        private void Decode_FormClosed(object sender, FormClosedEventArgs e)
        {
            RunningThreads = false;
            formClose();
        }

        private void IP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isExam)
            {
                Errors += 10;
                MessageBox.Show("Vous avez tenter de tricher.\r\nPénalitée de 10 points.", "Tricheur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void AnswerExam()
        {
            if (!_isExam)
                return;

            if (Exercices == _setting.Number)
            {
                string passwd = Interaction.InputBox("Bravo, vous avez finis.\r\nAppelez le prof pour valider votre exam.", "Terminé");
                while (!_setting.Password.Equals(passwd))
                {
                    passwd = Interaction.InputBox("Bravo, vous avez finis.\r\nAppelez le prof pour valider votre exam.", "Terminé");
                }
                _isExam = false;
                formClose();
                this.Close();
            }
        }

        private void SetGoodLabel(Label lbl)
        {
            lbl.BackColor = Color.LimeGreen;
        }

        private void SetBadLabel(Label lbl)
        {
            Errors += 1;
            lbl.BackColor = Color.IndianRed;

        }
        #endregion

        #region Mode Decode

        private Thread[] Decodes = new Thread[4];
        private void initDecode()
        {
            grpPropose.Visible = false;
            btnStop.Click += StopDecode;
            btnAnswer.Click += AnswerDecode;
            rbtnA.Checked = false;
            //startDecodeThreads();
        }

        private void startDecodeThreads()
        {
            //rbtnA.Checked = false;
            clearSelected(_btnsClass);
            clearSelected(_btnsType);
            clearSelected(_btnsMasque);
            //startDecodeThread(Decodes[0], $"lblBlock0", 223);
            for (int i = 0; i < Decodes.Length; i++)
            {
                startDecodeThread(Decodes[i], $"lblBlock{i}", 256);
            }
            resetLabelSolution(lblSolutionClass);
            resetLabelSolution(lblSolutionType);
            resetLabelSolution(lblSolutionMasque);
        }

        private void clearSelected(List<RadioButton> list)
        {
            foreach (RadioButton rb in list)
            {
                rb.Checked = false;
            }
        }

        private void startDecodeThread(Thread thread, string name, int max)
        {
            thread = new Thread(UpdateTextBox);
            Label lbl = grpAddress.Controls.OfType<Label>().FirstOrDefault(l => l.Name == name);
            thread.Start(new Tuple<Label, int>(lbl, max));
        }

        private void StopDecode(object sender, EventArgs e)
        {
            RunningThreads = !RunningThreads;
            switch (btnStop.Text)
            {
                case "&Arrêter":
                    Exercices += 1;
                    btnStop.Text = "&Générer";
                    btnAnswer.Enabled = true;
                    btnStop.Enabled = false;
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

            while (RunningThreads)
            {
                int randomNumber = random.Next(0, maxRandom);

                if (label.InvokeRequired)
                {
                    if(RunningThreads)
                        label.Invoke(new Action(() => label.Text = randomNumber.ToString()));
                }
                else
                {
                    if(RunningThreads)
                        label.Text = randomNumber.ToString();
                }
#if DEBUG
                Thread.Sleep(1000);
#else
                Thread.Sleep(10);
#endif
            }
        }

        private void AnswerDecode(object sender, EventArgs e)
        {
            RadioButton selectedClass = GroupBoxCheckedRadioButton.GetChecked(grpClasse);
            RadioButton selectedType = GroupBoxCheckedRadioButton.GetChecked(grpType);
            RadioButton selectedMasque = GroupBoxCheckedRadioButton.GetChecked(grpMasque);
            if (selectedClass == null || selectedType == null || selectedMasque == null)
            {
                MessageBox.Show("Une sélection est manquante", "Valeur manquante", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Errors += 1;
                return;
            }

            Address address = new Address(Convert.ToInt32(lblBlock0.Text), Convert.ToInt32(lblBlock1.Text), Convert.ToInt32(lblBlock2.Text), Convert.ToInt32(lblBlock3.Text));

            lblSolutionClass.Text = address.Classe;
            if (selectedClass.Text.Equals(lblSolutionClass.Text))
            {
                SetGoodLabel(lblSolutionClass);
            }
            else
            {
                SetBadLabel(lblSolutionClass);
            }

            lblSolutionType.Text = address.Type;
            if (selectedType.Text.Equals(lblSolutionType.Text))
            {
                SetGoodLabel(lblSolutionType);
            }
            else
            {
                SetBadLabel(lblSolutionType);
            }

            lblSolutionMasque.Text = address.Masque;
            if (selectedMasque.Text.Equals(lblSolutionMasque.Text))
            {
                SetGoodLabel(lblSolutionMasque);
            }
            else
            {
                SetBadLabel(lblSolutionMasque);
            }

            btnAnswer.Enabled = false;
            btnStop.Enabled = true;

            AnswerExam();
        }

        #endregion

        #region Mode Propose
        private List<TextBox> _tbxProposes;

        private void initPropose()
        {
            grpAddress.Visible = false;
            grpMasque.Visible = false;
            lblSolutionMasque.Visible = false;
            lblSolution.Text = "Votre Proposition correspond à ...";


            _tbxProposes = grpPropose.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex).ToList();

            btnStop.Click += StopPropose;
            btnAnswer.Click += AnswerPropose;
            //startProposeThreads();

            tbxBlock0.KeyPress += tbxTextChange;
            tbxBlock1.KeyPress += tbxTextChange;
            tbxBlock2.KeyPress += tbxTextChange;
            tbxBlock3.KeyPress += tbxTextChange;
        }

        private void tbxTextChange(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                Control control = sender as Control;
                if (control != null)
                {
                    int tabIndex = control.TabIndex;
                    int nextIndex = tabIndex + 1;
                    if (nextIndex < 4)
                    {
                        TextBox next = _tbxProposes.First(tbx => tbx.TabIndex == nextIndex);
                        next.Focus();
                    }
                    e.Handled = true;
                }
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void startProposeThreads()
        {
            //startProposeThread(Proposes[0], grpClasse);
            //startProposeThread(Proposes[1], grpType);

            Thread thread = new Thread(UpdateRadioButton);
            thread.Start(new Tuple<List<RadioButton>, List<RadioButton>>(_btnsClass, _btnsType));

            resetLabelSolution(lblSolutionClass);
            resetLabelSolution(lblSolutionType);
            resetTextBox(tbxBlock0);
            resetTextBox(tbxBlock1);
            resetTextBox(tbxBlock2);
            resetTextBox(tbxBlock3);
        }

        private void resetTextBox(TextBox tbx)
        {
            tbx.BackColor = SystemColors.Window;
            tbx.Text = string.Empty;
        }

        private void StopPropose(object sender, EventArgs e)
        {
            RunningThreads = !RunningThreads;
            switch (btnStop.Text)
            {
                case "&Arrêter":
                    Exercices += 1;
                    btnStop.Text = "&Générer";
                    btnAnswer.Enabled = true;
                    btnStop.Enabled = false;
                    tbxBlock0.Focus();
                    break;
                case "&Générer":
                    btnStop.Text = "&Arrêter";
                    startProposeThreads();
                    break;
            }

        }

        private void AnswerPropose(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxBlock0.Text) || string.IsNullOrEmpty(tbxBlock1.Text) || string.IsNullOrEmpty(tbxBlock2.Text) || string.IsNullOrEmpty(tbxBlock3.Text))
            {
                MessageBox.Show("Un block de l'adresse IP est vide", "Valeur incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Errors += 1;
                return;
            }

            RadioButton selectedClass = GroupBoxCheckedRadioButton.GetChecked(grpClasse);
            RadioButton selectedType = GroupBoxCheckedRadioButton.GetChecked(grpType);
            string result = $"{selectedClass.TabIndex}{selectedType.TabIndex}";

            int valueBlock0 = Convert.ToInt32(tbxBlock0.Text);
            int valueBlock1 = Convert.ToInt32(tbxBlock1.Text);
            int valueBlock2 = Convert.ToInt32(tbxBlock2.Text);
            int valueBlock3 = Convert.ToInt32(tbxBlock3.Text);

            switch (result)
            {
                case "00":
                    CheckValue(tbxBlock0, 0, 126);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 1, 254);
                    break;
                case "02":
                    CheckValue(tbxBlock0, 0, 126);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 255);
                    break;
                case "03":
                    CheckValue(tbxBlock0, 127, 127);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckOutOfRange(tbxBlock3);
                    break;
                case "04":
                    CheckValue(tbxBlock0, 0, 127);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 0, 0);
                    break;
                case "10":
                    CheckValue(tbxBlock0, 128, 191);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 1, 254);
                    break;
                case "12":
                    CheckValue(tbxBlock0, 128, 191);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 255);
                    break;
                case "14":
                    CheckValue(tbxBlock0, 128, 191);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 0, 0);
                    break;
                case "20":
                    CheckValue(tbxBlock0, 192, 223);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 1, 254);
                    break;
                case "22":
                    CheckValue(tbxBlock0, 192, 223);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 255);
                    break;
                case "24":
                    CheckValue(tbxBlock0, 192, 223);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 0, 0);
                    break;
                case "31":
                    CheckValue(tbxBlock0, 224, 239);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckOutOfRange(tbxBlock3);
                    break;
                case "45":
                    CheckValue(tbxBlock0, 240, 255);
                    CheckOutOfRange(tbxBlock1);
                    CheckOutOfRange(tbxBlock2);
                    CheckValue(tbxBlock3, 0, 254);
                    break;
            }

            Address address = new Address(Convert.ToInt32(tbxBlock0.Text), Convert.ToInt32(tbxBlock1.Text), Convert.ToInt32(tbxBlock2.Text), Convert.ToInt32(tbxBlock3.Text));
            lblSolutionClass.Text = address.Classe;
            lblSolutionType.Text = address.Type;

            btnAnswer.Enabled = false;
            btnStop.Enabled = true;

            AnswerExam();
        }

        private void UpdateRadioButton(object obj)
        {
            //GroupBox data = obj as GroupBox;
            //List<RadioButton> radioButtons = data.Controls.OfType<RadioButton>().Where(r => r.Visible = true).ToList();
            var data = obj as Tuple<List<RadioButton>, List<RadioButton>>;
            List<RadioButton> btnsClass = data.Item1;
            List<RadioButton> btnsType = data.Item2;

            //List<RadioButton> radioButtons = obj as List<RadioButton>;
            //int maxRandom = radioButtons.Count();
            Random random = new Random();

            while (RunningThreads)
            {
                int index = random.Next(0, btnsClass.Count);
                RadioButton classButton = btnsClass[index];

                int[] availableType = { };
                switch (classButton.Text)
                {
                    case "A":
                        availableType = new int[] { 0, 2, 3, 4 };
                        break;
                    case "B":
                    case "C":
                        availableType = new int[] { 0, 2, 4 };
                        break;
                    case "D":
                        availableType = new int[] { 1 };
                        break;
                    case "E":
                        availableType = new int[] { 5 };
                        break;
                }

                int typeRandom = random.Next(availableType.Length);
                int typeIndex = availableType[typeRandom];
                RadioButton typeButton = btnsType[typeIndex];

                if (classButton.InvokeRequired)
                {
                    if(RunningThreads)
                        classButton.Invoke(new Action(() => classButton.Checked = true));
                }
                else
                {
                    if (RunningThreads)
                        classButton.Checked = true;
                }

                if (typeButton.InvokeRequired)
                {
                    if (RunningThreads)
                        typeButton.Invoke(new Action(() => typeButton.Checked = true));
                }
                else
                {
                    if (RunningThreads)
                        typeButton.Checked = true;
                }


#if DEBUG
                Thread.Sleep(1000);
#else
                Thread.Sleep(10);
#endif   
            }
        }

        private void CheckOutOfRange(TextBox tbx)
        {
            int value = Convert.ToInt32(tbx.Text);
            if (value < 0 || value > 255)
            {
                Errors += 1;
                tbx.BackColor = Color.IndianRed;
            }
            else
            {
                tbx.BackColor = Color.LimeGreen;
            }
        }
        private void CheckValue(TextBox tbx, int min, int? max = null)
        {
            int value = Convert.ToInt32(tbx.Text);

            if (value < 0 || value > 255)
            {
                Errors += 1;
                tbx.BackColor = Color.IndianRed;
                return;
            }

            if (max == null)
            {
                if (value >= min)
                {
                    tbx.BackColor = Color.LimeGreen;
                }
                else
                {
                    Errors += 1;
                    tbx.BackColor = Color.IndianRed;
                }
            }
            else
            {
                if (min == max)
                {
                    if (value == min)
                    {
                        tbx.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        Errors += 1;
                        tbx.BackColor = Color.IndianRed;
                    }


                    return;

                }

                if (value >= min && value <= max)
                {
                    tbx.BackColor = Color.LimeGreen;
                }
                else
                {
                    Errors += 1;
                    tbx.BackColor = Color.IndianRed;
                }
            }
        }
        #endregion


    }
}
