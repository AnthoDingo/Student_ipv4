using IPv4.Class;
using IPv4.Converter;
using Type = IPv4.Class.Type;

namespace IPv4.Forms
{
    internal partial class IP : Form
    {
        private Main _frmMain;
        private bool _isExam;
        private int _exercices = 0;
        private int _errors = 0;
        private Mode _mode;

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
            formClose();
        }
        #endregion

        #region Mode Decode

        private bool RunningDecode = true;
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
            rbtnA.Checked = false;
            //startDecodeThread(Decodes[0], $"lblBlock0", 223);
            for (int i = 0; i < Decodes.Length; i++)
            {
                startDecodeThread(Decodes[i], $"lblBlock{i}", 256);
            }
            resetLabelSolution(lblSolutionClass);
            resetLabelSolution(lblSolutionType);
            resetLabelSolution(lblSolutionMasque);
        }

        private void startDecodeThread(Thread thread, string name, int max)
        {
            thread = new Thread(UpdateTextBox);
            Label lbl = grpAddress.Controls.OfType<Label>().FirstOrDefault(l => l.Name == name);
            thread.Start(new Tuple<Label, int>(lbl, max));
        }

        private void StopDecode(object sender, EventArgs e)
        {
            RunningDecode = !RunningDecode;
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

            while (RunningDecode)
            {
                int randomNumber = random.Next(0, maxRandom);

                if (label.InvokeRequired)
                {
                    label.Invoke(new Action(() => label.Text = randomNumber.ToString()));
                }
                else
                {
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
                return;
            }

            int block0 = Convert.ToInt32(lblBlock0.Text);
            int block1 = Convert.ToInt32(lblBlock1.Text);
            int block2 = Convert.ToInt32(lblBlock2.Text);
            int block3 = Convert.ToInt32(lblBlock3.Text);

            if (block0 < 128)
            {
                lblSolutionClass.Text = Classe.A;
            }
            else if (block0 < 192)
            {
                lblSolutionClass.Text = Classe.B;
            }
            else if (block0 < 224)
            {
                lblSolutionClass.Text = Classe.C;
            }
            else if (block0 < 240)
            {
                lblSolutionClass.Text = Classe.D;
            }
            else
            {
                lblSolutionClass.Text = Classe.E;
            }


            if (selectedClass.Text.Equals(lblSolutionClass.Text))
            {
                lblSolutionClass.BackColor = Color.LimeGreen;
            }
            else
            {
                Errors += 1;
                lblSolutionClass.BackColor = Color.IndianRed;
            }


            lblSolutionType.Text = Type.Unicast;
            switch (lblSolutionClass.Text)
            {
                case "A":
                    if (block0 == 127)
                    {
                        lblSolutionType.Text = Type.Loopback;
                        break;
                    }

                    if (block1 == 0 & block2 == 0 & block3 == 0)
                    {
                        lblSolutionType.Text = Type.Network;
                        break;
                    }

                    if (block1 == 255 & block2 == 255 & block3 == 255)
                    {
                        lblSolutionType.Text = Type.Broadcast;
                        break;
                    }

                    break;
                case "B":

                    if (block2 == 0 & block3 == 0)
                    {
                        lblSolutionType.Text = Type.Network;
                        break;
                    }

                    if (block2 == 255 & block3 == 255)
                    {
                        lblSolutionType.Text = Type.Broadcast;
                        break;
                    }
                    break;
                case "C":

                    if (block3 == 0)
                    {
                        lblSolutionType.Text = Type.Network;
                        break;
                    }

                    if (block3 == 255)
                    {
                        lblSolutionType.Text = Type.Broadcast;
                        break;
                    }
                    break;
                case "D":
                    lblSolutionType.Text = Type.Multicast;
                    break;
                case "E":
                    lblSolutionType.Text = Type.NotConcerned;
                    break;
            }

            if (selectedType.Text.Equals(lblSolutionType.Text))
            {
                lblSolutionType.BackColor = Color.LimeGreen;
            }
            else
            {
                Errors += 1;
                lblSolutionType.BackColor = Color.IndianRed;
            }

            switch (lblSolutionClass.Text)
            {
                case "A":
                    lblSolutionMasque.Text = Masque.A;
                    break;
                case "B":
                    lblSolutionMasque.Text = Masque.B;
                    break;
                case "C":
                    lblSolutionMasque.Text = Masque.C;
                    break;
                case "D":
                    lblSolutionMasque.Text = Masque.Full;
                    break;
                case "E":
                case "Réservé ...":
                    lblSolutionMasque.Text = Masque.NotConcerned;
                    break;
            }

            if (selectedMasque.Text.Equals(lblSolutionMasque.Text))
            {
                lblSolutionMasque.BackColor = Color.LimeGreen;
            }
            else
            {
                Errors += 1;
                lblSolutionMasque.BackColor = Color.IndianRed;
            }

            btnAnswer.Enabled = false;
            btnStop.Enabled = true;
        }

        #endregion

        #region Mode Propose

        private bool RunningPropose = true;
        private Thread[] Proposes = new Thread[2];
        private List<RadioButton> _btnsClass;
        private List<RadioButton> _btnsType;

        private void initPropose()
        {
            grpAddress.Visible = false;
            grpMasque.Visible = false;
            lblSolutionMasque.Visible = false;
            lblSolution.Text = "Votre Proposition correspond à ...";

            _btnsClass = grpClasse.Controls.OfType<RadioButton>().OrderBy(r => r.TabIndex).ToList();
            _btnsType = grpType.Controls.OfType<RadioButton>().OrderBy(r => r.TabIndex).ToList();

            btnStop.Click += StopPropose;
            //startProposeThreads();
        }

        private void startProposeThreads()
        {
            //startProposeThread(Proposes[0], grpClasse);
            //startProposeThread(Proposes[1], grpType);

            Thread thread = new Thread(UpdateRadioButton);
            thread.Start(new Tuple<List<RadioButton>, List<RadioButton>>(_btnsClass, _btnsType));

            resetLabelSolution(lblSolutionClass);
            resetLabelSolution(lblSolutionType);
        }

        private void StopPropose(object sender, EventArgs e)
        {
            RunningPropose = !RunningPropose;
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
                    startProposeThreads();
                    break;
            }

        }

        private void AnswerPropose(object sender, EventArgs e)
        {

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

            while (RunningPropose)
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
                    classButton.Invoke(new Action(() => classButton.Checked = true));
                }
                else
                {
                    classButton.Checked = true;
                }

                if (typeButton.InvokeRequired)
                {
                    typeButton.Invoke(new Action(() => typeButton.Checked = true));
                } 
                else
                {
                    typeButton.Checked = true;
                }


#if DEBUG
                Thread.Sleep(1000);
#else
                Thread.Sleep(10);
#endif   
            }
        }

        #endregion
    }
}
