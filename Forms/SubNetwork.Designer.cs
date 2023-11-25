namespace IPv4.Forms
{
    partial class SubNetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubNetwork));
            lblError = new Label();
            lblExercice = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblBlock3 = new Label();
            lblBlock2 = new Label();
            lblBlock1 = new Label();
            lblBlock0 = new Label();
            lblMask3 = new Label();
            lblMask2 = new Label();
            lblMask1 = new Label();
            lblMask0 = new Label();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblError.BorderStyle = BorderStyle.Fixed3D;
            lblError.Location = new Point(334, 5);
            lblError.Name = "lblError";
            lblError.Size = new Size(179, 33);
            lblError.TabIndex = 3;
            lblError.Text = "Nombre d'erreur(s) : 0";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExercice
            // 
            lblExercice.BorderStyle = BorderStyle.Fixed3D;
            lblExercice.Location = new Point(35, 9);
            lblExercice.Name = "lblExercice";
            lblExercice.Size = new Size(179, 33);
            lblExercice.TabIndex = 2;
            lblExercice.Text = "Nombre d'exercice(s) : 0";
            lblExercice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(418, 55);
            label3.Name = "label3";
            label3.Size = new Size(27, 45);
            label3.TabIndex = 13;
            label3.Text = ".";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 55);
            label2.Name = "label2";
            label2.Size = new Size(27, 45);
            label2.TabIndex = 12;
            label2.Text = ".";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(220, 55);
            label1.Name = "label1";
            label1.Size = new Size(27, 45);
            label1.TabIndex = 11;
            label1.Text = ".";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock3
            // 
            lblBlock3.BorderStyle = BorderStyle.Fixed3D;
            lblBlock3.Location = new Point(451, 63);
            lblBlock3.Name = "lblBlock3";
            lblBlock3.Size = new Size(60, 37);
            lblBlock3.TabIndex = 10;
            lblBlock3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock2
            // 
            lblBlock2.BorderStyle = BorderStyle.Fixed3D;
            lblBlock2.Location = new Point(352, 63);
            lblBlock2.Name = "lblBlock2";
            lblBlock2.Size = new Size(60, 37);
            lblBlock2.TabIndex = 9;
            lblBlock2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock1
            // 
            lblBlock1.BorderStyle = BorderStyle.Fixed3D;
            lblBlock1.Location = new Point(253, 63);
            lblBlock1.Name = "lblBlock1";
            lblBlock1.Size = new Size(60, 37);
            lblBlock1.TabIndex = 8;
            lblBlock1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock0
            // 
            lblBlock0.BorderStyle = BorderStyle.Fixed3D;
            lblBlock0.Location = new Point(154, 63);
            lblBlock0.Name = "lblBlock0";
            lblBlock0.Size = new Size(60, 37);
            lblBlock0.TabIndex = 7;
            lblBlock0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMask3
            // 
            lblMask3.BorderStyle = BorderStyle.Fixed3D;
            lblMask3.Location = new Point(451, 100);
            lblMask3.Name = "lblMask3";
            lblMask3.Size = new Size(60, 37);
            lblMask3.TabIndex = 17;
            lblMask3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMask2
            // 
            lblMask2.BorderStyle = BorderStyle.Fixed3D;
            lblMask2.Location = new Point(352, 100);
            lblMask2.Name = "lblMask2";
            lblMask2.Size = new Size(60, 37);
            lblMask2.TabIndex = 16;
            lblMask2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMask1
            // 
            lblMask1.BorderStyle = BorderStyle.Fixed3D;
            lblMask1.Location = new Point(253, 100);
            lblMask1.Name = "lblMask1";
            lblMask1.Size = new Size(60, 37);
            lblMask1.TabIndex = 15;
            lblMask1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMask0
            // 
            lblMask0.BorderStyle = BorderStyle.Fixed3D;
            lblMask0.Location = new Point(154, 100);
            lblMask0.Name = "lblMask0";
            lblMask0.Size = new Size(60, 37);
            lblMask0.TabIndex = 14;
            lblMask0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubNetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 494);
            Controls.Add(lblMask3);
            Controls.Add(lblMask2);
            Controls.Add(lblMask1);
            Controls.Add(lblMask0);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBlock3);
            Controls.Add(lblBlock2);
            Controls.Add(lblBlock1);
            Controls.Add(lblBlock0);
            Controls.Add(lblError);
            Controls.Add(lblExercice);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SubNetting";
            Text = "Les Sous-réseaux";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblError;
        private Label lblExercice;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblBlock3;
        private Label lblBlock2;
        private Label lblBlock1;
        private Label lblBlock0;
        private Label lblMask3;
        private Label lblMask2;
        private Label lblMask1;
        private Label lblMask0;
    }
}