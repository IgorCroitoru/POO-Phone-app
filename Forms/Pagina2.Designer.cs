namespace Forms
{
    partial class Pagina2
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
            lblOS = new Label();
            lblBuget = new Label();
            lblResolutie = new Label();
            lblCamera = new Label();
            lblCaracteristici = new Label();
            lblPag1Title = new Label();
            panelButoane = new Panel();
            roundedPanelMedia = new RoundedPanel();
            lblMedia = new Label();
            lblTopBox3 = new Label();
            roundedPanelFotografie = new RoundedPanel();
            lblFotografie = new Label();
            labelTopBox2 = new Label();
            roundedPanelDivertisment = new RoundedPanel();
            lblDivertisment = new Label();
            labelTopBox1 = new Label();
            buttonNext1 = new CustomControls.RJControls.RJButton();
            piceExit = new PictureBox();
            panelButoane.SuspendLayout();
            roundedPanelMedia.SuspendLayout();
            roundedPanelFotografie.SuspendLayout();
            roundedPanelDivertisment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piceExit).BeginInit();
            SuspendLayout();
            // 
            // lblOS
            // 
            lblOS.AutoSize = true;
            lblOS.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOS.Location = new Point(94, 21);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(80, 19);
            lblOS.TabIndex = 0;
            lblOS.Text = "1. Interese";
            lblOS.Click += lblOS_Click;
            // 
            // lblBuget
            // 
            lblBuget.AutoSize = true;
            lblBuget.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuget.ForeColor = SystemColors.ControlDark;
            lblBuget.Location = new Point(180, 21);
            lblBuget.Name = "lblBuget";
            lblBuget.Size = new Size(68, 19);
            lblBuget.TabIndex = 1;
            lblBuget.Text = "2. Buget";
            lblBuget.Click += lblBuget_Click;
            // 
            // lblResolutie
            // 
            lblResolutie.AutoSize = true;
            lblResolutie.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResolutie.ForeColor = SystemColors.ControlDark;
            lblResolutie.Location = new Point(254, 21);
            lblResolutie.Name = "lblResolutie";
            lblResolutie.Size = new Size(92, 19);
            lblResolutie.TabIndex = 2;
            lblResolutie.Text = "3. Resolutie";
            lblResolutie.Click += lblResolutie_Click;
            // 
            // lblCamera
            // 
            lblCamera.AutoSize = true;
            lblCamera.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera.ForeColor = SystemColors.ControlDark;
            lblCamera.Location = new Point(352, 21);
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(79, 19);
            lblCamera.TabIndex = 3;
            lblCamera.Text = "4. Camera";
            lblCamera.Click += lblCamera_Click;
            // 
            // lblCaracteristici
            // 
            lblCaracteristici.AutoSize = true;
            lblCaracteristici.Font = new Font("Rubik", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteristici.ForeColor = SystemColors.ControlDark;
            lblCaracteristici.Location = new Point(437, 21);
            lblCaracteristici.Name = "lblCaracteristici";
            lblCaracteristici.Size = new Size(120, 19);
            lblCaracteristici.TabIndex = 4;
            lblCaracteristici.Text = "5. Caracteristici";
            lblCaracteristici.Click += lblCaracteristici_Click;
            // 
            // lblPag1Title
            // 
            lblPag1Title.AutoSize = true;
            lblPag1Title.Font = new Font("Rubik", 42F, FontStyle.Bold, GraphicsUnit.Point);
            lblPag1Title.Location = new Point(62, 170);
            lblPag1Title.Name = "lblPag1Title";
            lblPag1Title.Size = new Size(625, 140);
            lblPag1Title.TabIndex = 5;
            lblPag1Title.Text = "Care sunt prioritatile \r\ntale principale?";
            lblPag1Title.Click += lblPag1Title_Click;
            // 
            // panelButoane
            // 
            panelButoane.BackColor = Color.FromArgb(244, 252, 248);
            panelButoane.Controls.Add(roundedPanelMedia);
            panelButoane.Controls.Add(roundedPanelFotografie);
            panelButoane.Controls.Add(roundedPanelDivertisment);
            panelButoane.Location = new Point(773, 170);
            panelButoane.Name = "panelButoane";
            panelButoane.Size = new Size(435, 424);
            panelButoane.TabIndex = 6;
            panelButoane.Paint += panelButoane_Paint;
            // 
            // roundedPanelMedia
            // 
            roundedPanelMedia.BackColor = Color.White;
            roundedPanelMedia.BorderRadius = 30;
            roundedPanelMedia.Controls.Add(lblMedia);
            roundedPanelMedia.Controls.Add(lblTopBox3);
            roundedPanelMedia.ForeColor = Color.Black;
            roundedPanelMedia.Location = new Point(35, 223);
            roundedPanelMedia.Name = "roundedPanelMedia";
            roundedPanelMedia.Size = new Size(165, 165);
            roundedPanelMedia.TabIndex = 1;
            roundedPanelMedia.MouseClick += roundedPanelMedia_MouseClick;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedia.Location = new Point(20, 112);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(114, 40);
            lblMedia.TabIndex = 4;
            lblMedia.Text = "Conectare cu \r\naltii";
            lblMedia.Click += lblDescriereBox3_Click;
            // 
            // lblTopBox3
            // 
            lblTopBox3.AutoSize = true;
            lblTopBox3.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopBox3.ForeColor = SystemColors.ControlDark;
            lblTopBox3.Location = new Point(17, 16);
            lblTopBox3.Name = "lblTopBox3";
            lblTopBox3.Size = new Size(99, 17);
            lblTopBox3.TabIndex = 3;
            lblTopBox3.Text = "SOCIAL MEDIA";
            // 
            // roundedPanelFotografie
            // 
            roundedPanelFotografie.BackColor = Color.White;
            roundedPanelFotografie.BorderRadius = 30;
            roundedPanelFotografie.Controls.Add(lblFotografie);
            roundedPanelFotografie.Controls.Add(labelTopBox2);
            roundedPanelFotografie.ForeColor = Color.Black;
            roundedPanelFotografie.Location = new Point(232, 30);
            roundedPanelFotografie.Name = "roundedPanelFotografie";
            roundedPanelFotografie.Size = new Size(165, 165);
            roundedPanelFotografie.TabIndex = 1;
            roundedPanelFotografie.MouseClick += roundedPanelFotografie_MouseClick;
            // 
            // lblFotografie
            // 
            lblFotografie.AutoSize = true;
            lblFotografie.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFotografie.Location = new Point(25, 114);
            lblFotografie.Name = "lblFotografie";
            lblFotografie.Size = new Size(101, 20);
            lblFotografie.TabIndex = 2;
            lblFotografie.Text = "Video si foto";
            // 
            // labelTopBox2
            // 
            labelTopBox2.AutoSize = true;
            labelTopBox2.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTopBox2.ForeColor = SystemColors.ControlDark;
            labelTopBox2.Location = new Point(25, 10);
            labelTopBox2.Name = "labelTopBox2";
            labelTopBox2.Size = new Size(87, 17);
            labelTopBox2.TabIndex = 1;
            labelTopBox2.Text = "FOTOGRAFIE";
            // 
            // roundedPanelDivertisment
            // 
            roundedPanelDivertisment.BackColor = Color.White;
            roundedPanelDivertisment.BorderRadius = 30;
            roundedPanelDivertisment.Controls.Add(lblDivertisment);
            roundedPanelDivertisment.Controls.Add(labelTopBox1);
            roundedPanelDivertisment.ForeColor = Color.Black;
            roundedPanelDivertisment.Location = new Point(35, 30);
            roundedPanelDivertisment.Name = "roundedPanelDivertisment";
            roundedPanelDivertisment.Size = new Size(165, 165);
            roundedPanelDivertisment.TabIndex = 0;
            roundedPanelDivertisment.MouseClick += roundedPanelDivertisment_MouseClick;
            // 
            // lblDivertisment
            // 
            lblDivertisment.AutoSize = true;
            lblDivertisment.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDivertisment.ForeColor = Color.Black;
            lblDivertisment.Location = new Point(17, 114);
            lblDivertisment.Name = "lblDivertisment";
            lblDivertisment.Size = new Size(114, 40);
            lblDivertisment.TabIndex = 1;
            lblDivertisment.Text = "Videoclipuri si\r\njocuri";
            lblDivertisment.Click += llblDescriereBox_Click;
            // 
            // labelTopBox1
            // 
            labelTopBox1.AutoSize = true;
            labelTopBox1.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTopBox1.ForeColor = SystemColors.ControlDark;
            labelTopBox1.Location = new Point(17, 10);
            labelTopBox1.Name = "labelTopBox1";
            labelTopBox1.Size = new Size(102, 17);
            labelTopBox1.TabIndex = 0;
            labelTopBox1.Text = "DIVERTISMENT";
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
            buttonNext1.TabIndex = 16;
            buttonNext1.Text = "Urmatorul";
            buttonNext1.TextColor = Color.White;
            buttonNext1.UseVisualStyleBackColor = false;
            buttonNext1.Click += buttonNext1_Click_1;
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
            // Pagina2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 674);
            Controls.Add(piceExit);
            Controls.Add(buttonNext1);
            Controls.Add(panelButoane);
            Controls.Add(lblPag1Title);
            Controls.Add(lblCaracteristici);
            Controls.Add(lblCamera);
            Controls.Add(lblResolutie);
            Controls.Add(lblBuget);
            Controls.Add(lblOS);
            Name = "Pagina2";
            Text = "Pgina2";
            Load += Pgina2_Load;
            panelButoane.ResumeLayout(false);
            roundedPanelMedia.ResumeLayout(false);
            roundedPanelMedia.PerformLayout();
            roundedPanelFotografie.ResumeLayout(false);
            roundedPanelFotografie.PerformLayout();
            roundedPanelDivertisment.ResumeLayout(false);
            roundedPanelDivertisment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piceExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOS;
        private Label lblBuget;
        private Label lblResolutie;
        private Label lblCamera;
        private Label lblCaracteristici;
        private Label lblPag1Title;
        private Panel panelButoane;
        private RoundedPanel roundedPanelMedia;
        private RoundedPanel roundedPanelFotografie;
        private RoundedPanel roundedPanelDivertisment;
        private Label lblDivertisment;
        private Label labelTopBox1;
        private Label labelTopBox2;
        private Label lblFotografie;
        private Label lblMedia;
        private Label lblTopBox3;
        private CustomControls.RJControls.RJButton buttonNext1;
        private PictureBox piceExit;
    }
}