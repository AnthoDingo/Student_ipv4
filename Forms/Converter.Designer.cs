namespace IPv4.Forms
{
    partial class Converter
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
            btnIP2Int = new Button();
            tbxBlockInt0 = new TextBox();
            tbxBlockInt1 = new TextBox();
            tbxBlockInt2 = new TextBox();
            tbxBlockInt3 = new TextBox();
            tbxBlockBin3 = new TextBox();
            tbxBlockBin2 = new TextBox();
            tbxBlockBin1 = new TextBox();
            tbxBlockBin0 = new TextBox();
            tbxBin = new TextBox();
            tbxResult = new TextBox();
            btnInt2IP = new Button();
            tbxDec = new TextBox();
            tbxIPv4 = new TextBox();
            rtbxResult = new RichTextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnIP2Int
            // 
            btnIP2Int.Location = new Point(116, 77);
            btnIP2Int.Name = "btnIP2Int";
            btnIP2Int.Size = new Size(139, 23);
            btnIP2Int.TabIndex = 1;
            btnIP2Int.Text = "IPv4 vers Décimal";
            btnIP2Int.UseVisualStyleBackColor = true;
            btnIP2Int.Click += btnIP2Int_Click;
            // 
            // tbxBlockInt0
            // 
            tbxBlockInt0.BackColor = SystemColors.Window;
            tbxBlockInt0.Location = new Point(14, 112);
            tbxBlockInt0.Name = "tbxBlockInt0";
            tbxBlockInt0.ReadOnly = true;
            tbxBlockInt0.Size = new Size(81, 23);
            tbxBlockInt0.TabIndex = 2;
            tbxBlockInt0.TabStop = false;
            tbxBlockInt0.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockInt1
            // 
            tbxBlockInt1.BackColor = SystemColors.Window;
            tbxBlockInt1.Location = new Point(103, 112);
            tbxBlockInt1.Name = "tbxBlockInt1";
            tbxBlockInt1.ReadOnly = true;
            tbxBlockInt1.Size = new Size(81, 23);
            tbxBlockInt1.TabIndex = 3;
            tbxBlockInt1.TabStop = false;
            tbxBlockInt1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockInt2
            // 
            tbxBlockInt2.BackColor = SystemColors.Window;
            tbxBlockInt2.Location = new Point(190, 112);
            tbxBlockInt2.Name = "tbxBlockInt2";
            tbxBlockInt2.ReadOnly = true;
            tbxBlockInt2.Size = new Size(81, 23);
            tbxBlockInt2.TabIndex = 4;
            tbxBlockInt2.TabStop = false;
            tbxBlockInt2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockInt3
            // 
            tbxBlockInt3.BackColor = SystemColors.Window;
            tbxBlockInt3.Location = new Point(277, 112);
            tbxBlockInt3.Name = "tbxBlockInt3";
            tbxBlockInt3.ReadOnly = true;
            tbxBlockInt3.Size = new Size(81, 23);
            tbxBlockInt3.TabIndex = 5;
            tbxBlockInt3.TabStop = false;
            tbxBlockInt3.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockBin3
            // 
            tbxBlockBin3.BackColor = SystemColors.Window;
            tbxBlockBin3.Location = new Point(277, 141);
            tbxBlockBin3.Name = "tbxBlockBin3";
            tbxBlockBin3.ReadOnly = true;
            tbxBlockBin3.Size = new Size(81, 23);
            tbxBlockBin3.TabIndex = 9;
            tbxBlockBin3.TabStop = false;
            tbxBlockBin3.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockBin2
            // 
            tbxBlockBin2.BackColor = SystemColors.Window;
            tbxBlockBin2.Location = new Point(190, 141);
            tbxBlockBin2.Name = "tbxBlockBin2";
            tbxBlockBin2.ReadOnly = true;
            tbxBlockBin2.Size = new Size(81, 23);
            tbxBlockBin2.TabIndex = 8;
            tbxBlockBin2.TabStop = false;
            tbxBlockBin2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockBin1
            // 
            tbxBlockBin1.BackColor = SystemColors.Window;
            tbxBlockBin1.Location = new Point(103, 141);
            tbxBlockBin1.Name = "tbxBlockBin1";
            tbxBlockBin1.ReadOnly = true;
            tbxBlockBin1.Size = new Size(81, 23);
            tbxBlockBin1.TabIndex = 7;
            tbxBlockBin1.TabStop = false;
            tbxBlockBin1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBlockBin0
            // 
            tbxBlockBin0.BackColor = SystemColors.Window;
            tbxBlockBin0.Location = new Point(14, 141);
            tbxBlockBin0.Name = "tbxBlockBin0";
            tbxBlockBin0.ReadOnly = true;
            tbxBlockBin0.Size = new Size(81, 23);
            tbxBlockBin0.TabIndex = 6;
            tbxBlockBin0.TabStop = false;
            tbxBlockBin0.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBin
            // 
            tbxBin.BackColor = SystemColors.Window;
            tbxBin.Location = new Point(14, 170);
            tbxBin.Name = "tbxBin";
            tbxBin.ReadOnly = true;
            tbxBin.Size = new Size(344, 23);
            tbxBin.TabIndex = 10;
            tbxBin.TabStop = false;
            tbxBin.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxResult
            // 
            tbxResult.BackColor = SystemColors.Window;
            tbxResult.Location = new Point(14, 199);
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.Size = new Size(344, 23);
            tbxResult.TabIndex = 11;
            tbxResult.TabStop = false;
            tbxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // btnInt2IP
            // 
            btnInt2IP.Enabled = false;
            btnInt2IP.Location = new Point(119, 245);
            btnInt2IP.Name = "btnInt2IP";
            btnInt2IP.Size = new Size(139, 23);
            btnInt2IP.TabIndex = 12;
            btnInt2IP.Text = "IPv4 vers Décimal";
            btnInt2IP.UseVisualStyleBackColor = true;
            btnInt2IP.Click += btnInt2IP_Click;
            // 
            // tbxDec
            // 
            tbxDec.Enabled = false;
            tbxDec.Location = new Point(119, 274);
            tbxDec.Name = "tbxDec";
            tbxDec.Size = new Size(136, 23);
            tbxDec.TabIndex = 13;
            tbxDec.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxIPv4
            // 
            tbxIPv4.Location = new Point(116, 41);
            tbxIPv4.Name = "tbxIPv4";
            tbxIPv4.Size = new Size(139, 23);
            tbxIPv4.TabIndex = 0;
            tbxIPv4.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbxResult
            // 
            rtbxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbxResult.BackColor = SystemColors.Window;
            rtbxResult.Location = new Point(12, 344);
            rtbxResult.Name = "rtbxResult";
            rtbxResult.ReadOnly = true;
            rtbxResult.Size = new Size(352, 113);
            rtbxResult.TabIndex = 2;
            rtbxResult.Text = "";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(165, 315);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 15);
            lblResult.TabIndex = 16;
            lblResult.Text = "Résultat";
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 469);
            Controls.Add(lblResult);
            Controls.Add(rtbxResult);
            Controls.Add(tbxIPv4);
            Controls.Add(tbxDec);
            Controls.Add(btnInt2IP);
            Controls.Add(tbxResult);
            Controls.Add(tbxBin);
            Controls.Add(tbxBlockBin3);
            Controls.Add(tbxBlockBin2);
            Controls.Add(tbxBlockBin1);
            Controls.Add(tbxBlockBin0);
            Controls.Add(tbxBlockInt3);
            Controls.Add(tbxBlockInt2);
            Controls.Add(tbxBlockInt1);
            Controls.Add(tbxBlockInt0);
            Controls.Add(btnIP2Int);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Converter";
            Text = "Calculatrice IPv4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIP2Int;
        private TextBox tbxBlockInt0;
        private TextBox tbxBlockInt1;
        private TextBox tbxBlockInt2;
        private TextBox tbxBlockInt3;
        private TextBox tbxBlockBin3;
        private TextBox tbxBlockBin2;
        private TextBox tbxBlockBin1;
        private TextBox tbxBlockBin0;
        private TextBox tbxBin;
        private TextBox tbxResult;
        private Button btnInt2IP;
        private TextBox tbxDec;
        private TextBox tbxIPv4;
        private RichTextBox rtbxResult;
        private Label lblResult;
    }
}