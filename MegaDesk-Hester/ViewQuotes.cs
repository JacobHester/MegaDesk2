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
            quotesGridView.AutoGenerateColumns = false;
            quotesGridView.ColumnCount = 8;

            quotesGridView.Columns[0].Name = "Customer Name";
            quotesGridView.Columns[0].DataPropertyName = "Name";

            quotesGridView.Columns[1].Name = "Quoted Price";
            quotesGridView.Columns[1].DataPropertyName = "Price";
            quotesGridView.Columns[1].DefaultCellStyle.Format = "c";
            quotesGridView.Columns[2].Name = "Width";
            quotesGridView.Columns[2].DataPropertyName = "Width";

            quotesGridView.Columns[3].Name = "Depth";
            quotesGridView.Columns[3].DataPropertyName = "depth";

            quotesGridView.Columns[4].Name = "Number of Drawers";
            quotesGridView.Columns[4].DataPropertyName = "NumDrawers";

            quotesGridView.Columns[5].Name = "Surface Material";
            quotesGridView.Columns[5].DataPropertyName = "SurfaceMaterial";

            quotesGridView.Columns[6].Name = "Quote Date";
            quotesGridView.Columns[6].DataPropertyName = "QuoteDate";

            quotesGridView.Columns[7].Name = "Shipping Option";
            quotesGridView.Columns[7].DataPropertyName = "Rush";

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

    }


    }

