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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void NewQuote_Click(object sender, EventArgs e)
        {
            MakeQuote NewQuoteForm = new MakeQuote();
            NewQuoteForm.Tag = this;
            NewQuoteForm.Show();
            Hide();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            ViewQuotes ViewQuotesForm = new ViewQuotes();
            ViewQuotesForm.Tag = this;
            ViewQuotesForm.Show();
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchQuotes ViewSearchQuotes = new SearchQuotes()
            {
                Tag = this,
            };

            ViewSearchQuotes.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
