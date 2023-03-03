using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_2_OOP_Form
{
    public partial class SearchRequests : Form
    {
        private Form1 mainForm;
        private List<Product> listProducts;
        public SearchRequests()
        {
            InitializeComponent();
        }
        public SearchRequests(Form1 f, List<Product> productList)
        {
            InitializeComponent();
            mainForm = f;
            listProducts = productList;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            IEnumerable<Product>? searched = null;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                searched = from i in mainForm.data
                           where i.Title == textBox1.Text
                           select i;
            }
            if (radioButton_Edible.Checked || radioButton_Inedible.Checked)
            {
                if (radioButton_Edible.Checked)
                {
                    if (searched == null)
                    {
                        searched = from i in mainForm.data
                                   where i.Type == ProductType.Edible
                                   select i;
                    }
                    else
                    {
                        searched = from i in searched
                                   where i.Type == ProductType.Edible
                                   select i;
                    }
                }
                if (radioButton_Inedible.Checked)
                {
                    if (searched == null)
                    {
                        searched = from i in mainForm.data
                                   where i.Type == ProductType.Inedible
                                   select i;
                    }
                    else
                    {
                        searched = from i in searched
                                   where i.Type == ProductType.Inedible
                                   select i;
                    }
                }
            }
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox_PriceRange.Text))
                {
                    string regex = @"\d{1,3}-\d{1,4}";
                    if (Regex.IsMatch(textBox_PriceRange.Text, regex))
                    {
                        string[] words = textBox_PriceRange.Text.Split(new char[] { '-' });
                        int priceFrom = Convert.ToInt32(words[0]);
                        int priceTo = Convert.ToInt32(words[1]);
                        if (priceFrom > priceTo)
                            throw new Exception("Price range is in not correct format(PriceFrom > PriceTo). Price range is not included in the search.");
                        if (searched == null)
                        {
                            searched = from i in mainForm.data
                                       where i.Price < priceTo && i.Price > priceFrom
                                       select i;
                        }
                        else
                        {
                            searched = from i in searched
                                       where i.Price < priceTo && i.Price > priceFrom
                                       select i;
                        }
                    }
                    else
                        throw new Exception("Price range is in not correct format. Price range is not included in the search.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BindingList<Product> data = new BindingList<Product>();
            if (searched != null)
                foreach (Product i in searched)
                    data.Add(i);
            SearchResult searchResultFrom = new SearchResult(data);
            searchResultFrom.Show();
        }
    }
}
