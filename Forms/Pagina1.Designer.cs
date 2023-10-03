namespace Forms
{
    partial class Pagina1
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
            startButton = new CustomControls.RJControls.RJButton();
            photoPagPrincipala = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)photoPagPrincipala).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(7, 48, 66);
            startButton.BackgroundColor = Color.FromArgb(7, 48, 66);
            startButton.BorderColor = Color.PaleVioletRed;
            startButton.BorderRadius = 20;
            startButton.BorderSize = 0;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("IBM Plex Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(27, 392);
            startButton.Name = "startButton";
            startButton.Size = new Size(150, 44);
            startButton.TabIndex = 7;
            startButton.Text = "Sa incepem";
            startButton.TextColor = Color.White;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // photoPagPrincipala
            // 
            photoPagPrincipala.Image = Properties.Resources.resized;
            photoPagPrincipala.Location = new Point(790, 74);
            photoPagPrincipala.Name = "photoPagPrincipala";
            photoPagPrincipala.Size = new Size(522, 443);
            photoPagPrincipala.TabIndex = 6;
            photoPagPrincipala.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IBM Plex Sans Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 303);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(755, 62);
            label2.TabIndex = 5;
            label2.Text = "Incearca rapid instrumentul nostru de comparare si alege telefonul \r\ncare e mai bun pentru tine.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik ExtraBold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 168);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(736, 120);
            label1.TabIndex = 4;
            label1.Text = "Vrei sa gasesti telefonul care\r\nti se potriveste cel mai bine?";
            // 
            // Pagina1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 676);
            Controls.Add(startButton);
            Controls.Add(photoPagPrincipala);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pagina1";
            Text = "Pagina1";
            Load += Pagina1_Load;
            ((System.ComponentModel.ISupportInitialize)photoPagPrincipala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton startButton;
        private PictureBox photoPagPrincipala;
        private Label label2;
        private Label label1;
    }
}