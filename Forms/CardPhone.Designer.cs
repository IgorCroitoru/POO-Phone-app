namespace Forms
{
    partial class CardPhone
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblDescriere = new Label();
            lblPrice = new Label();
            lblSettings = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 221);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblDescriere
            // 
            lblDescriere.AutoSize = true;
            lblDescriere.Font = new Font("Rubik Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriere.Location = new Point(15, 261);
            lblDescriere.Margin = new Padding(3, 0, 0, 0);
            lblDescriere.Name = "lblDescriere";
            lblDescriere.Size = new Size(189, 48);
            lblDescriere.TabIndex = 3;
            lblDescriere.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaa\r\naaaaaaaaaaaaaaaaaaaaaaaaaa\r\n\r\n";
            lblDescriere.MouseEnter += lblDescriere_MouseEnter;
            lblDescriere.MouseLeave += lblDescriere_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("IBM Plex Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(15, 353);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(93, 35);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "label1";
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Rubik", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblSettings.Location = new Point(15, 315);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(39, 15);
            lblSettings.TabIndex = 5;
            lblSettings.Text = "label1";
            // 
            // CardPhone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSettings);
            Controls.Add(lblPrice);
            Controls.Add(pictureBox1);
            Controls.Add(lblDescriere);
            Name = "CardPhone";
            Size = new Size(251, 398);
            Load += CardPhone_Load;
            MouseEnter += CardPhone_MouseEnter;
            MouseLeave += CardPhone_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDescriere;
        private Label lblPrice;
        private Label lblSettings;
    }
}
