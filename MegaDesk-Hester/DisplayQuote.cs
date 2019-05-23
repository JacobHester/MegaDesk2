using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hester
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            _deskQuote = deskQuote;

            NameTextBox.Text = _deskQuote.Name;
            WidthNumericUpDown.Value = _deskQuote.NewDesk.Width;
            DepthNumericUpDown.Value = _deskQuote.NewDesk.Depth;
            DrawersNumericUpDown.Value = _deskQuote.NewDesk.NumDrawers;
            MaterialText.Text = _deskQuote.NewDesk.SurfaceMaterial.ToString();
            RushText.Text = _deskQuote.Rush.ToString();

            NameTextBox.Enabled = false;
            WidthNumericUpDown.Enabled = false;
            DepthNumericUpDown.Enabled = false;
            DrawersNumericUpDown.Enabled = false;
            MaterialText.Enabled = false;
            RushText.Enabled = false;

            QuoteLabel.Text = _deskQuote.QuoteTotal(_deskQuote).ToString("c");


        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeForm = (HomeForm)Tag;
            homeForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
