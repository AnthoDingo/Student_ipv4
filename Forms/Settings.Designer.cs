namespace IPv4.Forms
{
    partial class Settings
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
            btnSave = new Button();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            lblNumber = new Label();
            numExercices = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numExercices).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(242, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Enregistrer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 19);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mot de passe Devoir";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(132, 16);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(177, 23);
            tbxPassword.TabIndex = 2;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(12, 72);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(88, 15);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Nbr d'Exercices";
            // 
            // numExercices
            // 
            numExercices.Location = new Point(132, 70);
            numExercices.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numExercices.Name = "numExercices";
            numExercices.Size = new Size(74, 23);
            numExercices.TabIndex = 4;
            numExercices.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 152);
            Controls.Add(numExercices);
            Controls.Add(lblNumber);
            Controls.Add(tbxPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Paramètres";
            ((System.ComponentModel.ISupportInitialize)numExercices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblPassword;
        private TextBox tbxPassword;
        private Label lblNumber;
        private NumericUpDown numExercices;
    }
}