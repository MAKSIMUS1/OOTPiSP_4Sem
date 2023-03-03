using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Lab_2_OOP_Form
{
    public partial class Form1 : Form
    {
        private Storekeeper Storekeeper1 = new Storekeeper("Kovalko", "Maksim", "Leonidovich", 2);
        private Storekeeper Storekeeper2 = new Storekeeper("Legotin", "Artem", "Aleksandrovich", 1);
        private Storekeeper Storekeeper3 = new Storekeeper("Kozin", "Nikita", "Olegovich", 0);
        private Storekeeper Storekeeper4 = new Storekeeper("Adamovich", "Dmitriy", "Nikolaevich", 3);

        private Storekeeper SelectedStorekeeper;

        public BindingList<Product> data = new BindingList<Product>(); //Специальный список List с вызовом события обновления внутреннего состояния, необходимого для автообновления datagridview

        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Producer producer1 = new Producer("Savushkin", "Belarus", "Ул.Бобруйская, д.25", "(375) 29232-2323");
            Product product1 = new Product("Milk", 10, 1, ProductType.Edible, DateTime.Now, 200, 2, producer1, Storekeeper1);
            data.Add(product1);
            dataGridView1.DataSource = data;
            toolStripStatusLabel_products_count.Text = data.Count.ToString();

            timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_Quantity_Value.Text = trackBar_Quantity.Value.ToString();
        }
        private bool EdibleCheck = false;
        private bool InedibleCheck = false;
        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Title.Text == "")
                    throw new Exception("Input Error");
                if (!TextBox_Title.Text.All(c => char.IsLetter(c)))
                    throw new Exception("Input Error");
                if (maskedTextBox_Size.Text.Contains(" "))
                    throw new Exception("Input Error");
                if (!EdibleCheck && !InedibleCheck)
                    throw new Exception("Input Error");
                if (comboBox_Storekeeper.Text == "")
                    throw new Exception("Input Error");
                if (button_Add.BackColor == Color.Red)
                    throw new Exception("Input Error");
                //----------------------------------------
                ProductType pr;
                if (EdibleCheck)
                    pr = ProductType.Edible;
                else pr = ProductType.Inedible;

                Product product = new Product(TextBox_Title.Text,
                    Convert.ToInt32(maskedTextBox_Size.Text),
                    Convert.ToInt32(numericUpDown_Weight.Value),
                    pr, dateTimePicker1.Value, trackBar_Quantity.Value,
                    Convert.ToSingle(maskedTextBox_Price.Text),
                    ProducerForm.producer, SelectedStorekeeper
                    );
                data.Add(product);
                toolStripStatusLabel_products_count.Text = data.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton_Edible_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                EdibleCheck = true;
                InedibleCheck = false;
            }
        }

        private void radioButton_Inedible_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                EdibleCheck = false;
                InedibleCheck = true;
            }
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void button_Set_Producer_Click(object sender, EventArgs e)
        {
            ProducerForm newForm = new ProducerForm(this);
            newForm.Show();
        }

        private void comboBox_Storekeeper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Storekeeper.SelectedIndex == 0)
                SelectedStorekeeper = Storekeeper1;
            if (comboBox_Storekeeper.SelectedIndex == 1)
                SelectedStorekeeper = Storekeeper2;
            if (comboBox_Storekeeper.SelectedIndex == 2)
                SelectedStorekeeper = Storekeeper3;
            if (comboBox_Storekeeper.SelectedIndex == 3)
                SelectedStorekeeper = Storekeeper4;
        }

        private void button_LoadFromXML_Click(object sender, EventArgs e)
        {

            try
            {
                Product deserializeProduct = XmlSerializeWrapper.Deserialize<Product>("product.xml");

                if (deserializeProduct != null)
                    data.Add(deserializeProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_SaveToXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Title.Text == "")
                    throw new Exception("Input Error");
                if (!TextBox_Title.Text.All(c => char.IsLetter(c)))
                    throw new Exception("Input Error");
                if (maskedTextBox_Size.Text.Contains(" "))
                    throw new Exception("Input Error");
                if (!EdibleCheck && !InedibleCheck)
                    throw new Exception("Input Error");
                if (comboBox_Storekeeper.Text == "")
                    throw new Exception("Input Error");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProductType pr;
            if (EdibleCheck) pr = ProductType.Edible;
            else pr = ProductType.Inedible;

            //--------------------------------------------------------------------------------------------------
            Producer producer1 = new Producer("Lays", "Belarus", "Ул.Бобруйская, д.25", "+375-29-338-4096");
            //--------------------------------------------------------------------------------------------------


            Product product = new Product(TextBox_Title.Text,
                Convert.ToInt32(maskedTextBox_Size.Text),
                Convert.ToInt32(numericUpDown_Weight.Value),
                pr, dateTimePicker1.Value, trackBar_Quantity.Value,
                Convert.ToSingle(maskedTextBox_Price.Text),
                producer1, SelectedStorekeeper
                );

            XmlSerializeWrapper.Serialize(product, "product.xml");
        }

        private void sortByTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
            foreach (Product i in data)
                productList.Add(i);
            data.Clear();
            var orderd = from i in productList
                         orderby i.Title
                         select i;
            foreach (Product i in orderd)
                data.Add(i);
        }

        private void sortByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
            foreach (Product i in data)
                productList.Add(i);
            data.Clear();
            var orderd = from i in productList
                         orderby i.DateOfReceipt
                         select i;
            foreach (Product i in orderd)
                data.Add(i);
        }

        private void sortByCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
            foreach (Product i in data)
                productList.Add(i);
            data.Clear();
            var orderd = from i in productList
                         orderby i.Manufacturer.Country
                         select i;
            foreach (Product i in orderd)
                data.Add(i);
        }

        private void toolStripMenuItem_Search_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
            foreach (Product i in data)
                productList.Add(i);
            SearchRequests newForm = new SearchRequests(this, productList);
            newForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Product[]));
            using (FileStream fs = new FileStream("products.xml", FileMode.OpenOrCreate))
            {
                List<Product> productList = new List<Product>();
                foreach (Product i in data)
                    productList.Add(i);
                Product[] products = new Product[productList.Count];
                for(int i = 0; i < productList.Count; i++)
                {
                    products[i] = productList[i];
                }
                formatter.Serialize(fs, products);
            }
        }

        private void toolStripButton_Delete_Click(object sender, EventArgs e)
        {
            data.Clear();
            toolStripStatusLabel_products_count.Text = data.Count.ToString();
        }

        private void toolStripButton_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Title.Text = string.Empty;
            maskedTextBox_Size.Text = string.Empty;
            numericUpDown_Weight.Value = 1;
            radioButton_Edible.Checked = false;
            radioButton_Inedible.Checked = false;
            trackBar_Quantity.Value = 100;
            maskedTextBox_Price.Text = string.Empty;
            comboBox_Storekeeper.Text = string.Empty;
            button_Set_Producer.BackColor = Color.Red;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_DateNow.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}