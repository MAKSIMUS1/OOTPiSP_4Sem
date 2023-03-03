using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_OOP_Form
{
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }
        public SearchResult(BindingList<Product> searchedProducts)
        {
            InitializeComponent();
            dataGridView1.DataSource = searchedProducts;
        }
    }
}
