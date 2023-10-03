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
    public partial class Pagina4 : Form
    {
        public Pagina4()
        {
            InitializeComponent();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Pagina3 pagina3 = new Pagina3();
            pagina3.UpdatePanelStates();
            FormUtility.OpenNextForm(this, pagina3);
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            Pagina5 pagina5 = new Pagina5();
            pagina5.UpdatePanelStates();
            FormUtility.OpenNextForm(this, pagina5);
        }

        private void roundedPanelRes1_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonRes1 = !PanelStateManager.buttonRes1;

            // Shimba butonul daca celalalt e apasat
            if (PanelStateManager.buttonRes1 && !PanelStateManager.buttonRes2)
            {
                FormUtility.UpdatePanelColor(roundedPanelRes1, PanelStateManager.buttonRes1, lblDescriereBox1);
            }

            if (PanelStateManager.buttonRes1 && PanelStateManager.buttonRes2)
            {
                PanelStateManager.buttonRes2 = !PanelStateManager.buttonRes2;
                FormUtility.UpdatePanelColor(roundedPanelRes2, PanelStateManager.buttonRes2, lblDescriereBox2);
            }
            UpdatePanelStates();
        }

        private void roundedPanelRes2_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonRes2 = !PanelStateManager.buttonRes2;

            // Shimba butonul daca celalalt e apasat
            if (PanelStateManager.buttonRes2 && PanelStateManager.buttonRes1)
            {
                PanelStateManager.buttonRes1 = !PanelStateManager.buttonRes1;
                FormUtility.UpdatePanelColor(roundedPanelRes1, PanelStateManager.buttonRes1, lblDescriereBox1);
            }

            FormUtility.UpdatePanelColor(roundedPanelRes2, PanelStateManager.buttonRes2, lblDescriereBox2);
            UpdatePanelStates();
        }

        public void UpdatePanelStates()
        {
            FormUtility.UpdatePanelColor(roundedPanelRes1, PanelStateManager.buttonRes1, lblDescriereBox1);
            FormUtility.UpdatePanelColor(roundedPanelRes2, PanelStateManager.buttonRes2, lblDescriereBox2);
            FormUtility.UpdateButtonState(buttonNext1, PanelStateManager.buttonRes1, PanelStateManager.buttonRes2);
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.FromArgb(168, 224, 210);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void piceExit_Click(object sender, EventArgs e)
        {
            FormUtility.ResetButton();
            Pagina1 pagina1 = new Pagina1();

            FormUtility.OpenNextForm(this, pagina1);
        }
    }
}
