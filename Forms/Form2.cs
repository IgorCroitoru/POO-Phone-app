using PhoneAdministration;

using PhoneClass;

using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        private int currentPage = 0;
        private const int itemPePagina = 6;


        CardPhone card = new CardPhone();
        List<Phone> phones = new List<Phone>();

        public Form2()
        {
            InitializeComponent();
        }

        private string ReturnQuery(List<string> list)
        {
            string query = "";

            foreach (string item in list)
            {
                if (item != list.Last())
                {
                    query += item + " and ";
                }
                else
                {
                    query += item;
                }
            }



            return query;
        }





        private async void Form2_Load(object sender, EventArgs e)
        {
            phones = new List<Phone>();
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Padding = new Padding(0);
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            string filePath = "C:\\Users\\Igor\\source\\repos\\POO-Phone app\\Config.txt";
            PhoneDatabase db = new PhoneDatabase(filePath);
            Filtru q = new Filtru();

            AutoScrollMinSize = new Size(0, 1000);
            flowLayoutPanel1.Visible = false;
            this.Enabled = false;
            LoadingForm loading = new LoadingForm();
            FormUtility.OpenNextForm(this, loading);

            phones = await Task.Run(() => db.ExtractPhoneData(ReturnQuery(q.PickPhones().Item1), ReturnQuery(q.PickPhones().Item2)));
            buttonUrma.Enabled = false;
            buttonUrma.BackColor = Color.FromArgb(232, 236, 236);

            DisplayItemsOnCurrentPage();

            //phones = await Task.Run(() => db.ExtractPhoneData(ReturnQuery(q.PickPhones().Item1), ReturnQuery(q.PickPhones().Item2)));
            //foreach (Phone phone in phones)
            //{
            //    card = new CardPhone();
            //    card.LoadPhoneData(phone);
            //    // Call the LoadPhoneData method, passing the phone object
            //    flowLayoutPanel1.Controls.Add(card);

            //}
            loading.Close();
            flowLayoutPanel1.Visible = true;
            this.Enabled = true;
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.FromArgb(168, 224, 210);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            FormUtility.ResetButton();
            Pagina1 pagina1 = new Pagina1();
            flowLayoutPanel1.Hide();
            flowLayoutPanel1.Controls.Clear();

            FormUtility.OpenNextForm(this, pagina1);

            //inchide scrollu
            AutoScrollMinSize = new Size(0, 0);
            AutoScrollMargin = new Size(0, 0);
            AutoScroll = false;
            AutoScrollPosition = new Point(0, 0);
        }



        private void DisplayItemsOnCurrentPage()
        {
            flowLayoutPanel1.Controls.Clear();


            int startIndex = currentPage * itemPePagina;
            int endIndex = startIndex + itemPePagina - 1;


            for (int i = startIndex; i <= endIndex && i < phones.Count; i++)
            {

                CardPhone card = new CardPhone();
                card.LoadPhoneData(phones[i]);
                flowLayoutPanel1.Controls.Add(card);
            }


        }

        private bool IsLastPage()
        {
            int totalPages = (int)Math.Ceiling((double)phones.Count / itemPePagina);
            return currentPage >= totalPages - 1;
        }



        private void buttonUrma_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                buttonUrma.Enabled = true;
                buttonUrma.BackColor = Color.FromArgb(7, 48, 66);
                currentPage--;
                DisplayItemsOnCurrentPage();
            }
            if (currentPage == 0)
            {
                buttonUrma.Enabled = false;
                buttonUrma.BackColor = Color.FromArgb(232, 236, 236);
            }
            if (!IsLastPage())
            {
                buttonInainte.Enabled = true;
                buttonInainte.BackColor = Color.FromArgb(7, 48, 66);
            }
        }

        private void buttonInainte_Click(object sender, EventArgs e)
        {
            currentPage++;
            DisplayItemsOnCurrentPage();
            if (IsLastPage())
            {
                buttonInainte.Enabled = false;
                buttonInainte.BackColor = Color.FromArgb(232, 236, 236);
            }

            if (currentPage > 0)
            {
                buttonUrma.Enabled = true;
                buttonUrma.BackColor = Color.FromArgb(7, 48, 66);
            }
        }
    }
}
