namespace Forms
{
    partial class Pagina5
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
            lblPagTitle = new Label();
            panelButoane = new Panel();
            roundedPanelCamera3 = new RoundedPanel();
            lblCamera3 = new Label();
            label2 = new Label();
            roundedPanelCamera2 = new RoundedPanel();
            lblCamera2 = new Label();
            labelTopBox2 = new Label();
            roundedPanelCamera1 = new RoundedPanel();
            lblCamera1 = new Label();
            labelTopBox1 = new Label();
            lblOS = new Label();
            lblCaracteristici = new Label();
            lblCamera = new Label();
            lblResolutie = new Label();
            lblBuget = new Label();
            lblBack = new Label();
            buttonNext1 = new CustomControls.RJControls.RJButton();
            piceExit = new PictureBox();
            panelButoane.SuspendLayout();
            roundedPanelCamera3.SuspendLayout();
            roundedPanelCamera2.SuspendLayout();
            roundedPanelCamera1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piceExit).BeginInit();
            SuspendLayout();
            // 
            // lblPagTitle
            // 
            lblPagTitle.AutoSize = true;
            lblPagTitle.Font = new Font("Rubik", 42F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagTitle.Location = new Point(62, 170);
            lblPagTitle.Name = "lblPagTitle";
            lblPagTitle.Size = new Size(621, 210);
            lblPagTitle.TabIndex = 23;
            lblPagTitle.Text = "Ok. Calitatea camerei\r\ne importanta pentru\r\ntine?";
            // 
            // panelButoane
            // 
            panelButoane.BackColor = Color.FromArgb(244, 252, 248);
            panelButoane.Controls.Add(roundedPanelCamera3);
            panelButoane.Controls.Add(roundedPanelCamera2);
            panelButoane.Controls.Add(roundedPanelCamera1);
            panelButoane.Location = new Point(773, 170);
            panelButoane.Name = "panelButoane";
            panelButoane.Size = new Size(435, 424);
            panelButoane.TabIndex = 24;
            // 
            // roundedPanelCamera3
            // 
            roundedPanelCamera3.BackColor = Color.White;
            roundedPanelCamera3.BorderRadius = 30;
            roundedPanelCamera3.Controls.Add(lblCamera3);
            roundedPanelCamera3.Controls.Add(label2);
            roundedPanelCamera3.ForeColor = Color.Black;
            roundedPanelCamera3.Location = new Point(35, 223);
            roundedPanelCamera3.Name = "roundedPanelCamera3";
            roundedPanelCamera3.Size = new Size(165, 165);
            roundedPanelCamera3.TabIndex = 2;
            roundedPanelCamera3.MouseClick += roundedPanelCamera3_MouseClick;
            // 
            // lblCamera3
            // 
            lblCamera3.AutoSize = true;
            lblCamera3.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera3.ForeColor = Color.Black;
            lblCamera3.Location = new Point(17, 93);
            lblCamera3.Name = "lblCamera3";
            lblCamera3.Size = new Size(127, 60);
            lblCamera3.TabIndex = 1;
            lblCamera3.Text = "Camera nu este\r\nun importanta\r\npentru mine\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(17, 10);
            label2.Name = "label2";
            label2.Size = new Size(26, 17);
            label2.TabIndex = 0;
            label2.Text = "NU";
            // 
            // roundedPanelCamera2
            // 
            roundedPanelCamera2.BackColor = Color.White;
            roundedPanelCamera2.BorderRadius = 30;
            roundedPanelCamera2.Controls.Add(lblCamera2);
            roundedPanelCamera2.Controls.Add(labelTopBox2);
            roundedPanelCamera2.ForeColor = Color.Black;
            roundedPanelCamera2.Location = new Point(232, 30);
            roundedPanelCamera2.Name = "roundedPanelCamera2";
            roundedPanelCamera2.Size = new Size(165, 165);
            roundedPanelCamera2.TabIndex = 1;
            roundedPanelCamera2.MouseClick += roundedPanelCamera2_MouseClick;
            // 
            // lblCamera2
            // 
            lblCamera2.AutoSize = true;
            lblCamera2.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera2.Location = new Point(14, 93);
            lblCamera2.Name = "lblCamera2";
            lblCamera2.Size = new Size(123, 40);
            lblCamera2.TabIndex = 2;
            lblCamera2.Text = "O camera buna\r\nnu ar incurca\r\n";
            // 
            // labelTopBox2
            // 
            labelTopBox2.AutoSize = true;
            labelTopBox2.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTopBox2.ForeColor = SystemColors.ControlDark;
            labelTopBox2.Location = new Point(25, 10);
            labelTopBox2.Name = "labelTopBox2";
            labelTopBox2.Size = new Size(47, 17);
            labelTopBox2.TabIndex = 1;
            labelTopBox2.Text = "SO-SO";
            // 
            // roundedPanelCamera1
            // 
            roundedPanelCamera1.BackColor = Color.White;
            roundedPanelCamera1.BorderRadius = 30;
            roundedPanelCamera1.Controls.Add(lblCamera1);
            roundedPanelCamera1.Controls.Add(labelTopBox1);
            roundedPanelCamera1.ForeColor = Color.Black;
            roundedPanelCamera1.Location = new Point(35, 30);
            roundedPanelCamera1.Name = "roundedPanelCamera1";
            roundedPanelCamera1.Size = new Size(165, 165);
            roundedPanelCamera1.TabIndex = 0;
            roundedPanelCamera1.MouseClick += roundedPanelCamera1_MouseClick;
            // 
            // lblCamera1
            // 
            lblCamera1.AutoSize = true;
            lblCamera1.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera1.ForeColor = Color.Black;
            lblCamera1.Location = new Point(17, 93);
            lblCamera1.Name = "lblCamera1";
            lblCamera1.Size = new Size(121, 60);
            lblCamera1.TabIndex = 1;
            lblCamera1.Text = "Iti place sa faci\r\npoze de inalta\r\ncalitate?";
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
            lblOS.TabIndex = 25;
            lblOS.Text = "1. Interese";
            // 
            // lblCaracteristici
            // 
            lblCaracteristici.AutoSize = true;
            lblCaracteristici.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristici.ForeColor = SystemColors.ControlDark;
            lblCaracteristici.Location = new Point(437, 20);
            lblCaracteristici.Name = "lblCaracteristici";
            lblCaracteristici.Size = new Size(120, 19);
            lblCaracteristici.TabIndex = 29;
            lblCaracteristici.Text = "5. Caracteristici";
            // 
            // lblCamera
            // 
            lblCamera.AutoSize = true;
            lblCamera.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera.ForeColor = Color.Black;
            lblCamera.Location = new Point(352, 20);
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(79, 19);
            lblCamera.TabIndex = 28;
            lblCamera.Text = "4. Camera";
            // 
            // lblResolutie
            // 
            lblResolutie.AutoSize = true;
            lblResolutie.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResolutie.ForeColor = Color.Black;
            lblResolutie.Location = new Point(254, 20);
            lblResolutie.Name = "lblResolutie";
            lblResolutie.Size = new Size(92, 19);
            lblResolutie.TabIndex = 27;
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
            lblBuget.TabIndex = 26;
            lblBuget.Text = "2. Buget";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Rubik", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblBack.ForeColor = Color.Black;
            lblBack.Location = new Point(783, 610);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(63, 19);
            lblBack.TabIndex = 26;
            lblBack.Text = "< Inapoi\r\n";
            lblBack.Click += lblBack_Click;
            lblBack.MouseEnter += lblBack_MouseEnter;
            lblBack.MouseLeave += lblBack_MouseLeave;
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
            buttonNext1.TabIndex = 30;
            buttonNext1.Text = "Urmatorul";
            buttonNext1.TextColor = Color.White;
            buttonNext1.UseVisualStyleBackColor = false;
            buttonNext1.Click += buttonNext1_Click;
            // 
            // piceExit
            // 
            piceExit.Image = Properties.Resources._4177409791543238955_1281;
            piceExit.Location = new Point(1294, 21);
            piceExit.Name = "piceExit";
            piceExit.Size = new Size(19, 19);
            piceExit.TabIndex = 31;
            piceExit.TabStop = false;
            piceExit.Click += piceExit_Click;
            // 
            // Pagina5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 674);
            Controls.Add(piceExit);
            Controls.Add(buttonNext1);
            Controls.Add(lblBack);
            Controls.Add(lblOS);
            Controls.Add(lblCaracteristici);
            Controls.Add(lblCamera);
            Controls.Add(lblResolutie);
            Controls.Add(lblBuget);
            Controls.Add(panelButoane);
            Controls.Add(lblPagTitle);
            Name = "Pagina5";
            Text = "Pagina5";
            Load += Pagina5_Load;
            panelButoane.ResumeLayout(false);
            roundedPanelCamera3.ResumeLayout(false);
            roundedPanelCamera3.PerformLayout();
            roundedPanelCamera2.ResumeLayout(false);
            roundedPanelCamera2.PerformLayout();
            roundedPanelCamera1.ResumeLayout(false);
            roundedPanelCamera1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piceExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagTitle;
        private Panel panelButoane;
        private RoundedPanel roundedPanelCamera2;
        private Label lblCamera2;
        private Label labelTopBox2;
        private RoundedPanel roundedPanelCamera1;
        private Label lblCamera1;
        private Label labelTopBox1;
        private Label lblOS;
        private Label lblCaracteristici;
        private Label lblCamera;
        private Label lblResolutie;
        private Label lblBuget;
        private RoundedPanel roundedPanelCamera3;
        private Label lblCamera3;
        private Label label2;
        private Label lblBack;
        private CustomControls.RJControls.RJButton buttonNext1;
        private PictureBox piceExit;
    }
}