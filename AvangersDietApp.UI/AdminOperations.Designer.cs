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
            btn_FoodAdd = new Button();
            nmr_Calories = new NumericUpDown();
            nmr_Protein = new NumericUpDown();
            nmr_Fat = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nmr_Carbonhid = new NumericUpDown();
            rch_FoodDesc = new RichTextBox();
            cmbCategoryId = new ComboBox();
            Txt_FoodName = new TextBox();
            txt_Category = new TextBox();
            groupBox2 = new GroupBox();
            btn_CategoryUpd = new Button();
            btn_CategoryDel = new Button();
            btn_CategoryAdd = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnFoodDelUpd = new Button();
            btn_Reports = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_Calories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Protein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Fat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Carbonhid).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Size = new Size(597, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yemek Ekleme";
            // 
            // btn_FoodAdd
            // 
            btn_FoodAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_FoodAdd.Location = new Point(270, 320);
            btn_FoodAdd.Name = "btn_FoodAdd";
            btn_FoodAdd.Size = new Size(245, 44);
            btn_FoodAdd.TabIndex = 6;
            btn_FoodAdd.Text = "Yemek Ekle";
            btn_FoodAdd.UseVisualStyleBackColor = true;
            btn_FoodAdd.Click += btn_FoodAdd_Click;
            // 
            // nmr_Calories
            // 
            nmr_Calories.Location = new Point(270, 287);
            nmr_Calories.Name = "nmr_Calories";
            nmr_Calories.Size = new Size(150, 27);
            nmr_Calories.TabIndex = 4;
            // 
            // nmr_Protein
            // 
            nmr_Protein.Location = new Point(270, 253);
            nmr_Protein.Name = "nmr_Protein";
            nmr_Protein.Size = new Size(150, 27);
            nmr_Protein.TabIndex = 4;
            // 
            // nmr_Fat
            // 
            nmr_Fat.Location = new Point(270, 219);
            nmr_Fat.Name = "nmr_Fat";
            nmr_Fat.Size = new Size(150, 27);
            nmr_Fat.TabIndex = 4;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 253);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 1;
            label7.Text = "Protein :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 219);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 1;
            label6.Text = "Yağ :";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 96);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "Açıklaması :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 61);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 1;
            label3.Text = "Kategorisi :";
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
            // nmr_Carbonhid
            // 
            nmr_Carbonhid.Location = new Point(270, 177);
            nmr_Carbonhid.Name = "nmr_Carbonhid";
            nmr_Carbonhid.Size = new Size(150, 27);
            nmr_Carbonhid.TabIndex = 5;
            // 
            // rch_FoodDesc
            // 
            rch_FoodDesc.Location = new Point(270, 93);
            rch_FoodDesc.Name = "rch_FoodDesc";
            rch_FoodDesc.Size = new Size(244, 77);
            rch_FoodDesc.TabIndex = 5;
            rch_FoodDesc.Text = "";
            // 
            // cmbCategoryId
            // 
            cmbCategoryId.FormattingEnabled = true;
            cmbCategoryId.Location = new Point(270, 59);
            cmbCategoryId.Name = "cmbCategoryId";
            cmbCategoryId.Size = new Size(244, 28);
            cmbCategoryId.TabIndex = 4;
            // 
            // Txt_FoodName
            // 
            Txt_FoodName.Location = new Point(270, 27);
            Txt_FoodName.Name = "Txt_FoodName";
            Txt_FoodName.Size = new Size(244, 27);
            Txt_FoodName.TabIndex = 3;
            // 
            // txt_Category
            // 
            txt_Category.Location = new Point(0, 76);
            txt_Category.Name = "txt_Category";
            txt_Category.Size = new Size(269, 27);
            txt_Category.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_CategoryUpd);
            groupBox2.Controls.Add(btn_CategoryDel);
            groupBox2.Controls.Add(btn_CategoryAdd);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_Category);
            groupBox2.Location = new Point(11, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kategori Ekleme";
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
            btn_CategoryUpd.Click += btn_CategoryUpd_Click;
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
            btn_CategoryDel.Click += btn_CategoryDel_Click;
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
            btn_CategoryAdd.Click += btn_CategoryAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(299, 188);
            dataGridView1.TabIndex = 3;
            // 
            // btnFoodDelUpd
            // 
            btnFoodDelUpd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFoodDelUpd.Location = new Point(410, 389);
            btnFoodDelUpd.Name = "btnFoodDelUpd";
            btnFoodDelUpd.Size = new Size(456, 49);
            btnFoodDelUpd.TabIndex = 4;
            btnFoodDelUpd.Text = "Silmek Veya Güncellemek İçin Tıklayınız...";
            btnFoodDelUpd.UseVisualStyleBackColor = true;
            btnFoodDelUpd.Click += btnFoodDelUpd_Click;
            // 
            // btn_Reports
            // 
            btn_Reports.DialogResult = DialogResult.No;
            btn_Reports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Reports.Location = new Point(410, 444);
            btn_Reports.Name = "btn_Reports";
            btn_Reports.Size = new Size(456, 44);
            btn_Reports.TabIndex = 5;
            btn_Reports.Text = "Raporlar Sayfasına Gitmek İçin Tıklayınız...";
            btn_Reports.UseVisualStyleBackColor = true;
            btn_Reports.Click += btn_Reports_Click;
            // 
            // AdminOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 520);
            Controls.Add(btn_Reports);
            Controls.Add(btnFoodDelUpd);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminOperations";
            Text = "AdminOperations";
            Load += AdminOperations_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_Calories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Protein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Fat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Carbonhid).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Category;
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
        private Button btn_Reports;
    }
}