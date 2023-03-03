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
    public partial class ProducerForm : Form
    {
        private Form1 mainForm;
        public static Producer producer = new Producer();
        public ProducerForm()
        {
            InitializeComponent();
        }
        public ProducerForm(Form1 f)
        {
            InitializeComponent();
            mainForm= f;
            mainForm.button_Set_Producer.BackColor = Color.Red;
            f.BackColor = Color.Yellow;
            f.Enabled= false;
        }

        private void ProducerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
            mainForm.BackColor= Color.White;

        }

        private void button_Set_Producer_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Organization.Text == "")
                    throw new Exception("Input Error");
                if (comboBox_Country.Text == "")
                    throw new Exception("Input Error");
                if (textBox_Address.Text == "")
                    throw new Exception("Input Error");

                producer.Organization = textBox_Organization.Text;
                producer.Country= comboBox_Country.Text;
                producer.Address = textBox_Address.Text;
                producer.Phone = maskedTextBox1.Text;
                Close();
                mainForm.button_Set_Producer.BackColor = Color.Green;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
