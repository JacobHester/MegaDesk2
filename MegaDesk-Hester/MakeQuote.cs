using System;
using System.Windows.Forms;

namespace MegaDesk_Hester
{
    public partial class MakeQuote : Form
    {
        public MakeQuote()
        {
            InitializeComponent();
        }

        private void CancelNewForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeForm = (HomeForm)Tag;
            homeForm.Show();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string material = (string)listBox.SelectedItem;


            if (material == "Oak")
            {
                this.SamplePic.Load("C:\\Users\\Lazjh\\Documents\\Spring 2019\\CIT 365\\oak.jpg");
            }
            else if (material == "Laminate")
            {
                this.SamplePic.Load("C:\\Users\\Lazjh\\Documents\\Spring 2019\\CIT 365\\laminate.jpg");
            }
            else if (material == "Rosewood")
            {
                this.SamplePic.Load("C:\\Users\\Lazjh\\Documents\\Spring 2019\\CIT 365\\rosewood.jpg");
            }
            else if (material == "Pine")
            {
                this.SamplePic.Load("C:\\Users\\Lazjh\\Documents\\Spring 2019\\CIT 365\\pine.jpg");
            }
            else if (material == "Veneer")
            {
                this.SamplePic.Load("C:\\Users\\Lazjh\\Documents\\Spring 2019\\CIT 365\\veneer.jpg");
            }
        }
    }
}
