using PhoneAdministration;
using PhoneClass;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Drawing2D;

namespace Forms
{
    public partial class CardPhone : UserControl
    {
        private Color originalBackColor;

        public CardPhone()
        {
            BackColor = Color.White;
            Size = new Size(200, 200);
            originalBackColor = this.BackColor;
            this.MouseEnter += CardPhone_MouseEnter;
            this.MouseLeave += CardPhone_MouseLeave;



            InitializeComponent();
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    // Create a rounded rectangle path
        //    GraphicsPath path = new GraphicsPath();
        //    int cornerRadius = 10; // Adjust the corner radius as desired
        //    Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
        //    path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
        //    path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
        //    path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        //    path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        //    path.CloseFigure();

        //    // Set the clipping region to the rounded rectangle path
        //    e.Graphics.SetClip(path);

        //    // Draw the control content here...

        //    // Dispose the GraphicsPath object
        //    path.Dispose();
        //}

        public void LoadPhoneData(Phone phone)
        {
            // Method implementation
            pictureBox1.Image = ResizeImage(phone.PhotoData);
            lblPrice.Text = phone.Price.ToString() + " lei";
            lblPrice.ForeColor = ColorTranslator.FromHtml("#C00033");

            if ((phone.Brand.ToString() + " " + phone.Model.ToString() + " " + phone.StorageCapacity.ToString() + " GB " + phone.color.ToString()).Length > 32)
            {
                lblDescriere.Text = phone.Brand.ToString() + " " + phone.Model.ToString() + " " + phone.StorageCapacity.ToString() + " GB " + "\n" + phone.color.ToString();
            }
            else
            {
                lblDescriere.Text = phone.Brand.ToString() + " " + phone.Model.ToString() + " " + phone.StorageCapacity.ToString() + " GB " + phone.color.ToString();
            }
            lblSettings.Text = phone.ScreenSize.ToString().Replace(",", ".") + "\"" + " | " + phone.CameraQuality.ToString() + " MP" + " | " + phone.Ram.ToString() + " GB" + " | " + phone.Sim.ToString();

        }

        public void CardPhone_Load(object sender, EventArgs e)
        {

            //pictureBox1.Image = ResizeImage(phone.PhotoData);
            //lblPrice.Text = phone.Price.ToString() + " lei";
            //lblPrice.ForeColor = ColorTranslator.FromHtml("#C00033");
            //lblDescriere.Text = "Telefon " + phone.Brand.ToString() + " " + phone.Model.ToString() + ", " + "\n" + phone.StorageCapacity.ToString() + "GB, " + phone.Ram.ToString() + "GB RAM" + ", " + phone.Sim.ToString() + ", " + phone.color.ToString();
        }

        public Image ResizeImage(byte[] origImage)
        {
            using (MemoryStream ms = new MemoryStream(origImage))
            {
                Image originalImage = Image.FromStream(ms); // Convert byte array to Image object

                // Create a new bitmap with the desired size
                Bitmap resizedImage = new Bitmap(221, 221);

                // Create a graphics object from the resized bitmap
                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    // Set the interpolation mode to achieve smooth resizing
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    // Draw the original image onto the resized bitmap
                    g.DrawImage(originalImage, 0, 0, 221, 221);
                }

                // Return the resized image
                return resizedImage;
            }
        }

        private void CardPhone_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void CardPhone_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = originalBackColor;
        }

        private void lblDescriere_MouseEnter(object sender, EventArgs e)
        {


        }

        private void lblDescriere_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
