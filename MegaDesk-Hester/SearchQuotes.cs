using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Hester
{
    public partial class SearchQuotes : Form
    {
        BindingSource quoteBindingSource;
        DataTable dataTable;
        public SearchQuotes()
        {
            InitializeComponent();
            InitializeQuoteList();
            InitializeComboBox();
           
        }

        private void InitializeComboBox()
        {
            List<SurfaceMaterial> materials =
         Enum.GetValues(typeof(SurfaceMaterial))
         .Cast<SurfaceMaterial>()
         .ToList();

            materialComboBox.DataSource = materials;
            materialComboBox.SelectedIndex = -1;

        }
        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        private void InitializeQuoteList()
        {
            string currentQuotes = File.ReadAllText("quotes.json");
            // create the deskQoute list
            List<DeskQuote> deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(currentQuotes);


            var formattedData = deskQuoteList.Select(DeskQuote => new
            {
                DeskQuote.Name,
                DeskQuote.Price,
                DeskQuote.NewDesk.Width,
                DeskQuote.NewDesk.Depth,
                DeskQuote.NewDesk.NumDrawers,
                DeskQuote.NewDesk.SurfaceMaterial,
                DeskQuote.QuoteDate,
                DeskQuote.Rush
            }).ToList();
            dataTable = ToDataTable(formattedData);
            quoteBindingSource = new BindingSource()
            {
                DataSource = dataTable
            };
        
            searchQuotesView.DataSource = quoteBindingSource;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeForm = (HomeForm)Tag;
            homeForm.Show();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox) sender;
            if (comboBox.SelectedIndex >= 0)
            {
                string filter = "SurfaceMaterial = '" + comboBox.SelectedIndex + "'";
                DataView dataView = new DataView(dataTable);
                dataView.RowFilter = filter;
                quoteBindingSource.DataSource = dataView;
            }
        }
    } 
}
