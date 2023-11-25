namespace IPv4.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            grpExercices = new GroupBox();
            rbtnTable = new RadioButton();
            rbtnNetworkPropose = new RadioButton();
            rbtnSubNetwork = new RadioButton();
            rbtnPropose = new RadioButton();
            rbtnDecode = new RadioButton();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            btnTraining = new Button();
            btnExam = new Button();
            btnCalculator = new Button();
            btnSettings = new Button();
            grpExercices.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpExercices
            // 
            grpExercices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpExercices.Controls.Add(rbtnTable);
            grpExercices.Controls.Add(rbtnNetworkPropose);
            grpExercices.Controls.Add(rbtnSubNetwork);
            grpExercices.Controls.Add(rbtnPropose);
            grpExercices.Controls.Add(rbtnDecode);
            grpExercices.Location = new Point(12, 27);
            grpExercices.Name = "grpExercices";
            grpExercices.Size = new Size(254, 250);
            grpExercices.TabIndex = 0;
            grpExercices.TabStop = false;
            grpExercices.Text = "Exercices";
            // 
            // rbtnTable
            // 
            rbtnTable.AutoSize = true;
            rbtnTable.Location = new Point(21, 134);
            rbtnTable.Name = "rbtnTable";
            rbtnTable.Size = new Size(131, 19);
            rbtnTable.TabIndex = 4;
            rbtnTable.TabStop = true;
            rbtnTable.Text = "Tableau à compléter";
            rbtnTable.UseVisualStyleBackColor = true;
            rbtnTable.Visible = false;
            // 
            // rbtnNetworkPropose
            // 
            rbtnNetworkPropose.AutoSize = true;
            rbtnNetworkPropose.Location = new Point(21, 109);
            rbtnNetworkPropose.Name = "rbtnNetworkPropose";
            rbtnNetworkPropose.Size = new Size(152, 19);
            rbtnNetworkPropose.TabIndex = 3;
            rbtnNetworkPropose.TabStop = true;
            rbtnNetworkPropose.Text = "Proposer un SUR-réseau";
            rbtnNetworkPropose.UseVisualStyleBackColor = true;
            rbtnNetworkPropose.Visible = false;
            // 
            // rbtnSubNetwork
            // 
            rbtnSubNetwork.AutoSize = true;
            rbtnSubNetwork.Location = new Point(21, 84);
            rbtnSubNetwork.Name = "rbtnSubNetwork";
            rbtnSubNetwork.Size = new Size(152, 19);
            rbtnSubNetwork.TabIndex = 2;
            rbtnSubNetwork.TabStop = true;
            rbtnSubNetwork.Text = "Décoder un sous-réseau";
            rbtnSubNetwork.UseVisualStyleBackColor = true;
            rbtnSubNetwork.Visible = false;
            // 
            // rbtnPropose
            // 
            rbtnPropose.AutoSize = true;
            rbtnPropose.Location = new Point(21, 59);
            rbtnPropose.Name = "rbtnPropose";
            rbtnPropose.Size = new Size(150, 19);
            rbtnPropose.TabIndex = 1;
            rbtnPropose.TabStop = true;
            rbtnPropose.Text = "Proposer une adresse IP";
            rbtnPropose.UseVisualStyleBackColor = true;
            // 
            // rbtnDecode
            // 
            rbtnDecode.AutoSize = true;
            rbtnDecode.Location = new Point(21, 34);
            rbtnDecode.Name = "rbtnDecode";
            rbtnDecode.Size = new Size(147, 19);
            rbtnDecode.TabIndex = 0;
            rbtnDecode.TabStop = true;
            rbtnDecode.Text = "Décoder une adresse IP";
            rbtnDecode.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(462, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem, githubToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(122, 22);
            aProposToolStripMenuItem.Text = "A Propos";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(122, 22);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // btnTraining
            // 
            btnTraining.Location = new Point(283, 71);
            btnTraining.Name = "btnTraining";
            btnTraining.Size = new Size(167, 34);
            btnTraining.TabIndex = 2;
            btnTraining.Text = "&Entraînement";
            btnTraining.UseVisualStyleBackColor = true;
            btnTraining.Click += btnTraining_Click;
            // 
            // btnExam
            // 
            btnExam.Location = new Point(283, 111);
            btnExam.Name = "btnExam";
            btnExam.Size = new Size(167, 34);
            btnExam.TabIndex = 3;
            btnExam.Text = "&Devoir";
            btnExam.UseVisualStyleBackColor = true;
            btnExam.Click += btnExam_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(283, 151);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(167, 56);
            btnCalculator.TabIndex = 4;
            btnCalculator.Text = "Décimale pointée <-> Décimale (32 bits)";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSettings.BackgroundImage = Properties.Resources.settings1;
            btnSettings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSettings.Location = new Point(410, 240);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(40, 40);
            btnSettings.TabIndex = 5;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Visible = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 289);
            Controls.Add(btnSettings);
            Controls.Add(btnCalculator);
            Controls.Add(btnExam);
            Controls.Add(btnTraining);
            Controls.Add(grpExercices);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adressage IP & sous-réseaux";
            grpExercices.ResumeLayout(false);
            grpExercices.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpExercices;
        private RadioButton rbtnTable;
        private RadioButton rbtnNetworkPropose;
        private RadioButton rbtnSubNetwork;
        private RadioButton rbtnPropose;
        private RadioButton rbtnDecode;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private Button btnTraining;
        private Button btnExam;
        private Button btnCalculator;
        private Button btnSettings;
    }
}