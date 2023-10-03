using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public static class FormUtility
    {

        //metoda pentru deschiderea formei urmatoare sau precedente
        public static void OpenNextForm(Form currentForm, Form nextForm)
        {
           
            nextForm.TopLevel = false;
            nextForm.FormBorderStyle = FormBorderStyle.None;
            nextForm.Dock = DockStyle.Fill;
            currentForm.Controls.Add(nextForm);
            nextForm.BringToFront();
            nextForm.Show();

        }


     

        //updateaza starea butoanelor (3panele)


        //buton oentru resetarea datelor
        public static void ResetButton()
        {
            Pagina2 pagina2 = new Pagina2();
            Pagina3 pagina3 = new Pagina3();
            Pagina4 pagina4 = new Pagina4();
            Pagina5 pagina5 = new Pagina5();
            Pagina6 pagina6 = new Pagina6();
            PanelStateManager.buttonDivertisment = false;
            PanelStateManager.buttonFotografie = false;
            PanelStateManager.buttonMedia = false;
            PanelStateManager.buttonPremium = false;
            PanelStateManager.buttonMediu = false;
            PanelStateManager.buttonEco = false;
            PanelStateManager.buttonRes1 = false;
            PanelStateManager.buttonRes2 = false;
            PanelStateManager.buttonCamera1 = false;
            PanelStateManager.buttonCamera2 = false;
            PanelStateManager.buttonCamera3 = false;
            PanelStateManager.buttonSim = false;
            PanelStateManager.buttonRetea = false;
            PanelStateManager.buttonBattery = false;

            pagina2.UpdatePanelStates();
            pagina3.UpdatePanelStates();
            pagina4.UpdatePanelStates();
            pagina5.UpdatePanelStates();
            pagina6.UpdatePanelStates();
        }


        //updateaza starea butoanelor (3 butoane de tip panel)
        //functia primeste 

        public static void UpdateButtonState(Button buttonNext, bool isActive1, bool isActive2, bool isActive3)
        {
            if (isActive1 || isActive2 || isActive3)
            {
                buttonNext.Enabled = true;
                buttonNext.BackColor = ColorTranslator.FromHtml("#073042");
                buttonNext.ForeColor = Color.White;
                
            }
            else
            {
                buttonNext.Enabled = false;
                buttonNext.BackColor = Color.FromArgb(232, 236, 236);
                buttonNext.ForeColor = Color.White;
            }
        }


        //updateaza starea butoanelor (4 butoane de tip panel)
        public static void UpdateButtonState(Button buttonNext, bool isActive1, bool isActive2, bool isActive3, bool isActive4)
        {
            if (isActive1 || isActive2 || isActive3 || isActive4)
            {
                buttonNext.Enabled = true;
                buttonNext.BackColor = ColorTranslator.FromHtml("#073042");
            }
            else
            {
                buttonNext.Enabled = false;
                buttonNext.BackColor = Color.FromArgb(232, 236, 236);
                buttonNext.ForeColor = Color.White;
            }
        }

       
        //updateaza starea butoanelor (2panele)

        public static void UpdateButtonState(Button buttonNext1, bool isActive1, bool isActive2)
        {
            if (isActive1 || isActive2 )
            {
                buttonNext1.Enabled = true;
                buttonNext1.BackColor = ColorTranslator.FromHtml("#073042");
                buttonNext1.ForeColor = Color.White;

            }
            else
            {
                buttonNext1.Enabled = false;
                buttonNext1.BackColor = Color.FromArgb(232, 236, 236);
                buttonNext1.ForeColor = Color.White;
            }
        }



        public static void UpdatePanelColor(Panel panel, bool isActive, Label lbl)
        {
            if (isActive)
            {
                panel.BackColor = ColorTranslator.FromHtml("#073042");
                lbl.ForeColor = Color.White;
               
            }
            else
            {
                panel.BackColor = Color.White;
                lbl.ForeColor = Color.Black;
               
            }
        }




    }


}
