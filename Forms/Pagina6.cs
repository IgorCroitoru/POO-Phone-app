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
    public partial class Pagina6 : Form
    {
        public Pagina6()
        {
            InitializeComponent();
        }

        private void piceExit_Click(object sender, EventArgs e)
        {
            FormUtility.ResetButton();
            Pagina1 pagina1 = new Pagina1();

            FormUtility.OpenNextForm(this, pagina1);
        }
        public void UpdatePanelStates()
        {
            FormUtility.UpdatePanelColor(roundedPanelFeature1, PanelStateManager.buttonSim, lblFeature1);
            FormUtility.UpdatePanelColor(roundedPanelFeature2, PanelStateManager.buttonRetea, lblFeature2);
            FormUtility.UpdatePanelColor(roundedPanelFeature3, PanelStateManager.buttonBattery, lblFeature3);
            FormUtility.UpdateButtonState(buttonNext1, PanelStateManager.buttonSim, PanelStateManager.buttonBattery, PanelStateManager.buttonRetea);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Pagina5 pagina5 = new Pagina5();
            pagina5.UpdatePanelStates();

            FormUtility.OpenNextForm(this, pagina5);
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.FromArgb(168, 224, 210);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void roundedPanelFeature1_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonSim = !PanelStateManager.buttonSim;
            UpdatePanelStates();
        }

        private void roundedPanelFeature2_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonRetea = !PanelStateManager.buttonRetea;
            UpdatePanelStates();
        }

        private void roundedPanelFeature3_MouseClick(object sender, MouseEventArgs e)
        {
            PanelStateManager.buttonBattery = !PanelStateManager.buttonBattery;
            UpdatePanelStates();
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            Form2 phoneForm = new Form2();
            FormUtility.OpenNextForm(this, phoneForm);
        }
    }
}
