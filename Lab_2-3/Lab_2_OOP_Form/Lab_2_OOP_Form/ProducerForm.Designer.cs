namespace Lab_2_OOP_Form
{
    partial class ProducerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_Producer_Title = new System.Windows.Forms.Label();
            this.label1_Organization = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label1_Address = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Organization = new System.Windows.Forms.TextBox();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.button_Set_Producer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Producer_Title
            // 
            this.label1_Producer_Title.AutoSize = true;
            this.label1_Producer_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_Producer_Title.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_Producer_Title.Location = new System.Drawing.Point(120, 9);
            this.label1_Producer_Title.Name = "label1_Producer_Title";
            this.label1_Producer_Title.Size = new System.Drawing.Size(147, 31);
            this.label1_Producer_Title.TabIndex = 0;
            this.label1_Producer_Title.Text = "Producer";
            // 
            // label1_Organization
            // 
            this.label1_Organization.AutoSize = true;
            this.label1_Organization.Location = new System.Drawing.Point(12, 49);
            this.label1_Organization.Name = "label1_Organization";
            this.label1_Organization.Size = new System.Drawing.Size(98, 20);
            this.label1_Organization.TabIndex = 1;
            this.label1_Organization.Text = "Organization:";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Location = new System.Drawing.Point(12, 114);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(63, 20);
            this.label_Country.TabIndex = 2;
            this.label_Country.Text = "Country:";
            // 
            // label1_Address
            // 
            this.label1_Address.AutoSize = true;
            this.label1_Address.Location = new System.Drawing.Point(12, 187);
            this.label1_Address.Name = "label1_Address";
            this.label1_Address.Size = new System.Drawing.Size(65, 20);
            this.label1_Address.TabIndex = 3;
            this.label1_Address.Text = "Address:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(12, 257);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(53, 20);
            this.label_Phone.TabIndex = 4;
            this.label_Phone.Text = "Phone:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 280);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 27);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // textBox_Organization
            // 
            this.textBox_Organization.Location = new System.Drawing.Point(12, 72);
            this.textBox_Organization.Name = "textBox_Organization";
            this.textBox_Organization.Size = new System.Drawing.Size(370, 27);
            this.textBox_Organization.TabIndex = 6;
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Items.AddRange(new object[] {
            "Abkhazia",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Belarus",
            "Belgium",
            "Bermuda Islands",
            "Bolivia",
            "Brazil",
            "Bulgaria",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Chile",
            "China",
            "Colombia",
            "Congo",
            "Costa Rica",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Estonia",
            "Ethiopia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Great Britain / United Kingdom",
            "Greece",
            "Guatemala",
            "Guinea",
            "Haiti",
            "Hawaii",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israe",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Kazakhstan",
            "Kenya",
            "Kuwait",
            "Kyrgyzstan",
            "Latvia",
            "Lebanon",
            "Liberia",
            "Libya",
            "Lithuania",
            "Luxemburg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Malta",
            "Mexico",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Morocco",
            "Nepal",
            "Netherlands / Holland",
            "New Zeland",
            "Nicaragua",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Romania",
            "Russia",
            "Rwanda",
            "Saudi Arabia",
            "Senegal",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South Korea",
            "South Ossetia",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Thailand",
            "Togo",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United States of America / USA",
            "Urugua",
            "Uzbekistan",
            "Venezuela",
            "Yemen",
            "Zaire",
            "Zambia",
            "Zimbabwe"});
            this.comboBox_Country.Location = new System.Drawing.Point(12, 137);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(370, 28);
            this.comboBox_Country.TabIndex = 7;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(12, 210);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(370, 27);
            this.textBox_Address.TabIndex = 8;
            // 
            // button_Set_Producer
            // 
            this.button_Set_Producer.Location = new System.Drawing.Point(130, 257);
            this.button_Set_Producer.Name = "button_Set_Producer";
            this.button_Set_Producer.Size = new System.Drawing.Size(252, 50);
            this.button_Set_Producer.TabIndex = 9;
            this.button_Set_Producer.Text = "Set";
            this.button_Set_Producer.UseVisualStyleBackColor = true;
            this.button_Set_Producer.Click += new System.EventHandler(this.button_Set_Producer_Click);
            // 
            // ProducerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 330);
            this.ControlBox = false;
            this.Controls.Add(this.button_Set_Producer);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.textBox_Organization);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label1_Address);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label1_Organization);
            this.Controls.Add(this.label1_Producer_Title);
            this.Name = "ProducerForm";
            this.Text = "ProducerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProducerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_Producer_Title;
        private Label label_Producer_Main;
        private Label label_Organization;
        private Label label_Country;
        private Label label_Phone;
        private Label label_Address;
        private Label label1_Organization;
        private Label label1_Address;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox_Organization;
        private ComboBox comboBox_Country;
        private TextBox textBox_Address;
        private Button button_Set_Producer;
    }
}