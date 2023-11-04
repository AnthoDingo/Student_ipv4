namespace IPv4.Forms
{
    partial class IP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblExercice = new Label();
            lblError = new Label();
            grpClasse = new GroupBox();
            rbtnE = new RadioButton();
            rbtnD = new RadioButton();
            rbtnC = new RadioButton();
            rbtnB = new RadioButton();
            rbtnA = new RadioButton();
            grpType = new GroupBox();
            rbtnNotConcerned = new RadioButton();
            rbtnNetwork = new RadioButton();
            rbtnLoopback = new RadioButton();
            rbtnBroadcast = new RadioButton();
            rbtnMulticast = new RadioButton();
            rbtnUnicast = new RadioButton();
            grpMasque = new GroupBox();
            rbtnMFull = new RadioButton();
            rbtnMC = new RadioButton();
            rbtnMB = new RadioButton();
            rbtnMA = new RadioButton();
            rbtnMNotConcerned = new RadioButton();
            grpAddress = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblBlock3 = new Label();
            lblBlock2 = new Label();
            lblBlock1 = new Label();
            lblBlock0 = new Label();
            btnBack = new Button();
            btnStop = new Button();
            btnAnswer = new Button();
            pnlDecodeAnswer = new Panel();
            lblSolutionMasque = new Label();
            lblSolutionType = new Label();
            lblSolutionClass = new Label();
            lblSolution = new Label();
            grpPropose = new GroupBox();
            tbxBlock3 = new TextBox();
            tbxBlock2 = new TextBox();
            tbxBlock1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxBlock0 = new TextBox();
            grpClasse.SuspendLayout();
            grpType.SuspendLayout();
            grpMasque.SuspendLayout();
            grpAddress.SuspendLayout();
            pnlDecodeAnswer.SuspendLayout();
            grpPropose.SuspendLayout();
            SuspendLayout();
            // 
            // lblExercice
            // 
            lblExercice.BorderStyle = BorderStyle.Fixed3D;
            lblExercice.Location = new Point(10, 13);
            lblExercice.Name = "lblExercice";
            lblExercice.Size = new Size(179, 33);
            lblExercice.TabIndex = 0;
            lblExercice.Text = "Nombre d'exercice(s) : 0";
            lblExercice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblError.BorderStyle = BorderStyle.Fixed3D;
            lblError.Location = new Point(309, 9);
            lblError.Name = "lblError";
            lblError.Size = new Size(179, 33);
            lblError.TabIndex = 1;
            lblError.Text = "Nombre d'erreur(s) : 0";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpClasse
            // 
            grpClasse.Controls.Add(rbtnE);
            grpClasse.Controls.Add(rbtnD);
            grpClasse.Controls.Add(rbtnC);
            grpClasse.Controls.Add(rbtnB);
            grpClasse.Controls.Add(rbtnA);
            grpClasse.Location = new Point(12, 138);
            grpClasse.Name = "grpClasse";
            grpClasse.Size = new Size(153, 196);
            grpClasse.TabIndex = 2;
            grpClasse.TabStop = false;
            grpClasse.Text = "Classe";
            // 
            // rbtnE
            // 
            rbtnE.AutoSize = true;
            rbtnE.Location = new Point(49, 122);
            rbtnE.Name = "rbtnE";
            rbtnE.Size = new Size(31, 19);
            rbtnE.TabIndex = 4;
            rbtnE.TabStop = true;
            rbtnE.Text = "E";
            rbtnE.UseVisualStyleBackColor = true;
            // 
            // rbtnD
            // 
            rbtnD.AutoSize = true;
            rbtnD.Location = new Point(49, 97);
            rbtnD.Name = "rbtnD";
            rbtnD.Size = new Size(33, 19);
            rbtnD.TabIndex = 3;
            rbtnD.TabStop = true;
            rbtnD.Text = "D";
            rbtnD.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            rbtnC.AutoSize = true;
            rbtnC.Location = new Point(49, 72);
            rbtnC.Name = "rbtnC";
            rbtnC.Size = new Size(33, 19);
            rbtnC.TabIndex = 2;
            rbtnC.TabStop = true;
            rbtnC.Text = "C";
            rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            rbtnB.AutoSize = true;
            rbtnB.Location = new Point(49, 47);
            rbtnB.Name = "rbtnB";
            rbtnB.Size = new Size(32, 19);
            rbtnB.TabIndex = 1;
            rbtnB.TabStop = true;
            rbtnB.Text = "B";
            rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnA
            // 
            rbtnA.AutoSize = true;
            rbtnA.CausesValidation = false;
            rbtnA.Location = new Point(49, 22);
            rbtnA.Name = "rbtnA";
            rbtnA.Size = new Size(33, 19);
            rbtnA.TabIndex = 0;
            rbtnA.TabStop = true;
            rbtnA.Text = "A";
            rbtnA.UseVisualStyleBackColor = true;
            // 
            // grpType
            // 
            grpType.Controls.Add(rbtnNotConcerned);
            grpType.Controls.Add(rbtnNetwork);
            grpType.Controls.Add(rbtnLoopback);
            grpType.Controls.Add(rbtnBroadcast);
            grpType.Controls.Add(rbtnMulticast);
            grpType.Controls.Add(rbtnUnicast);
            grpType.Location = new Point(171, 138);
            grpType.Name = "grpType";
            grpType.Size = new Size(153, 196);
            grpType.TabIndex = 3;
            grpType.TabStop = false;
            grpType.Text = "Type";
            // 
            // rbtnNotConcerned
            // 
            rbtnNotConcerned.AutoSize = true;
            rbtnNotConcerned.Location = new Point(32, 147);
            rbtnNotConcerned.Name = "rbtnNotConcerned";
            rbtnNotConcerned.Size = new Size(100, 19);
            rbtnNotConcerned.TabIndex = 5;
            rbtnNotConcerned.TabStop = true;
            rbtnNotConcerned.Text = "Non concerné";
            rbtnNotConcerned.UseVisualStyleBackColor = true;
            // 
            // rbtnNetwork
            // 
            rbtnNetwork.AutoSize = true;
            rbtnNetwork.Location = new Point(32, 122);
            rbtnNetwork.Name = "rbtnNetwork";
            rbtnNetwork.Size = new Size(103, 19);
            rbtnNetwork.TabIndex = 4;
            rbtnNetwork.TabStop = true;
            rbtnNetwork.Text = "Adresse réseau";
            rbtnNetwork.UseVisualStyleBackColor = true;
            // 
            // rbtnLoopback
            // 
            rbtnLoopback.AutoSize = true;
            rbtnLoopback.Location = new Point(32, 97);
            rbtnLoopback.Name = "rbtnLoopback";
            rbtnLoopback.Size = new Size(77, 19);
            rbtnLoopback.TabIndex = 3;
            rbtnLoopback.TabStop = true;
            rbtnLoopback.Text = "LoopBack";
            rbtnLoopback.UseVisualStyleBackColor = true;
            // 
            // rbtnBroadcast
            // 
            rbtnBroadcast.AutoSize = true;
            rbtnBroadcast.Location = new Point(32, 72);
            rbtnBroadcast.Name = "rbtnBroadcast";
            rbtnBroadcast.Size = new Size(77, 19);
            rbtnBroadcast.TabIndex = 2;
            rbtnBroadcast.TabStop = true;
            rbtnBroadcast.Text = "Broadcast";
            rbtnBroadcast.UseVisualStyleBackColor = true;
            // 
            // rbtnMulticast
            // 
            rbtnMulticast.AutoSize = true;
            rbtnMulticast.Location = new Point(32, 47);
            rbtnMulticast.Name = "rbtnMulticast";
            rbtnMulticast.Size = new Size(74, 19);
            rbtnMulticast.TabIndex = 1;
            rbtnMulticast.TabStop = true;
            rbtnMulticast.Text = "Multicast";
            rbtnMulticast.UseVisualStyleBackColor = true;
            // 
            // rbtnUnicast
            // 
            rbtnUnicast.AutoSize = true;
            rbtnUnicast.Location = new Point(32, 22);
            rbtnUnicast.Name = "rbtnUnicast";
            rbtnUnicast.Size = new Size(64, 19);
            rbtnUnicast.TabIndex = 0;
            rbtnUnicast.TabStop = true;
            rbtnUnicast.Text = "Unicast";
            rbtnUnicast.UseVisualStyleBackColor = true;
            // 
            // grpMasque
            // 
            grpMasque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpMasque.Controls.Add(rbtnMFull);
            grpMasque.Controls.Add(rbtnMC);
            grpMasque.Controls.Add(rbtnMB);
            grpMasque.Controls.Add(rbtnMA);
            grpMasque.Controls.Add(rbtnMNotConcerned);
            grpMasque.Location = new Point(330, 138);
            grpMasque.Name = "grpMasque";
            grpMasque.Size = new Size(153, 196);
            grpMasque.TabIndex = 4;
            grpMasque.TabStop = false;
            grpMasque.Text = "Masque";
            // 
            // rbtnMFull
            // 
            rbtnMFull.AutoSize = true;
            rbtnMFull.Location = new Point(29, 122);
            rbtnMFull.Name = "rbtnMFull";
            rbtnMFull.Size = new Size(106, 19);
            rbtnMFull.TabIndex = 4;
            rbtnMFull.TabStop = true;
            rbtnMFull.Text = "255.255.255.255";
            rbtnMFull.UseVisualStyleBackColor = true;
            // 
            // rbtnMC
            // 
            rbtnMC.AutoSize = true;
            rbtnMC.Location = new Point(29, 97);
            rbtnMC.Name = "rbtnMC";
            rbtnMC.Size = new Size(94, 19);
            rbtnMC.TabIndex = 3;
            rbtnMC.TabStop = true;
            rbtnMC.Text = "255.255.255.0";
            rbtnMC.UseVisualStyleBackColor = true;
            // 
            // rbtnMB
            // 
            rbtnMB.AutoSize = true;
            rbtnMB.Location = new Point(29, 72);
            rbtnMB.Name = "rbtnMB";
            rbtnMB.Size = new Size(82, 19);
            rbtnMB.TabIndex = 2;
            rbtnMB.TabStop = true;
            rbtnMB.Text = "255.255.0.0";
            rbtnMB.UseVisualStyleBackColor = true;
            // 
            // rbtnMA
            // 
            rbtnMA.AutoSize = true;
            rbtnMA.Location = new Point(29, 47);
            rbtnMA.Name = "rbtnMA";
            rbtnMA.Size = new Size(70, 19);
            rbtnMA.TabIndex = 1;
            rbtnMA.TabStop = true;
            rbtnMA.Text = "255.0.0.0";
            rbtnMA.UseVisualStyleBackColor = true;
            // 
            // rbtnMNotConcerned
            // 
            rbtnMNotConcerned.AutoSize = true;
            rbtnMNotConcerned.Location = new Point(29, 22);
            rbtnMNotConcerned.Name = "rbtnMNotConcerned";
            rbtnMNotConcerned.Size = new Size(100, 19);
            rbtnMNotConcerned.TabIndex = 0;
            rbtnMNotConcerned.TabStop = true;
            rbtnMNotConcerned.Text = "Non concerné";
            rbtnMNotConcerned.UseVisualStyleBackColor = true;
            // 
            // grpAddress
            // 
            grpAddress.Controls.Add(label3);
            grpAddress.Controls.Add(label2);
            grpAddress.Controls.Add(label1);
            grpAddress.Controls.Add(lblBlock3);
            grpAddress.Controls.Add(lblBlock2);
            grpAddress.Controls.Add(lblBlock1);
            grpAddress.Controls.Add(lblBlock0);
            grpAddress.Location = new Point(10, 59);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(467, 70);
            grpAddress.TabIndex = 5;
            grpAddress.TabStop = false;
            grpAddress.Text = "Je décode cette adresse ...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(329, 19);
            label3.Name = "label3";
            label3.Size = new Size(27, 45);
            label3.TabIndex = 6;
            label3.Text = ".";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 19);
            label2.Name = "label2";
            label2.Size = new Size(27, 45);
            label2.TabIndex = 5;
            label2.Text = ".";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 19);
            label1.Name = "label1";
            label1.Size = new Size(27, 45);
            label1.TabIndex = 4;
            label1.Text = ".";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock3
            // 
            lblBlock3.BorderStyle = BorderStyle.Fixed3D;
            lblBlock3.Location = new Point(371, 19);
            lblBlock3.Name = "lblBlock3";
            lblBlock3.Size = new Size(60, 37);
            lblBlock3.TabIndex = 3;
            lblBlock3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock2
            // 
            lblBlock2.BorderStyle = BorderStyle.Fixed3D;
            lblBlock2.Location = new Point(254, 19);
            lblBlock2.Name = "lblBlock2";
            lblBlock2.Size = new Size(60, 37);
            lblBlock2.TabIndex = 2;
            lblBlock2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock1
            // 
            lblBlock1.BorderStyle = BorderStyle.Fixed3D;
            lblBlock1.Location = new Point(135, 19);
            lblBlock1.Name = "lblBlock1";
            lblBlock1.Size = new Size(60, 37);
            lblBlock1.TabIndex = 1;
            lblBlock1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock0
            // 
            lblBlock0.BorderStyle = BorderStyle.Fixed3D;
            lblBlock0.Location = new Point(24, 19);
            lblBlock0.Name = "lblBlock0";
            lblBlock0.Size = new Size(60, 37);
            lblBlock0.TabIndex = 0;
            lblBlock0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(12, 513);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 52);
            btnBack.TabIndex = 6;
            btnBack.Text = "&Retour";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStop.Location = new Point(160, 513);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(107, 52);
            btnStop.TabIndex = 7;
            btnStop.Text = "&Arrêter";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            btnAnswer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnswer.Enabled = false;
            btnAnswer.Location = new Point(273, 513);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(107, 52);
            btnAnswer.TabIndex = 8;
            btnAnswer.Text = "&J'ai répondu";
            btnAnswer.UseVisualStyleBackColor = true;
            // 
            // pnlDecodeAnswer
            // 
            pnlDecodeAnswer.Controls.Add(lblSolutionMasque);
            pnlDecodeAnswer.Controls.Add(lblSolutionType);
            pnlDecodeAnswer.Controls.Add(lblSolutionClass);
            pnlDecodeAnswer.Controls.Add(lblSolution);
            pnlDecodeAnswer.Location = new Point(12, 421);
            pnlDecodeAnswer.Name = "pnlDecodeAnswer";
            pnlDecodeAnswer.Size = new Size(476, 70);
            pnlDecodeAnswer.TabIndex = 10;
            // 
            // lblSolutionMasque
            // 
            lblSolutionMasque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSolutionMasque.BorderStyle = BorderStyle.Fixed3D;
            lblSolutionMasque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSolutionMasque.Location = new Point(318, 35);
            lblSolutionMasque.Name = "lblSolutionMasque";
            lblSolutionMasque.Size = new Size(153, 23);
            lblSolutionMasque.TabIndex = 11;
            lblSolutionMasque.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSolutionType
            // 
            lblSolutionType.BorderStyle = BorderStyle.Fixed3D;
            lblSolutionType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSolutionType.Location = new Point(159, 35);
            lblSolutionType.Name = "lblSolutionType";
            lblSolutionType.Size = new Size(153, 23);
            lblSolutionType.TabIndex = 11;
            lblSolutionType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSolutionClass
            // 
            lblSolutionClass.BorderStyle = BorderStyle.Fixed3D;
            lblSolutionClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSolutionClass.Location = new Point(0, 35);
            lblSolutionClass.Name = "lblSolutionClass";
            lblSolutionClass.Size = new Size(153, 23);
            lblSolutionClass.TabIndex = 11;
            lblSolutionClass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSolution
            // 
            lblSolution.AutoSize = true;
            lblSolution.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSolution.ForeColor = Color.IndianRed;
            lblSolution.Location = new Point(0, 0);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(123, 21);
            lblSolution.TabIndex = 10;
            lblSolution.Text = "La solution est ...";
            // 
            // grpPropose
            // 
            grpPropose.Controls.Add(tbxBlock3);
            grpPropose.Controls.Add(tbxBlock2);
            grpPropose.Controls.Add(tbxBlock1);
            grpPropose.Controls.Add(label4);
            grpPropose.Controls.Add(label5);
            grpPropose.Controls.Add(label6);
            grpPropose.Controls.Add(tbxBlock0);
            grpPropose.Location = new Point(12, 343);
            grpPropose.Name = "grpPropose";
            grpPropose.Size = new Size(476, 59);
            grpPropose.TabIndex = 11;
            grpPropose.TabStop = false;
            grpPropose.Text = "Je propose ...";
            // 
            // tbxBlock3
            // 
            tbxBlock3.Location = new Point(369, 23);
            tbxBlock3.Name = "tbxBlock3";
            tbxBlock3.Size = new Size(60, 23);
            tbxBlock3.TabIndex = 12;
            // 
            // tbxBlock2
            // 
            tbxBlock2.Location = new Point(252, 23);
            tbxBlock2.Name = "tbxBlock2";
            tbxBlock2.Size = new Size(60, 23);
            tbxBlock2.TabIndex = 11;
            // 
            // tbxBlock1
            // 
            tbxBlock1.Location = new Point(133, 22);
            tbxBlock1.Name = "tbxBlock1";
            tbxBlock1.Size = new Size(60, 23);
            tbxBlock1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(327, 1);
            label4.Name = "label4";
            label4.Size = new Size(27, 45);
            label4.TabIndex = 9;
            label4.Text = ".";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(209, 1);
            label5.Name = "label5";
            label5.Size = new Size(27, 45);
            label5.TabIndex = 8;
            label5.Text = ".";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 1);
            label6.Name = "label6";
            label6.Size = new Size(27, 45);
            label6.TabIndex = 7;
            label6.Text = ".";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxBlock0
            // 
            tbxBlock0.Location = new Point(22, 22);
            tbxBlock0.Name = "tbxBlock0";
            tbxBlock0.Size = new Size(60, 23);
            tbxBlock0.TabIndex = 0;
            // 
            // IP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 577);
            Controls.Add(grpPropose);
            Controls.Add(pnlDecodeAnswer);
            Controls.Add(btnAnswer);
            Controls.Add(btnStop);
            Controls.Add(btnBack);
            Controls.Add(grpAddress);
            Controls.Add(grpMasque);
            Controls.Add(grpType);
            Controls.Add(grpClasse);
            Controls.Add(lblError);
            Controls.Add(lblExercice);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IP";
            Text = "Les classes IP";
            FormClosed += Decode_FormClosed;
            Load += Decode_Load;
            grpClasse.ResumeLayout(false);
            grpClasse.PerformLayout();
            grpType.ResumeLayout(false);
            grpType.PerformLayout();
            grpMasque.ResumeLayout(false);
            grpMasque.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            pnlDecodeAnswer.ResumeLayout(false);
            pnlDecodeAnswer.PerformLayout();
            grpPropose.ResumeLayout(false);
            grpPropose.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblExercice;
        private Label lblError;
        private GroupBox grpClasse;
        private RadioButton rbtnE;
        private RadioButton rbtnD;
        private RadioButton rbtnC;
        private RadioButton rbtnB;
        private RadioButton rbtnA;
        private GroupBox grpType;
        private GroupBox grpMasque;
        private GroupBox grpAddress;
        private RadioButton rbtnNotConcerned;
        private RadioButton rbtnNetwork;
        private RadioButton rbtnLoopback;
        private RadioButton rbtnBroadcast;
        private RadioButton rbtnMulticast;
        private RadioButton rbtnUnicast;
        private RadioButton rbtnMB;
        private RadioButton rbtnMA;
        private RadioButton rbtnMNotConcerned;
        private RadioButton rbtnMFull;
        private RadioButton rbtnMC;
        private Button btnBack;
        private Button btnStop;
        private Button btnAnswer;
        private Label lblBlock0;
        private Label lblBlock1;
        private Label lblBlock2;
        private Label lblBlock3;
        private Panel pnlDecodeAnswer;
        private Label lblSolution;
        private Label lblSolutionClass;
        private Label lblSolutionType;
        private Label lblSolutionMasque;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpPropose;
        private TextBox tbxBlock3;
        private TextBox tbxBlock2;
        private TextBox tbxBlock1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxBlock0;
    }
}