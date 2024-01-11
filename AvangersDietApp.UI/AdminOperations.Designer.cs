namespace AvangersDietApp.UI
{
    partial class AdminOperations
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            btn_CategoryAdd = new Button();
            dataGridView1 = new DataGridView();
            btn_CategoryDel = new Button();
            btn_CategoryUpd = new Button();
            Txt_FoodName = new TextBox();
            cmbCategoryId = new ComboBox();
            rch_FoodDesc = new RichTextBox();
            nmr_Fat = new NumericUpDown();
            nmr_Carbonhid = new NumericUpDown();
            nmr_Protein = new NumericUpDown();
            nmr_Calories = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_FoodAdd = new Button();
            btnFoodDelUpd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Fat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Carbonhid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Protein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Calories).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_FoodAdd);
            groupBox1.Controls.Add(nmr_Calories);
            groupBox1.Controls.Add(nmr_Protein);
            groupBox1.Controls.Add(nmr_Fat);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nmr_Carbonhid);
            groupBox1.Controls.Add(rch_FoodDesc);
            groupBox1.Controls.Add(cmbCategoryId);
            groupBox1.Controls.Add(Txt_FoodName);
            groupBox1.Location = new Point(327, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yemek Ekleme";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_CategoryUpd);
            groupBox2.Controls.Add(btn_CategoryDel);
            groupBox2.Controls.Add(btn_CategoryAdd);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(12, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kategori Ekleme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı :";
            // 
            // btn_CategoryAdd
            // 
            btn_CategoryAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_CategoryAdd.Location = new Point(0, 109);
            btn_CategoryAdd.Name = "btn_CategoryAdd";
            btn_CategoryAdd.Size = new Size(269, 40);
            btn_CategoryAdd.TabIndex = 2;
            btn_CategoryAdd.Text = "Kategori Ekle";
            btn_CategoryAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 3;
            // 
            // btn_CategoryDel
            // 
            btn_CategoryDel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_CategoryDel.Location = new Point(0, 155);
            btn_CategoryDel.Name = "btn_CategoryDel";
            btn_CategoryDel.Size = new Size(269, 40);
            btn_CategoryDel.TabIndex = 2;
            btn_CategoryDel.Text = "Kategori Sil";
            btn_CategoryDel.UseVisualStyleBackColor = true;
            // 
            // btn_CategoryUpd
            // 
            btn_CategoryUpd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_CategoryUpd.Location = new Point(0, 199);
            btn_CategoryUpd.Name = "btn_CategoryUpd";
            btn_CategoryUpd.Size = new Size(269, 40);
            btn_CategoryUpd.TabIndex = 2;
            btn_CategoryUpd.Text = "Kategori Güncelle";
            btn_CategoryUpd.UseVisualStyleBackColor = true;
            // 
            // Txt_FoodName
            // 
            Txt_FoodName.Location = new Point(270, 26);
            Txt_FoodName.Name = "Txt_FoodName";
            Txt_FoodName.Size = new Size(244, 27);
            Txt_FoodName.TabIndex = 3;
            // 
            // cmbCategoryId
            // 
            cmbCategoryId.FormattingEnabled = true;
            cmbCategoryId.Location = new Point(270, 59);
            cmbCategoryId.Name = "cmbCategoryId";
            cmbCategoryId.Size = new Size(244, 28);
            cmbCategoryId.TabIndex = 4;
            // 
            // rch_FoodDesc
            // 
            rch_FoodDesc.Location = new Point(270, 93);
            rch_FoodDesc.Name = "rch_FoodDesc";
            rch_FoodDesc.Size = new Size(244, 77);
            rch_FoodDesc.TabIndex = 5;
            rch_FoodDesc.Text = "";
            // 
            // nmr_Fat
            // 
            nmr_Fat.Location = new Point(270, 218);
            nmr_Fat.Name = "nmr_Fat";
            nmr_Fat.Size = new Size(150, 27);
            nmr_Fat.TabIndex = 4;
            // 
            // nmr_Carbonhid
            // 
            nmr_Carbonhid.Location = new Point(270, 177);
            nmr_Carbonhid.Name = "nmr_Carbonhid";
            nmr_Carbonhid.Size = new Size(150, 27);
            nmr_Carbonhid.TabIndex = 5;
            // 
            // nmr_Protein
            // 
            nmr_Protein.Location = new Point(270, 254);
            nmr_Protein.Name = "nmr_Protein";
            nmr_Protein.Size = new Size(150, 27);
            nmr_Protein.TabIndex = 4;
            // 
            // nmr_Calories
            // 
            nmr_Calories.Location = new Point(270, 287);
            nmr_Calories.Name = "nmr_Calories";
            nmr_Calories.Size = new Size(150, 27);
            nmr_Calories.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 33);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 62);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 1;
            label3.Text = "Kategorisi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 96);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "Açıklaması :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 179);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 1;
            label5.Text = "Karbonhidrat :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 218);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 1;
            label6.Text = "Yağ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 254);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 1;
            label7.Text = "Protein :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(200, 289);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 1;
            label8.Text = "Kalori :";
            // 
            // btn_FoodAdd
            // 
            btn_FoodAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_FoodAdd.Location = new Point(270, 320);
            btn_FoodAdd.Name = "btn_FoodAdd";
            btn_FoodAdd.Size = new Size(244, 44);
            btn_FoodAdd.TabIndex = 6;
            btn_FoodAdd.Text = "Yemek Ekle";
            btn_FoodAdd.UseVisualStyleBackColor = true;
            // 
            // btnFoodDelUpd
            // 
            btnFoodDelUpd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFoodDelUpd.Location = new Point(390, 397);
            btnFoodDelUpd.Name = "btnFoodDelUpd";
            btnFoodDelUpd.Size = new Size(438, 57);
            btnFoodDelUpd.TabIndex = 4;
            btnFoodDelUpd.Text = "Silmek Veya Güncellemek İçin Tıklayınız...";
            btnFoodDelUpd.UseVisualStyleBackColor = true;
            btnFoodDelUpd.Click += btnFoodDelUpd_Click;
            // 
            // AdminOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 466);
            Controls.Add(btnFoodDelUpd);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminOperations";
            Text = "AdminOperations";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Fat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Carbonhid).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Protein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Calories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button btn_CategoryAdd;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_CategoryUpd;
        private Button btn_CategoryDel;
        private TextBox Txt_FoodName;
        private RichTextBox rch_FoodDesc;
        private ComboBox cmbCategoryId;
        private NumericUpDown nmr_Calories;
        private NumericUpDown nmr_Protein;
        private NumericUpDown nmr_Fat;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown nmr_Carbonhid;
        private Button btn_FoodAdd;
        private Button btnFoodDelUpd;
    }
}