using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Forms
{
    public class RoundedPanelCaracateristica : Panel
    {
        private int borderRadius = 30;
        public bool isActive = false;
        Label lbl = new Label();
        Label lbl2 = new Label();

        public RoundedPanelCaracateristica()
        {   this.BackColor = Color.White;
            this.BorderRadius = 30;
            this.Controls.Add(lbl);
            this.Controls.Add(lbl2);
            this.ForeColor = Color.Black;
            this.Location = new Point(35, 223);
            this.Name = "roundedPanel";
            this.Size = new Size(165, 165);
            this.TabIndex = 1;

            //bottom scris
            lbl.AutoSize = true;
            lbl.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(20, 112);
            lbl.Name = "lblDescriereBox3";
            lbl.Size = new Size(114, 40);
            lbl.TabIndex = 4;
            lbl.Text = "Conectare cu \r\naltii";

            //top scris
            lbl2.AutoSize = true;
            lbl2.Font = new Font("IBM Plex Sans Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = SystemColors.ControlDark;
            lbl2.Location = new Point(17, 16);
            lbl2.Name = "lblTopBox3";
            lbl2.Size = new Size(99, 17);
            lbl2.TabIndex = 3;
            lbl2.Text = "SOCIAL MEDIA";
        }



        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseAllFigures();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectangleF = new Rectangle(0, 0, this.Width, this.Height);

            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rectangleF);
            }
        }

    }
}
