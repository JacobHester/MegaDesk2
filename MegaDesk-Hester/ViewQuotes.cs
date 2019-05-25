using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace MegaDesk_Hester
{
    public partial class ViewQuotes : Form
    {
        private DataGridView dataGridView = new DataGridView();
        private BindingSource bindingSource = new BindingSource();
        public ViewQuotes()
        {
            InitializeComponent();

            InitializeGridView();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeForm = (HomeForm)Tag;
            homeForm.Show();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {
            
            
        }

        private void InitializeGridView()
        {
  
            // reads the json from the file
            string currentQuotes = File.ReadAllText("quotes.json");
                // create the deskQoute list here so that we retain scope access
                List<DeskQuote> deskQuoteList= JsonConvert.DeserializeObject<List<DeskQuote>>(currentQuotes);


            quotesGridView.DataSource = new BindingSource() { DataSource = deskQuoteList.Select(DeskQuote => new
            {
                DeskQuote.Name,
                DeskQuote.Price,
                DeskQuote.NewDesk.Width,
                DeskQuote.NewDesk.Depth,
                DeskQuote.NewDesk.NumDrawers,
                DeskQuote.NewDesk.SurfaceMaterial,
                DeskQuote.QuoteDate,
                DeskQuote.Rush
            })
            };

        }

        private void DeskBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }


    }

