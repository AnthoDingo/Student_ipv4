namespace IPv4.Forms
{
    partial class Decode
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
            grpType = new GroupBox();
            grpMasque = new GroupBox();
            rbtnA = new RadioButton();
            rbtnB = new RadioButton();
            rbtnC = new RadioButton();
            rbtnD = new RadioButton();
            rbtnE = new RadioButton();
            rbtnReserved = new RadioButton();
            grpAddress = new GroupBox();
            grpClasse.SuspendLayout();
            SuspendLayout();
            // 
            // lblExercice
            // 
            lblExercice.BorderStyle = BorderStyle.Fixed3D;
            lblExercice.Location = new Point(10, 13);
            lblExercice.Name = "lblExercice";
            lblExercice.Size = new Size(179, 33);
            lblExercice.TabIndex = 0;
            lblExercice.Text = "Nombre d'exercice(s) :";
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
            lblError.Text = "Nombre d'erreur(s) :";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpClasse
            // 
            grpClasse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpClasse.Controls.Add(rbtnReserved);
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
            // grpType
            // 
            grpType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpType.Location = new Point(171, 138);
            grpType.Name = "grpType";
            grpType.Size = new Size(153, 196);
            grpType.TabIndex = 3;
            grpType.TabStop = false;
            grpType.Text = "Type";
            // 
            // grpMasque
            // 
            grpMasque.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grpMasque.Location = new Point(330, 138);
            grpMasque.Name = "grpMasque";
            grpMasque.Size = new Size(153, 196);
            grpMasque.TabIndex = 4;
            grpMasque.TabStop = false;
            grpMasque.Text = "Masque";
            // 
            // rbtnA
            // 
            rbtnA.AutoSize = true;
            rbtnA.Location = new Point(49, 22);
            rbtnA.Name = "rbtnA";
            rbtnA.Size = new Size(33, 19);
            rbtnA.TabIndex = 0;
            rbtnA.TabStop = true;
            rbtnA.Text = "A";
            rbtnA.UseVisualStyleBackColor = true;
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
            // rbtnReserved
            // 
            rbtnReserved.AutoSize = true;
            rbtnReserved.Location = new Point(48, 147);
            rbtnReserved.Name = "rbtnReserved";
            rbtnReserved.Size = new Size(83, 19);
            rbtnReserved.TabIndex = 5;
            rbtnReserved.TabStop = true;
            rbtnReserved.Text = "Réservée ...";
            rbtnReserved.UseVisualStyleBackColor = true;
            // 
            // grpAddress
            // 
            grpAddress.Location = new Point(21, 55);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(467, 70);
            grpAddress.TabIndex = 5;
            grpAddress.TabStop = false;
            grpAddress.Text = "Je décode cette adresse ...";
            // 
            // Decode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 456);
            Controls.Add(grpAddress);
            Controls.Add(grpMasque);
            Controls.Add(grpType);
            Controls.Add(grpClasse);
            Controls.Add(lblError);
            Controls.Add(lblExercice);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Decode";
            Text = "Decode";
            Load += Decode_Load;
            grpClasse.ResumeLayout(false);
            grpClasse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblExercice;
        private Label lblError;
        private GroupBox grpClasse;
        private RadioButton rbtnReserved;
        private RadioButton rbtnE;
        private RadioButton rbtnD;
        private RadioButton rbtnC;
        private RadioButton rbtnB;
        private RadioButton rbtnA;
        private GroupBox grpType;
        private GroupBox grpMasque;
        private GroupBox grpAddress;
    }
}