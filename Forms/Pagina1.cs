using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Pagina1 : Form
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.BackColor = Color.FromArgb(55, 190, 158);
            startButton.ForeColor = Color.Black;
            Pagina2 pagina2 = new Pagina2();
            pagina2.UpdatePanelStates();

            FormUtility.OpenNextForm(this, pagina2);
        }

        private void Pagina1_Load(object sender, EventArgs e)
        {

        }
    }
}
