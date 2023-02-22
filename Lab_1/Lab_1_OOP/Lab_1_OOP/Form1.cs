namespace Lab_1_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }
        private bool dot = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            if(!dot)
            {
                dot = true;
                textBox1.Text = textBox1.Text + ",";
            }
        }
        double a;
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void AddAnswer(string textAnsw, string textList)
        {
            label_answ.Text = textAnsw;
            try
            {
                if (listBox1.Items.Count == 5)
                {
                    throw new Exception("Memory out");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                listBox1.Items.Clear();
            }
            finally
            {
                listBox1.Items.Add(textList);
            }
        }
        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = listBox1.SelectedItem.ToString();
            textBox1.Text = value;
        }

        private void button_square_root_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + Math.Sqrt(a), Convert.ToString(Math.Sqrt(a)));
        }

        private void button_cube_root_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + Math.Pow(a, 1.0 / 3.0), Convert.ToString(Math.Pow(a, 1.0 / 3.0)));
        }
        private void button_sin_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + Math.Sin(a), Convert.ToString(Math.Sin(a)));
        }
        private void button_cos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + Math.Cos(a), Convert.ToString(Math.Cos(a)));
        }

        private void button_tan_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + Math.Tan(a), Convert.ToString(Math.Tan(a)));
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + (1/Math.Tan(a)), Convert.ToString(1 / Math.Tan(a)));
        }

        private void button_degree_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            AddAnswer("=" + Math.Pow(a, 2), Convert.ToString(Math.Pow(a, 2)));
        }
    }
}