using System;
using System.Linq;
using System.Collections.Generic;
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
            string material = (string)listBox.Text;


            if (material == "Oak")
            {
                this.SamplePic.Load("oak.jpg");
            }
            else if (material == "Laminate")
            {
                this.SamplePic.Load("laminate.jpg");
            }
            else if (material == "Rosewood")
            {
                this.SamplePic.Load("rosewood.jpg");
            }
            else if (material == "Pine")
            {
                this.SamplePic.Load("pine.jpg");
            }
            else if (material == "Veneer")
            {
                this.SamplePic.Load("veneer.jpg");
            }
        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {

            try
            {
                Desk desk = new Desk()
                {
                    Width = this.WidthNumericUpDown.Value,
                    Depth = this.DepthNumericUpDown.Value,
                    NumDrawers = this.DrawersNumericUpDown.Value,
                    SurfaceMaterial = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), MaterialListBox.Text)

                };
                try
                {
                    DeskQuote deskQuote = new DeskQuote()
                    {
                        NewDesk = desk,
                        Name = this.NameTextBox.Text,
                        QuoteDate = DateTime.Now,
                        Rush = (Rush)Enum.Parse(typeof(Rush), RushComboBox.SelectedValue.ToString())
                    };

                    DisplayQuote displayQuote = new DisplayQuote(deskQuote);
                    HomeForm homeform = (HomeForm)Tag;
                    displayQuote.Tag = homeform;
                    displayQuote.Show();
                    Hide();

                } catch (System.NullReferenceException) { System.Windows.Forms.MessageBox.Show("Please Enter Values for All Parameters!", "ERROR"); }

                

            }
            catch (System.ArgumentException)
            {
                System.Windows.Forms.MessageBox.Show("Please Enter Values for All Parameters!", "ERROR");
            }

        }

        private void MakeQuote_Load(object sender, EventArgs e)
        {
            List<SurfaceMaterial> materials = 
                    Enum.GetValues(typeof(SurfaceMaterial))
                    .Cast<SurfaceMaterial>()
                    .ToList();

            MaterialListBox.DataSource = materials;
            MaterialListBox.SelectedIndex = -1;

            List<Rush> rush =
                Enum.GetValues(typeof(Rush))
                .Cast<Rush>()
                .ToList();

            RushComboBox.DataSource = rush;
            RushComboBox.SelectedIndex = -1;
        }
    }
}

