namespace Forms
{
    partial class Pagina4
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
            lblBack = new Label();
            roundedPanelRes2 = new RoundedPanel();
            lblDescriereBox2 = new Label();
            labelTopBox2 = new Label();
            buttonNext1 = new CustomControls.RJControls.RJButton();
            labelTopBox1 = new Label();
            lblOS = new Label();
            roundedPanelRes1 = new RoundedPanel();
            lblDescriereBox1 = new Label();
            lblPagTitle = new Label();
            lblCaracteristici = new Label();
            lblCamera = new Label();
            lblResolutie = new Label();
            lblBuget = new Label();
            panelButoane = new Panel();
            piceExit = new PictureBox();
            roundedPanelRes2.SuspendLayout();
            roundedPanelRes1.SuspendLayout();
            panelButoane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piceExit).BeginInit();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Rubik", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblBack.ForeColor = Color.Black;
            lblBack.Location = new Point(783, 610);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(63, 19);
            lblBack.TabIndex = 25;
            lblBack.Text = "< Inapoi\r\n";
            lblBack.Click += lblBack_Click;
            lblBack.MouseEnter += lblBack_MouseEnter;
            lblBack.MouseLeave += lblBack_MouseLeave;
            // 
            // roundedPanelRes2
            // 
            roundedPanelRes2.BackColor = Color.White;
            roundedPanelRes2.BorderRadius = 30;
            roundedPanelRes2.Controls.Add(lblDescriereBox2);
            roundedPanelRes2.Controls.Add(labelTopBox2);
            roundedPanelRes2.ForeColor = Color.Black;
            roundedPanelRes2.Location = new Point(232, 30);
            roundedPanelRes2.Name = "roundedPanelRes2";
            roundedPanelRes2.Size = new Size(165, 165);
            roundedPanelRes2.TabIndex = 1;
            roundedPanelRes2.Paint += roundedPanel2_Paint;
            roundedPanelRes2.MouseClick += roundedPanelRes2_MouseClick;
            // 
            // lblDescriereBox2
            // 
            lblDescriereBox2.AutoSize = true;
            lblDescriereBox2.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriereBox2.Location = new Point(14, 93);
            lblDescriereBox2.Name = "lblDescriereBox2";
            lblDescriereBox2.Size = new Size(122, 60);
            lblDescriereBox2.TabIndex = 2;
            lblDescriereBox2.Text = "O rezolutie \r\nstandard este\r\nok pentru mine\r\n";
            // 
            // labelTopBox2
            // 
            labelTopBox2.AutoSize = true;
            labelTopBox2.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTopBox2.ForeColor = SystemColors.ControlDark;
            labelTopBox2.Location = new Point(25, 10);
            labelTopBox2.Name = "labelTopBox2";
            labelTopBox2.Size = new Size(26, 17);
            labelTopBox2.TabIndex = 1;
            labelTopBox2.Text = "NU";
            // 
            // buttonNext1
            // 
            buttonNext1.BackColor = Color.FromArgb(232, 236, 236);
            buttonNext1.BackgroundColor = Color.FromArgb(232, 236, 236);
            buttonNext1.BorderColor = Color.PaleVioletRed;
            buttonNext1.BorderRadius = 20;
            buttonNext1.BorderSize = 0;
            buttonNext1.FlatAppearance.BorderSize = 0;
            buttonNext1.FlatStyle = FlatStyle.Flat;
            buttonNext1.Font = new Font("Rubik Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext1.ForeColor = Color.White;
            buttonNext1.Location = new Point(1095, 600);
            buttonNext1.Name = "buttonNext1";
            buttonNext1.Size = new Size(113, 41);
            buttonNext1.TabIndex = 24;
            buttonNext1.Text = "Urmatorul";
            buttonNext1.TextColor = Color.White;
            buttonNext1.UseVisualStyleBackColor = false;
            buttonNext1.Click += buttonNext1_Click;
            // 
            // labelTopBox1
            // 
            labelTopBox1.AutoSize = true;
            labelTopBox1.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTopBox1.ForeColor = SystemColors.ControlDark;
            labelTopBox1.Location = new Point(17, 10);
            labelTopBox1.Name = "labelTopBox1";
            labelTopBox1.Size = new Size(26, 17);
            labelTopBox1.TabIndex = 0;
            labelTopBox1.Text = "DA";
            // 
            // lblOS
            // 
            lblOS.AutoSize = true;
            lblOS.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOS.Location = new Point(94, 21);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(80, 19);
            lblOS.TabIndex = 17;
            lblOS.Text = "1. Interese";
            // 
            // roundedPanelRes1
            // 
            roundedPanelRes1.BackColor = Color.White;
            roundedPanelRes1.BorderRadius = 30;
            roundedPanelRes1.Controls.Add(lblDescriereBox1);
            roundedPanelRes1.Controls.Add(labelTopBox1);
            roundedPanelRes1.ForeColor = Color.Black;
            roundedPanelRes1.Location = new Point(35, 30);
            roundedPanelRes1.Name = "roundedPanelRes1";
            roundedPanelRes1.Size = new Size(165, 165);
            roundedPanelRes1.TabIndex = 0;
            roundedPanelRes1.Paint += roundedPanel1_Paint;
            roundedPanelRes1.MouseClick += roundedPanelRes1_MouseClick;
            // 
            // lblDescriereBox1
            // 
            lblDescriereBox1.AutoSize = true;
            lblDescriereBox1.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriereBox1.ForeColor = Color.Black;
            lblDescriereBox1.Location = new Point(17, 93);
            lblDescriereBox1.Name = "lblDescriereBox1";
            lblDescriereBox1.Size = new Size(134, 60);
            lblDescriereBox1.TabIndex = 1;
            lblDescriereBox1.Text = "Vreau o rezolutie\r\nmare pentru \r\njocuri si video\r\n";
            // 
            // lblPagTitle
            // 
            lblPagTitle.AutoSize = true;
            lblPagTitle.Font = new Font("Rubik", 42F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagTitle.Location = new Point(62, 170);
            lblPagTitle.Name = "lblPagTitle";
            lblPagTitle.Size = new Size(608, 210);
            lblPagTitle.TabIndex = 22;
            lblPagTitle.Text = "Rezolutia displayului\r\ne importanta pentru\r\ntine?";
            // 
            // lblCaracteristici
            // 
            lblCaracteristici.AutoSize = true;
            lblCaracteristici.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristici.ForeColor = SystemColors.ControlDark;
            lblCaracteristici.Location = new Point(437, 21);
            lblCaracteristici.Name = "lblCaracteristici";
            lblCaracteristici.Size = new Size(120, 19);
            lblCaracteristici.TabIndex = 21;
            lblCaracteristici.Text = "5. Caracteristici";
            // 
            // lblCamera
            // 
            lblCamera.AutoSize = true;
            lblCamera.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera.ForeColor = SystemColors.ControlDark;
            lblCamera.Location = new Point(352, 21);
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(79, 19);
            lblCamera.TabIndex = 20;
            lblCamera.Text = "4. Camera";
            // 
            // lblResolutie
            // 
            lblResolutie.AutoSize = true;
            lblResolutie.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResolutie.ForeColor = Color.Black;
            lblResolutie.Location = new Point(254, 21);
            lblResolutie.Name = "lblResolutie";
            lblResolutie.Size = new Size(92, 19);
            lblResolutie.TabIndex = 19;
            lblResolutie.Text = "3. Resolutie";
            // 
            // lblBuget
            // 
            lblBuget.AutoSize = true;
            lblBuget.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuget.ForeColor = SystemColors.ControlText;
            lblBuget.Location = new Point(180, 21);
            lblBuget.Name = "lblBuget";
            lblBuget.Size = new Size(68, 19);
            lblBuget.TabIndex = 18;
            lblBuget.Text = "2. Buget";
            // 
            // panelButoane
            // 
            panelButoane.BackColor = Color.FromArgb(244, 252, 248);
            panelButoane.Controls.Add(roundedPanelRes2);
            panelButoane.Controls.Add(roundedPanelRes1);
            panelButoane.Location = new Point(773, 170);
            panelButoane.Name = "panelButoane";
            panelButoane.Size = new Size(435, 424);
            panelButoane.TabIndex = 23;
            // 
            // piceExit
            // 
            piceExit.Image = Properties.Resources._4177409791543238955_1281;
            piceExit.Location = new Point(1294, 21);
            piceExit.Name = "piceExit";
            piceExit.Size = new Size(19, 19);
            piceExit.TabIndex = 32;
            piceExit.TabStop = false;
            piceExit.Click += piceExit_Click;
            // 
            // Pagina4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 674);
            Controls.Add(piceExit);
            Controls.Add(lblBack);
            Controls.Add(buttonNext1);
            Controls.Add(lblOS);
            Controls.Add(lblPagTitle);
            Controls.Add(lblCaracteristici);
            Controls.Add(lblCamera);
            Controls.Add(lblResolutie);
            Controls.Add(lblBuget);
            Controls.Add(panelButoane);
            Name = "Pagina4";
            Text = "Pagina4";
            roundedPanelRes2.ResumeLayout(false);
            roundedPanelRes2.PerformLayout();
            roundedPanelRes1.ResumeLayout(false);
            roundedPanelRes1.PerformLayout();
            panelButoane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piceExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBack;
        private RoundedPanel roundedPanelRes2;
        private Label lblDescriereBox2;
        private Label labelTopBox2;
        private CustomControls.RJControls.RJButton buttonNext1;
        private Label labelTopBox1;
        private Label lblOS;
        private RoundedPanel roundedPanelRes1;
        private Label lblDescriereBox1;
        private Label lblPagTitle;
        private Label lblCaracteristici;
        private Label lblCamera;
        private Label lblResolutie;
        private Label lblBuget;
        private Panel panelButoane;
        private PictureBox piceExit;
    }
}