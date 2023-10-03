namespace Forms
{
    partial class Form2
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblPotriviri = new Label();
            lblBack = new Label();
            buttonUrma = new CustomControls.RJControls.RJButton();
            buttonInainte = new CustomControls.RJControls.RJButton();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(518, 0);
            flowLayoutPanel1.Margin = new Padding(3, 6, 10, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(824, 830);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblPotriviri
            // 
            lblPotriviri.AutoSize = true;
            lblPotriviri.Font = new Font("Rubik", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            lblPotriviri.Location = new Point(25, 155);
            lblPotriviri.Name = "lblPotriviri";
            lblPotriviri.Size = new Size(460, 120);
            lblPotriviri.TabIndex = 1;
            lblPotriviri.Text = "Sa vedem cele mai\r\nbune potriviri\r\n";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Rubik", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblBack.ForeColor = Color.Black;
            lblBack.Location = new Point(25, 24);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(123, 19);
            lblBack.TabIndex = 27;
            lblBack.Text = "< Incepe din nou";
            lblBack.Click += lblBack_Click;
            lblBack.MouseEnter += lblBack_MouseEnter;
            lblBack.MouseLeave += lblBack_MouseLeave;
            // 
            // buttonUrma
            // 
            buttonUrma.BackColor = Color.FromArgb(7, 48, 66);
            buttonUrma.BackgroundColor = Color.FromArgb(7, 48, 66);
            buttonUrma.BorderColor = Color.PaleVioletRed;
            buttonUrma.BorderRadius = 20;
            buttonUrma.BorderSize = 0;
            buttonUrma.FlatAppearance.BorderSize = 0;
            buttonUrma.FlatStyle = FlatStyle.Flat;
            buttonUrma.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUrma.ForeColor = Color.White;
            buttonUrma.Location = new Point(528, 836);
            buttonUrma.Name = "buttonUrma";
            buttonUrma.Size = new Size(43, 40);
            buttonUrma.TabIndex = 28;
            buttonUrma.Text = "<";
            buttonUrma.TextColor = Color.White;
            buttonUrma.UseVisualStyleBackColor = false;
            buttonUrma.Click += buttonUrma_Click;
            // 
            // buttonInainte
            // 
            buttonInainte.BackColor = Color.FromArgb(7, 48, 66);
            buttonInainte.BackgroundColor = Color.FromArgb(7, 48, 66);
            buttonInainte.BorderColor = Color.PaleVioletRed;
            buttonInainte.BorderRadius = 20;
            buttonInainte.BorderSize = 0;
            buttonInainte.FlatAppearance.BorderSize = 0;
            buttonInainte.FlatStyle = FlatStyle.Flat;
            buttonInainte.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInainte.ForeColor = Color.White;
            buttonInainte.Location = new Point(577, 836);
            buttonInainte.Name = "buttonInainte";
            buttonInainte.Size = new Size(43, 40);
            buttonInainte.TabIndex = 29;
            buttonInainte.Text = " >";
            buttonInainte.TextColor = Color.White;
            buttonInainte.UseVisualStyleBackColor = false;
            buttonInainte.Click += buttonInainte_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 676);
            Controls.Add(buttonInainte);
            Controls.Add(buttonUrma);
            Controls.Add(lblBack);
            Controls.Add(lblPotriviri);
            Controls.Add(flowLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblPotriviri;
        private Label lblBack;
        private CustomControls.RJControls.RJButton nextButton;
        private CustomControls.RJControls.RJButton backButton;
        private CustomControls.RJControls.RJButton buttonUrma;
        private CustomControls.RJControls.RJButton buttonInainte;
    }
}