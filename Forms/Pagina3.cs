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
    public partial class Pagina3 : Form
    {


        public Pagina3()
        {
            InitializeComponent();

        }


        private void lblBack_Click(object sender, EventArgs e)
        {

            Pagina2 pagina2 = new Pagina2();
            pagina2.UpdatePanelStates();


            FormUtility.OpenNextForm(this, pagina2);
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.FromArgb(168, 224, 210);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            Pagina4 pagina4 = new Pagina4();
            pagina4.UpdatePanelStates();
            FormUtility.OpenNextForm(this, pagina4);
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void roundedPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonPremium = !PanelStateManager.buttonPremium;

            if (PanelStateManager.buttonPremium)
            {
                PanelStateManager.buttonMediu = false;
                PanelStateManager.buttonEco = false;
            }

            FormUtility.UpdatePanelColor(roundedPanelBuget1, PanelStateManager.buttonCamera1, llblDescriereBox1);
            FormUtility.UpdatePanelColor(roundedPanelBuget2, PanelStateManager.buttonCamera2, lblDescriereBox2);
            FormUtility.UpdatePanelColor(roundedPanelBuget3, PanelStateManager.buttonCamera3, lblDescriereBox3);
            UpdatePanelStates();

        }

        private void roundedPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonMediu = !PanelStateManager.buttonMediu;
            if (PanelStateManager.buttonMediu)
            {
                PanelStateManager.buttonPremium = false;
                PanelStateManager.buttonEco = false;
            }

            FormUtility.UpdatePanelColor(roundedPanelBuget1, PanelStateManager.buttonCamera1, llblDescriereBox1);
            FormUtility.UpdatePanelColor(roundedPanelBuget2, PanelStateManager.buttonCamera2, lblDescriereBox2);
            FormUtility.UpdatePanelColor(roundedPanelBuget3, PanelStateManager.buttonCamera3, lblDescriereBox3);
            UpdatePanelStates();

        }

        private void roundedPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonEco = !PanelStateManager.buttonEco;
            if (PanelStateManager.buttonEco)
            {
                PanelStateManager.buttonMediu = false;
                PanelStateManager.buttonPremium = false;
            }

            FormUtility.UpdatePanelColor(roundedPanelBuget1, PanelStateManager.buttonCamera1, llblDescriereBox1);
            FormUtility.UpdatePanelColor(roundedPanelBuget2, PanelStateManager.buttonCamera2, lblDescriereBox2);
            FormUtility.UpdatePanelColor(roundedPanelBuget3, PanelStateManager.buttonCamera3, lblDescriereBox3);
            UpdatePanelStates();

        }
        public void UpdatePanelStates()
        {
            FormUtility.UpdatePanelColor(roundedPanelBuget1, PanelStateManager.buttonPremium, llblDescriereBox1);
            FormUtility.UpdatePanelColor(roundedPanelBuget2, PanelStateManager.buttonMediu, lblDescriereBox2);
            FormUtility.UpdatePanelColor(roundedPanelBuget3, PanelStateManager.buttonEco, lblDescriereBox3);
            FormUtility.UpdateButtonState(buttonNext1, PanelStateManager.buttonPremium, PanelStateManager.buttonMediu, PanelStateManager.buttonEco);
        }

        private void piceExit_Click(object sender, EventArgs e)
        {
            FormUtility.ResetButton();
            Pagina1 pagina1 = new Pagina1();

            FormUtility.OpenNextForm(this, pagina1);
        }
    }
}
