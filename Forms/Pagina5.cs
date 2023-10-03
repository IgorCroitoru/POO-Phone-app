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
    public partial class Pagina5 : Form
    {
        public Pagina5()
        {
            InitializeComponent();
        }

        private void Pagina5_Load(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Pagina4 pagina4 = new Pagina4();
            pagina4.UpdatePanelStates();

            FormUtility.OpenNextForm(this, pagina4);
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            Pagina6 pagina6 = new Pagina6();
            pagina6.UpdatePanelStates();
            FormUtility.OpenNextForm(this, pagina6);
        }


        //permite numai o alegere

        private void roundedPanelCamera1_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonCamera1 = !PanelStateManager.buttonCamera1;

            if (PanelStateManager.buttonCamera1)
            {
                PanelStateManager.buttonCamera2 = false;
                PanelStateManager.buttonCamera3 = false;
            }

            FormUtility.UpdatePanelColor(roundedPanelCamera1, PanelStateManager.buttonCamera1, lblCamera1);
            FormUtility.UpdatePanelColor(roundedPanelCamera2, PanelStateManager.buttonCamera2, lblCamera2);
            FormUtility.UpdatePanelColor(roundedPanelCamera3, PanelStateManager.buttonCamera3, lblCamera3);
            UpdatePanelStates();
        }

        private void roundedPanelCamera2_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonCamera2 = !PanelStateManager.buttonCamera2;

            if (PanelStateManager.buttonCamera2)
            {
                PanelStateManager.buttonCamera1 = false;
                PanelStateManager.buttonCamera3 = false;
            }

            FormUtility.UpdatePanelColor(roundedPanelCamera1, PanelStateManager.buttonCamera1, lblCamera1);
            FormUtility.UpdatePanelColor(roundedPanelCamera2, PanelStateManager.buttonCamera2, lblCamera2);
            FormUtility.UpdatePanelColor(roundedPanelCamera3, PanelStateManager.buttonCamera3, lblCamera3);
            UpdatePanelStates();
        }

        private void roundedPanelCamera3_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonCamera3 = !PanelStateManager.buttonCamera3;

            if (PanelStateManager.buttonCamera3)
            {
                PanelStateManager.buttonCamera1 = false;
                PanelStateManager.buttonCamera2 = false;
            }

            FormUtility.UpdatePanelColor(roundedPanelCamera1, PanelStateManager.buttonCamera1, lblCamera1);
            FormUtility.UpdatePanelColor(roundedPanelCamera2, PanelStateManager.buttonCamera2, lblCamera2);
            FormUtility.UpdatePanelColor(roundedPanelCamera3, PanelStateManager.buttonCamera3, lblCamera3);
            UpdatePanelStates();
        }


        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.FromArgb(168, 224, 210);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        public void UpdatePanelStates()
        {
            FormUtility.UpdatePanelColor(roundedPanelCamera1, PanelStateManager.buttonCamera1, lblCamera1);
            FormUtility.UpdatePanelColor(roundedPanelCamera2, PanelStateManager.buttonCamera2, lblCamera2);
            FormUtility.UpdatePanelColor(roundedPanelCamera3, PanelStateManager.buttonCamera3, lblCamera3);
            FormUtility.UpdateButtonState(buttonNext1, PanelStateManager.buttonCamera1, PanelStateManager.buttonCamera2, PanelStateManager.buttonCamera3);
        }

        private void piceExit_Click(object sender, EventArgs e)
        {
            FormUtility.ResetButton();
            Pagina1 pagina1 = new Pagina1();

            FormUtility.OpenNextForm(this, pagina1);
        }
    }
}
