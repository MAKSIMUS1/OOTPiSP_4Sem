namespace Lab_2_OOP_Form
{
    partial class SearchRequests
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
            this.label_SearchByTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_SearchByType = new System.Windows.Forms.GroupBox();
            this.radioButton_Inedible = new System.Windows.Forms.RadioButton();
            this.radioButton_Edible = new System.Windows.Forms.RadioButton();
            this.button_search = new System.Windows.Forms.Button();
            this.label_PriceRange = new System.Windows.Forms.Label();
            this.textBox_PriceRange = new System.Windows.Forms.TextBox();
            this.groupBox_SearchByType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SearchByTitle
            // 
            this.label_SearchByTitle.AutoSize = true;
            this.label_SearchByTitle.Location = new System.Drawing.Point(12, 9);
            this.label_SearchByTitle.Name = "label_SearchByTitle";
            this.label_SearchByTitle.Size = new System.Drawing.Size(106, 20);
            this.label_SearchByTitle.TabIndex = 0;
            this.label_SearchByTitle.Text = "Search by title:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 27);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox_SearchByType
            // 
            this.groupBox_SearchByType.Controls.Add(this.radioButton_Inedible);
            this.groupBox_SearchByType.Controls.Add(this.radioButton_Edible);
            this.groupBox_SearchByType.Location = new System.Drawing.Point(12, 65);
            this.groupBox_SearchByType.Name = "groupBox_SearchByType";
            this.groupBox_SearchByType.Size = new System.Drawing.Size(163, 93);
            this.groupBox_SearchByType.TabIndex = 2;
            this.groupBox_SearchByType.TabStop = false;
            this.groupBox_SearchByType.Text = "Search by type";
            // 
            // radioButton_Inedible
            // 
            this.radioButton_Inedible.AutoSize = true;
            this.radioButton_Inedible.Location = new System.Drawing.Point(6, 56);
            this.radioButton_Inedible.Name = "radioButton_Inedible";
            this.radioButton_Inedible.Size = new System.Drawing.Size(84, 24);
            this.radioButton_Inedible.TabIndex = 1;
            this.radioButton_Inedible.TabStop = true;
            this.radioButton_Inedible.Text = "Inedible";
            this.radioButton_Inedible.UseVisualStyleBackColor = true;
            // 
            // radioButton_Edible
            // 
            this.radioButton_Edible.AutoSize = true;
            this.radioButton_Edible.Location = new System.Drawing.Point(6, 26);
            this.radioButton_Edible.Name = "radioButton_Edible";
            this.radioButton_Edible.Size = new System.Drawing.Size(72, 24);
            this.radioButton_Edible.TabIndex = 0;
            this.radioButton_Edible.TabStop = true;
            this.radioButton_Edible.Text = "Edible";
            this.radioButton_Edible.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(208, 78);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(189, 51);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_PriceRange
            // 
            this.label_PriceRange.AutoSize = true;
            this.label_PriceRange.Location = new System.Drawing.Point(12, 181);
            this.label_PriceRange.Name = "label_PriceRange";
            this.label_PriceRange.Size = new System.Drawing.Size(86, 20);
            this.label_PriceRange.TabIndex = 3;
            this.label_PriceRange.Text = "Price range:";
            // 
            // textBox_PriceRange
            // 
            this.textBox_PriceRange.Location = new System.Drawing.Point(18, 204);
            this.textBox_PriceRange.Name = "textBox_PriceRange";
            this.textBox_PriceRange.Size = new System.Drawing.Size(250, 27);
            this.textBox_PriceRange.TabIndex = 8;
            // 
            // SearchRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_PriceRange);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_PriceRange);
            this.Controls.Add(this.groupBox_SearchByType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_SearchByTitle);
            this.Name = "SearchRequests";
            this.Text = "SearchRequests";
            this.groupBox_SearchByType.ResumeLayout(false);
            this.groupBox_SearchByType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_SearchByTitle;
        private TextBox textBox1;
        private GroupBox groupBox_SearchByType;
        private RadioButton radioButton_Inedible;
        private RadioButton radioButton_Edible;
        private Button button_search;
        private Label label_PriceRange;
        private TextBox textBox_PriceRange;
    }
}