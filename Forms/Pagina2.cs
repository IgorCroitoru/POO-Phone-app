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
    public partial class Pagina2 : Form
    {



        public Pagina2()
        {
            InitializeComponent();

        }

        private void Pgina2_Load(object sender, EventArgs e)
        {
            
        }





        private void llblDescriereBox_Click(object sender, EventArgs e)
        {

        }

        private void lblDescriereBox3_Click(object sender, EventArgs e)
        {

        }


        public void UpdatePanelStates()
        {
            FormUtility.UpdatePanelColor(roundedPanelDivertisment, PanelStateManager.buttonDivertisment, lblDivertisment);
            FormUtility.UpdatePanelColor(roundedPanelFotografie, PanelStateManager.buttonFotografie, lblFotografie);
            FormUtility.UpdatePanelColor(roundedPanelMedia, PanelStateManager.buttonMedia, lblMedia);
            FormUtility.UpdateButtonState(buttonNext1, PanelStateManager.buttonDivertisment, PanelStateManager.buttonMedia, PanelStateManager.buttonFotografie);
        }

        private void buttonNext1_Click_1(object sender, EventArgs e)
        {
            Pagina3 pagina3 = new Pagina3();
            pagina3.UpdatePanelStates();
            FormUtility.OpenNextForm(this, pagina3);
        }

        private void roundedPanelDivertisment_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonDivertisment = !PanelStateManager.buttonDivertisment;
            UpdatePanelStates();
        }

        private void roundedPanelFotografie_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonFotografie = !PanelStateManager.buttonFotografie;
            UpdatePanelStates();
        }

        private void roundedPanelMedia_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonMedia = !PanelStateManager.buttonMedia;
            UpdatePanelStates();
        }

        private void panelButoane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPag1Title_Click(object sender, EventArgs e)
        {
        }

        private void lblCaracteristici_Click(object sender, EventArgs e)
        {
        }

        private void lblCamera_Click(object sender, EventArgs e)
        {
        }

        private void lblResolutie_Click(object sender, EventArgs e)
        {
        }

        private void lblBuget_Click(object sender, EventArgs e)
        {
        }

        private void lblOS_Click(object sender, EventArgs e)
        {
        }

        private void piceExit_Click(object sender, EventArgs e)
        {
            FormUtility.ResetButton();
            Pagina1 pagina1 = new Pagina1();

            FormUtility.OpenNextForm(this, pagina1);
        }
    }
}
